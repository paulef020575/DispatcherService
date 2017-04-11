using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using System.Data.Common;

namespace DispatcherService
{
    [DataTable("refCargos")]
    public class Cargo : EPVDataRow
    {
        private string name;

        [DataField("name")]
        [EPVGridColumn(0, "наименование", EPVGridColumnType.TextBox, 250)]
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value) SetState();
                name = value;
            }
        }

        public static Cargo Empty { get { return new Cargo(1, "За бумагой"); } }

        public Cargo()
        {
            name = "новый груз";
            Insert();
        }

        public Cargo(DbDataReader reader)
        {
            id = (int)reader["id"];
            name = (string)reader["name"];
        }

        public Cargo(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
