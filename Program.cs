using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DispatcherService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //StiConfig.Services.Add(new Stimulsoft.Report.Dictionary.StiFirebirdAdapterService());
            //StiConfig.Services.Add(new Stimulsoft.Report.Dictionary.StiFirebirdDatabase());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStart());
        }
    }
}