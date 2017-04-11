using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using System.Data.Common;

namespace DispatcherService
{
    [DataTable("refPoints")]
    public class Point : EPVDataRow
    {
        private Unit unit;
        private string name;
        private int capacity;

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

        [DataField("name")]
        [EPVGridColumn(0, "наименование", EPVGridColumnType.TextBox, 200)]
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value) SetState();
                name = value;
            }
        }

        [DataField("capacity")]
        [EPVGridColumn(1, "вместимость")]
        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (capacity != value) SetState();
                capacity = value;
            }
        }

        public Point(Unit unt)
        {
            id = 0;
            unit = unt;
            name = "место погрузки/выгрузки";
            capacity = 1;
            Insert();
        }

        public Point(DbDataReader reader, Unit unt)
        {
            id = (int)reader["id"];
            unit = unt;
            name = (string)reader["name"];
            capacity = (int)reader["capacity"];
        }

        public Point(DbDataReader reader, Units units)
        {
            id = (int)reader["id"];
            unit = units.Find((int)reader["idUnit"]);
            name = (string)reader["name"];
            capacity = (int)reader["capacity"];
        }

        public override string ToString()
        {
            return name;
        }
    }
}
