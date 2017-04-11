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
    public partial class FormStates : EPVFormChild
    {
        public EPVDatabase Database
        {
            set
            {
                if (value != null)
                {
                    epvGridStates.Database = value;
                    epvGridStates.DataSource = new States(value);
                }
            }
        }

        public FormStates()
        {
            InitializeComponent();
        }
    }
}