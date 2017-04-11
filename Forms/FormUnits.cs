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
    public partial class FormUnits : EPVFormChild
    {
        private EPVDatabase database;
        public EPVDatabase Database
        {
            set
            {
                database = value;
                epvGridUnits.Database = database;
                epvGridUnits.DataSource = new Units(database);
            }
        }

        public FormUnits()
        {
            InitializeComponent();
        }
    }
}