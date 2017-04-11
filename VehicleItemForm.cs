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
    public partial class VehicleItemForm : Form
    {
        private EPVDatabase Database;

        public Vehicle Vehicle
        {
            get { return (Vehicle)bsItem.DataSource; }
            set { bsItem.DataSource = value; }
        }

        private VehicleItemForm()
        {
            InitializeComponent();
        }

        public VehicleItemForm(Form mdiParent, EPVDatabase database, Vehicle vehicle)
            : this()
        {
            MdiParent = mdiParent;
            Database = database;

            AddBindings();

            Vehicle = vehicle;
        }

        private void AddBindings()
        {
            tboxVehicleMark.DataBindings.Add("Text", bsItem, "VehicleMark", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxLicensePlate.DataBindings.Add("Text", bsItem, "LicensePlate", true, DataSourceUpdateMode.OnPropertyChanged);

            btnOK.DataBindings.Add("Enabled", bsItem, "IsModified", true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private EventHandler<ItemEventArgs> onItemSaved;
        public event EventHandler<ItemEventArgs> ItemSaved
        {
            add { onItemSaved += value; }
            remove { onItemSaved -= value; }
        }
        private void OnItemSaved()
        {
            if (onItemSaved != null)
                onItemSaved(this, new ItemEventArgs(Vehicle));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Vehicle.Save((FirebirdDatabase)Database);
            OnItemSaved();
            Close();
        }
    }
}
