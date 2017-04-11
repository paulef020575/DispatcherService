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
using System.Data.Common;

namespace DispatcherService.Forms
{
    public partial class PlanAppointForm : Form
    {
        #region Fields & Properties

        private EPVDatabase database;

        public PlanAppoint PlanAppoint
        {
            get { return (PlanAppoint)bsRow.DataSource; }
            set 
            {
                try
                {
                    bsRow.DataSource = value.CreateCopy(database);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка");
                }
            }
        }

        #endregion

        #region Constructors

        public PlanAppointForm(Form parent, EPVDatabase dbase)
        {
            InitializeComponent();

            MdiParent = parent;
            database = dbase;
        }

        #endregion

        #region Event handlers

        private EventHandler onDataSaved;

        public event EventHandler DataSaved
        {
            add { onDataSaved += value; }
            remove { onDataSaved -= value; }
        }

        private void PlanAppointForm_Load(object sender, EventArgs e)
        {
            Units units = new Units(database);
            if (bsRow.DataSource == null)
                bsRow.DataSource = new PlanAppoint(units[0]);

            FillTrackMarkList(); 

            AddBindings();
        }

        private void tboxTrackMark_Leave(object sender, EventArgs e)
        {
            AutoCompleteStringCollection licensePlateCollection = new AutoCompleteStringCollection();
            QueryParameters parameters = new QueryParameters("trackMark", tboxTrackMark.Text);
            DbDataReader reader = database.ExecuteReader(Queries.LicensePlateList, parameters);
            while (reader.Read())
                licensePlateCollection.Add((string)reader[0]);
            reader.Close();

            tboxLicensePlate.AutoCompleteCustomSource = licensePlateCollection;

        }

        private void tboxLicensePlate_Leave(object sender, EventArgs e)
        {
            AutoCompleteStringCollection driverCollection = new AutoCompleteStringCollection();
            QueryParameters parameters = new QueryParameters("trackMark", tboxTrackMark.Text);
            parameters.Add("licensePlate", tboxLicensePlate.Text);

            DbDataReader reader = database.ExecuteReader(Queries.DriverList, parameters);
            while (reader.Read())
            {
                if (tboxDriverName.Text.Equals(string.Empty)
                    || tboxDriverName.Text.Equals("Водитель"))
                {
                    tboxDriverName.Text = (string)reader["driverName"];
                    tboxDriverPhone.Text = (string)reader["driverPhone"];
                }

                driverCollection.Add((string)reader["driverName"]);
            }

            reader.Close();

            tboxDriverName.AutoCompleteCustomSource = driverCollection;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveAppoint())
                Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void FillTrackMarkList()
        {
            AutoCompleteStringCollection trackMarkCollection = new AutoCompleteStringCollection();
            DbDataReader reader = database.ExecuteReader(Queries.TrackMarkList);
            while (reader.Read())
                trackMarkCollection.Add((string)reader[0]);
            reader.Close();

            tboxTrackMark.AutoCompleteMode = AutoCompleteMode.Suggest;
            tboxTrackMark.AutoCompleteCustomSource = trackMarkCollection;
            tboxTrackMark.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void AddBindings()
        {
            pickPlanDate.DataBindings.Add("Value", bsRow, "PlanDate", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxTrackMark.DataBindings.Add("Text", bsRow, "TrackMark", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxLicensePlate.DataBindings.Add("Text", bsRow, "LicensePlate", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxDriverName.DataBindings.Add("Text", bsRow, "DriverName", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxDriverPhone.DataBindings.Add("Text", bsRow, "DriverPhone", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCargo.DataBindings.Add("Text", bsRow, "Cargo", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxNotes.DataBindings.Add("Text", bsRow, "Notes", true, DataSourceUpdateMode.OnPropertyChanged);
            chkClosed.DataBindings.Add("Checked", bsRow, "IsClosed", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private bool SaveAppoint()
        {
            try
            {
                PlanAppoint.Save(database);

                if (onDataSaved != null)
                    onDataSaved(PlanAppoint, new EventArgs());

                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка сохранения");
                return false;
            }
            
        }
        
        #endregion

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            PlanAppoint.Cargo = "за бумагой";
        }

        private void buttonLst_Click(object sender, EventArgs e)
        {
            PlanAppoint.Cargo = "за лигносульфанатами";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanAppoint.Cargo = "за дрожжами";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlanAppoint.Cargo = "за картоном";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlanAppoint.Cargo = "органол";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlanAppoint.Cargo = "мазут";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlanAppoint.Cargo = "бензин/диз.топливо";
        }


    }
}
