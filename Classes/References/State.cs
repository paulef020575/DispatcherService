using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using System.Data.Common;

namespace DispatcherService
{
    [DataTable("refStates")]
    public class State : EPVDataRow
    {
        private string name;
        private string code;
        private int p;
        private string p_2;
        private string p_3;

        [EPVGridColumn(0, "наименование", EPVGridColumnType.TextBox, 200)]
        [DataField("name")]
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value) SetState();
                name = value;
            }
        }

        [EPVGridColumn(1, "код", EPVGridColumnType.TextBox, 50)]
        [DataField("code")]
        public string Code
        {
            get { return code; }
            set
            {
                if (code != value) SetState();
                code = value;
            }
        }

        public static State Empty
        {
            get
            {
                return new State(1, "РОССИЯ", "RUS");
            }
        }

        public State()
        {
            name = "новое государство";
            code = "UNK";
            Insert();
        }

        public State(DbDataReader reader)
        {
            id = (int)reader["id"];
            name = (string)reader["name"];
            code = (string)reader["code"];
        }

        public State(int p, string p_2, string p_3)
        {
            // TODO: Complete member initialization
            id = p;
            name = p_2;
            code = p_3;
        }



        public override string ToString()
        {
            return code;
        }
    }
}
