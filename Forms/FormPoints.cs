using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Forms;
using EPV.Database;

namespace DispatcherService
{
    public partial class FormPoints : EPVFormChild
    {
        public EPVDatabase Database
        {
            set
            {
                epvGridPoints.Database = value;
                comboBoxUnits.DataSource = new Units(value);
            }
        }

        public FormPoints()
        {
            InitializeComponent();
        }

        private void comboBoxUnits_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxUnits.SelectedValue == null) return;
            Unit unit = (Unit)comboBoxUnits.SelectedValue;
            EPVDatabase database = epvGridPoints.Database;
            epvGridPoints.DataSource = new Points(database, unit);
        }
    }
}