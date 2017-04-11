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
    public partial class FormGetAppoint : EPVFormChild
    {
        private EPVDatabase database;
        private Appoint appoint;
        private bool ready = false;

        public SecurityUser User
        {
            get { return (SecurityUser)((FormStart)Application.OpenForms["FormStart"]).User; }
        }


        public FormGetAppoint()
        {
            InitializeComponent();
            dateTimePickerSetting.Value = DateTime.Now;
        }

        #region INeedDatabase Members

        public EPVDatabase Database { set { database = value; } }

        #endregion

        public Appoint Appoint
        {
            get { return appoint; }
            set
            {
                appoint = value;
                textBoxLicensePlate.Text = appoint.LicensePlate;
                textBoxCargo.Text = appoint.Cargo;
                textBoxIdleReason.Text = appoint.IdleReason;
                Points points = new Points(database, Appoint.Unit);
                comboBoxPoints.DataSource = points;
                if (appoint.Point != null) comboBoxPoints.SelectedItem = points.Find(Appoint.Point.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ready)
                appoint.StandAtPoint(database, (Point)comboBoxPoints.SelectedItem,
                                     dateTimePickerSetting.Value, User);
            else
                appoint.GetToPoint(database, (Point)comboBoxPoints.SelectedItem,
                                   dateTimePickerSetting.Value, textBoxIdleReason.Text, User);

            if (onSaveData != null)
                onSaveData(sender, e);

            Close();
        }


        public bool Ready
        {
            set
            {
                ready = value;
                if (ready)
                {
                    labelReason.Visible = false;
                    textBoxIdleReason.Visible = false;
                    Height = 214;
                }
            }
        }

        private EventHandler onSaveData;

        public event EventHandler SaveData
        {
            add { onSaveData += value; }
            remove { onSaveData -= value; }
        }

    }
}