using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using DispatcherService.Classes;
using System.Data.Common;

namespace DispatcherService
{
    public partial class PlanAppointControl : UserControl
    {
        private EPVDatabase Database;

        public PlanAppoint PlanAppoint
        {
            get { return (PlanAppoint)bsItem.DataSource; }
            set { bsItem.DataSource = value; }
        }

        private PlanAppointControl()
        {
            InitializeComponent();

            rboxLicensePlate.ButtonImage = DispatcherService.Resources.Image.Find;
            pickComingTime.Value = DateTime.Now;
        }

        private List<VehicleMark> MarkList
        {
            get { return (List<VehicleMark>)rboxVehicleMark.DataSource; }
            set { rboxVehicleMark.DataSource = value; }
        }

        public PlanAppointControl(EPVDatabase database, PlanAppoint planAppoint)
            : this()
        {
            Database = database;

            PreloadData();
            planAppoint.PropertyChanged += planAppointPropertyChanged;
            PlanAppoint = planAppoint;
            AddBindings();
        }

        private void AddBindings()
        {
            rboxCargo.DataBindings.Add("SelectedItem", bsItem, "Cargo", true, DataSourceUpdateMode.OnPropertyChanged);

            if (!PlanAppoint.Vehicle.Equals(Vehicle.Empty))
            {
                Vehicle vehicle = PlanAppoint.Vehicle.LoadCopy(Database);
                rboxVehicleMark.SelectedItem = vehicle.VehicleMark;
            }

            rboxLicensePlate.DataBindings.Add("SelectedItem", bsItem, "Vehicle", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxDriverName.DataBindings.Add("Text", bsItem, "DriverName", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxContact.DataBindings.Add("Text", bsItem, "Contact", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxWhereTo.DataBindings.Add("Text", bsItem, "WhereTo", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxComment.DataBindings.Add("Text", bsItem, "Comment", true, DataSourceUpdateMode.OnPropertyChanged);
            pickDateFrom.DataBindings.Add("Value", bsItem, "DateFrom", true, DataSourceUpdateMode.OnPropertyChanged);
            pickDateTo.DataBindings.Add("Value", bsItem, "DateTo", true, DataSourceUpdateMode.OnPropertyChanged);

            btnPrintPermit.DataBindings.Add("Enabled", bsItem, "HasPermit");
            btnClearPermit.DataBindings.Add("Enabled", bsItem, "HasPermit");

            if (PlanAppoint.HasPermit)
                LoadPermit(PlanAppoint.PermitId);
            else
                tboxPermit.Text = "не оформлен";
        }

        private void LoadPermit(int permitId)
        {
            Permit permit = Permit.Load(Database, permitId);
            tboxPermit.Text = permit.ToString();
        }

        private void PreloadData()
        {
            rboxCargo.DataSource = new Cargos(Database);
            MarkList = VehicleMark.LoadList(Database);
            rboxLicensePlate.DataSource = Vehicle.LoadList(Database, VehicleMark.Empty, "");

            rboxCargo.NullValue = Cargo.Empty;
            rboxVehicleMark.NullValue = VehicleMark.Empty;
            rboxLicensePlate.NullValue = Vehicle.Empty;

            cboxCountry.DataSource = new States(Database);
            cboxUnit.DataSource = new Units(Database);
        }

        private void rboxCargo_CallReference(object sender, EventArgs e)
        {
            CargoListForm form = CargoListForm.OpenReference(FindForm().MdiParent, Database);
            form.ItemSelected += ((ReferenceBox)sender).SetItem;
            form.Show();
        }

        private void rboxVehicleMark_SelectedItemChanged(object sender, EventArgs e)
        {
            VehicleMark mark = rboxVehicleMark.SelectedItem as VehicleMark;

            if (mark != null)
                rboxLicensePlate.DataSource = Vehicle.LoadList(Database, mark, "");
        }

        private void rboxLicensePlate_ItemNotFound(object sender, ItemEventArgs e)
        {
            FindVehicle((string)e.Item);
        }
        

        void FindVehicle(string licensePlate)
        {
            List<Vehicle> vehicleList = Vehicle.LoadList(Database, (VehicleMark)rboxVehicleMark.SelectedItem,
                                                            licensePlate);
            if (vehicleList.Count == 1)
            {
                PlanAppoint.Vehicle = vehicleList[0];
                return;
            }

            if (vehicleList.Count > 1)
            {
                SelectItemForm form = new SelectItemForm(vehicleList);
                if (form.ShowDialog() == DialogResult.OK)
                    PlanAppoint.Vehicle = (Vehicle)form.SelectedItem;
                return;
            }

            if (MessageBox.Show(DispatcherService.Resources.Error.VehicleNotFound, FindForm().Text,
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.VehicleMark = (VehicleMark)rboxVehicleMark.SelectedItem;
                vehicle.LicensePlate = licensePlate;

                VehicleItemForm form = new VehicleItemForm(FindForm().MdiParent, Database, vehicle);
                form.ItemSaved += new EventHandler<ItemEventArgs>(vehicleItemSaved);
                form.Show();
            }

        }
        
        void vehicleItemSaved(object sender, ItemEventArgs e)
        {
            PlanAppoint.Vehicle = (Vehicle)e.Item;
            tboxDriverName.Select(0, tboxDriverName.Text.Length);
        }

        private void rboxLicensePlate_CallReference(object sender, EventArgs e)
        {
            FindVehicle(rboxLicensePlate.Text);
        }

        private void planAppointPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Equals(e.PropertyName, "Vehicle", StringComparison.CurrentCultureIgnoreCase)
                && PlanAppoint.IsNew)
            {
                rboxVehicleMark.SelectedItem = PlanAppoint.Vehicle.VehicleMark;
                FillLastAppointData();
            }

        }

        private void FillLastAppointData()
        {
            PlanAppoint lastPlanAppoint = PlanAppoint.Vehicle.GetLastPlanAppoint(Database);

            if (lastPlanAppoint != null)
            {
                PlanAppoint.Cargo = lastPlanAppoint.Cargo;
                rboxCargo.Refresh();
                PlanAppoint.DriverName = lastPlanAppoint.DriverName;
                PlanAppoint.Contact = lastPlanAppoint.Contact;
                PlanAppoint.WhereTo = lastPlanAppoint.WhereTo;

                string query = DispatcherService.Resources.Doc.PlanAppoint.GetTrailer;
                QueryParameters parameters = new QueryParameters("id", lastPlanAppoint.Id);

                using (DbDataReader reader = Database.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        if (!DBNull.Value.Equals(reader["trailer"]))
                            tboxTrailer.Text = (string)reader["trailer"];

                        if (!DBNull.Value.Equals(reader["state"]))
                            cboxCountry.SelectedItem = ((States)cboxCountry.DataSource).Find((int)reader["state"]);

                        if (!DBNull.Value.Equals(reader["idUnit"]))
                            cboxUnit.SelectedItem = ((Units)cboxUnit.DataSource).Find((int)reader["idUnit"]);

                    }

                    reader.Close();
                }
            }
        }

        public EventHandler BtnNextClick { get { return btnNextClick; } }

        private void btnNextClick(object sender, EventArgs e)
        {
            if (SavePlanAppoint())
                CreateAppoint();
        }

        private bool SavePlanAppoint()
        {
            try
            {
                if (CheckRequiredProperties())
                {
                    PlanAppoint.Save(Database, ((FormStart)FindForm().MdiParent).User);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка сохранения объекта: " + exc.Message, "Ошибка сохранения");
                return false;
            }
        }

        private bool CheckRequiredProperties()
        {
            bool result = true;
            if (PlanAppoint.Vehicle == null || PlanAppoint.Vehicle.Equals(Vehicle.Empty))
            {
                result = false;
                errorProvider.SetError(rboxLicensePlate, "Не выбран автомобиль");
            }

            if (PlanAppoint.Cargo == null)
            {
                result = false;
                errorProvider.SetError(rboxCargo, "Не выбран груз");
            }

            if (string.IsNullOrEmpty(PlanAppoint.DriverName))
            {
                result = false;
                errorProvider.SetError(tboxDriverName, "Не указан водитель");
            }

            return result;
        }

        private void CreateAppoint()
        {
            Appoint appoint = new Appoint(PlanAppoint);

            appoint.Citizen = (State)cboxCountry.SelectedItem;
            appoint.SetComingDate(pickComingTime.Value);
            appoint.Unit = (Unit)cboxUnit.SelectedItem;
            appoint.Warrant = tboxWarrant.Text;
            appoint.Trailer = tboxTrailer.Text;

            appoint.Save(Database);

            string query = DispatcherService.Resources.Doc.PlanAppoint.LinkToAppoint;
            QueryParameters parameters = new QueryParameters("plan", PlanAppoint.Id);
            parameters.Add("id", appoint.Id);
            Database.ExecuteQuery(query, parameters);


            FindForm().Close();
        }

        private void rboxCargo_SelectedItemChanged(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, "");
        }
    }
}
