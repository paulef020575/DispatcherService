using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Forms;
using EPV.Database;
using EPV.Data;
using System.Data.Common;

namespace DispatcherService
{
    public partial class FormAppoint : EPVFormChild
    {
        #region Поля и свойства
        
        private bool autoComplete;

        private EPVDatabase database;
        public EPVDatabase Database
        {
            set
            {
                database = value;
                comboBoxCitizen.DataSource = new States(database);
                comboBoxUnits.DataSource = new Units(database);

                appoint = new Appoint((Unit)comboBoxUnits.Items[0],
                                      (State)comboBoxCitizen.Items[0],
                                      new EnumerationItem("docState", 0, "ожидает обработки"));

                fillMarkAutoComplete();
                fillLicenseAutoComplete(); 
                AddBindings();
                autoComplete = true;
            }
        }

        private Appoint appoint;
        public Appoint Appoint
        {
            get { return appoint; }
            set
            {
                ClearBindings();
                appoint = new Appoint(database, value, (Units)comboBoxUnits.DataSource, (States)comboBoxCitizen.DataSource);
                AddBindings();
                autoComplete = false;
            }
        }

        public SecurityUser User
        {
            get { return (SecurityUser)((FormStart)Application.OpenForms["FormStart"]).User; ; }
        }


        #endregion

        #region Методы

        private void fillLicenseAutoComplete()
        {
            string query = "select licensePlate, count(id) as cnt from docAppoints ";
            if (textBoxTrackMark.Text.Length > 0) query += "where trackMark like '" + textBoxTrackMark.Text + "' ";
            query += "group by licensePlate having count(id) > 1 order by cnt desc";

            DbDataReader reader = database.ExecuteReader(query);
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (reader.Read()) collection.Add((string)reader["licensePlate"]);
            reader.Close();
            textBoxLicensePlate.AutoCompleteCustomSource = collection;
        }

        private void fillMarkAutoComplete()
        {
            DbDataReader reader = database.ExecuteReader("select trackMark from docAppoints group by trackMark order by trackMark");
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (reader.Read()) collection.Add((string)reader["trackMark"]);
            reader.Close();
            textBoxTrackMark.AutoCompleteCustomSource = collection;
        }

        private void AddBindings()
        {
            textBoxTrackMark.DataBindings.Add("Text", appoint, "TrackMark", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxLicensePlate.DataBindings.Add("Text", appoint, "LicensePlate", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxTrailer.DataBindings.Add("Text", appoint, "Trailer", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxCitizen.DataBindings.Add("SelectedItem", appoint, "Citizen", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCargo.DataBindings.Add("Text", appoint, "Cargo", false, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxUnits.DataBindings.Add("SelectedItem", appoint, "Unit", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxDriverName.DataBindings.Add("Text", appoint, "DriverName", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxDriverPhone.DataBindings.Add("Text", appoint, "DriverPhone", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxWarrant.DataBindings.Add("Text", appoint, "Warrant", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxWhereTo.DataBindings.Add("Text", appoint, "WhereTo", false, DataSourceUpdateMode.OnPropertyChanged);

            dateTimePickerComing.Value = appoint.DateComing;
        }

        private void ClearBindings()
        {
            textBoxWhereTo.DataBindings.Clear();
            textBoxWarrant.DataBindings.Clear();
            textBoxDriverName.DataBindings.Clear();
            textBoxDriverPhone.DataBindings.Clear();
            comboBoxUnits.DataBindings.Clear();
            textBoxCargo.DataBindings.Clear();
            comboBoxCitizen.DataBindings.Clear();
            textBoxTrailer.DataBindings.Clear();
            textBoxLicensePlate.DataBindings.Clear();
            textBoxTrackMark.DataBindings.Clear();
        }

        #endregion

        #region Конструктор

        public FormAppoint()
        {
            InitializeComponent();
            dateTimePickerComing.Value = DateTime.Now;
        }

        #endregion

        #region События

        private void buttonSave_Click(object sender, EventArgs e)
        {
            appoint.Save(database);

            if (appoint.DateComing != dateTimePickerComing.Value)
                appoint.SetTimeComing(database, dateTimePickerComing.Value, User);

            if (onSaveData != null)
                onSaveData(sender, e);
        }

        #region cargoAutoFill
        private void buttonPaper_Click(object sender, EventArgs e)
        {
            textBoxCargo.Text = "за бумагой";
        }

        private void buttonLst_Click(object sender, EventArgs e)
        {
            textBoxCargo.Text = "за лигносульфанатами";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCargo.Text = "за дрожжами";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxCargo.Text = "за картоном";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxCargo.Text = "органол";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxCargo.Text = "мазут";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxCargo.Text = "бензин/диз.топливо";
        }

        #endregion

        private void textBoxLicensePlate_Enter(object sender, EventArgs e)
        {
            fillLicenseAutoComplete();
        }

        private void textBoxLicensePlate_Leave(object sender, EventArgs e)
        {
            if (autoComplete && textBoxLicensePlate.Text.Length > 0)
            {
                string query = "select first 1 * from docAppoints where licensePlate like '" + textBoxLicensePlate.Text;
                query += "' order by id desc";

                DbDataReader reader = database.ExecuteReader(query);
                if (reader.Read())
                {
                    if (textBoxTrackMark.Text.Length == 0) textBoxTrackMark.Text = (string)reader["trackMark"];
                    textBoxTrailer.Text = (string)reader["trailer"];
                    comboBoxCitizen.SelectedItem = ((States)comboBoxCitizen.DataSource).Find((int)reader["state"]);
                    textBoxCargo.Text = (string)reader["cargo"];
                    comboBoxUnits.SelectedItem = ((Units)comboBoxUnits.DataSource).Find((int)reader["idUnit"]);
                    textBoxDriverName.Text = (string)reader["driverName"];
                    textBoxDriverPhone.Text = (string)reader["driverPhone"];
                    textBoxWhereTo.Text = (string)reader["whereTo"];

                    autoComplete = false;
                }

                reader.Close();
            }
        }

        private EventHandler onSaveData;

        public event EventHandler SaveData
        {
            add { onSaveData += value; }
            remove { onSaveData -= value; }
        }

        #endregion

    }
}