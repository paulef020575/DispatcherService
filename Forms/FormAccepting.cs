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

namespace DispatcherService
{
    public partial class FormAccepting : EPVFormChild, INeedDatabase
    {
        private int timerToRefresh;

        private EPVDatabase database;
        public EPVDatabase Database
        {
            set
            {
                if (database != null) return;
                database = value;
                Units units = new Units(database);
                comboBoxUnits.DataSource = units;
                comboBoxUnits.SelectedItem = units.Find(Settings.Default.Unit);
                timerRefresh.Start();

                if (MdiParent != null)
                    comboBoxUnits.Enabled = ((EPVFormStart)MdiParent).User.CheckAdmin();
            }
        }

        public SecurityUser User
        {
            get { return (SecurityUser)((FormStart)Application.OpenForms["FormStart"]).User; }
        }



        public FormAccepting()
        {
            InitializeComponent();
            dataGridViewDispatcher.AutoGenerateColumns = false;
            dataGridViewInWay.AutoGenerateColumns = false;
            buttonAccept.Width = panelDispatcherTools.Width / 3;
            buttonIdle.Width = panelDispatcherTools.Width / 3;

            timerToRefresh = Settings.Default.SecondsToRefresh;
            textBoxTimer.Text = timerToRefresh.ToString();
            comboBoxProperties.SelectedIndex = 0;

            //dataGridViewDispatcher.Height = panelData.Height / 2;
        }

        private void comboBoxUnits_SelectedValueChanged(object sender, EventArgs e)
        {
            if (database != null && comboBoxUnits.SelectedItem is Unit)
            {
                panelPoints.Controls.Clear();
                Points points = new Points(database, (Unit)comboBoxUnits.SelectedItem);
                int position = 0;
                for (int i = 0; i < points.Count; i++)
                {
                    UserControlPoint control = new UserControlPoint();
                    control.Database = database;
                    control.Point = points[i];
                    control.Top = position;
                    control.Left = 0;
                    position += control.Height;
                    panelPoints.Controls.Add(control);
                }
                RefreshData();
            }

        }

        private void FormAccepting_SizeChanged(object sender, EventArgs e)
        {
            buttonAccept.Width = panelDispatcherTools.Width / 3;
            buttonIdle.Width = panelDispatcherTools.Width / 3;

            int bottomHeight = buttonToPoint.Height + buttonNegative.Height + buttonReturn.Height;
            bottomHeight += panelGetHeader.Height + panelDispatcherTools.Height;
            dataGridViewDispatcher.Height = panelData.Height - panelFilter.Height - bottomHeight;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            FormStart form = (FormStart)MdiParent;
            FormGetAppoint formGet = new FormGetAppoint();
            formGet.Database = database;
            formGet.Appoint = ((Appoints)dataGridViewDispatcher.DataSource)[dataGridViewDispatcher.CurrentCell.RowIndex];
            form.AddDialog(formGet);
            RefreshData();
        }

        private void FormAccepting_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Appoints appoints = (Appoints)dataGridViewDispatcher.DataSource;
            if (appoints.Count > 0)
            {
                FormStart parent = (FormStart)MdiParent;
                FormBrakeOrOut form = new FormBrakeOrOut();
                form.Database = database;
                form.Appoint = ((Appoints)dataGridViewDispatcher.DataSource)[dataGridViewDispatcher.CurrentCell.RowIndex];
                form.GetOut = true;
                parent.AddDialog(form);
                RefreshData();
            }
        }

        private void buttonIdle_Click(object sender, EventArgs e)
        {
            Appoints appoints = (Appoints)dataGridViewDispatcher.DataSource;
            if (appoints.Count > 0)
            {
                FormStart parent = (FormStart)MdiParent;
                FormBrakeOrOut form = new FormBrakeOrOut();
                form.Database = database;
                form.Appoint = ((Appoints)dataGridViewDispatcher.DataSource)[dataGridViewDispatcher.CurrentCell.RowIndex];
                form.GetOut = false;
                parent.AddDialog(form);
                RefreshData();
            }
        }

        private void buttonToPoint_Click(object sender, EventArgs e)
        {
            Appoints appoints = (Appoints)dataGridViewInWay.DataSource;
            if (appoints.Count > 0)
            {
                FormStart form = (FormStart)MdiParent;
                FormGetAppoint formGet = new FormGetAppoint();
                formGet.Database = database;
                formGet.Ready = true;
                formGet.Appoint = ((Appoints)dataGridViewInWay.DataSource)[dataGridViewInWay.CurrentCell.RowIndex];
                form.AddDialog(formGet);
                RefreshData();
            }
        }

        public void RefreshData()
        {
            buttonRefresh.Text = "обновляю";
            int idAppoint = 0;
            if (dataGridViewDispatcher.DataSource != null
                && dataGridViewDispatcher.CurrentCell != null
                && dataGridViewDispatcher.Rows.Count > 0)
                idAppoint = ((Appoints)dataGridViewDispatcher.DataSource)[dataGridViewDispatcher.CurrentCell.RowIndex].Id;

            Appoints appoints = new Appoints(database, DocStateGroups.Dispatcher,
                                                             (Unit)comboBoxUnits.SelectedItem);
            dataGridViewDispatcher.DataSource = appoints;
            int index = appoints.FindIndex("Id", idAppoint, EPV.Data.SearchTerm.Full, 0);
            if (index > -1)
                dataGridViewDispatcher.CurrentCell = dataGridViewDispatcher[0, index];

            dataGridViewInWay.DataSource = new Appoints(database, DocStateGroups.BeforeStart,
                                                        (Unit)comboBoxUnits.SelectedItem);

            //panelPoints.Visible = false;
            for (int i = 0; i < panelPoints.Controls.Count; i++)
            {
                UserControlPoint control = (UserControlPoint)panelPoints.Controls[i];
                control.RefreshData();
            }
            //panelPoints.Visible = true;

            timerToRefresh = Settings.Default.SecondsToRefresh;
            buttonRefresh.Text = "обновить";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            timerToRefresh--;
            if (timerToRefresh == 0) RefreshData();
            textBoxTimer.Text = timerToRefresh.ToString();
        }

        private void textBoxLookup_TextChanged(object sender, EventArgs e)
        {
            string str = textBoxLookup.Text;
            string[] properties = { "LicensePlate", "DriverName", "Warrant" };

            Appoints appoints = (Appoints)dataGridViewDispatcher.DataSource;

            if (appoints.Count > 0 && str.Length > 0)
            {
                int index = appoints.FindIndex(properties[comboBoxProperties.SelectedIndex],
                                               str, SearchTerm.Contains, 0);
                if (index == -1) index = 0;
                dataGridViewDispatcher.CurrentCell = dataGridViewDispatcher[0, index];
            }
        }

        private void FormAccepting_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void dataGridViewDispatcher_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Appoint appoint = ((Appoints)dataGridViewDispatcher.DataSource)[e.RowIndex];
            dataGridViewDispatcher.Rows[e.RowIndex].DefaultCellStyle.BackColor = appoint.Color;
        }

        public void SetReadOnly()
        {
            panelDispatcherTools.Visible = false;
            panelGetTools.Visible = false;

            for (int i = 0; i < panelPoints.Controls.Count; i++)
            {
                UserControlPoint control = (UserControlPoint)panelPoints.Controls[i];
                control.SetReadOnly();
            }
        }


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Appoints appoints = (Appoints)dataGridViewInWay.DataSource;
            if (appoints.Count > 0
                && MessageBox.Show("Вернуть машину на стоянку?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ((Appoints)dataGridViewInWay.DataSource)[dataGridViewInWay.CurrentCell.RowIndex].ReturnToDispatcher(database, User);
            RefreshData();
       }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            Appoints appoints = (Appoints)dataGridViewInWay.DataSource;
            if (appoints.Count > 0
                && MessageBox.Show("Отказать в обработке?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ((Appoints)dataGridViewInWay.DataSource)[dataGridViewInWay.CurrentCell.RowIndex].GetOut(database, User);
            RefreshData();
        }

        private void FormAccepting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Unit = ((Unit)comboBoxUnits.SelectedItem).Id;
            Settings.Default.Save();
        }
    }
}