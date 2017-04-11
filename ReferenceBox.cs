using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using EPV.Data;

namespace DispatcherService
{
    public partial class ReferenceBox : UserControl, INotifyPropertyChanged
    {
        public ReferenceBox()
        {
            InitializeComponent();

        //    if (!DesignMode)
        //        tboxItem.DataBindings.Add("Text", this, "SelectedItem", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private IList itemList;
        public IList DataSource
        {
            get { return itemList; }
            set
            {
                itemList = value;
                if (DataSource != null)
                    FillAutoCompleteSource();
            }
        }

        private object selectedItem;
        public object SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if (selectedItem == null || !selectedItem.Equals(value))
                {
                    selectedItem = value;
                    OnPropertyChanged("SelectedItem");
                    OnSelectedItemChanged();
                }
            }
        }

        public object NullValue { get; set; }

        public new string Text
        {
            get { return tboxItem.Text; }
            set { tboxItem.Text = value; }
        }

        public Image ButtonImage
        {
            get { return btnShowReference.BackgroundImage; }
            set
            {
                if (value != null)
                {
                    btnShowReference.Text = "";
                    btnShowReference.BackgroundImage = value;
                }
            }
        }

        public string DisplayMember { get; set; }

        private void FillAutoCompleteSource()
        {
            AutoCompleteStringCollection stringList = new AutoCompleteStringCollection();
            foreach (object item in itemList)
                    stringList.Add(GetItemString(item));
            tboxItem.AutoCompleteCustomSource = stringList;
        }


        #region PropertyChanged event

        private PropertyChangedEventHandler onPropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { onPropertyChanged += value; }
            remove { onPropertyChanged -= value; }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (onPropertyChanged != null)
                onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region CallReference event

        private EventHandler onCallReference;

        public event EventHandler CallReference
        {
            add { onCallReference += value; }
            remove { onCallReference -= value; }
        }

        public void OnCallReference()
        {
            if (SelectedItem != null)
                tboxItem.Text = GetItemString(SelectedItem);
            if (onCallReference != null)
                onCallReference(this, EventArgs.Empty);
        }
        
        #endregion

        #region SelectedItemChanged event

        private EventHandler onSelectedItemChanged;

        public event EventHandler SelectedItemChanged
        {
            add { onSelectedItemChanged += value; }
            remove { onSelectedItemChanged -= value; }
        }

        private void OnSelectedItemChanged()
        {
            if (onSelectedItemChanged != null)
                onSelectedItemChanged(this, EventArgs.Empty);

            if (SelectedItem != null)
                tboxItem.Text = GetItemString(SelectedItem);
        }

        #endregion

        #region ItemNotFound event

        private EventHandler<ItemEventArgs> onItemNotFount;

        public event EventHandler<ItemEventArgs> ItemNotFound
        {
            add { onItemNotFount += value; }
            remove { onItemNotFount -= value; }
        }

        public void OnItemNotFound()
        {
            if (onItemNotFount != null)
            {
                string text = tboxItem.Text;
                tboxItem.Clear();
                onItemNotFount(this, new ItemEventArgs(text));
            }
            else
            {
                if (SelectedItem != null)
                    tboxItem.Text = GetItemString(SelectedItem);
                else
                    tboxItem.Clear();
            }
        }

        #endregion

        private void btnShowReference_Click(object sender, EventArgs e)
        {
            OnCallReference();
        }

        private void setItem(object sender, ItemEventArgs e)
        {
            SelectedItem = e.Item;
        }

        public EventHandler<ItemEventArgs> SetItem { get { return setItem; } }

        private void tboxItem_Validating(object sender, CancelEventArgs e)
        {
            if (tboxItem.Text == GetItemString(SelectedItem)) return; 

            if (string.IsNullOrEmpty(tboxItem.Text))
            {
                SelectedItem = NullValue;
                e.Cancel = false;
                return;
            }

            if (DataSource != null)
            {
                foreach (object item in DataSource)
                {
                    if (string.Equals(GetItemString(item), tboxItem.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        SelectedItem = item;
                        return;
                    }
                }
            }

            OnItemNotFound();
        }

        private string GetItemString(object item)
        {
            if (item == null) return "";

            if (DisplayMember == null || DisplayMember.Length == 0)
                return item.ToString();

            return item.GetType().GetProperty(DisplayMember).GetValue(item, null).ToString();
        }

        //protected override void OnValidating(CancelEventArgs e)
        //{
        //    base.OnValidating(e);
        //    foreach (Binding b in DataBindings)
        //        b.WriteValue();
        //}
    }
}
