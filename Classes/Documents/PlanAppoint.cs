using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using EPV.Forms;
using EPV.Database;
using System.ComponentModel;

namespace DispatcherService.Classes
{
    public class PlanAppoint : INotifyPropertyChanged
    {
        public int Id { get; private set; }

        public bool IsNew { get { return (Id == 0); } }

        private bool isModified = false;

        private Cargo cargo;
        public Cargo Cargo 
        {
            get { return cargo; }
            set 
            {
                if (Cargo == null || !Cargo.Equals(value))
                {
                    cargo = value;
                    OnPropertyChanged("Cargo");
                }
            }
        }

        private Vehicle vehicle;
        public Vehicle Vehicle 
        {
            get { return vehicle; }
            set
            {
                if (Vehicle == null || !Vehicle.Equals(value))
                {
                    vehicle = value;
                    OnPropertyChanged("Vehicle");
                }
            }
        }

        private string driverName;
        public string DriverName 
        {
            get { return driverName; }
            set
            {
                if (driverName != value)
                {
                    driverName = value;
                    OnPropertyChanged("DriverName");
                }
            }
        }

        private string contact;
        public string Contact 
        {
            get { return contact; }
            set
            {
                if (contact != value)
                {
                    contact = value;
                    OnPropertyChanged("Contact");
                }
            }
        }

        private string whereTo;
        public string WhereTo 
        {
            get { return whereTo; }
            set
            {
                if (whereTo != value)
                {
                    whereTo = value;
                    OnPropertyChanged("WhereTo");
                }
            }
        }

        private DateTime dateFrom;
        public DateTime DateFrom 
        {
            get { return dateFrom; }
            set
            {
                if (dateFrom != value)
                {
                    dateFrom = value;
                    OnPropertyChanged("DateFrom");
                }

                DateTo = DateFrom;
            }
        }

        private DateTime dateTo;
        public DateTime DateTo
        {
            get { return dateTo; }
            set
            {
                if (dateTo != value)
                {
                    dateTo = value;
                    OnPropertyChanged("DateTo");
                }
            }
        }

        public int CreatorId { get; private set; }

        public string CreatorName { get; private set; }

        public DateTime CreateDate { get; private set; }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set
            {
                if (comment != value)
                {
                    comment = value;
                    OnPropertyChanged("Comment");
                }
            }
        }

        public int PermitId { get; private set; }

        public bool HasPermit { get { return (PermitId > 0); } }

        private string InsertQuery { get { return DispatcherService.Resources.Doc.PlanAppoint.Insert; } }

        private string UpdateQuery { get { return DispatcherService.Resources.Doc.PlanAppoint.Update; } }

        private string DeleteQuery { get { return DispatcherService.Resources.Doc.PlanAppoint.Delete; } }

        private static string LoadQuery { get { return DispatcherService.Resources.Doc.PlanAppoint.Load; } }

        private static string LoadListQuery { get { return DispatcherService.Resources.Doc.PlanAppoint.LoadList; } }

        public PlanAppoint(DbDataReader reader)
        {
            Id = (int)reader["id"];
            CreatorId = (int)reader["creator"];
            CreatorName = (string)reader["creatorName"];
            CreateDate = (DateTime)reader["createDate"];
            cargo = new Cargo((int)reader["cargo"], (string)reader["cargoName"]);
            vehicle = Vehicle.CreateForDocument(reader);
            driverName = (string)reader["driverName"];
            contact = (string)reader["contact"];
            whereTo = (string)reader["whereTo"];
            dateFrom = (DateTime)reader["dateFrom"];
            dateTo = (DateTime)reader["dateTo"];
            comment = (string)(DBNull.Value.Equals(reader["comment"]) ? "" : reader["comment"]);

            if (DBNull.Value.Equals(reader["permit"]))
                PermitId = 0;
            else
                PermitId = (int)reader["permit"];
        }

        public PlanAppoint(ISystemUser user)
        {
            Id = 0;
            CreatorId = user.Id;
            CreatorName = user.ToString();
            CreateDate = DateTime.Now;
            cargo = Cargo.Empty;
            vehicle = Vehicle.Empty;
            driverName = "";
            contact = "";
            whereTo = "";
            dateFrom = DateTime.Today;
            dateTo = DateTime.Today.AddDays(1);
            PermitId = 0;
            comment = "";

            isModified = true;
        }

        public override bool Equals(object obj)
        {
            PlanAppoint planAppoint = obj as PlanAppoint;

            if (planAppoint != null)
                return planAppoint.Id.Equals(Id);

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Vehicle.ToString();
        }

        public static PlanAppoint Load(EPVDatabase database, int id)
        {
            PlanAppoint planAppoint = null;

            QueryParameters parameters = new QueryParameters("id", id);

            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    planAppoint = new PlanAppoint(reader);

                reader.Close();
            }

            if (planAppoint == null)
                throw new ArgumentException(DispatcherService.Resources.Error.WrongIdentifier);

            return planAppoint;
        }

        public PlanAppoint LoadCopy(EPVDatabase database)
        {
            return Load(database, Id);
        }

        public static List<PlanAppoint> LoadList(EPVDatabase database, DateTime date)
        {
            List<PlanAppoint> planAppointList = new List<PlanAppoint>();

            QueryParameters parameters = new QueryParameters("dateStart", date);

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery, parameters))
            {
                while (reader.Read())
                    planAppointList.Add(new PlanAppoint(reader));
                reader.Close();
            }

            return planAppointList;
        }

        #region INotifyPropertyChanged Members

        private PropertyChangedEventHandler onPropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { onPropertyChanged += value; }
            remove { onPropertyChanged -= value; }
        }

        private void OnPropertyChanged(string propertyName)
        {
            isModified = true;

            if (onPropertyChanged != null)
                onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        internal void Save(EPVDatabase database, ISystemUser user)
        {
            if (isModified)
            {
                if (Id == 0)
                    SaveInsertedRow(database);
                else
                    SaveModifiedRow(database, user);
            }
        }

        private void SaveModifiedRow(EPVDatabase database, ISystemUser user)
        {
            QueryParameters parameters = CreateParameters();
            parameters.Add("userId", user.Id);

            database.ExecuteQuery(UpdateQuery, parameters);
        }

        private void SaveInsertedRow(EPVDatabase database)
        {
            Id = ((FirebirdDatabase)database).Generator("docPlanAppoint");

            database.ExecuteQuery(InsertQuery, CreateParameters());
        }

        private QueryParameters CreateParameters()
        {
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("creator", CreatorId);
            parameters.Add("createDate", CreateDate);
            parameters.Add("cargo", Cargo.Id);
            parameters.Add("vehicle", Vehicle.Id);
            parameters.Add("driverName", DriverName);
            parameters.Add("contact", Contact);
            parameters.Add("whereTo", WhereTo);
            parameters.Add("dateFrom", DateFrom);
            parameters.Add("dateTo", DateTo);
            parameters.Add("comment", Comment);

            return parameters;
        }
    }
}
