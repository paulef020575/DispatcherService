using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPV.Database;

namespace DispatcherService
{
    public partial class CreateAppointForm : Form
    {
        private FirebirdDatabase Database;
        
        private CreateAppointForm()
        {
            InitializeComponent();
        }

        public CreateAppointForm(Form mdiParent, FirebirdDatabase database)
            : this()
        {
            MdiParent = mdiParent;
            Database = database;

            ShowStepOne();
        }

        private void ShowStepOne()
        {
            panelMaster.Controls.Clear();

            PlanAppointListControl control = new PlanAppointListControl(Database);
            control.Dock = DockStyle.Fill;
            panelMaster.Controls.Add(control);
        }
    }
}
