using DispatcherService.Classes;
using EPV.Data;
using EPV.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DispatcherService
{
    public partial class FormRepointAppoint : Form
    {
        private EPVDatabase database;
        public Appoint Appoint { get; private set; }

        private string currentComment;
        private Point fromPoint;

        public SecurityUser User
        {
            get { return (SecurityUser)((FormStart)Application.OpenForms["FormStart"]).User; }
        }


        private FormRepointAppoint()
        {
            InitializeComponent();
        }

        public FormRepointAppoint(EPVDatabase _database, Appoint appoint, Point _fromPoint)
            : this()
        {
            database = _database;
            Appoint = appoint;
            fromPoint = _fromPoint;

            Text = Appoint.TrackInfo;
        }

        private void FormRepointAppoint_Load(object sender, EventArgs e)
        {
            Permit permit = Appoint.GetPermit(database);
            if (permit == null)
            {
                MessageBox.Show(DispatcherService.Resources.Error.PermitNotFound);
                Close();
            }

            currentComment = permit.GetComment(database);
            tboxComment.Text = currentComment;

            Points points = new DispatcherService.Points(database, Appoint.Unit);
            cboxPoint.DataSource = points;

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (CheckPoint(cboxPoint.SelectedItem)
                && CheckComment(tboxComment.Text))
            {
                UpdatePermitComment(tboxComment.Text);
                Appoint.SetToPoint(database, Appoint.Unit, (Point)cboxPoint.SelectedItem, DateTime.Now, User);
                DialogResult = DialogResult.OK;
            }

        }

        private bool CheckComment(string text)
        {
            if (text.Length > 0
                || MessageBox.Show("При пустом комментарии машину может не пройти через пункт пропуска. Оставить незаполненным?",
                                    "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                return true;

            return false;
        }

        private bool CheckPoint(object selectedItem)
        {
            if (selectedItem == null || !(selectedItem is Point))
            {
                MessageBox.Show("Не указано новое место погрузки/разгрузки");
                return false;
            }

            return true;
        }

        private void UpdatePermitComment(string text)
        {
            Permit permit = Appoint.GetPermit(database);
            permit.UpdateComment(database, text);
        }

        private void cboxPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPoint.SelectedItem != null)
            {
                Point point = cboxPoint.SelectedItem as Point;

                if (point != null)
                {
                    tboxComment.Text = currentComment + Environment.NewLine;
                    tboxComment.Text += "ДОЗАГРУЗ: переезд с пункта " + fromPoint.Name;
                    tboxComment.Text += " в пункт " + point.Name;
                }
            }
        }
    }
}
