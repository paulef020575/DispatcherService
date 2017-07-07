using EPV.Database;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Components.TextFormats;
using Stimulsoft.Report.Dictionary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DispatcherService
{
    public partial class FormHistory : Form
    {
        private EPVDatabase database;

        private bool isControlsFilled = false;
        private int pbarLoadHeight;

        private struct LoadParameters
        {
            public EPVDatabase Database { get; set; }
            public DateTime DateFrom { get; set; }
            public DateTime DateTo { get; set; }
            public string VehicleNum { get; set; }
            public int UnitId { get; set; }
            public string Cargo { get; set; }
            public bool Grouped { get; set; }
        }

        public DateTime DateFrom
        {
            get { return pickDateFrom.Value; }
            set { pickDateFrom.Value = value; }
        }

        public DateTime DateTo
        {
            get { return pickDateTo.Value; }
            set { pickDateTo.Value = value; }
        }

        public string LicensePlate
        {
            get { return tboxLicensePlate.Text; }
        }

        private Units UnitList
        {
            get { return (Units)cboxUnitList.DataSource; }
            set { cboxUnitList.DataSource = value; }
        }

        public Unit SelectedUnit
        {
            get { return (Unit)cboxUnitList.SelectedItem; }
            set { cboxUnitList.SelectedItem = value; }
        }

        public string Cargo
        {
            get { return tboxCargo.Text; }
        }

        public bool Group
        {
            get { return chkGroup.Checked; }
            set { chkGroup.Checked = value; }
        }

        private FormHistory()
        {
            InitializeComponent();

            pbarLoadHeight = pbarLoad.Height;
        }

        public FormHistory(Form mdiParent, EPVDatabase dbase)
            : this()
        {
            MdiParent = mdiParent;
            database = dbase;

            FillControls();
        }

        private void ReadDgvColumns()
        {
            if (File.Exists(PropertiesFile))
            {
                FormHistoryProperties.Load(this);
            }
        }


        private void FillControls()
        {
            btnMore.Image = Resources.Image.DocumentView;

            DateFrom = DateTime.Now.AddDays(-1);
            DateTo = DateTime.Now;

            Units units = new Units(database);
            Unit emptyUnit = new Unit(0, "ВСЕ");
            units.Insert(0, emptyUnit);
            UnitList = units;
            SelectedUnit = emptyUnit;

            ReadDgvColumns();
            isControlsFilled = true;

            RefreshData();
        }

        private BindingList<IAppointHistory> LoadData(EPVDatabase dbase, bool grouped,
            DateTime dateFrom, DateTime dateTo, string vehicleNum, int unitId, string cargo)
        {
            if (grouped)
                return AppointHistory.LoadList(dbase, 0, dateFrom, dateTo, vehicleNum, unitId, cargo);
            else
                return AppointStateHistory.LoadList(dbase, 0, dateFrom, dateTo, vehicleNum, unitId, cargo);
        }

        private void RefreshData()
        {
            if (isControlsFilled && !bgWorker.IsBusy)
            {
                LoadParameters parameters = new LoadParameters()
                {
                    Database = database,
                    DateFrom = this.DateFrom,
                    DateTo = this.DateTo,
                    VehicleNum = this.LicensePlate,
                    UnitId = this.SelectedUnit.Id,
                    Cargo = this.Cargo,
                    Grouped = this.Group
                };

                pbarLoad.Height = pbarLoadHeight;
                timerLoad.Start();
                bgWorker.RunWorkerAsync(parameters);
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadParameters parameters = (LoadParameters)e.Argument;

            e.Result = LoadData(parameters.Database, parameters.Grouped, parameters.DateFrom, parameters.DateTo,
                                parameters.VehicleNum, parameters.UnitId, parameters.Cargo);
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (++pbarLoad.Value == 100)
                pbarLoad.Value = 0;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timerLoad.Stop();
            pbarLoad.Height = 0;

            bSource.DataSource = e.Result;
        }

        private void pickDateFrom_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            IAppointHistory item = (IAppointHistory)bSource[e.RowIndex];

            if (item is AppointHistory)
            {
                dgvData.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgvData.Font, FontStyle.Bold);
            }
        }

        private void FormHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveDgvColumns();
        }

        private void SaveDgvColumns()
        {
            FormHistoryProperties.Save(this);
        }

        public string PropertiesFile
        {
            get
            {
                string fileName = this.Name + ".properties";
                return Path.Combine(FormStart.ApplicationFolder, fileName);
            }
        }

        public class ColumnProperties
        {
            public string ColumnName { get; set; }
            public int DisplayIndex { get; set; }
            public int Width { get; set; }

            public ColumnProperties() { }

            public ColumnProperties(DataGridViewColumn column)
            {
                ColumnName = column.Name;
                DisplayIndex = column.DisplayIndex;
                Width = column.Width;
            }

            public static List<ColumnProperties> GetList(DataGridView dgv)
            {
                List<ColumnProperties> list = new List<ColumnProperties>();
                foreach (DataGridViewColumn column in dgv.Columns)
                    list.Add(new ColumnProperties(column));

                return list;
            }

            public void ApplyColumn(DataGridView dgv)
            {
                DataGridViewColumn column = dgv.Columns[ColumnName];
                if (column != null)
                {
                    column.DisplayIndex = DisplayIndex;
                    column.Width = Width;
                }
            }
        }

        public class FormHistoryProperties
        {
            public bool IsGrouped { get; set; }

            public List<ColumnProperties> DgvColumns { get; set; }

            public FormHistoryProperties() { }

            public FormHistoryProperties(FormHistory form)
            {
                this.IsGrouped = form.Group;
                DgvColumns = ColumnProperties.GetList(form.dgvData);
            }

            public static void Save(FormHistory form)
            {
                FormHistoryProperties properties = new FormHistoryProperties(form);

                XmlSerializer serializer = new XmlSerializer(properties.GetType());

                using (FileStream fs = new FileStream(form.PropertiesFile, FileMode.Create))
                {
                    serializer.Serialize(fs, properties);
                }
            }

            public static void Load(FormHistory form)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(FormHistoryProperties));

                using (FileStream fs = new FileStream(form.PropertiesFile, FileMode.Open))
                {
                    FormHistoryProperties properties = (FormHistoryProperties)serializer.Deserialize(fs);

                    properties.Apply(form);
                }

            }

            private void Apply(FormHistory form)
            {
                form.Group = this.IsGrouped;

                foreach (ColumnProperties properties in DgvColumns)
                    properties.ApplyColumn(form.dgvData);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnImage.Index)
            {
                AppointHistory item = bSource[e.RowIndex] as AppointHistory;
                if (item != null)
                {
                    if (item.Expanded)
                        item.Collapse(bSource);
                    else
                        item.Expand(bSource);
                }

                dgvData.Refresh();
            }
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == ColumnImage.Index && e.RowIndex > -1)
            {
                AppointHistory item = bSource[e.RowIndex] as AppointHistory;
                if (item != null)
                {
                    if (item.Expanded)
                    {
                        e.Value = Resources.Image.Expanded;
                        dgvData[e.ColumnIndex, e.RowIndex].Tag = "-";
                    }
                    else
                    {
                        e.Value = Resources.Image.Collapsed;
                        dgvData[e.ColumnIndex, e.RowIndex].Tag = "+";
                    }
                }
                else
                {
                    e.Value = Resources.Image.Item;
                    dgvData[e.ColumnIndex, e.RowIndex].Tag = ".";
                }
            }
        }
            


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintList();
        }


        private void PrintList()
        {
            DataTable dataTable = CreateDataTable(dgvData);
            FillDataTable(dataTable, dgvData);

            string title = Text;
            string subtitle = BuildSubtitle();

            CreateReport(dataTable, dgvData, title, subtitle);
        }

        private string BuildSubtitle()
        {
            string dateFormat = "dd.MM.yyyy HH:mm";

            StringBuilder text = new StringBuilder("Период: ");
            text.Append(DateFrom.ToString(dateFormat) + " - ");
            text.Append(DateTo.ToString(dateFormat));

            text.Append(", подразделение: ");
            text.Append(SelectedUnit.Name);

            if (LicensePlate.Trim().Length > 0)
            {
                text.Append(", номер т/с: ");
                text.Append(LicensePlate.Trim());
            }

            if (Cargo.Trim().Length > 0)
            {
                text.Append(", груз: ");
                text.Append(Cargo.Trim());
            }

            return text.ToString();
        }

        private void CreateReport(DataTable table, DataGridView dgv, string title, string subtitle)
        {
            StiReport report = new StiReport();
            StiDataTableSource sourceTable = new StiDataTableSource("DS", "DS", "DS");
            report.Dictionary.DataSources.Add(sourceTable);
            report.RegData("DS", "DS", table);
            sourceTable.SynchronizeColumns();


            StiPage page = report.Pages.Items[0];
            page.Orientation = StiPageOrientation.Landscape;
            double pageW = page.Width;
            double pageH = page.Height;

            //============заголовок
            StiText headerReport = new StiText(new RectangleD(new PointD(0, 0), new SizeD(pageW, 0.6)),
                                             "Заголовок1");
            headerReport.Font = new Font("Arial", 10, FontStyle.Bold);
            headerReport.HorAlignment = StiTextHorAlignment.Center;
            headerReport.Text = "История обработок";

            StiText subtitleReport = new StiText(new RectangleD(new PointD(0, 0.6), new SizeD(pageW, 0.4)),
                                                 "Подзаголовок1");
            subtitleReport.Font = new Font("Arial", 10, FontStyle.Regular);
            subtitleReport.HorAlignment = StiTextHorAlignment.Center;
            subtitleReport.Text = subtitle;

            PointD BrandLoc = new PointD(0, 0.4);
            
            //хедер рапорта
            StiReportTitleBand headerPage = new StiReportTitleBand(new RectangleD(BrandLoc, new SizeD(pageW, 1.2)));
            page.Components.Add(headerPage);
            headerPage.Components.Add(headerReport);
            headerPage.Components.Add(subtitleReport);

            
            //хедер таблицы
            BrandLoc = new PointD(0, 1.2);
            StiHeaderBand headerTable = new StiHeaderBand(new RectangleD(BrandLoc, new SizeD(pageW, 0.6)));
            page.Components.Add(headerTable);

            //область данных
            PointD BrandDataLoc = new PointD(0, 1.8);
            StiDataBand BrandData = new StiDataBand(new RectangleD(BrandDataLoc, new SizeD(pageW, 0.4)));
            page.Components.Add(BrandData);
            BrandData.DataSourceName = "DS";

            StiPageFooterBand FooterBand = new StiPageFooterBand();
            page.Components.Add(FooterBand);
            FooterBand.Height = 0.6;

            StiText FooterNameTxt = new StiText(new RectangleD(0, 0, pageW, 0.6));
            FooterNameTxt.Text = title;
            FooterNameTxt.ShrinkFontToFit = true;
            FooterNameTxt.HorAlignment = StiTextHorAlignment.Right;
            FooterNameTxt.ShrinkFontToFitMinimumSize = 8;


            StiText FooterTxt = new StiText(new RectangleD(0, 0, 1, 0.6));
            FooterTxt.Text = "Лист {PageNumber}";
            FooterTxt.ShrinkFontToFit = true;
            FooterTxt.ShrinkFontToFitMinimumSize = 8;
            FooterBand.Components.Add(FooterNameTxt);
            FooterBand.Components.Add(FooterTxt);

            StiText TimeText = new StiText(new RectangleD(-0.2, -0.4, 3, 0.6));
            TimeText.Text = "{Time}";
            TimeText.ShrinkFontToFit = true;
            TimeText.ShrinkFontToFitMinimumSize = 8;
            page.Components.Add(TimeText);

            double numWidth = .5;

            double Wkoef = pageW / GetColumnWidth(table, dgv);
            double prevX = 0; //numWidth;
            //StiText headerNum = new StiText(new RectangleD(BrandLoc.X, 0, numWidth, 0.4));
            //headerNum.Border.Side = StiBorderSides.All;
            //headerNum.Border.Size = 1.5;
            //headerNum.Text = "N п/п";
            //headerNum.Font = new Font("Arial", 8, FontStyle.Bold);
            //headerNum.HorAlignment = StiTextHorAlignment.Center;
            //headerNum.ShrinkFontToFit = true;
            //headerNum.ShrinkFontToFitMinimumSize = 8;
            //headerTable.Components.Add(headerNum);

            //StiText dataNum = new StiText(new RectangleD(BrandLoc.X, 0, numWidth, 0.4));
            //dataNum.Border.Side = StiBorderSides.All;
            //dataNum.ShrinkFontToFit = true;
            //dataNum.ShrinkFontToFitMinimumSize = 8;
            //dataNum.Text = "{Line}";
            //dataNum.HorAlignment = StiTextHorAlignment.Right;
            //dataNum.Font = new Font("Arial", 8, FontStyle.Regular);
            //BrandData.Components.Add(dataNum);

            foreach (DataColumn column in table.Columns) //добалвляем в область заголовка и в область данных
            {
                string colName = column.ColumnName;
                DataGridViewColumn dgvColumn = dgv.Columns[colName];

                StiText headerTXT = new StiText(new RectangleD(BrandLoc.X + prevX, 0,
                                                dgvColumn.Width * Wkoef, 0.4));
                headerTXT.Border.Side = StiBorderSides.All;
                headerTXT.Border.Size = 1.5;
                headerTXT.Text = dgvColumn.HeaderText;
                headerTXT.Font = new Font("Arial", 8, FontStyle.Bold);
                headerTXT.HorAlignment = StiTextHorAlignment.Center;
                headerTXT.ShrinkFontToFit = true;
                headerTXT.ShrinkFontToFitMinimumSize = 8;

                headerTable.Components.Add(headerTXT);
                StiText dataTXT = new StiText(new RectangleD(BrandLoc.X + prevX, 0,
                                                             dgvColumn.Width * Wkoef, 0.4));
                dataTXT.Border.Side = StiBorderSides.All;
                dataTXT.ShrinkFontToFit = true;
                dataTXT.ShrinkFontToFitMinimumSize = 8;
                dataTXT.Font = new Font("Arial", 8, FontStyle.Regular);

                if (column.DataType == typeof(bool))
                    dataTXT.Text = "{IIF(DS." + colName + ", \"+\", \"\")}";
                else
                    dataTXT.Text = "{DS." + colName + "}";

                if (column.DataType == typeof(DateTime))
                {
                    string dateFormat = "dd.MM.yyyy HH:mm";
                    dataTXT.TextFormat = new StiDateFormatService(dateFormat, "");
                }

                if (column.DataType == typeof(double))
                    dataTXT.TextFormat = new StiNumberFormatService(1, ".", 1, ",", 3, true, true, " ");


                switch (dgvColumn.DefaultCellStyle.Alignment)
                {
                    case DataGridViewContentAlignment.BottomCenter:
                    case DataGridViewContentAlignment.MiddleCenter:
                    case DataGridViewContentAlignment.TopCenter:
                        dataTXT.HorAlignment = StiTextHorAlignment.Center;
                        break;

                    case DataGridViewContentAlignment.BottomLeft:
                    case DataGridViewContentAlignment.MiddleLeft:
                    case DataGridViewContentAlignment.TopLeft:
                        dataTXT.HorAlignment = StiTextHorAlignment.Left;
                        break;

                    case DataGridViewContentAlignment.BottomRight:
                    case DataGridViewContentAlignment.MiddleRight:
                    case DataGridViewContentAlignment.TopRight:
                        dataTXT.HorAlignment = StiTextHorAlignment.Right;
                        break;
                }

                BrandData.Components.Add(dataTXT);

                prevX += dgvColumn.Width * Wkoef;
            }

            report.Show();
        }

        private double GetColumnWidth(DataTable table, DataGridView dgv)
        {
            int result = 0;
            foreach (DataColumn column in table.Columns)
            {
                result += dgv.Columns[column.ColumnName].Width;
            }

            return result;
        }

        private void FillDataTable(DataTable dataTable, DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dataRow = dataTable.NewRow();

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    if (column == ColumnImage)
                    {
                        if (bSource[row.Index] is AppointHistory)
                        {
                            AppointHistory value = (AppointHistory)bSource[row.Index];
                            dataRow[column.Name] = (value.Expanded ? "-" : "+");
                        }
                        continue;
                    }
                        

                    if (column.Visible)
                    {
                        dataRow[column.Name] = dgv[column.Name, row.Index].Value;
                    }
                }

                dataTable.Rows.Add(dataRow);
            }
        }

        private DataTable CreateDataTable(DataGridView dgv)
        {
            DataTable table = new DataTable("Report");

            DataGridViewColumn dgvColumn = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
            if (dgvColumn == ColumnImage)
                table.Columns.Add(dgvColumn.Name, typeof(string));

            dgvColumn = dgv.Columns.GetNextColumn(dgvColumn, DataGridViewElementStates.Visible, 0);
            while (dgvColumn != null)
            {
                //DataGridViewCell cell = dgv[dgvColumn.Name, 0];
                //if (dgv.Rows.Count > 0 && cell.Value != null)
                //    table.Columns.Add(dgvColumn.Name, cell.ValueType);
                //else
                    table.Columns.Add(dgvColumn.Name);

                dgvColumn = dgv.Columns.GetNextColumn(dgvColumn, DataGridViewElementStates.Visible, 0);
            }

            return table;
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (bSource.Current != null)
            {
                ShowAppointInfo((IAppointHistory)bSource.Current);
            }
        }

        private void ShowAppointInfo(IAppointHistory current)
        {
            FormAppointHistory form = new DispatcherService.FormAppointHistory(MdiParent, database, current);
            form.Show();
        }
    }
}
