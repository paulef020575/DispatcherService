using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Forms;
using DispatcherService.Properties;

namespace DispatcherService
{
    public partial class FormMainSettings : EPVFormChild
    {
        public FormMainSettings()
        {
            InitializeComponent();
            textBoxSecondsToRefresh.Text = Settings.Default.SecondsToRefresh.ToString();
            textBoxMinutesToSign.Text = Settings.Default.MinutesToSign.ToString();
            textBoxDaysOld.Text = Settings.Default.DaysOld.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string variable = label1.Text.Substring(0, label1.Text.Length - 5);
            TextBox textBoxVariable = textBoxSecondsToRefresh;
            try
            {
                variable = "Время обновления списков";
                textBoxVariable = textBoxSecondsToRefresh;
                Settings.Default.SecondsToRefresh = int.Parse(textBoxSecondsToRefresh.Text);

                variable = label2.Text.Substring(0, label2.Text.Length - 5);
                textBoxVariable = textBoxMinutesToSign;
                Settings.Default.MinutesToSign = int.Parse(textBoxMinutesToSign.Text);

                variable = label3.Text.Substring(0, label3.Text.Length - 5);
                textBoxVariable = textBoxDaysOld;
                Settings.Default.DaysOld = int.Parse(textBoxDaysOld.Text);

                Settings.Default.Save();
                Close();
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Неверный формат числа", variable);
                textBoxVariable.Select();
            }
        }
    }
}