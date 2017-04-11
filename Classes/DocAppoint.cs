using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using System.Data.Common;
using EPV.Database;
using DispatcherService.Properties;
using System.Drawing;
using DispatcherService.Classes;
using EPV.Forms;

namespace DispatcherService
{
    [DataTable("docAppoints")]
    public class Appoint : EPVDataRow
    {
        private Unit unit;
        private string trackMark;
        private string licensePlate;
        private string trailer;
        private State citizen;
        private string driverName;
        private string driverPhone;
        private string warrant;
        private string whereTo;
        private string cargo;

        private DateTime dateComing;

        private Point point;
        private DateTime dateToPoint;

        private EnumerationItem docState;
        private DateTime docStateDate;

        private string idleReason;
        private Classes.PlanAppoint PlanAppoint;

        [DataReference("idUnit")]
        public Unit Unit
        {
            get { return unit; }
            set
            {
                if (unit.Id != value.Id) SetState();
                unit = value;
            }
        }

        [DataField("trackMark")]
        public string TrackMark
        {
            get { return trackMark; }
            set
            {
                if (trackMark != value) SetState();
                trackMark = value;
            }
        }

        [DataField("licensePlate")]
        public string LicensePlate
        {
            get { return licensePlate; }
            set
            {
                if (licensePlate != value) SetState();
                licensePlate = value;
            }
        }

        [DataField("trailer")]
        public string Trailer
        {
            get { return trailer; }
            set
            {
                if (trailer != value) SetState();
                trailer = value;
            }
        }

        public string TrackInfo 
        { 
            get { return trackMark + " " + licensePlate + "\n" + (trailer.Length > 0 ? "прицеп " + trailer : ""); } }

        [DataReference("state")]
        public State Citizen
        {
            get { return citizen; }
            set
            {
                if (citizen.Id != value.Id) SetState();
                citizen = value;
            }
        }

        [DataField("driverName")]
        public string DriverName
        {
            get { return driverName; }
            set
            {
                if (driverName != value) SetState();
                driverName = value;
            }
        }

        [DataField("driverPhone")]
        public string DriverPhone
        {
            get { return driverPhone; }
            set
            {
                if (driverPhone != value) SetState();
                driverPhone = value;
            }
        }

        public string DriverInfo { get { return driverName + "\n" + driverPhone; } }

        [DataField("warrant")]
        public string Warrant
        {
            get { return warrant; }
            set
            {
                if (warrant != value) SetState();
                warrant = value;
            }
        }

        [DataField("whereTo")]
        public string WhereTo
        {
            get { return whereTo;}
            set
            {
                if (whereTo != value) SetState();
                whereTo = value;
            }
        }

        public string WarrantInfo { get { return warrant + "\n" + cargo + " (" + whereTo + ")"; } }

        [DataField("cargo")]
        public string Cargo
        {
            get { return cargo; }
            set
            {
                if (cargo != value) SetState();
                cargo = value;
            }
        }

        public string UnitInfo { get { return unit.ToString() + "\n" + warrant + " (" + cargo + ")"; } }

        public DateTime DateComing { get { return dateComing; } }

        [DataReference("point")]
        public Point Point
        {
            get { return point; }
            set
            {
                if (point == null || point.Id != value.Id) 
                    SetState();
                point = value;
            }
        }

        [DataField("dateToPoint")]
        public DateTime DateToPoint
        {
            get { return dateToPoint; }
            set
            {
                if (dateToPoint != value) SetState();
                dateToPoint = value;
            }
        }

        public string PointInfo
        {
            get
            {
                if (point == null) return "";

                string result = point.ToString() + "\n";
                if (dateToPoint.Year < 2100) result += dateToPoint.ToString("dd.MM.yyyy HH:mm");

                return result;
            }
        } 

        [DataField("idleReason")]
        public string IdleReason
        {
            get { return idleReason; }
            set
            {
                if (idleReason != value) SetState();
                idleReason = value;
            }
        }

        public EnumerationItem DocState { get { return docState; } }

        public DateTime DocStateDate { get { return docStateDate; } }

        public bool ReadyToPoint 
        { 
            get 
            {
                return (docState.Id == 1 && (dateToPoint - DateTime.Now).TotalMinutes <= Settings.Default.MinutesToSign); 
            } 
        }

        public bool DoNotEnter
        {
            get { return docState.Id == 2; }
        }

        public bool OldComing
        {
            get { return (DateTime.Now - dateComing).TotalDays > Settings.Default.DaysOld; }
        }

        public override Color Color
        {
            get
            {
                if (ReadyToPoint) return Color.Khaki;
                if (DoNotEnter) return Color.Salmon;
                if (OldComing) return SystemColors.ControlLight;
                return SystemColors.Window;
            }
            set
            {
                base.Color = value;
            }
        }

        public bool HasPermit { get; private set; }

        private int permitId;

        public int PermitId { get { return permitId; } }


        public Appoint(DbDataReader reader, Units units, States states, Enumeration docStates)
        {
            id = (int)reader["id"];
            unit = units.Find((int)reader["idUnit"]);
            trackMark = (string)(DBNull.Value.Equals(reader["trackMark"]) ? string.Empty : reader["trackMark"]);
            licensePlate = (string)reader["licensePlate"];
            trailer = (string)(DBNull.Value.Equals(reader["trailer"]) ? string.Empty : reader["trailer"]);
            citizen = states.Find((int)reader["state"]);
            driverName = (string)(DBNull.Value.Equals(reader["driverName"]) ? string.Empty : reader["driverName"]);
            driverPhone = (string)(DBNull.Value.Equals(reader["driverPhone"]) ? string.Empty : reader["driverPhone"]);
            warrant = (string)(DBNull.Value.Equals(reader["warrant"]) ? string.Empty : reader["warrant"]);
            whereTo = (string)(DBNull.Value.Equals(reader["whereTo"]) ? string.Empty : reader["whereTo"]);
            cargo = (string)(DBNull.Value.Equals(reader["cargo"]) ? string.Empty : reader["cargo"]);
            dateComing = (DateTime)reader["dateComing"];
            point = null;
            dateToPoint = new DateTime(2100, 12, 31);
            idleReason = (string)(DBNull.Value.Equals(reader["idleReason"]) ? string.Empty : reader["idleReason"]);
            docState = docStates.Find((int)reader["docState"]);
            docStateDate = (DateTime)reader["dateState"];

            if (DBNull.Value.Equals(reader["permitId"]))
                HasPermit = false;
            else
            {
                HasPermit = ((int)reader["permitId"] > 0);
                permitId = (int)reader["permitId"];
            }
        }

        public Appoint(DbDataReader reader, Units units, States states, Points points,
                        Enumeration docStates)
        {
            id = (int)reader["id"];
            unit = units.Find((int)reader["idUnit"]);
            trackMark = (string)(DBNull.Value.Equals(reader["trackMark"]) ? string.Empty : reader["trackMark"]);
            licensePlate = (string)reader["licensePlate"];
            trailer = (string)(DBNull.Value.Equals(reader["trailer"]) ? string.Empty : reader["trailer"]);
            citizen = states.Find((int)reader["state"]);
            driverName = (string)(DBNull.Value.Equals(reader["driverName"]) ? string.Empty : reader["driverName"]);
            driverPhone = (string)(DBNull.Value.Equals(reader["driverPhone"]) ? string.Empty : reader["driverPhone"]);
            warrant = (string)(DBNull.Value.Equals(reader["warrant"]) ? string.Empty : reader["warrant"]);
            whereTo = (string)(DBNull.Value.Equals(reader["whereTo"]) ? string.Empty : reader["whereTo"]);
            cargo = (string)(DBNull.Value.Equals(reader["cargo"]) ? string.Empty : reader["cargo"]);
            dateComing = (DateTime)reader["dateComing"];
            point = (DBNull.Value.Equals(reader["point"]) ? null : points.Find((int)reader["point"]));
            dateToPoint = (DBNull.Value.Equals(reader["dateToPoint"]) ? new DateTime(2100, 12, 31) 
                                                                        : (DateTime)reader["dateToPoint"]);
            idleReason = (string)(DBNull.Value.Equals(reader["idleReason"]) ? string.Empty : reader["idleReason"]);
            docState = docStates.Find((int)reader["docState"]);
            docStateDate = (DateTime)reader["dateState"];



            if (DBNull.Value.Equals(reader["permitId"]))
                HasPermit = false;
            else
            {
                HasPermit = ((int)reader["permitId"] > 0);
                permitId = (int)reader["permitId"];
            }
        }

        public Appoint(Unit unt, State ctzn, EnumerationItem stt)
        {
            unit = unt;
            trackMark = "";
            licensePlate = "";
            trailer = "";
            citizen = ctzn;
            driverName = "";
            driverPhone = "";
            warrant = "";
            whereTo = "";
            cargo = "укажите груз...";
            docState = stt;
            docStateDate = DateTime.Now;
            dateComing = DateTime.Now;
            point = null;
            dateToPoint = new DateTime(2100, 12, 31);

            HasPermit = false;

            Insert();
        }

        public Appoint(PlanAppoint plan)
        {
            if (plan.Vehicle.VehicleMark != null)
                trackMark = plan.Vehicle.VehicleMark.ToString();
            else
                trackMark = "";

            licensePlate = plan.Vehicle.LicensePlate;
            trailer = "";
            driverName = plan.DriverName;
            driverPhone = plan.Contact;
            warrant = "";
            whereTo = plan.WhereTo;
            cargo = plan.Cargo.ToString();
            docStateDate = DateTime.Now;
            dateComing = DateTime.Now;
            point = null;
            dateToPoint = new DateTime(2100, 12, 31);

            unit = Unit.Empty;
            citizen = DispatcherService.State.Empty;
            docState = new EnumerationItem("docState", 0, "ожидает обработки");

            PlanAppoint = plan;

            HasPermit = PlanAppoint.HasPermit;
            permitId = PlanAppoint.PermitId;

            Insert();
        }

        public Appoint(EPVDatabase database, Appoint copy, Units units, States states)
        {
            id = copy.Id;
            string query = "select a.*, ";
            query += "(select dateState from docAppointStates where appoint = a.id and docState = 0) as dateComing ";
            query += ", (select PERMIT from docPlanAppoint where id = a.planAppoint) as permitId ";
            query += "from docAppoints a where a.id = @id";
            QueryParameters parameters = new QueryParameters("id", id);
            DbDataReader reader = database.ExecuteReader(query, parameters);
            reader.Read();
            unit = units.Find((int)reader["idUnit"]);
            trackMark = (string)(DBNull.Value.Equals(reader["trackMark"]) ? string.Empty : reader["trackMark"]);
            licensePlate = (string)reader["licensePlate"];
            trailer = (string)(DBNull.Value.Equals(reader["trailer"]) ? string.Empty : reader["trailer"]);
            citizen = states.Find((int)reader["state"]);
            driverName = (string)(DBNull.Value.Equals(reader["driverName"]) ? string.Empty : reader["driverName"]);
            driverPhone = (string)(DBNull.Value.Equals(reader["driverPhone"]) ? string.Empty : reader["driverPhone"]);            
            warrant = (string)(DBNull.Value.Equals(reader["warrant"]) ? string.Empty : reader["warrant"]);
            whereTo = (string)(DBNull.Value.Equals(reader["whereTo"]) ? string.Empty : reader["whereTo"]);
            cargo = (string)(DBNull.Value.Equals(reader["cargo"]) ? string.Empty : reader["cargo"]);
            idleReason = (string)(DBNull.Value.Equals(reader["idleReason"]) ? string.Empty : reader["idleReason"]);
            dateComing = (DateTime)reader["dateComing"];
            docState = copy.DocState;
            docStateDate = copy.docStateDate;


            if (DBNull.Value.Equals(reader["permitId"]))
                HasPermit = false;
            else
            {
                HasPermit = ((int)reader["permitId"] > 0);
                permitId = (int)reader["permitId"];
            }

            reader.Close();
        }

        public AppointStates GetStates(EPVDatabase database)
        {
            return new AppointStates(database, this);
        }

        public void SetTimeComing(EPVDatabase database, DateTime dateComing, SecurityUser user)
        {
            if (id == 0) return;
            string query = "update docAppointStates set dateState = @date where appoint = @appoint and docState = 0";
            QueryParameters parameters = new QueryParameters("date", dateComing);
            parameters.Add("appoint", id);
            database.ExecuteQuery(query, parameters);

            WriteLogRow(database, 0, user);
        }



        public void GetToPoint(EPVDatabase database, Point pnt, DateTime time, string reason, SecurityUser user)
        {
            Point = pnt;
            IdleReason = reason;
            DateToPoint = time;

            Save(database);

            if ((int)database.ExecuteScalar("select count(id) from docAppointStates where docState = 1 and appoint = " + id.ToString())
                == 0)
            {
                SetDocState(database, 1, Point, user);
            }
        }


        public void SetToPoint(EPVDatabase database, Unit unt, Point pnt, DateTime dateTime, SecurityUser user)
        {
            Unit = unt;
            Point = pnt;
            Save(database);

            SetDocState(database, 3, Point, user);
            if (Unit.IsAutoExit)
            {
                StandAtPoint(database, Point, dateTime, user);
                EndPoint(database, user);
            }
        }

        public void GetOut(EPVDatabase database, SecurityUser user)
        {
            SetDocState(database, 100, null, user);
        }

        public void WeCannotGetIt(EPVDatabase database, string reason, SecurityUser user)
        {
            IdleReason = reason;
            Save(database);
            SetDocState(database, 2, null, user);
        }

        public void StandAtPoint(EPVDatabase database, Point pnt, DateTime date, SecurityUser user)
        {
            Point = pnt;
            Save(database);
            SetDocState(database, 4, date, Point, user);
        }

        public void EndPoint(EPVDatabase database, SecurityUser user)
        {
            SetDocState(database, 5, Point, user);
        }

        private void SetDocState(EPVDatabase database, int idState, Point pnt, SecurityUser user)
        {
            string query = "insert into docAppointStates (id, appoint, docState, dateState, point) ";
            query += "values (gen_id(gen_docAppointStates_id, 1), @appoint, @state, @time, @point)";
            QueryParameters parameters = new QueryParameters("appoint", id);
            parameters.Add("state", idState);
            parameters.Add("time", DateTime.Now);
            if (pnt == null)
                parameters.Add("point", DBNull.Value);
            else
                parameters.Add("point", pnt.Id);
            database.ExecuteQuery(query, parameters);

            WriteLogRow(database, idState, user);
        }

        private void SetDocState(EPVDatabase database, int idState, DateTime date, Point pnt, SecurityUser user)
        {
            string query = "insert into docAppointStates (id, appoint, docState, dateState, point) ";
            query += "values (gen_id(gen_docAppointStates_id, 1), @appoint, @state, @time, @point)";
            QueryParameters parameters = new QueryParameters("appoint", id);
            parameters.Add("state", idState);
            parameters.Add("time", date);
            if (pnt == null)
                parameters.Add("point", DBNull.Value);
            else
                parameters.Add("point", pnt.Id);
            database.ExecuteQuery(query, parameters);

            WriteLogRow(database, idState, user);
        }

        public void ReturnToDispatcher(EPVDatabase database, SecurityUser user)
        {
            string query = "update docAppoints set point = 0, dateToPoint='31.12.2100' where id = " + id.ToString();
            database.ExecuteQuery(query);

            query = "delete from docAppointStates where appoint = @appoint and docState > 0";
            QueryParameters parameters = new QueryParameters("appoint", Id);
            database.ExecuteQuery(query, parameters);

            WriteLogRow(database, -1, user);
        }


        internal void SetComingDate(DateTime dateTime)
        {
            dateComing = dateTime;
        }

        public Permit GetPermit(EPVDatabase database)
        {
            return Permit.Load(database, permitId);
        }

        private void WriteLogRow(EPVDatabase database, int stateId, SecurityUser user)
        {
            string query = DispatcherService.Resources.Doc.Appoint.InsertLog;
            QueryParameters parameters = new QueryParameters("appoint", Id);
            parameters.Add("appointState", stateId);
            parameters.Add("hostName", Environment.MachineName);
            parameters.Add("userName", user.Name);

            database.ExecuteQuery(query, parameters);
        }
    }
}
