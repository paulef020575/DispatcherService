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
    public partial class CargoListForm : Form
    {
        private EPVDatabase Database;

        private bool IsReferenceForm
        {
            get { return btnOK.Visible; }
        }

        public Cargo SelectedItem
        {
            get { return (Cargo)bsList.Current; }
            set { bsList.Position = bsList.IndexOf(value); }
        }

        private CargoListForm()
        {
            InitializeComponent();
        }

        public CargoListForm(Form mdiParent, EPVDatabase database)
            : this()
        {
            MdiParent = mdiParent;
            Database = database;

            bsList.DataSource = GetData();
        }

        private object GetData()
        {
            return new Cargos(Database);
        }

        public static CargoListForm OpenReference(Form mdiParent, EPVDatabase database)
        {
            CargoListForm form = new CargoListForm(mdiParent, database);

            form.btnOK.Visible = true;
            return form;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region ItemSelected event

        private EventHandler<ItemEventArgs> onItemSelected;

        public event EventHandler<ItemEventArgs> ItemSelected
        {
            add { onItemSelected += value; }
            remove { onItemSelected -= value; }
        }

        private void OnItemSelected()
        {
            if (onItemSelected != null)
                onItemSelected(this, new ItemEventArgs(SelectedItem));
        }

        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            OnItemSelected();
            Close();
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsReferenceForm)
            {
                OnItemSelected();
                Close();
            }
            else
                EditCurrentItem();
        }

        private void EditCurrentItem()
        {
            throw new NotImplementedException("EditCurrentItem method");
        }
    }
}
