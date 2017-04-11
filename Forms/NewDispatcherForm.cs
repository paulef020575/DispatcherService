using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using DispatcherService.Classes.PlanAppoints;
using DispatcherService.Properties;

namespace DispatcherService.Forms
{
    public partial class NewDispatcherForm : Form
    {
        #region Fields & properties

        private EPVDatabase database;

        private int timeRemaining = 45;

        public int TimeRemaining
        {
            get { return timeRemaining; }
            set { }
        }


        #endregion

        #region Constructor
        
        public NewDispatcherForm(Form parent, EPVDatabase dbase)
        {
            InitializeComponent();

            timeRemaining = Settings.Default.SecondsToRefresh;

            MdiParent = parent;
            database = dbase;
        }

        #endregion

        #region Methods

        private void RefreshData()
        {
            if (tabControl.SelectedTab == factPage)
                RefreshAppoints();
            else
                RefreshPlanAppoints();
            RefreshTimer();
        }

        private void RefreshTimer()
        {
            timeRemaining = Settings.Default.SecondsToRefresh;
        }

        private void RefreshPlanAppoints()
        {
            bsPlanAppoints.DataSource = PlanAppoint.LoadList(database);
        }

        private void RefreshAppoints()
        {
            bsAppoints.DataSource = new Appoints(database, DocStateGroups.Dispatcher);
        }

        private void FindInDGV(DataGridView dataGridView, string p, bool next)
        {
            int currentRow = dataGridView.CurrentCell.RowIndex;
            int currentColumn = dataGridView.CurrentCell.ColumnIndex;

            textBox1.BackColor = SystemColors.Window;

            if (p.Equals(string.Empty))
                return;

            for (int i = currentRow; i < dataGridView.Rows.Count; i++)
            {
                for (int j = currentColumn + (next ? 1 : 0) ; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView[j, i].Value != null
                        && dataGridView[j, i].Value.ToString().Length >= p.Length
                        && dataGridView[j, i].Value.ToString().ToUpper().Contains(p.ToUpper()))
                    {
                        dataGridView.CurrentCell = dataGridView[j, i];
                        return;
                    }
                    currentColumn = 0;
                }
            }

            for (int i = 0; i <= currentRow; i++)
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                    if (dataGridView[j, i].Value != null
                        && dataGridView[j, i].Value.ToString().Length >= p.Length
                        && dataGridView[j, i].Value.ToString().ToUpper().Contains(p.ToUpper()))
                    {
                        dataGridView.CurrentCell = dataGridView[j, i];
                        return;
                    }

            dataGridView.CurrentCell = dataGridView[0, 0];
            textBox1.BackColor = Color.LightSalmon;
        }

        private void ClearFindText()
        {
            textBox1.Clear();
        }

        private void AddNewAppoint()
        {
            FormStart form = (FormStart)MdiParent;
            FormAppoint formAppoint = new FormAppoint();
            formAppoint.Database = database;
            formAppoint.SaveData += SavingItem;
            form.AddChild(formAppoint);
        }

        private void EditCurrentAppoint()
        {
            FormStart form = (FormStart)MdiParent;
            FormAppoint formAppoint = new FormAppoint();
            formAppoint.Database = database;
            formAppoint.Appoint = (Appoint)bsAppoints.Current;
            formAppoint.SaveData += SavingItem;

            form.AddChild(formAppoint);
        }

        private void SetAppointNextStep()
        {
            Appoints appoints = (Appoints)bsAppoints.DataSource;

            FormStart form = (FormStart)MdiParent;
            FormSetToPoint formAppoint = new FormSetToPoint();
            formAppoint.Database = database;
            formAppoint.Appoint = (Appoint)bsAppoints.Current;
            formAppoint.SaveData += SavingItem;

            form.AddChild(formAppoint);
        }

        private void SetAppointOut()
        {
            Appoint appoint = (Appoint)bsAppoints.Current;
            if (appoint != null)
                appoint.GetOut(database);
            RefreshData();
        }

        private void CreateAppointFromPlan()
        {
            if (bsPlanAppoints.Current != null)
            {
                FormStart form = (FormStart)MdiParent;
                FormAppoint formAppoint = new FormAppoint();
                formAppoint.Database = database;
                formAppoint.PlanAppoint = (PlanAppoint)bsPlanAppoints.Current;
                formAppoint.SaveData += SavingItem;
                form.AddChild(formAppoint);
            }
        }

        private void CloseCurrentPlan()
        {
            if (bsPlanAppoints.Current != null
                && MessageBox.Show("Отменить указанный план", ((PlanAppoint)bsPlanAppoints.Current).ToString(),
                                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                PlanAppoint planAppoint = (PlanAppoint)bsPlanAppoints.Current;
                planAppoint.Close();
                planAppoint.Save(database);
                RefreshData();
            }
        }

        #endregion

        #region Event handlers

        private void NewDispatcherForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            RefreshData();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeRemaining--;

            if (timeRemaining == 0)
            {
                RefreshData();
            }

            lblTimer.Text = TimeRemaining.ToString();
        }

        private void dgvDispatcher_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0
                && e.Value != null
                && !textBox1.Text.Equals(string.Empty)
                && e.Value.ToString().Length >= textBox1.Text.Length
                && e.Value.ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
            {
                e.Graphics.FillRectangle(Brushes.LightGreen, e.CellBounds);
                e.PaintContent(e.ClipBounds);
                e.Handled = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab != planPage)
            {
                dgvDispatcher.Refresh();
                FindInDGV(dgvDispatcher, textBox1.Text, false);
            }
            else
            {
                dgvPlanAppoints.Refresh();
                FindInDGV(dgvPlanAppoints, textBox1.Text, false);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFindText();
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab != planPage)
            {
                dgvDispatcher.Refresh();
                FindInDGV(dgvDispatcher, textBox1.Text, true);
            }
            else
            {
                dgvPlanAppoints.Refresh();
                FindInDGV(dgvPlanAppoints, textBox1.Text, true);
            }
        }

        private void buttonAppointNew_Click(object sender, EventArgs e)
        {
            AddNewAppoint();
        }

        private void SavingItem(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonAppointEdit_Click(object sender, EventArgs e)
        {
            EditCurrentAppoint();
        }

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            SetAppointNextStep();
        }

        private void buttonSetOut_Click(object sender, EventArgs e)
        {
            SetAppointOut();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CreateAppointFromPlan();
        }

        private void buttonClosePlan_Click(object sender, EventArgs e)
        {
            CloseCurrentPlan();
        }

        #endregion

    }
}
