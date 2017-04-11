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
    public partial class FormCargos : EPVFormChild
    {
        public EPVDatabase Database
        {
            set
            {
                epvGridCargos.Database = value;
                epvGridCargos.DataSource = new Cargos(value);
            }
        }

        public FormCargos()
        {
            InitializeComponent();
        }
    }
}