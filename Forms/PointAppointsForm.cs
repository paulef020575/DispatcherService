using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using DispatcherService.Properties;
using EPV.Data;
using EPV.Forms;

namespace DispatcherService.Forms
{
    public partial class PointAppointsForm : Form
    {
        #region Поля и свойства

        private EPVDatabase database;

        private Point point;

        public Point Point
        {
            set { point = value; }
        }

        public SecurityUser User
        {
            get { return (SecurityUser)((FormStart)Application.OpenForms["FormStart"]).User; }
        }


        private int timeToRefresh;

        #endregion

        #region Конструктор
        
        public PointAppointsForm(Form mdiParent, EPVDatabase dbase)
        {
            InitializeComponent();

            MdiParent = mdiParent;
            database = dbase;

            timeToRefresh = Settings.Default.SecondsToRefresh;

            dgvQueue.AutoGenerateColumns = false;
            dgvLoading.AutoGenerateColumns = false;


            buttonFinish.Text = "Завершение\nпогрузки / выгрузки";
        }

        #endregion

        #region Обработчики событий

        private void PointAppointsForm_Load(object sender, EventArgs e)
        {
            SelectPoint();
            //RefreshData();
            StartTimer();
        }

        private void eventRefreshData(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TickTimer();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvQueue_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            BindingList<AppointState> appointList = (BindingList<AppointState>)((DataGridView)sender).DataSource;

            if (appointList.Count > 0 &&
                ((dgvQueue.Equals(sender) && e.ColumnIndex == queueColumnTime.Index)
                 || (dgvLoading.Equals(sender) && e.ColumnIndex == loadingColumnTime.Index)))
            {
                TimeSpan timeSpan = DateTime.Now - appointList[e.RowIndex].Date;
                int seconds = timeSpan.Seconds;

                e.Value = ((int)timeSpan.TotalMinutes).ToString() + ":" + (seconds < 10 ? "0" : "") + seconds.ToString();
            }
        }

        private void dgvQueue_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            BindingList<AppointState> appointList = (BindingList<AppointState>)((DataGridView)sender).DataSource;
            AppointState appointState = appointList[e.RowIndex];

            TimeSpan timeSpan = DateTime.Now - appointState.Date;

            DataGridView dgv = (DataGridView)sender;

            if (timeSpan.TotalMinutes >= 30)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSalmon;
                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Red;
            }
        }

        private void PointAppointsForm_Shown(object sender, EventArgs e)
        {
            dgvLoading.ClearSelection();
        }

        private void dgvQueue_Enter(object sender, EventArgs e)
        {
            dgvLoading.ClearSelection();
        }

        private void dgvLoading_Enter(object sender, EventArgs e)
        {
            dgvQueue.ClearSelection();
        }

        private void buttonSetToLoading_Click(object sender, EventArgs e)
        {
            SetAppointFromQueueToLoading();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            FinishAppointLoading();
        }

        private void buttonRequeue_Click(object sender, EventArgs e)
        {
            ResetAppointPoint();
        }

        private void tboxFind_TextChanged(object sender, EventArgs e)
        {
            if (!tboxFind.Text.Equals(string.Empty))
                ShowCellsWithText(tboxFind.Text);
            else
                ClearFindedText();
        }

        private void buttonClearFind_Click(object sender, EventArgs e)
        {
            tboxFind.Clear();
        }

        #endregion

        #region Методы

        private void SelectPoint()
        {
            Points points = new Points(database);
            cboxPoint.DataSource = points;

            if (Settings.Default.PointId > 0)
                cboxPoint.SelectedItem = points.Find(Settings.Default.PointId);
        }

        public void SetPointFixed()
        {
            if (Settings.Default.PointId > 0)
                cboxPoint.Enabled = false;
        }

        private void StartTimer()
        {
            timer.Start();
        }

        private void TickTimer()
        {
            timeToRefresh--;

            if (timeToRefresh == 0)
                RefreshData();

            lblTimer.Text = timeToRefresh.ToString();
            dgvQueue.Refresh();
            dgvLoading.Refresh();
        }

        private void RefreshData()
        {
                Enumeration docStates = new Enumeration(database, "docState");
                //Points points = new Points(database);

                Point point = (Point)cboxPoint.SelectedItem;

                dgvQueue.DataSource = AppointState.LoadList(database, point, docStates.Find(3));

                docStates = new Enumeration(database, "docState");
                //points = new Points(database);
                dgvLoading.DataSource = AppointState.LoadList(database, point, docStates.Find(4));

                timeToRefresh = Settings.Default.SecondsToRefresh;

                if (ActiveControl == dgvLoading)
                    dgvQueue.ClearSelection();
                else
                    dgvLoading.ClearSelection();
        }

        private void SetAppointFromQueueToLoading()
        {
            BindingList<AppointState> appoints = (BindingList<AppointState>)dgvQueue.DataSource;

            if (dgvQueue.SelectedRows.Count > 0)
            {
                FormStart form = (FormStart)MdiParent;
                FormGetAppoint formGet = new FormGetAppoint();
                formGet.Database = database;
                formGet.Ready = true;
                formGet.Appoint = appoints[dgvQueue.SelectedRows[0].Index].Appoint;
                formGet.SaveData += eventRefreshData;
                form.AddDialog(formGet);
                
            }
            else
                MessageBox.Show(resources.Message.WrongDataGridView, "Ошибка");
        }

        private void FinishAppointLoading()
        {
            BindingList<AppointState> appoints = (BindingList<AppointState>)dgvLoading.DataSource;

            if (dgvLoading.SelectedRows.Count > 0)
            {
                Appoint appoint = appoints[dgvLoading.SelectedRows[0].Index].Appoint;
                if (MessageBox.Show(resources.Message.AskLoadingFinish, appoint.LicensePlate, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    appoint.EndPoint(database, User);
                    RefreshData();
                }
            }
            else
                MessageBox.Show(resources.Message.WrongDataGridView, "Ошибка");
        }

        private void ResetAppointPoint()
        {
            Appoint appoint = null;

            if (dgvQueue.SelectedRows.Count > 0)
            {
                BindingList<AppointState> appoints = (BindingList<AppointState>)dgvQueue.DataSource;
                appoint = appoints[dgvQueue.SelectedRows[0].Index].Appoint;
            }
            else
            {
                if (dgvLoading.SelectedRows.Count > 0)
                {
                    BindingList<AppointState> appoints = (BindingList<AppointState>)dgvLoading.DataSource;
                    appoint = appoints[dgvLoading.SelectedRows[0].Index].Appoint;
                }
                else
                {
                    MessageBox.Show(resources.Message.NoAppointSelected, "Ошибка");
                    return;
                }
            }

            FormStart form = (FormStart)MdiParent;
            FormSetToPoint formAppoint = new FormSetToPoint();
            formAppoint.Database = database;
            formAppoint.Appoint = appoint;
            formAppoint.SaveData += eventRefreshData;
            form.AddChild(formAppoint);
            
        }

        private void ShowCellsWithText(string p)
        {
            for (int i = 0; i < dgvQueue.Rows.Count; i++)
                for (int j = 0; j < dgvQueue.Columns.Count; j++)
                {
                    if (dgvQueue[j, i].Value == null) continue;
                    Color defaultColor = ((dgvQueue[j, i].State & DataGridViewElementStates.Selected) > 0 ?
                                            dgvQueue.Rows[i].DefaultCellStyle.SelectionBackColor : dgvQueue.Rows[i].DefaultCellStyle.BackColor);

                    string valueText = dgvQueue[j, i].Value.ToString();
                    if (valueText.Length > p.Length && valueText.ToUpper().Contains(p.ToUpper()))
                        dgvQueue[j, i].Style.BackColor = SystemColors.Highlight;
                    else
                        dgvQueue[j, i].Style.BackColor = defaultColor;

                }

            for (int i = 0; i < dgvLoading.Rows.Count; i++)
                for (int j = 0; j < dgvLoading.Columns.Count; j++)
                {
                    if (dgvLoading[j, i].Value == null) continue;
                    Color defaultColor = ((dgvLoading[j, i].State & DataGridViewElementStates.Selected) > 0 ?
                                            dgvLoading.Rows[i].DefaultCellStyle.SelectionBackColor : dgvLoading.Rows[i].DefaultCellStyle.BackColor);

                    string valueText = dgvLoading[j, i].Value.ToString();
                    if (valueText.Length > p.Length && valueText.ToUpper().Contains(p.ToUpper()))
                        dgvLoading[j, i].Style.BackColor = SystemColors.Highlight;
                    else
                        dgvLoading[j, i].Style.BackColor = defaultColor;
                }
        }

        private void ClearFindedText()
        {
            for (int i = 0; i < dgvQueue.Rows.Count; i++)
                for (int j = 0; j < dgvQueue.Columns.Count; j++)
                {
                    Color defaultColor = ((dgvQueue[j, i].State & DataGridViewElementStates.Selected) > 0 ?
                                            dgvQueue.Rows[i].DefaultCellStyle.SelectionBackColor : dgvQueue.Rows[i].DefaultCellStyle.BackColor);
                    dgvQueue[j, i].Style.BackColor = defaultColor;
                }

            for (int i = 0; i < dgvLoading.Rows.Count; i++)
                for (int j = 0; j < dgvLoading.Columns.Count; j++)
                {
                    Color defaultColor = ((dgvLoading[j, i].State & DataGridViewElementStates.Selected) > 0 ?
                                            dgvLoading.Rows[i].DefaultCellStyle.SelectionBackColor : dgvLoading.Rows[i].DefaultCellStyle.BackColor);
                    dgvLoading[j, i].Style.BackColor = defaultColor;
                }
        }

        #endregion

        private void PointAppointsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.PointId = ((Point)cboxPoint.SelectedItem).Id;
            Settings.Default.Save();
        }


    }
}
