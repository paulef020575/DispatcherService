using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EPV.Forms;
using EPV.Database;
using EPV.Data;
using DispatcherService.Properties;
using System.Data.Common;
using System.Collections;
using System.Security.Cryptography;
using DispatcherService.Forms;
using System.IO;

namespace DispatcherService
{
    [GetMenu(TypeSource = "Database", UseSecurity = true)]
    [UseSecurity]
    public partial class FormStart : EPVFormStart
    {
        public FormStart()
        {
            InitializeComponent();

            DateTime xDate = new DateTime(2016, 1, 13, 16, 0, 0);

            if (DateTime.Now > xDate)
                CreateNewConnection();
            else
                ShowMessage();

#if DEBUG
            database = new FirebirdDatabase("localhost", "d:\\prog\\dispatcher\\dispatcher.fdb", "sysdba", "masterkey");
#else
            database = new FirebirdDatabase(Settings.Default.ServerName, Settings.Default.DBPath, "sysdba", "masterkey");
#endif


            //database = new FirebirdDatabase("172.18.39.135", "c:\\db_pulp\\dispatcher.fdb", "sysdba", "masterkey");
            //string connectionString = Constant.GetString(database, "connectionString");
            //database = FirebirdDatabase.FromConnectionString(connectionString);

            Text = Constant.GetString(database, "applicationName");
                        
            SecurityUsers users = new SecurityUsers(database);
            FormConnect form = new FormConnect();
            form.Database = database;
            form.Users = users;
            SecurityUser user1 = users.Find(Settings.Default.LastUserId);
            if (user1 != null) form.User = user1;

            if (form.ShowDialog() == DialogResult.Cancel) Environment.Exit(0);
            user = (ISystemUser)form.User;
            Settings.Default.LastUserId = user.Id;
            Settings.Default.Save();

            GetMenu();
            MenuSecurity.DropDownItems.Add("Подразделения", null, new EventHandler(ReferenceUnits));
            SecurityUsers += new EventHandler(ShowUsers);
            SecurityGroups += new EventHandler(ShowUserGroups);
            SecurityAccess += new EventHandler(ShowMenuAccess);
        }

        private void ShowMessage()
        {
            MessageBox.Show("Внимание! 13 января 2016 года система будет перенесена на новый сервер. В связи с переносом "
                            + "необходимо воздержаться от работы в ней 13.01.2016 с 16 до 17 часов. Данные, внесенные в указанный период, "
                            + "в процессе переноса могут быть утеряны. Вопросы по тел. 67-90",
                            "Внимание");
            
        }

        private void CreateNewConnection()
        {
#if DEBUG
                Settings.Default.ServerName = "localhost";
                Settings.Default.DBPath = "d:\\prog\\Dispatcher\\Dispatcher.fdb";
                Settings.Default.Save();
            return;
#endif


            if (Settings.Default.ServerName != "172.18.39.135")
            {
                Settings.Default.ServerName = "172.18.39.135";
                Settings.Default.DBPath = "c:\\DB_PULP\\Dispatcher.fdb";
                Settings.Default.Save();
            }

        }

        void ShowMenuAccess(object sender, EventArgs e)
        {
            AddChild(new FormMenuAccess());
        }

        private void ReferenceUnits(object sender, EventArgs e)
        {
            FormUnits form = new FormUnits();
            form.Database = database;
            AddChild(form);
        }

        public void ReferencePoints()
        {
            FormPoints form = new FormPoints();
            form.Database = database;
            AddChild(form);
        }

        public void ReferenceStates()
        {
            FormStates form = new FormStates();
            form.Database = database;
            AddChild(form);
        }

        public void ReferenceCargos()
        {
            FormCargos form = new FormCargos();
            form.Database = database;
            AddChild(form);
        }

        public void ShowDispatcherForm()
        {
            FormDispatcher form = new FormDispatcher();
            form.Database = database;
            AddChild(form);
        }

        public void ShowAcceptingForm()
        {
            AddChild(new FormAccepting());
        }

        public void ShowUsers(object sender, EventArgs e)
        {
            AddChild(new FormUsers());
        }

        public void ShowUserGroups(object sender, EventArgs e)
        {
            AddChild(new FormSecGroups());
        }

        public void ShowSettings()
        {
            AddDialog(new FormMainSettings());
        }

        public void ShowAcceptingFormReadOnly()
        {
            FormAccepting form = new FormAccepting();
            form.Database = database;
            form.SetReadOnly();
            AddChild(form);
        }

        public void ShowFullList()
        {
            AddChild(new FormReportList());
        }

        public void ShowSummary()
        {
            AddChild(new FormReportSummary());
        }

        public void ShowPlanForm()
        {
        }

        public void ShowPointForm()
        {
            PointAppointsForm form = new PointAppointsForm(this, database);
            if (!user.CheckAdmin())
                form.SetPointFixed();

            form.Show();
        }

        public void ShowMaterialPermits()
        {
            MaterialPermitListForm form = new MaterialPermitListForm(this, database);
            form.Show();
        }

        public void ShowAppointHistory()
        {
            FormHistory form = new DispatcherService.FormHistory(this, database);
            form.Show();
        }

        public static string ApplicationFolder
        {
            get
            {
                string applicationFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string applicationName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
                applicationFolder = Path.Combine(applicationFolder, applicationName);

                if (!Directory.Exists(applicationFolder))
                    Directory.CreateDirectory(applicationFolder);

                return applicationFolder;
            }
        }

    }
}