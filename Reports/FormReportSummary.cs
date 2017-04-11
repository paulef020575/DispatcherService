using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Forms;
using Stimulsoft.Report;

namespace DispatcherService
{
    public partial class FormReportSummary : EPVFormChild
    {
        public FormReportSummary()
        {
            InitializeComponent();
            dateTimePickerFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dateTimePickerTo.Value = DateTime.Today;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load("Summary.mrt");
            report.Compile();
            report["dateFrom"] = dateTimePickerFrom.Value;
            report["dateTo"] = dateTimePickerTo.Value;
            report.Render();
            report.Show();
        }
    }
}