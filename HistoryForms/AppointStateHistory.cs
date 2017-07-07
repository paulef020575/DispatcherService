using EPV.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DispatcherService
{
    public class AppointStateHistory : IAppointHistory
    {
        public bool Expanded { get { return false; } }

        public int Id { get; private set; }

        public DateTime DateFrom { get; private set; }

        public DateTime? DateTo { get { return null; } }

        public string Driver { get; private set; }

        public string DriverPhone { get; private set; }

        public string Vehicle { get; private set; }

        public string Cargo { get; private set; }

        public string WhereTo { get; private set; }

        public string Operation { get; private set; }

        public string Point { get; private set; }

        public string Reason { get; private set; }

        public AppointStateHistory(DbDataReader reader)
        {
            Id = (int)reader["appointId"];
            DateFrom = (DateTime)reader["dateOperation"];
            Driver = (string)reader["driverName"];
            DriverPhone = (string)reader["driverPhone"];
            Vehicle = (string)reader["trackMark"] + " " + (string)reader["licensePlate"];
            Cargo = (string)reader["Cargo_"];
            WhereTo = (string)reader["WhereTo"];
            Operation = (string)reader["operation"];
            Point = (string)reader["pointName"];
            Reason = (string)reader["reason"];
        }

        public static BindingList<IAppointHistory> LoadList(EPVDatabase database,
            int id, DateTime dateFrom, DateTime dateTo, string vehicleNum, int unitId, string cargo)
        {
            BindingList<IAppointHistory> list = new BindingList<IAppointHistory>();

            QueryParameters parameters = new QueryParameters("id", id);
            parameters.Add("dateFrom", dateFrom);
            parameters.Add("dateTo", dateTo);
            parameters.Add("vehicleNum", vehicleNum);
            parameters.Add("unitId", unitId);
            parameters.Add("cargo", cargo);

            string query = DispatcherService.Resources.Doc.Appoint.LoadHistory;

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    list.Add(new DispatcherService.AppointStateHistory(reader));

                reader.Close();
            }

            return list;
        }
    }
}
