using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using DispatcherService.Classes;
using EPV.Data;
using EPV.Forms;

namespace DispatcherService
{
    public partial class MaterialPermitListForm : Form
    {
        private EPVDatabase Database;

        private bool isInitialized = false;

        private struct RefreshArgs
        {
            public EPVDatabase Database;
            public ISystemUser User;
            public Unit Unit;
        }

        private MaterialPermit documentToSelect;

        private ISystemUser User { get { return ((FormStart)MdiParent).User; } }

        private bool IsCreator;
        private bool IsSigner;

        private int refreshingPeriod = 60;
        private int secondsToRefresh;

        private MaterialPermitListForm()
        {
            InitializeComponent();

            dgvItemList.AutoGenerateColumns = false;
            periodPicker1.DateFrom = DateTime.Today.AddDays(-5);
            periodPicker1.DateTo = DateTime.Today.AddDays(2);

            addDocumentTool.Image = DispatcherService.Resources.Image.Add;
            editDocumentTool.Image = DispatcherService.Resources.Image.Edit;
            deleteDocumentTool.Image = DispatcherService.Resources.Image.Failed;
            refreshListTool.Image = DispatcherService.Resources.Image.Refresh;
        }

        public MaterialPermitListForm(Form mdiParent, EPVDatabase database)
            : this()
        {
            MdiParent = mdiParent;
            Database = database;

            bsDocumentList.DataSource = new MaterialPermit(Unit.Empty);
            cboxUnit.DataSource = Unit.LoadList(Database, User);

            AddBindings();
            ForceRefresh();
            isInitialized = true;

        }

        private void AddBindings()
        {
            AddBinding(tboxHeader, "Header");
            AddBinding(pboxCreateFlag, "CreateFlagImage");
            AddBinding(pboxSignedFlag, "SignedFlagImage");
            AddBinding(pboxEntryFlag, "EntryFlagImage");

            AddBinding(lblCreator, "Creator");
            AddBinding(lblSigner, "Signer");
            AddBinding(lblEntryPoint, "EntryPoint");

            AddBinding(tboxPerson, "Person");
            AddBinding(tboxVehicle, "Vehicle");
            AddBinding(tboxBaseDocument, "BaseDocString");
            AddBinding(tboxComment, "Comment");
        }

        private Binding AddBinding(Label lbl, string p)
        {
            return lbl.DataBindings.Add("Text", bsDocumentList, p, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private Binding AddBinding(PictureBox pbox, string p)
        {
            return pbox.DataBindings.Add("Image", bsDocumentList, p, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private Binding AddBinding(TextBox tbox, string propertyName)
        {
            return tbox.DataBindings.Add("Text", bsDocumentList, propertyName, true, DataSourceUpdateMode.OnPropertyChanged);
        }



        private void ForceRefresh()
        {
            
            RefreshArgs args = new RefreshArgs();
            args.Database = Database;
            args.User = User;
            args.Unit = (Unit)cboxUnit.SelectedItem;

            if (!bgRefreshing.IsBusy)
                bgRefreshing.RunWorkerAsync(args);

            refreshingLabel.Text = "обновляем...";
            refreshTimer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bgRefreshing_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshArgs args = (RefreshArgs)e.Argument;

            e.Result = MaterialPermit.LoadList(args.Database, args.Unit,
                                                DateTime.MinValue, DateTime.MaxValue, args.User);
        }

        private void bgRefreshing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (documentToSelect == null)
                documentToSelect = (MaterialPermit)bsDocumentList.Current;

            bsDocumentList.DataSource = e.Result;

            if (documentToSelect != null)
                bsDocumentList.Position = bsDocumentList.IndexOf(documentToSelect);

            documentToSelect = null;

            secondsToRefresh = refreshingPeriod;
            refreshTimer.Start();

            CheckForNewDocuments();
        }

        private void bsDocumentList_CurrentChanged(object sender, EventArgs e)
        {
            clearNewTimer.Stop();

            if (bsDocumentList.Current != null)
            {
                MaterialPermit document = (MaterialPermit)bsDocumentList.Current;
                dgvItemList.DataSource = document.GetItemList(Database);

                editDocumentTool.Enabled = (document.CreateFlag != 1);
                deleteDocumentTool.Enabled = (document.CreateFlag != 1);

                CheckPermissions(document);

                if (document.IsNew)
                    clearNewTimer.Start();
            }
        }

        private void CheckPermissions(MaterialPermit document)
        {
            btnCreate.Enabled = (document.CreateFlag != 1 && IsCreator);
            btnFailCreate.Enabled = (document.SignedFlag != 1 && IsCreator && document.CreateFlag != -1);

            btnSign.Enabled = (document.CreateFlag == 1 && document.SignedFlag != 1 && IsSigner);
            btnFailSign.Enabled = (document.EntryFlag != 1 && document.SignedFlag != -1 && IsSigner);
        }

        private void cboxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserRole();
            addDocumentTool.Enabled = IsCreator;

            if (isInitialized)
                ForceRefresh();

        }

        private void GetUserRole()
        {
            string query = DispatcherService.Resources.Doc.MaterialPermit.GetUserRole;
            QueryParameters parameters = new QueryParameters("userId", User.Id);
            parameters.Add("unitId", ((Unit)cboxUnit.SelectedItem).Id);

            object result = Database.ExecuteScalar(query, parameters);

            if (result == null)
            {
                IsCreator = false;
                IsSigner = false;
            }
            else
            {
                IsCreator = true;
                IsSigner = ((int)result == 5);
            }
        }

        private void addDocumentTool_Click(object sender, EventArgs e)
        {
            CreateNewDocument();
        }

        private void CreateNewDocument()
        {
            MaterialPermit document = new MaterialPermit((Unit)cboxUnit.SelectedItem);

            ShowDocumentForm(document);
        }

        private void ShowDocumentForm(MaterialPermit document)
        {
            MaterialPermitForm form = new MaterialPermitForm(MdiParent, Database, document);
            form.ItemSaved += new EventHandler(form_ItemSaved);
            form.Show();
        }

        void form_ItemSaved(object sender, EventArgs e)
        {
            MaterialPermitForm form = (MaterialPermitForm)sender;

            documentToSelect = form.Document;
            ForceRefresh();
        }

        private void editDocumentTool_Click(object sender, EventArgs e)
        {
            if (bsDocumentList.Current != null)
                ShowDocumentForm(((MaterialPermit)bsDocumentList.Current).LoadCopy(Database));
        }

        private void dgvList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (bsDocumentList.DataSource != null && e.RowIndex > -1 && e.RowIndex < bsDocumentList.Count)
            {
                MaterialPermit document = (MaterialPermit)bsDocumentList[e.RowIndex];
                if (document.IsNew)
                    dgvList.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgvList.Font, FontStyle.Bold);
            }
        }

        private void deleteDocumentTool_Click(object sender, EventArgs e)
        {
            DeleteCurrentDocument();
        }

        private void DeleteCurrentDocument()
        {
            MaterialPermit document = (MaterialPermit)bsDocumentList.Current;
            if (MessageBox.Show(DispatcherService.Resources.Message.DeleteDocument, document.ToString(),
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bsDocumentList.Remove(document);
                document.Delete();
                document.Save(Database, User);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MaterialPermit document = (MaterialPermit)bsDocumentList.Current;

            document.MarkCreated(1, Database, User);

            ForceRefresh();
        }

        private void btnFailCreate_Click(object sender, EventArgs e)
        {
            MaterialPermit document = (MaterialPermit)bsDocumentList.Current;

            document.MarkCreated(-1, Database, User);
            ForceRefresh();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            MaterialPermit document = (MaterialPermit)bsDocumentList.Current;

            document.MarkSigned(1, Database, User);
            ForceRefresh();
        }

        private void btnFailSign_Click(object sender, EventArgs e)
        {
            MaterialPermit document = (MaterialPermit)bsDocumentList.Current;

            document.MarkSigned(-1, Database, User);
            ForceRefresh();
        }

        private void refreshListTool_Click(object sender, EventArgs e)
        {
            ForceRefresh();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            secondsToRefresh--;
            if (secondsToRefresh > 0)
                refreshingLabel.Text = secondsToRefresh.ToString();
            else
                ForceRefresh();
        }

        private bool emptyIcon = false;

        private void iconTimer_Tick(object sender, EventArgs e)
        {
            if (emptyIcon)
                notifyIcon.Icon = DispatcherService.Resources.Image.Document;
            else
                notifyIcon.Icon = DispatcherService.Resources.Image.Empty;
            emptyIcon = !emptyIcon;
        }

        private void CheckForNewDocuments()
        {
            int newDocumentCount = 0;
            foreach (MaterialPermit document in bsDocumentList)
            {
                if (document.IsNew)
                    newDocumentCount++;
            }

            if (newDocumentCount > 0)
            {
                notifyIcon.Icon = DispatcherService.Resources.Image.Empty;
                emptyIcon = true;
                iconTimer.Start();

                notifyIcon.BalloonTipText = "Имеются новые документы: " + newDocumentCount.ToString();
                notifyIcon.ShowBalloonTip(5000);
            }
            else
            {
                notifyIcon.Icon = null;
                iconTimer.Stop();
            }
        }

        private void clearNewTimer_Tick(object sender, EventArgs e)
        {
            MaterialPermit document = bsDocumentList.Current as MaterialPermit;

            if (document != null)
            {
                document.ClearNew(Database, User);
                CheckForNewDocuments();
                dgvList.Rows[bsDocumentList.Position].DefaultCellStyle.Font = dgvList.Font;
            }
        }

        
         
    }
}
