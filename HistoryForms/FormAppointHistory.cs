using EPV.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DispatcherService
{
    public partial class FormAppointHistory : Form
    {
        private EPVDatabase database;
        private int appointId;
        private int progressBarHeight;

        private class LoadingParameters
        {
            public EPVDatabase Database { get; set; }
            public int AppointId { get; set; }
        }

        private class LoadingResult
        {
            public AppointHistory AppointHistory { get; set; }
            public BindingList<AppointLog> AppointLog { get; set; }
        }


        private FormAppointHistory()
        {
            InitializeComponent();

            progressBarHeight = pbarLoading.Height;

        }

        public FormAppointHistory(Form mdiParent, EPVDatabase dbase, IAppointHistory appoint)
            : this()
        {
            MdiParent = mdiParent;
            database = dbase;

            appointId = appoint.Id;
        }

        private void LoadData()
        {
            pbarLoading.Height = progressBarHeight;
            timerLoading.Start();

            LoadingParameters parameters = new LoadingParameters()
            {
                Database = database,
                AppointId = appointId
            };


            //AppointHistory appointHistory = AppointHistory.LoadList(parameters.Database, parameters.AppointId); ;
            //bsAppointHistory.DataSource = appointHistory;
            //lblVehicle.Text = appointHistory.Vehicle;
            //lblDriverName.Text = appointHistory.Driver;
            //lblDriverPhone.Text = appointHistory.DriverPhone;
            //lblCargo.Text = appointHistory.Cargo;
            //lblWhereTo.Text = appointHistory.WhereTo;
            //bsLog.DataSource = AppointLog.LoadList(parameters.Database, parameters.AppointId);
            bwRefresh.RunWorkerAsync(parameters);
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (++pbarLoading.Value == pbarLoading.Maximum)
                pbarLoading.Value = 0;
        }

        private void FormAppointHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bwRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadingParameters parameters = (LoadingParameters)e.Argument;

            LoadingResult result = new LoadingResult()
            {
                AppointHistory = AppointHistory.LoadList(parameters.Database, parameters.AppointId),
                AppointLog = AppointLog.LoadList(parameters.Database, parameters.AppointId)
            };

            e.Result = result;
        }

        private void bwRefresh_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadingResult result = (LoadingResult)e.Result; 
            AppointHistory appointHistory = result.AppointHistory;
            bsAppointHistory.DataSource = appointHistory;
            lblVehicle.Text = appointHistory.Vehicle;
            lblDriverName.Text = appointHistory.Driver;
            lblDriverPhone.Text = appointHistory.DriverPhone;
            lblCargo.Text = appointHistory.Cargo;
            lblWhereTo.Text = appointHistory.WhereTo;

            bsLog.DataSource = result.AppointLog;

            timerLoading.Stop();
            pbarLoading.Height = 0;
        }
    }
}
