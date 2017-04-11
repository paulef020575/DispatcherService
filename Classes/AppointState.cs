using System;
using System.Collections.Generic;
using System.Text;
using EPV.Data;
using System.Data.Common;
using EPV.Database;
using System.ComponentModel;

namespace DispatcherService
{
    /// <summary>
    ///     ����� "��������� ����������"
    /// </summary>
    [DataTable("docAppointStates")]
    public class AppointState : EPVDataRow
    {
        #region ���� � ��������

        #region �������� ������ Appoint

        private Appoint appoint;
        /// <summary>
        ///     ��������� ���������
        /// </summary>
        [DataReference("appoint")]
        public Appoint Appoint
        {
            get { return appoint; }
            set
            {
                if (appoint.Id != value.Id) SetState();
                appoint = value;
            }
        }

        /// <summary>
        ///     ������������ ��������
        /// </summary>
        public string TrackInfo
        {
            get { return Appoint.TrackInfo; }
        }

        /// <summary>
        ///     �������� � ������������
        /// </summary>
        public string DriverInfo
        {
            get { return Appoint.DriverInfo; }
        }

        #endregion

        private EnumerationItem docState;
        /// <summary>
        ///     ��������� (������������)
        /// </summary>
        [EPVGridColumn(0, "���������")]
        [DataReference("docState")]
        public EnumerationItem DocState
        {
            get { return docState; }
            set
            {
                if (docState.Id != value.Id) SetState();
                docState = value;
            }
        }

        private DateTime date;
        /// <summary>
        ///     ���� ����������� ���������
        /// </summary>
        [EPVGridColumn(1, "���� ���������")]
        [DataField("dateState")]
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date != value) SetState();
                date = value;
            }
        }

        private string reason;
        /// <summary>
        ///     ����������-���������
        /// </summary>
        [EPVGridColumn(2, "����� ���������", EPVGridColumnType.TextBox, 200)]
        [DataField("reason")]
        public string Reason
        {
            get { return reason; }
            set
            {
                if (reason != value) SetState();
                reason = value;
            }
        }

        public string IdleReason { get { return Appoint.IdleReason; } }

        #endregion

        #region ������������
        
        /// <summary>
        ///     ������� ������ �� ������ ������ ��
        /// </summary>
        /// <param name="reader">������ ��</param>
        /// <param name="apnt">���������</param>
        /// <param name="docStates">����� ��������� ���������</param>
        public AppointState(DbDataReader reader, Appoint apnt, Enumeration docStates)
        {
            appoint = apnt;
            docState = docStates.Find((int)reader["docState"]);
            date = (DateTime)reader["dateState"];
            reason = (string)reader["reason"];
        }

        /// <summary>
        ///     ������� ����� ��������� ��� ����������
        /// </summary>
        /// <param name="apnt">���������</param>
        /// <param name="dcSt">����� ���������</param>
        public AppointState(Appoint apnt, EnumerationItem dcSt)
        {
            appoint = apnt;
            docState = dcSt;
            date = DateTime.Now;
            reason = "";
            Insert();
        }

        #endregion

        #region ������

        /// <summary>
        ///     �������� �� �� ������ ���� �����������, ����������� � ������������ ��������� �� ������������ �����
        /// </summary>
        /// <param name="database">���� ������</param>
        /// <param name="point">����� ��������/��������</param>
        /// <param name="docState">���������</param>
        /// <returns>����� �������</returns>
        public static BindingList<AppointState> LoadList(EPVDatabase database, Point point, EnumerationItem docState)
        {
            Units unitList = new Units(database);
            States stateList = new States(database);
            Enumeration docStates =  new Enumeration(database, "docState");

            BindingList<AppointState> appointList = new BindingList<AppointState>();
            QueryParameters parameters = new QueryParameters("pointId", point.Id);
            parameters.Add("docState", docState.Id);

            DbDataReader reader = database.ExecuteReader(Classes.Queries.PointStateAppoins, parameters);
            while (reader.Read())
                appointList.Add(new AppointState(reader, new Appoint(reader, unitList, stateList, docStates), docStates));
            reader.Close();

            return appointList;
        }

        #endregion
    }
}
