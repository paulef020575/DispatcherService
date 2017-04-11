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
    ///     класс "Состояние транспорта"
    /// </summary>
    [DataTable("docAppointStates")]
    public class AppointState : EPVDataRow
    {
        #region Поля и свойства

        #region Свойства класса Appoint

        private Appoint appoint;
        /// <summary>
        ///     Прибывший транспорт
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
        ///     Транспортное средство
        /// </summary>
        public string TrackInfo
        {
            get { return Appoint.TrackInfo; }
        }

        /// <summary>
        ///     водитель с координатами
        /// </summary>
        public string DriverInfo
        {
            get { return Appoint.DriverInfo; }
        }

        #endregion

        private EnumerationItem docState;
        /// <summary>
        ///     Состояние (перечисление)
        /// </summary>
        [EPVGridColumn(0, "состояние")]
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
        ///     дата наступления состояния
        /// </summary>
        [EPVGridColumn(1, "дата изменения")]
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
        ///     примечание-сообщение
        /// </summary>
        [EPVGridColumn(2, "текст сообщения", EPVGridColumnType.TextBox, 200)]
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

        #region Конструкторы
        
        /// <summary>
        ///     создает объект на основе строки БД
        /// </summary>
        /// <param name="reader">строка БД</param>
        /// <param name="apnt">Транспорт</param>
        /// <param name="docStates">набор возможных состояний</param>
        public AppointState(DbDataReader reader, Appoint apnt, Enumeration docStates)
        {
            appoint = apnt;
            docState = docStates.Find((int)reader["docState"]);
            date = (DateTime)reader["dateState"];
            reason = (string)reader["reason"];
        }

        /// <summary>
        ///     создает новое состояние для транспорта
        /// </summary>
        /// <param name="apnt">транспорт</param>
        /// <param name="dcSt">новое состояние</param>
        public AppointState(Appoint apnt, EnumerationItem dcSt)
        {
            appoint = apnt;
            docState = dcSt;
            date = DateTime.Now;
            reason = "";
            Insert();
        }

        #endregion

        #region Методы

        /// <summary>
        ///     Получает из БД список всех транспортов, находящихся в определенном состоянии на определенной точке
        /// </summary>
        /// <param name="database">База данных</param>
        /// <param name="point">Точка погрузки/выгрузки</param>
        /// <param name="docState">состояние</param>
        /// <returns>набор записей</returns>
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
