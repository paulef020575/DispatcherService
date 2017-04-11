using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EPV.Data;
using System.Data.Common;
using System.Collections;
using EPV.Database;

namespace DispatcherService.Classes
{
    public class VehicleMark : EPVDataRow
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { SetField("name", value); }
        }

        public static VehicleMark Empty { get { return new VehicleMark(0, "Не указана"); } }

        protected override string QueryInsert
        {
            get
            {
                return DispatcherService.Resources.Ref.VehicleMark.Insert;
            }
        }

        private static string LoadQuery
        {
            get
            {
                return DispatcherService.Resources.Ref.VehicleMark.Load;
            }
        }

        private static string LoadListQuery
        {
            get
            {
                return DispatcherService.Resources.Ref.VehicleMark.LoadList;
            }
        }

        public VehicleMark()
        {
            id = 0;
            name = "Новая марка ТС";
            Insert();
        }

        public VehicleMark(DbDataReader reader)
        {
            id = (int)reader["id"];
            name = (string)reader["name"];
        }

        public VehicleMark(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public override void Save(EPVDatabase database)
        {
            Save((FirebirdDatabase)database);
        }

        public void Save(EPV.Database.FirebirdDatabase database)
        {
            if (id != 0) return;

            switch (this.State)
            {
                case RowState.Inserted:
                    SaveInsertedRow(database);
                    break;

                default:
                    return;
            }
        }

        private void SaveInsertedRow(EPV.Database.FirebirdDatabase database)
        {
            id = database.Generator("refVehicleMark");
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("name", Name);
            database.ExecuteQuery(QueryInsert, parameters);
        }

        public static VehicleMark Load(EPVDatabase database, int id)
        {
            VehicleMark vehicleMark = null;
            QueryParameters parameters = new QueryParameters("id", id);
            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    vehicleMark = new VehicleMark(reader);
                reader.Close();
            }

            if (vehicleMark == null)
                throw new ArgumentException(DispatcherService.Resources.Error.WrongIdentifier);

            return vehicleMark;
        }

        public VehicleMark LoadCopy(EPVDatabase database)
        {
            return Load(database, Id);
        }

        public static List<VehicleMark> LoadList(EPVDatabase database)
        {
            List<VehicleMark> list = new List<VehicleMark>();
            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    list.Add(new VehicleMark(reader));
                reader.Close();
            }

            return list;
        }


    }
}
