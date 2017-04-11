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
    public partial class FormBrakeOrOut : EPVFormChild
    {
        private EPVDatabase database;
        public EPVDatabase Database { set { database = value; } }

        private Appoint appoint;
        public Appoint Appoint
        {
            set
            {
                appoint = value;
                textBoxLicensePlate.Text = appoint.LicensePlate;
                textBoxCargo.Text = appoint.Cargo;
                textBoxIdleReason.Text = appoint.IdleReason;

                if (appoint.IdleReason == "")
                {
                    string query = "select first 1 idleReason from docAppoints where idUnit = " + appoint.Unit.Id.ToString();
                    query += " order by id desc";
                    object res = database.ExecuteScalar(query);
                    if (!DBNull.Value.Equals(res))
                        textBoxIdleReason.Text = (string)res;
                }
            }
        }

        private bool getOut;
        public bool GetOut
        {
            set
            {
                getOut = value;
                if (getOut)
                {
                    Text = "ѕричина отказа";
                    label3.Text = "ѕричина отказа";
                }

            }
        }

        private string textLast;

        public SecurityUser User
        {
            get { return (SecurityUser)((FormStart)Application.OpenForms["FormStart"]).User; }
        }


        public FormBrakeOrOut()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (getOut)
                appoint.WeCannotGetIt(database, textBoxIdleReason.Text, User);
            else
            {
                appoint.IdleReason = textBoxIdleReason.Text;
                appoint.Save(database);
            }
            Close();
        }

        private void buttonNoPaper_Click(object sender, EventArgs e)
        {
            textBoxIdleReason.Text = "нет бумаги";
        }

        private void buttonTooMany_Click(object sender, EventArgs e)
        {
            textBoxIdleReason.Text = "очередь - нет точки под погрузку";
        }

        private void buttonNoWarrant_Click(object sender, EventArgs e)
        {
            textBoxIdleReason.Text = "нет доверенности";
        }
    }
}