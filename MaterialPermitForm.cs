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
using System.IO;

namespace DispatcherService
{
    public partial class MaterialPermitForm : Form
    {
        private EPVDatabase Database;

        public MaterialPermit Document
        {
            get { return (MaterialPermit)bsDocument.DataSource; }
            set { bsDocument.DataSource = value; }
        }
        
        private MaterialPermitForm()
        {
            InitializeComponent();

            dgvItemList.AutoGenerateColumns = false;

            addItemTool.Image = DispatcherService.Resources.Image.Add;
            deleteItemTool.Image = DispatcherService.Resources.Image.Failed;

            LoadAutoCompleteList();
        }

        public MaterialPermitForm(Form mdiParent, EPVDatabase database, MaterialPermit document)
            : this()
        {
            MdiParent = mdiParent;
            Database = database;

            Document = document;

            AddBindings();
        }

        private void AddBindings()
        {
            AddBinding(tboxDocNumber, "DocNumber");
            AddBinding(pickDocDate, "DocDate");
            AddBinding(tboxPerson, "Person");
            AddBinding(tboxVehicleMark, "VehicleMark");
            AddBinding(tboxLicensePlate, "LicensePlate");
            AddBinding(tboxBaseDocument, "BaseDocument");
            AddBinding(tboxBaseDocNumber, "BaseDocNumber");
            AddBinding(pickBaseDocDate, "BaseDocDate");
            AddBinding(tboxComment, "Comment");

            bsItemList.DataSource = Document.GetItemList(Database);

            if (Document.PermitId != 0)
            {
                Permit permit = Permit.Load(Database, Document.PermitId);
                tboxPermit.Text = permit.ToString();

                btnFindPermit.Text = permit.ToString();
            }

        }

        private void AddBinding(DateTimePicker picker, string propertyName)
        {
            picker.DataBindings.Add("Value", bsDocument, propertyName);
        }

        private void AddBinding(TextBox tbox, string propertyName)
        {
            tbox.DataBindings.Add("Text", bsDocument, propertyName, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void SaveItem()
        {
            Document.Save(Database, ((FormStart)MdiParent).User);

            SaveAutoCompleteList();
            OnItemSaved();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveItem();
            Close();
        }

        private void addItemTool_Click(object sender, EventArgs e)
        {
            MaterialPermitItem item = Document.AddItem();
            bsItemList.Position = bsItemList.IndexOf(item);
            dgvItemList.Select();
        }


        #region ItemSaved event

               private EventHandler onItemSaved;

        public event EventHandler ItemSaved
        {
            add { onItemSaved += value; }
            remove { onItemSaved -= value; }
        }

        public void OnItemSaved()
        {
            if (onItemSaved != null)
                onItemSaved(this, EventArgs.Empty);
        }

        #endregion

        private void deleteItemTool_Click(object sender, EventArgs e)
        {
            MaterialPermitItem item = bsItemList.Current as MaterialPermitItem;
            if (item != null)
                Document.RemoveItem(item);
        }

        #region Автозаполнение

        private class MaterialSource
        {
            public string Material { get; private set; }
            public string MaterialUnit { get; private set; }

            public MaterialSource(string line)
            {
                string[] words = line.Split(new char[] { '\t' });
                Material = words[0];
                MaterialUnit = words[1];
            }

            public MaterialSource(MaterialPermitItem item)
            {
                Material = item.Material;
                MaterialUnit = item.MaterialUnit;
            }

            public string ToFile()
            {
                return Material + '\t' + MaterialUnit;
            }

            public override string ToString()
            {
                return Material;
            }

            public override bool Equals(object obj)
            {
                MaterialSource source = obj as MaterialSource;
                if (source != null)
                    return string.Equals(Material, source.Material, StringComparison.CurrentCultureIgnoreCase);

                return false;
            }

            public override int GetHashCode()
            {
                return Material.GetHashCode();
            }
        }

        private void LoadAutoCompleteList()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "EPV.MateruialDocument");
            if (Directory.Exists(path))
            {
                string fileName = Path.Combine(path, "ItemList.txt");
                List<MaterialSource> source = new List<MaterialSource>();
                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);

                    foreach (string line in lines)
                        source.Add(new MaterialSource(line));

                    if (source.Count > 0)
                        lboxAutoComplete.DataSource = source;

                    return;
                }
            }

            lboxAutoComplete.Visible = false;
        }

        private void lboxAutoComplete_DoubleClick(object sender, EventArgs e)
        {
            MaterialSource source = lboxAutoComplete.SelectedItem as MaterialSource;

            if (source != null)
            {
                MaterialPermitItem item = Document.AddItem();
                item.Material = source.Material;
                item.MaterialUnit = source.MaterialUnit;

                bsItemList.Position = bsItemList.IndexOf(item);
                dgvItemList.Select();
            }
        }

        private void SaveAutoCompleteList()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "EPV.MateruialDocument");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string fileName = Path.Combine(path, "ItemList.txt");

            List<MaterialSource> list = new List<MaterialSource>();
            foreach (MaterialPermitItem item in bsItemList)
                list.Add(new MaterialSource(item));

            if (lboxAutoComplete.DataSource != null)
            {
                foreach (MaterialSource source in (List<MaterialSource>)lboxAutoComplete.DataSource)
                {
                    if (!list.Contains(source))
                        list.Add(source);
                }
            }

            List<string> lines = new List<string>();
            foreach (MaterialSource line in list)
                lines.Add(line.ToFile());

            File.WriteAllLines(fileName, lines.ToArray());

        }

        #endregion

    }
}
