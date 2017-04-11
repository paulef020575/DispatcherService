using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using EPV.Database;
using System.Data.Common;

namespace DispatcherService
{
    public class AppointStates : EPVList<AppointState>
    {
        private Appoint appoint;
        private Enumeration docStates;

        public AppointStates(EPVDatabase database, Appoint apnt)
        {
            appoint = apnt;
            querySelect = "select * from docAppointStates where appoint = @appoint order by dateState";
            QueryParameters parameters = new QueryParameters("appoint", appoint.Id);
            docStates = new Enumeration(database, "docState");
            DbDataReader reader = database.ExecuteReader(querySelect, parameters);
            while (reader.Read())
                Add(new AppointState(reader, appoint, docStates));
            reader.Close();
        }



        new void Add()
        {
            EnumerationItem item = Items[0].DocState, newItem = docStates.Find(item.Id + 1);
            if (newItem == null) newItem = item;
            Add(new AppointState(appoint, newItem));
        }

        new void Insert(int index)
        {
            EnumerationItem item = Items[0].DocState, newItem = docStates.Find(item.Id + 1);
            if (newItem == null) newItem = item;
            Insert(index, new AppointState(appoint, newItem));
        }

        new void Refresh(EPVDatabase database)
        {
            QueryParameters parameters = new QueryParameters("appoint", appoint.Id);
            docStates = new Enumeration(database, "docState");
            DbDataReader reader = database.ExecuteReader(querySelect, parameters);
            while (reader.Read())
                Add(new AppointState(reader, appoint, docStates));
            reader.Close();
        }

    }
}
