using EPV.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DispatcherService
{
    public class AppointHistory : List<AppointStateHistory>, IAppointHistory
    {
        #region Свойства

        public string Cargo { get; private set; }

        public DateTime DateFrom
        {
            get; private set;
        }

        public DateTime? DateTo
        {
            get; private set;
        }

        public string Driver { get; private set; }

        public string DriverPhone { get; private set; }

        public bool Expanded { get; private set; }

        public int Id { get; private set; }

        public string Operation { get { return ""; } }

        public string Vehicle { get; private set; }

        public string WhereTo { get; private set; }

        public string Point { get { return ""; } }

        public string Reason { get; private set; }

        #endregion

        #region Конструктор

        private AppointHistory() : base() { }

        public AppointHistory(DbDataReader reader)
            : this()
        {
            Id = (int)reader["appointId"];
            Driver = (string)reader["driverName"];
            DriverPhone = (string)reader["driverPhone"];
            Vehicle = (string)reader["trackMark"] + " " + (string)reader["licensePlate"];
            Cargo = (string)reader["Cargo_"];
            WhereTo = (string)reader["WhereTo"];
            Expanded = false;
            DateFrom = (DateTime)reader["dateMin"];
            DateTo = (DateTime)reader["dateMax"];
            Reason = (string)reader["idleReason"];

            Add(new AppointStateHistory(reader));
        }

        #endregion

        #region Методы

        public static BindingList<IAppointHistory> LoadList(EPVDatabase database,
            int id, DateTime dateFrom, DateTime dateTo, string vehicleNum, int unitId, string cargo)
        {
            BindingList<IAppointHistory> list = new BindingList<IAppointHistory>();
            AppointHistory currentAppoint = null;

            QueryParameters parameters = new QueryParameters("id", id);
            parameters.Add("dateFrom", dateFrom);
            parameters.Add("dateTo", dateTo);
            parameters.Add("vehicleNum", vehicleNum);
            parameters.Add("unitId", unitId);
            parameters.Add("cargo", cargo);

            string query = DispatcherService.Resources.Doc.Appoint.LoadHistoryGroup;

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    if (currentAppoint == null || currentAppoint.Id != (int)reader["appointId"])
                    {
                        currentAppoint = new AppointHistory(reader);
                        list.Add(currentAppoint);
                    }

                    currentAppoint.Add(new DispatcherService.AppointStateHistory(reader));
                }

                reader.Close();
            }

            return list;
        }

        public static AppointHistory LoadList(EPVDatabase database, int id)
        {
            BindingList<IAppointHistory> list = LoadList(database, id, DateTime.MinValue, DateTime.MaxValue,
                                                            "", 0, "");

            if (list.Count > 0)
                return (AppointHistory)list[0];
            else
                throw new ArgumentOutOfRangeException(DispatcherService.Resources.Error.WrongIdentifier);

        }

        internal void Collapse(BindingSource bSource)
        {
            foreach (AppointStateHistory item in this)
                bSource.Remove(item);
            Expanded = false;
        }

        internal void Expand(BindingSource bSource)
        {
            int index = bSource.IndexOf(this);

            foreach (AppointStateHistory item in this)
                bSource.Insert(++index, item);

            Expanded = true;
        }

        #endregion
    }
}
