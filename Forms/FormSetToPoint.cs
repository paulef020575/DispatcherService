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

namespace DispatcherService
{
    public partial class FormSetToPoint : EPVFormChild
    {
        private EPVDatabase database;
        public EPVDatabase Database
        {
            set
            {
                database = value;
                comboBoxUnits.DataSource = new Units(database);
            }
        }

        private Appoint appoint;
        public Appoint Appoint
        {
            get { return appoint; }
            set
            {
                appoint = value;
                AddBindings();
            }
        }

        public SecurityUser User
        {
            get { return (SecurityUser)((FormStart)Application.OpenForms["FormStart"]).User; ; }
        }


        private void AddBindings()
        {
            textBoxLicensePlate.DataBindings.Add("Text", appoint, "LicensePlate");
            textBoxCargo.DataBindings.Add("Text", appoint, "Cargo");
            comboBoxUnits.SelectedItem = ((Units)comboBoxUnits.DataSource).Find(appoint.Unit.Id);
            if (appoint.Point != null)
                comboBoxPoints.SelectedItem = ((Points)comboBoxPoints.DataSource).Find(appoint.Point.Id);
            dateTimePickerSetting.Value = DateTime.Now;
        }


        public FormSetToPoint()
        {
            InitializeComponent();
        }

        private void comboBoxUnits_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxUnits.SelectedItem != null)
                comboBoxPoints.DataSource = new Points(database, (Unit)comboBoxUnits.SelectedItem);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (appoint != null)
                appoint.SetToPoint(database, (Unit)comboBoxUnits.SelectedItem, 
                                   (Point)comboBoxPoints.SelectedItem, dateTimePickerSetting.Value, User);

            if (onSaveData != null)
                onSaveData(sender, e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private EventHandler onSaveData;

        public event EventHandler SaveData
        {
            add { onSaveData += value; }
            remove { onSaveData -= value; }
        }
    }
}