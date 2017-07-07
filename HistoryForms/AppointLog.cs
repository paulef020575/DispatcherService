using EPV.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace DispatcherService
{
    public class AppointLog
    {
        #region Свойства


        public string Operation { get; private set; }

        public string HostName { get; private set; }

        public string UserName { get; private set; }

        public DateTime LogTime { get; private set; }

        #endregion

        #region Конструкторы

        private AppointLog() { }

        public AppointLog(DbDataReader reader)
        {
            Operation = (string)reader["stateName"];
            HostName = (string)reader["hostName"];
            UserName = (string)reader["userName"];
            LogTime = (DateTime)reader["logTime"];
        }

        #endregion

        #region Методы

        public static BindingList<AppointLog> LoadList(EPVDatabase database, int id)
        {
            BindingList<AppointLog> list = new BindingList<AppointLog>();

            string query = Resources.Doc.Appoint.LoadLog;
            QueryParameters parameters = new QueryParameters("id", id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    list.Add(new AppointLog( reader));

                reader.Close();
            }

            return list;
        }

        #endregion

    }
}
