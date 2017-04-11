using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using System.Data.Common;
using EPV.Database;
using EPV.Forms;

namespace DispatcherService
{
    /// <summary>
    ///     Подразделение предприятия
    /// </summary>
    [DataTable("RefUnits")]
    public class Unit : EPVDataRow
    {
        private string name;
        private string code;
        private short autoExit;

        [DataField("name")]
        [EPVGridColumn(1, "наименование", EPVGridColumnType.TextBox, 250)]
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value) SetState();
                name = value;
            }
        }

        [DataField("code")]
        [EPVGridColumn(0, "код", EPVGridColumnType.TextBox, 50)]
        public string Code
        {
            get { return code; }
            set
            {
                if (code != value) SetState();
                code = value;
            }
        }

        [DataField("autoExit")]
        public short AutoExit { get { return autoExit; } }

        [EPVGridColumn(2, "авто", EPVGridColumnType.CheckBox)]
        public bool IsAutoExit
        {
            get { return (autoExit > 0); }
            set
            {
                if ((autoExit > 0) != value) SetState();
                autoExit = (short)(value ? 1 : 0);
            }
        }

        public static Unit Empty
        {
            get { return new Unit(1, "ЦПГП"); }
        }

        public Unit()
        {
            code = "";
            name = "новое подразделение";
            autoExit = 0;
            Insert();
        }

        public Unit(DbDataReader reader)
        {
            id = (int)reader["id"];
            code = (string)reader["code"];
            name = (string)reader["name"];
            autoExit = (short)reader["autoExit"];
        }

        public Unit(int idr, string nm)
        {
            id = idr;
            name = nm;
            code = "";
            autoExit = 0;
        }

        public override string ToString()
        {
            return name;
        }

        public static List<Unit> LoadList(EPVDatabase database, ISystemUser user)
        {
            List<Unit> unitList = new List<Unit>();

            string query = DispatcherService.Resources.Ref.Unit.ListForUser;
            QueryParameters parameters = new QueryParameters("userId", user.Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    unitList.Add(new Unit(reader));
                reader.Close();
            }

            return unitList;
        }
    }
}
