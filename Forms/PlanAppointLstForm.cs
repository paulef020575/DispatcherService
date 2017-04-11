using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPV.Database;
using DispatcherService.Classes.PlanAppoints;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Components;
using Stimulsoft.Base.Drawing;

namespace DispatcherService.Forms
{
    public partial class PlanAppointLstForm : Form
    {
        #region Fields & Properties

        private EPVDatabase database;

        #endregion

        #region Constructors

        public PlanAppointLstForm(Form parent, EPVDatabase dbase)
        {
            InitializeComponent();
            MdiParent = parent;
            database = dbase;
        }

        #endregion

        #region Event handlers

        private void PlanAppointLstForm_Load(object sender, EventArgs e)
        {
            pickPlan.Value = DateTime.Today.AddDays(1);
        }

        private void pickPlan_ValueChanged(object sender, EventArgs e)
        {
            RefreshList(sender, e);
        }

        private void RefreshList(object sender, EventArgs e)
        {
            try
            {
                BindingList<PlanAppoint> list = PlanAppoint.LoadList(database, pickPlan.Value);
                bsList.DataSource = list;

                if (sender is PlanAppoint)
                    bsList.Position = list.IndexOf((PlanAppoint)sender);
            }
            catch (Exception exc)
            { 
                MessageBox.Show(exc.Message); 
            }
        }

        private void addPlanTool_Click(object sender, EventArgs e)
        {
            AddNewPlan();
        }

        private void editPlanTool_Click(object sender, EventArgs e)
        {
            EditCurrentPlan();
        }

        private void deletePlanTool_Click(object sender, EventArgs e)
        {
            DeleteCurrentPlan();
        }

        private void refreshListTool_Click(object sender, EventArgs e)
        {
            RefreshList(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reportTool_Click(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void dgvList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    AddNewPlan();
                    e.Handled = true;
                    break;

                case Keys.Return:
                    EditCurrentPlan();
                    e.Handled = true;
                    break;

                case Keys.Delete:
                    DeleteCurrentPlan();
                    e.Handled = true;
                    break;
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditCurrentPlan();
        }

        #endregion

        #region Methods


        private void AddNewPlan()
        {
            PlanAppointForm form = new PlanAppointForm(MdiParent, database);
            form.DataSaved += RefreshList;
            form.Show();

        }

        private void EditCurrentPlan()
        {
            if (bsList.Current != null
                && ((PlanAppoint)bsList.Current).DateAppoint.Equals(DateTime.MaxValue))
            {
                PlanAppointForm form = new PlanAppointForm(MdiParent, database);
                form.PlanAppoint = (PlanAppoint)bsList.Current;
                form.DataSaved += RefreshList;
                form.Show();
            }
        }

        private void DeleteCurrentPlan()
        {
            if (bsList.Current != null
                 && ((PlanAppoint)bsList.Current).DateAppoint.Equals(DateTime.MaxValue)
                && MessageBox.Show("Удалить текущий план?", "Внимание", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                PlanAppoint plan = (PlanAppoint)bsList.Current;
                bsList.Remove(plan);
                plan.Delete();
                plan.Save(database);
            }
        }

        private void ShowReport()
        {
            StiReport report = new StiReport();

            float columnsWidth = 0;

            DataTable table = new DataTable("ReportData");
            for (int i = 0; i < dgvList.Columns.Count; i++)
            {
                table.Columns.Add(dgvList.Columns[i].Name, dgvList.Columns[i].ValueType);
                columnsWidth += dgvList.Columns[i].Width;
            }

            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                DataRow row = table.NewRow();
                for (int j = 0; j < dgvList.Columns.Count; j++)
                    row[dgvList.Columns[j].Name] = dgvList[j, i].Value;
                table.Rows.Add(row);
            }

            report.RegData(table);
            report.Dictionary.Synchronize();

            StiPage page = report.Pages[0];

            StiReportTitleBand titleBand = new StiReportTitleBand();
            titleBand.Height = 1.0;
            titleBand.Name = "TitleBand";
            page.Components.Add(titleBand);

            StiText titleText = new StiText(new RectangleD(0, 0, page.Width, 1));
            titleText.Name = "TitleText";
            titleText.Text = Text + " " + pickPlan.Value.ToShortDateString();
            titleText.Width = page.Width;
            titleText.HorAlignment = StiTextHorAlignment.Center;
            titleText.Font = new Font("Arial", 10);
            titleBand.Components.Add(titleText);

            //Create HeaderBand
            StiHeaderBand headerBand = new StiHeaderBand();
            headerBand.Height = 0.5;
            headerBand.Name = "HeaderBand";
            page.Components.Add(headerBand);

            
            float bandWidth = (float)page.Width;
            float multiplier = bandWidth / columnsWidth;
            float previousWidth = 0;

            //Create text on header
            for (int i = 0; i < dgvList.Columns.Count; i++)
            {
                StiText headerText = new StiText(new RectangleD(previousWidth, 0, dgvList.Columns[i].Width * multiplier, 0.5));
                headerText.Text = dgvList.Columns[i].HeaderText;
                headerText.HorAlignment = StiTextHorAlignment.Center;
                headerText.Name = "HeaderText" + i.ToString();
                headerText.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid);
                headerText.Brush = new StiSolidBrush(Color.LightGreen);
                headerBand.Components.Add(headerText);

                previousWidth += dgvList.Columns[i].Width * multiplier;
            }

            

            //Create Databand
            StiDataBand dataBand = new StiDataBand();
            dataBand.DataSourceName = "ReportData";
            dataBand.Height = 0.5;
            dataBand.Name = "DataBand";
            page.Components.Add(dataBand);

            previousWidth = 0;

            //Create text
            for (int i = 0; i < dgvList.Columns.Count; i++)
            {
                RectangleD rectangle = new RectangleD(previousWidth, 0, dgvList.Columns[i].Width * multiplier, 1); 
                StiText dataText = new StiText(rectangle);
                dataText.Format = dgvList.Columns[i].DefaultCellStyle.Format;
                dataText.Text = "{ReportData." + dgvList.Columns[i].Name + "}";
                dataText.Name = "DataText" + i.ToString();

                dataText.Border = new StiBorder(StiBorderSides.All, Color.Black, 1, StiPenStyle.Solid);

                dataBand.Components.Add(dataText);
                previousWidth += dgvList.Columns[i].Width * multiplier;
            }
            
            //Create FooterBand
            StiFooterBand footerBand = new StiFooterBand();
            footerBand.Height = 0.5;
            footerBand.Name = "FooterBand";
            page.Components.Add(footerBand);

            //Create text on footer
            StiText footerText = new StiText(new RectangleD(0, 0, 5, 0.5));
            footerText.Text = "Всего - {Count()} строк";
            footerText.HorAlignment = StiTextHorAlignment.Right;
            footerText.Name = "FooterText";
            footerText.Brush = new StiSolidBrush(Color.LightGreen);
            footerBand.Components.Add(footerText);

            report.Save("D:\\report.mrt");
            report.Show();
                

        }


        #endregion

        private void dgvList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.PaintBackground(e.CellBounds, ((e.State & DataGridViewElementStates.Selected) > 0));
            if (e.Value is DateTime
                && DateTime.MaxValue.Equals((DateTime)e.Value))
                e.Handled = true;
            else
                e.PaintContent(e.CellBounds);
        }

        private void dgvList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PlanAppoint planAppoint = (PlanAppoint)bsList[e.RowIndex];
                if (!planAppoint.DateAppoint.Equals(DateTime.MaxValue))
                {
                    dgvList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = SystemColors.GrayText;
                    dgvList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = SystemColors.GrayText;
                }

                if (planAppoint.IsClosed)
                {
                    dgvList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    dgvList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightSalmon;
                }
            }

        }


    }
}
