using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using EPV.Database;
using System.Data;
using Stimulsoft.Report;
using System.IO;
using System.Windows.Forms;
using Stimulsoft.Report.Dictionary;

namespace DispatcherService.Classes
{
    public class Permit
    {
        #region Свойства

        public int Id { get; private set; }

        public int Period { get; private set; }

        public int DocNumber { get; private set; }

        public string ShortNumber { get { return Period.ToString() + "-" + DocNumber.ToString(); } }

        public DateTime CreateDate { get; private set; }

        public DateTime DateFrom { get; private set; }

        public DateTime DateTo { get; private set; }

        public Cargo Cargo { get; private set; }

        private int VehicleId;

        public Vehicle Vehicle { get; private set; }

        public string DriverName { get; private set; }

        public string Contact { get; private set; }

        public string Comment { get; set; }

        public EntryPoint EntryPoint { get; private set; }

        public bool MultiEntry { get; private set; }

        #endregion

        #region Конструктор

        public Permit(DbDataReader reader)
        {
            Id = (int)reader["id"];
            Cargo = new Cargo((int)reader["cargo"], (string)reader["cargoName"]);
            Period = (int)reader["period"];
            DocNumber = (int)reader["docNumber"];
            CreateDate = (DateTime)reader["createDate"];
            DateFrom = (DateTime)reader["dateFrom"];
            DateTo = (DateTime)reader["dateTo"];
            VehicleId = (int)reader["vehicle"];
            DriverName = (string)reader["driverName"];
            Contact = (string)reader["contact"];
            Comment = (string)reader["comment"];

            EntryPoint = new EntryPoint((int)reader["entryPoint"], (string)reader["entryPointName"]);
            MultiEntry = ((short)reader["multiEntry"] > 0);
        }

        #endregion

        public static Permit Load(EPVDatabase database, int id)
        {
            string query = DispatcherService.Resources.Doc.Permit.Load;
            QueryParameters parameters = new QueryParameters("id", id);

            Permit permit = null;

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                    permit = new Permit(reader);

                reader.Close();
            }

            if (permit == null)
                throw new ArgumentException(DispatcherService.Resources.Error.WrongIdentifier);

            permit.Vehicle = Vehicle.Load(database, permit.VehicleId);

            return permit;
        }

        public override bool Equals(object obj)
        {
            Permit permit = obj as Permit;

            if (permit != null)
                return Id.Equals(permit.Id);

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return "№ " + ShortNumber + " от " + CreateDate.ToShortDateString();
        }

        public void Print()
        {
            DataTable dataTable = CreateDataTable();
            DataSet dataSet = new DataSet("DataSet");
            dataSet.Tables.Add(dataTable);

            StiReport report = new StiReport();
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = Path.Combine(path, "Permit.mrt");
            report.Load(path);


            report.DataSources.Clear();
            StiDataTableSource sourceTable = new StiDataTableSource("PermitTable", "PermitTable", "PermitTable");
            report.Dictionary.DataSources.Add(sourceTable);
            report.RegData("PermitTable", "PermitTable", dataTable);
            sourceTable.SynchronizeColumns();

            report.Show();
        }

        private DataTable CreateDataTable()
        {
            DataTable table = new DataTable("PermitTable");
            table.Columns.Add("ShortNumber", typeof(string));
            table.Columns.Add("VehicleName", typeof(string));
            table.Columns.Add("DriverName", typeof(string));
            table.Columns.Add("Contact", typeof(string));
            table.Columns.Add("CargoName", typeof(string));
            table.Columns.Add("DateFrom", typeof(DateTime));
            table.Columns.Add("DateTo", typeof(DateTime));
            
            DataRow row = table.NewRow();
            row["ShortNumber"] = ShortNumber;
            row["VehicleName"] = Vehicle.ToString();
            row["DriverName"] = DriverName;
            row["Contact"] = Contact;
            row["CargoName"] = Cargo.ToString();
            row["DateFrom"] = DateFrom;
            row["DateTo"] = DateTo;
            table.Rows.Add(row);

            return table;
        }

        public string GetComment(EPVDatabase database)
        {
            QueryParameters parameters = new QueryParameters("id", Id);
            return (string)database.ExecuteScalar(DispatcherService.Resources.Doc.Permit.GetComment, parameters);
        }

        public void UpdateComment(EPVDatabase database, string comment)
        {
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("comment", comment);
            database.ExecuteQuery(DispatcherService.Resources.Doc.Permit.UpdateComment, parameters);
        }
    }
}
