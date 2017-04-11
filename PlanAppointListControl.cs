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

namespace DispatcherService
{
    public partial class PlanAppointListControl : UserControl
    {
        private EPVDatabase Database;

        private PlanAppointListControl()
        {
            InitializeComponent();

            pboxFind.Image = DispatcherService.Resources.Image.Find;
            pboxFindNext.Image = DispatcherService.Resources.Image.FindNext;
        }

        public PlanAppointListControl(EPVDatabase database)
            : this()
        {
            Database = database;

            GetPlanAppointList();
        }

        private void GetPlanAppointList()
        {
            bsList.DataSource = PlanAppoint.LoadList(Database, DateTime.Today.AddDays(-7));
        }

        private void tboxFind_TextChanged(object sender, EventArgs e)
        {
            if (tboxFind.Text.Length > 0
                && FindTextInGrid(tboxFind.Text, -1, 0))
            {
                tboxFind.ForeColor = SystemColors.WindowText;
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                tboxFind.ForeColor = Color.Red;
            }
        }

        private bool FindTextInGrid(string text, int startColumnIndex, int startRowIndex)
        {
            int startColumn = startColumnIndex + 1;

            for (int i = startRowIndex; i < dgvList.Rows.Count; i++)
            {
                for (int j = startColumn; j < dgvList.Columns.Count; j++)
                {
                    if (dgvList[j, i].Value != null)
                    {
                        string cellValue = dgvList[j, i].Value.ToString().ToUpper();
                        if (cellValue.Contains(text.ToUpper()))
                        {
                            dgvList.CurrentCell = dgvList[j, i];
                            return true;
                        }
                    }
                }

                startColumn = 0;
            }

            for (int i = 0; i <= startRowIndex; i++)
            {
                for (int j = 0; j < dgvList.Columns.Count; j++)
                {
                    if (dgvList[j, i].Value != null)
                    {
                        string cellValue = dgvList[j, i].Value.ToString().ToUpper();
                        if (cellValue.Contains(text.ToUpper()))
                        {
                            dgvList.CurrentCell = dgvList[j, i];
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private void dgvList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex < bsList.Count)
            {
                if (dgvList.CurrentCell != null
                    && dgvList.CurrentCell.ColumnIndex == e.ColumnIndex)
                {
                    e.CellStyle.SelectionBackColor = dgvList.DefaultCellStyle.BackColor;
                    e.CellStyle.SelectionForeColor = dgvList.DefaultCellStyle.ForeColor;
                }

                e.PaintBackground(e.ClipBounds, true);
                                
                if (dgvList.CurrentCell != null
                    && dgvList.CurrentCell.ColumnIndex == e.ColumnIndex
                    && (e.State & DataGridViewElementStates.Selected) > 0)
                    e.Graphics.DrawRectangle(Pens.Gray, new Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1,
                                                                        e.CellBounds.Width - 4, e.CellBounds.Height - 4));

                e.PaintContent(e.CellBounds);

                e.Handled = true;
            }

        }

        private void pboxFindNext_Click(object sender, EventArgs e)
        {
            if (tboxFind.Text.Length > 0
                && FindTextInGrid(tboxFind.Text, dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex))
            {
                tboxFind.ForeColor = SystemColors.WindowText;
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                tboxFind.ForeColor = Color.Red;
            }

        }
    }
}
