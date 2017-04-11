using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using DispatcherService.Classes;

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

            control.ItemSelected += planAppointSelected;
            btnNext.Click += control.BtnNextPressed;

            panelMaster.Controls.Add(control);
        }

        void planAppointSelected(object sender, ItemEventArgs e)
        {
            Text = ((PlanAppoint)e.Item).ToString();

            PlanAppointListControl control = (PlanAppointListControl)sender;

            control.ItemSelected -= planAppointSelected;
            btnNext.Click -= control.BtnNextPressed;

            panelMaster.Controls.Clear();

            PlanAppointControl control1 = new PlanAppointControl(Database, (PlanAppoint)e.Item);
            control1.Dock = DockStyle.Fill;
            btnNext.Click += control1.BtnNextClick;
            panelMaster.Controls.Add(control1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
