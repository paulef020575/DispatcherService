using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EPV.Data;
using System.Data.Common;
using EPV.Database;
using System.ComponentModel;

namespace DispatcherService.Classes.PlanAppoints
{
    /// <summary>
    ///     класс "План прибытия"
    /// </summary>
    [DataTable("PlanAppoints")]
    public class PlanAppoint : EPVDataRow
    {
        #region Fields & Properties

        private Unit unit;
        /// <summary>
        ///     подразделение прибытия
        /// </summary>
        [DataReference("idUnit")]
        public Unit Unit
        {
            get { return unit; }
            set { SetField("unit", value); }
        }

        private string trackMark;
        /// <summary>
        ///     марка т/с
        /// </summary>
        [DataField("TrackMark")]
        public string TrackMark
        {
            get { return trackMark; }
            set { SetField("trackMark", value); }
        }

        private string licensePlate;
        /// <summary>
        ///     гос. номер ТС
        /// </summary>
        [DataField("LicensePlate")]
        public string LicensePlate
        {
            get { return licensePlate; }
            set { SetField("licensePlate", value); }
        }

        /// <summary>
        ///     описание т/с
        /// </summary>
        public string TrackInfo
        {
            get { return trackMark + "\n" + licensePlate; }
        }

        private string driverName;
        /// <summary>
        ///     имя водителя
        /// </summary>
        [DataField("DriverName")]
        public string DriverName
        {
            get { return driverName; }
            set { SetField("driverName", value); }
        }

        private string driverPhone;
        /// <summary>
        ///     телефон водителя
        /// </summary>
        [DataField("DriverPhone")]
        public string DriverPhone
        {
            get { return driverPhone; }
            set { SetField("driverPhone", value); }
        }

        public string DriverInfo { get { return DriverName + "\n" + DriverPhone; } }

        private DateTime planDate;
        /// <summary>
        ///     плановая дата прибытия
        /// </summary>
        [DataField("PlanDate")]
        public DateTime PlanDate
        {
            get { return planDate; }
            set { SetField("planDate", value); }
        }

        private string cargo;
        /// <summary>
        ///     груз
        /// </summary>
        [DataField("Cargo")]
        public string Cargo
        {
            get { return cargo; }
            set { SetField("cargo", value); }
        }

        private string notes;
        [DataField("Notes")]
        public string Notes
        {
            get { return notes; }
            set 
            {
                if (value.Length > 100) throw new ArgumentException("Слишком длинное примечание");
                SetField("notes", value); 
            }
        }

        private short isClosed;
        [DataField("isClosed")]
        public bool IsClosed
        {
            get { return (isClosed > 0); }
            set { SetField("isClosed", (short)(value ? 1 : 0)); }
        }

        private DateTime dateAppoint;

        public DateTime DateAppoint
        {
            get { return dateAppoint; }
        }

        protected override string QueryInsert
        {
            get
            {
                return PlanAppoints.Queries.QueryInsert;
            }
        }

        protected override string QueryUpdate
        {
            get
            {
                return Queries.QueryUpdate;
            }
        }

        protected override string QueryDelete
        {
            get
            {
                return Queries.QueryDelete;
            }
        }

        #endregion

        #region Constructors

        public PlanAppoint(DbDataReader reader, Units units)
        {
            id = (int)reader["id"];
            unit = units.Find((int)reader["idUnit"]);
            trackMark = (string)reader["trackMark"];
            licensePlate = (string)reader["licensePlate"];
            driverName = (string)reader["driverName"];
            driverPhone = (string)reader["driverPhone"];
            planDate = (DateTime)reader["planDate"];
            cargo = (string)(DBNull.Value.Equals(reader["cargo"]) ? "" : reader["cargo"]);
            notes = (string)reader["notes"];
            isClosed = (short)reader["isClosed"];
            dateAppoint = (DateTime)(DBNull.Value.Equals(reader["dateAppoint"]) ? DateTime.MaxValue : reader["dateAppoint"]);
        }

        public PlanAppoint(Unit unt)
        {
            id = 0;
            unit = unt;
            trackMark = "Марка ТС";
            licensePlate = "Номер ТС";
            driverName = "Водитель";
            driverPhone = "+7";
            planDate = DateTime.Now.AddDays(1);
            cargo = "";
            notes = "";
            isClosed = 0;
            dateAppoint = DateTime.MaxValue; 

            Insert();
        }

        #endregion

        #region Methods

        public PlanAppoint CreateCopy(EPVDatabase database)
        {
            Units units = new Units(database);

            QueryParameters parameters = new QueryParameters("id", Id);
            PlanAppoint appoint = null;

            DbDataReader reader = database.ExecuteReader(Queries.QuerySelect, parameters);
            if (reader.Read())
                appoint = new PlanAppoint(reader, units);
            reader.Close();

            if (appoint == null)
                throw new ArgumentException("Нет записи с идентификатором " + Id.ToString());

            return appoint;
        }

        public static BindingList<PlanAppoint> LoadList(EPVDatabase database, DateTime date)
        {
            Units units = new Units(database);

            BindingList<PlanAppoint> list = new BindingList<PlanAppoint>();

            QueryParameters parameters = new QueryParameters("dateFrom", date);
            parameters.Add("dateTo", date.AddDays(1).AddSeconds(-1));

            DbDataReader reader = database.ExecuteReader(Queries.QuerySelectList, parameters);
            while (reader.Read())
                list.Add(new PlanAppoint(reader, units));
            reader.Close();
            return list;
        }

        public static BindingList<PlanAppoint> LoadList(EPVDatabase database)
        {
            Units units = new Units(database);

            BindingList<PlanAppoint> list = new BindingList<PlanAppoint>();

            DbDataReader reader = database.ExecuteReader(Queries.SelectFullList);
            while (reader.Read())
                list.Add(new PlanAppoint(reader, units));
            reader.Close();
            return list;
        }

        public override bool Equals(object obj)
        {
            if (obj is PlanAppoint)
                return Id.Equals(((PlanAppoint)obj).Id);
            return false;
        }

      private QueryParameters CreateParameters()
        {
            QueryParameters parameters = new QueryParameters("idUnit", unit.Id);
            parameters.Add("trackMark", trackMark);
            parameters.Add("licensePlate", licensePlate);
            parameters.Add("driverName", driverName);
            parameters.Add("driverPhone", driverPhone);
            parameters.Add("cargo", Cargo);
            parameters.Add("isClosed", isClosed);

            return parameters;
        }

      internal void Close()
      {
          IsClosed = true;
      }
        #endregion

    }
}
