using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EPV.Data;
using EPV.Database;
using System.Data.Common;

namespace DispatcherService.Classes
{
    public class Vehicle
    {
        private RowState rowState;

        public bool IsModified { get { return (rowState != RowState.Readed); } }

        public int Id { get; private set; }

        public VehicleMark VehicleMark { get; set; }

        public string LicensePlate { get; set; }

        private string InsertQuery
        {
            get { return DispatcherService.Resources.Ref.Vehicle.Insert; }
        }

        private static string LoadQuery
        {
            get { return DispatcherService.Resources.Ref.Vehicle.Load; }
        }

        private static string LoadListQuery
        {
            get { return DispatcherService.Resources.Ref.Vehicle.LoadList; }
        }

        public static Vehicle Empty { get { return new Vehicle(0, VehicleMark.Empty, ""); } }


        public Vehicle()
        {
            Id = 0;
            VehicleMark = VehicleMark.Empty;
            LicensePlate = "";

            rowState = RowState.Inserted;
        }

        public Vehicle(DbDataReader reader)
        {
            Id = (int)reader["id"];
            VehicleMark = new VehicleMark((int)reader["vehicleMark"], (string)reader["nameMark"]);
            LicensePlate = (string)reader["licensePlate"];

            rowState = RowState.Readed;
        }

        private Vehicle(int id, VehicleMark vehicleMark, string licensePlate)
        {
            Id = id;
            VehicleMark = vehicleMark;
            LicensePlate = licensePlate;

            rowState = RowState.Readed;
        }

        public override bool Equals(object obj)
        {
            Vehicle vehicle = obj as Vehicle;

            if (vehicle != null)
                return Id.Equals(vehicle.Id);

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return VehicleMark.ToString() + " " + LicensePlate;
        }

        public static Vehicle Load(EPVDatabase database, int id)
        {
            QueryParameters parameters = new QueryParameters("id", id);

            Vehicle vehicle = null;

            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    vehicle = new Vehicle(reader);
                reader.Close();
            }

            if (vehicle == null)
                throw new ArgumentException(DispatcherService.Resources.Error.WrongIdentifier);

            return vehicle;
        }

        public Vehicle LoadCopy(EPVDatabase database)
        {
            return Load(database, Id);
        }

        public static List<Vehicle> LoadList(EPVDatabase database, VehicleMark mark, string licensePlate)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            QueryParameters parameters = new QueryParameters("licensePlate", licensePlate);
            if (mark != null)
                parameters.Add("vehicleMark", mark.Id);
            else
                parameters.Add("vehicleMark", DBNull.Value);

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery, parameters))
            {
                while (reader.Read())
                    vehicleList.Add(new Vehicle(reader));

                reader.Close();
            }

            return vehicleList;
        }

        public void Save(FirebirdDatabase database)
        {
            switch (rowState)
            {
                case RowState.Inserted:
                    SaveInsertedRow(database);
                    break;

                default:
                    break;
            }

            rowState = RowState.Readed;
        }

        private void SaveInsertedRow(FirebirdDatabase database)
        {
            Id = database.Generator(DispatcherService.Resources.Ref.Vehicle.TableName);

            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("vehicleMark", VehicleMark.Id);
            parameters.Add("licensePlate", LicensePlate);
            database.ExecuteQuery(InsertQuery, parameters);
        }


        public static Vehicle CreateForDocument(DbDataReader reader)
        {
            return new Vehicle((int)reader["vehicle"],
                                new VehicleMark((int)reader["vehicleMark"], (string)reader["markName"]),
                                (string)reader["licensePlate"]);
        }


        public PlanAppoint GetLastPlanAppoint(EPVDatabase database)
        {
            string query = DispatcherService.Resources.Ref.Vehicle.GetLastPlanAppoint;
            QueryParameters parameters = new QueryParameters("id", Id);
            object result = database.ExecuteScalar(query, parameters);

            if (result != null && !DBNull.Value.Equals(result))
            {
                PlanAppoint planAppoint = PlanAppoint.Load(database, (int)result);
                return planAppoint;
            }

            return null;
        }

        
    }
}
