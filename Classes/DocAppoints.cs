using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using EPV.Database;
using System.Data.Common;

namespace DispatcherService
{
    public class Appoints : EPVList<Appoint>
    {
        private DocStateGroups group;
        private Unit unit;

        private Units units;
        public Units Units { get { return units; } }

        private Enumeration docStates;
        public Enumeration DocStates { get { return docStates; } }

        private States states;
        public States States { get { return states; } }

        private Points points;
        public Points Points { get { return points; } }

        public Appoints(EPVDatabase database, DocStateGroups grp)
        {
            group = grp;
            units = new Units(database);
            docStates = new Enumeration(database, "docState");
            states = new States(database);
            points = new Points(database);

            querySelect = "select a.*, s.*, ";
            querySelect += "(select dateState from docAppointStates where appoint = a.id and docState = 0) as dateComing ";
            querySelect += ", (select PERMIT from docPlanAppoint where id = a.planAppoint) as permitId ";
            querySelect += "from docAppoints a, docAppointStates s ";
            querySelect += "where a.id = s.appoint and ";
            querySelect += "s.docState = (select max(s1.docState) from docAppointStates s1 where s1.appoint = a.id) ";

            switch (group)
            {
                case DocStateGroups.Dispatcher:
                    querySelect += "and s.docState < 3";
                    break;

                case DocStateGroups.BeforeStart:
                    querySelect += "and s.docState = 3";
                    break;

                case DocStateGroups.OnPoint:
                    querySelect += "and s.docState = 4";
                    break;

                case DocStateGroups.ToExit:
                    querySelect += "and s.docState = 5";
                    break;
            }

            DbDataReader reader = database.ExecuteReader(querySelect);
            while (reader.Read())
                Add(new Appoint(reader, units, states, points, docStates));
            reader.Close();
        }

        public Appoints(EPVDatabase database, DocStateGroups grp, Point point)
        {
            group = grp;
            units = new Units(database);
            docStates = new Enumeration(database, "docState");
            states = new States(database);
            points = new Points(database);

            querySelect = "select a.*, s.*, ";
            querySelect += "(select dateState from docAppointStates where appoint = a.id and docState = 0) as dateComing ";
            querySelect += ", (select PERMIT from docPlanAppoint where id = a.planAppoint) as permitId ";
            querySelect += "from docAppoints a, docAppointStates s ";
            querySelect += "where a.id = s.appoint and a.point = " + point.Id.ToString() + " and "; 
            querySelect += "s.docState = (select max(s1.docState) from docAppointStates s1 where s1.appoint = a.id) ";

            switch (group)
            {
                case DocStateGroups.Dispatcher:
                    querySelect += "and s.docState < 3";
                    break;

                case DocStateGroups.BeforeStart:
                    querySelect += "and s.docState = 3";
                    break;

                case DocStateGroups.OnPoint:
                    querySelect += "and s.docState = 4";
                    break;

                case DocStateGroups.ToExit:
                    querySelect += "and s.docState = 5";
                    break;
            }

            DbDataReader reader = database.ExecuteReader(querySelect);
            while (reader.Read())
                Add(new Appoint(reader, units, states, points, docStates));
            reader.Close();
        }

        public Appoints(EPVDatabase database, DocStateGroups grp, Unit unt)
        {
            group = grp;
            unit = unt;
            units = new Units(database);
            docStates = new Enumeration(database, "docState");
            states = new States(database);
            points = new Points(database);

            querySelect = "select a.*, s.*, ";
            querySelect += "(select dateState from docAppointStates where appoint = a.id and docState = 0) as dateComing ";
            querySelect += ", (select PERMIT from docPlanAppoint where id = a.planAppoint) as permitId ";
            querySelect += "from docAppoints a, docAppointStates s ";
            querySelect += "where a.id = s.appoint and ";
            querySelect += "s.docState = (select max(s1.docState) from docAppointStates s1 where s1.appoint = a.id) ";
            querySelect += "and idUnit = @unit "; 

            switch (group)
            {
                case DocStateGroups.Dispatcher:
                    querySelect += "and s.docState < 3";
                    break;

                case DocStateGroups.BeforeStart:
                    querySelect += "and s.docState = 3";
                    break;

                case DocStateGroups.OnPoint:
                    querySelect += "and s.docState = 4";
                    break;

                case DocStateGroups.ToExit:
                    querySelect += "and s.docState = 5";
                    break;
            }

            QueryParameters parameters = new QueryParameters("unit", unit.Id);

            DbDataReader reader = database.ExecuteReader(querySelect, parameters);
            while (reader.Read())
                Add(new Appoint(reader, units, states, points, docStates));
            reader.Close();
        }

        public bool ReadyToPoint
        {
            get
            {
                for (int i = 0; i < Count; i++)
                    if (Items[i].ReadyToPoint) return true;
                return false;
            }
        }
    }

}
