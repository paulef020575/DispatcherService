using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Forms;
using EPV.Database;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace DispatcherService
{
    public partial class FormReportList : EPVFormChild, INeedDatabase
    {
        private EPVDatabase database;

        public FormReportList()
        {
            InitializeComponent();
            if (DateTime.Today.Day <= 10)
                dateTimePickerFrom.Value = new DateTime(DateTime.Today.AddMonths(-1).Year, DateTime.Today.AddMonths(-1).Month, 1);
            else
                dateTimePickerFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dateTimePickerTo.Value = dateTimePickerFrom.Value.AddMonths(1).AddSeconds(-1);            
        }

        #region INeedDatabase Members

        public EPV.Database.EPVDatabase Database
        {
            set 
            { 
                database = value;
                Units units = new Units(database);
                units.Insert(0, new Unit(0, "все подразделения"));
                comboBoxUnits.DataSource = units;
            }
        }

        #endregion

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //StiConfig.Services.Add(new Stimulsoft.Report.Dictionary.StiFirebirdAdapterService());
            //StiConfig.Services.Add(new Stimulsoft.Report.Dictionary.StiFirebirdDatabase());

            StiReport report = new StiReport();
            report.Load("FullList.mrt");
            report.Compile();

            //report.Dictionary.Databases.Clear();
            //report.Dictionary.Databases.Add(new StiSqlDatabase("Соединение", database.ConnectionString));

            report["dateFrom"] = dateTimePickerFrom.Value;
            report["dateTo"] = dateTimePickerTo.Value;
            report["unit"] = ((Unit)comboBoxUnits.SelectedItem).Id;
            report["hourFrom"] = pickerTimeFrom.Value.Hour;
            report["hourTo"] = (pickerTimeTo.Value.Hour == 0 ? 24 : pickerTimeTo.Value.Hour);

            report.Render();
            report.Show();
        }

        private void FormReportList_Load(object sender, EventArgs e)
        {
            buttonClose.Left = panelBottom.Width - 8 - buttonClose.Width;
        }
    }
}