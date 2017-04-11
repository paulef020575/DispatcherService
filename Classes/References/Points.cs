using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using EPV.Database;
using System.Data.Common;

namespace DispatcherService
{
    public class Points : EPVList<Point>, IEPVEditable
    {
        private Unit unit;
        private Units units;

        public Points(EPVDatabase database, Unit unt)
        {
            unit = unt;

            querySelect = "select * from refPoints where idUnit = @unit order by id";
            QueryParameters parameters = new QueryParameters("unit", unit.Id);
            DbDataReader reader = database.ExecuteReader(querySelect, parameters);
            while (reader.Read())
                Add(new Point(reader, unit));
            reader.Close();
        }

        public Points(EPVDatabase database) 
        {
            units = new Units(database);
            querySelect = "select * from refPoints order by idunit, id";
            DbDataReader reader = database.ExecuteReader(querySelect);
            while (reader.Read())
                Add(new Point(reader, units));
            reader.Close();
        }

        #region IEPVEditable Members

        new public void Add()
        {
            Add(new Point(unit));
        }

        new public void Insert(int index)
        {
            Insert(index, new Point(unit));
        }

        new public void Refresh(EPVDatabase database)
        {
            DbDataReader reader;
            Clear();
            if (unit != null)
            {
                QueryParameters parameters = new QueryParameters("unit", unit.Id);
                reader = database.ExecuteReader(querySelect, parameters);
            }
            else
                reader = database.ExecuteReader(querySelect);
            while (reader.Read())
            {
                if (unit != null) Add(new Point(reader, unit));
                else Add(new Point(reader, units));
            }

            reader.Close();
        }

        #endregion
    }
}
