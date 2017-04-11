using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DispatcherService
{
    public partial class SelectItemForm : Form
    {
        private SelectItemForm()
        {
            InitializeComponent();
        }

        public SelectItemForm(IList list)
            : this()
        {
            lboxItems.DataSource = list;
        }

        public object SelectedItem
        {
            get { return lboxItems.SelectedItem; }
            set { lboxItems.SelectedItem = value; }
        }

        private EventHandler<ItemEventArgs> onItemSelected;

        public event EventHandler<ItemEventArgs> ItemSelected
        {
            add { onItemSelected += value; }
            remove { onItemSelected -= value; }
        }

        private void OnItemSelected()
        {
            if (onItemSelected != null)
                onItemSelected(this, new ItemEventArgs(lboxItems.SelectedItem));

            DialogResult = DialogResult.OK;
        }

        private void lboxItems_DoubleClick(object sender, EventArgs e)
        {
            OnItemSelected();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OnItemSelected();
        }


    }
}
