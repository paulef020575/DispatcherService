using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using EPV.Data;

namespace DispatcherService
{
    public partial class UserControlPoint : UserControl
    {
        private EPVDatabase database;
        public EPVDatabase Database
        {
            set { database = value; }
        }

        private Point point;
        public Point Point
        {
            get { return point; }
            set
            {
                point = value;
                labelName.Text = point.ToString();
                DataGridViewRow row = dataGridViewAppoints.RowTemplate;
                Height = panelHeader.Height + row.Height * (point.Capacity + 2);
            }
        }

        public SecurityUser User
        {
            get
            {
                Form form = FindForm();
                return (SecurityUser)((FormStart)Application.OpenForms["FormStart"]).User; 
            }
        }

        public UserControlPoint()
        {
            InitializeComponent();
            dataGridViewAppoints.AutoGenerateColumns = false;
        }

        private void dataGridViewAppoints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Appoint appoint = ((Appoints)dataGridViewAppoints.DataSource)[e.RowIndex];

            if (e.ColumnIndex == 2 
                && MessageBox.Show(DispatcherService.Resources.Message.EndPoint, 
                                    dataGridViewAppoints[0, e.RowIndex].Value.ToString(),
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                appoint.EndPoint(database, User);
                RefreshData();                   
            }

            if (e.ColumnIndex == 3)
            {
                MoveTrackToOtherPoint(appoint);
            }
        }

        private void MoveTrackToOtherPoint(Appoint appoint)
        {
            FormRepointAppoint form = new FormRepointAppoint(database, appoint, Point);
            if (form.ShowDialog(FindForm().MdiParent) == DialogResult.OK)
            {
                FormAccepting parentForm = (FormAccepting)this.FindForm();
                parentForm.RefreshData();
            }
        }

        public void RefreshData()
        {
                Appoints appoints = new Appoints(database, DocStateGroups.OnPoint, point);
                labelState.Text = appoints.Count.ToString() + " / " + point.Capacity.ToString();
                dataGridViewAppoints.DataSource = appoints;
        }


        internal void SetReadOnly()
        {
            columnStop.Visible = false;
        }
    }
}
