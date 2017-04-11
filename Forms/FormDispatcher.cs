using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Forms;
using EPV.Database;
using DispatcherService.Properties;
using EPV.Data;
using DispatcherService.Classes;

namespace DispatcherService
{
    public partial class FormDispatcher : EPVFormChild
    {
        private int timeToUpdate;

        private EPVDatabase database;

        public EPVDatabase Database
        {
            set
            {
                database = value;
                bindingSourceAppoints.DataSource = new Appoints(database, DocStateGroups.Dispatcher);
                timeToUpdate = Settings.Default.SecondsToRefresh;
                timerDispatcher.Start();
            }
        }

        public SecurityUser User
        {
            get { return (SecurityUser)((FormStart)Application.OpenForms["FormStart"]).User; }
        }

        public FormDispatcher()
        {
            InitializeComponent();
            dataGridViewAppoints.AutoGenerateColumns = false;
            toolStripComboBoxProperty.SelectedIndex = 0;

            btnPermit.DataBindings.Add("Enabled", bindingSourceAppoints, "HasPermit");
        }

        private void buttonAppointNew_Click(object sender, EventArgs e)
        {
            CreateNewAppoint();
        }

        private void buttonAppointEdit_Click(object sender, EventArgs e)
        {
            FormStart form = (FormStart)MdiParent;
            FormAppoint formAppoint = new FormAppoint();
            formAppoint.Database = database;
            formAppoint.Appoint = (Appoint)bindingSourceAppoints.Current;

            form.AddChild(formAppoint);
        }

        private void FormDispatcher_Activated(object sender, EventArgs e)
        {
            bindingSourceAppoints.DataSource = new Appoints(database, DocStateGroups.Dispatcher);
        }

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            Appoints appoints = (Appoints)bindingSourceAppoints.DataSource;

            FormStart form = (FormStart)MdiParent;
            FormSetToPoint formAppoint = new FormSetToPoint();
            formAppoint.Database = database;
            formAppoint.Appoint = (Appoint)bindingSourceAppoints.Current;

            form.AddChild(formAppoint);
        }

        private void timerDispatcher_Tick(object sender, EventArgs e)
        {
            timeToUpdate--;
            if (timeToUpdate == 0)
            {
                toolStripButtonRefresh.Text = "обновление";
                bindingSourceAppoints.DataSource = new Appoints(database, DocStateGroups.Dispatcher);
                toolStripButtonRefresh.Text = "обновить";
                timeToUpdate = Settings.Default.SecondsToRefresh;
            }
/*            else
            {
                    Appoints appoints = (Appoints)bindingSourceAppoints.DataSource;
                    if (appoints.ReadyToPoint)
                        BackColor = (BackColor == Color.Red ? SystemColors.Control : Color.Red);
            } */
            toolStripTextBoxTimeToUpdate.Text = timeToUpdate.ToString();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            toolStripButtonRefresh.Text = "обновление";
            bindingSourceAppoints.DataSource = new Appoints(database, DocStateGroups.Dispatcher);
            toolStripButtonRefresh.Text = "обновить";
            timeToUpdate = Settings.Default.SecondsToRefresh;
            toolStripTextBoxTimeToUpdate.Text = timeToUpdate.ToString();
        }

        private void dataGridViewAppoints_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Appoint appoint = ((Appoints)bindingSourceAppoints.DataSource)[e.RowIndex];
            dataGridViewAppoints.Rows[e.RowIndex].DefaultCellStyle.BackColor = appoint.Color;
            if (appoint.Color != SystemColors.Window)
            {
                dataGridViewAppoints.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Green;
                dataGridViewAppoints.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = appoint.Color;
                dataGridViewAppoints.Rows[e.RowIndex].DefaultCellStyle.Font
                    = new Font(dataGridViewAppoints.DefaultCellStyle.Font, FontStyle.Bold);
            }


        }

        private void buttonSetOut_Click(object sender, EventArgs e)
        {
            Appoint appoint = (Appoint)bindingSourceAppoints.Current;
            if (appoint != null)
                appoint.GetOut(database, User);
            toolStripButtonRefresh_Click(sender, e);
        }

        private void toolStripTextBoxLookup_TextChanged(object sender, EventArgs e)
        {
            string str = toolStripTextBoxLookup.Text;
            string[] properties = { "LicensePlate", "DriverName", "Warrant" };

            Appoints appoints = (Appoints)bindingSourceAppoints.DataSource;

            if (appoints.Count > 0 && str.Length > 0)
            {
                int index = appoints.FindIndex(properties[toolStripComboBoxProperty.SelectedIndex],
                                               str, SearchTerm.Contains, 0);
                if (index == -1) index = 0;
                dataGridViewAppoints.CurrentCell = dataGridViewAppoints[0, index];
            }
        }

        private void FormDispatcher_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }


        private void CreateNewAppoint()
        {
            //FormStart form = (FormStart)MdiParent;
            //FormAppoint formAppoint = new FormAppoint();
            //formAppoint.Database = database;
            //form.AddChild(formAppoint);

            CreateAppointForm form = new CreateAppointForm(MdiParent, (FirebirdDatabase)database);
            form.Show();
        }

        private void btnPermit_Click(object sender, EventArgs e)
        {
            ShowPermit();
        }

        private void ShowPermit()
        {
            Appoint appoint = (Appoint)bindingSourceAppoints.Current;
            Permit permit = appoint.GetPermit(database);
            permit.Print();
        }

    }
}