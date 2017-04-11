using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EPV.Data;
using System.Data.Common;
using EPV.Database;

namespace DispatcherService.Classes
{
    public class MaterialPermitItem : EPVDataRow
    {
        #region Поля и свойства

        public MaterialPermit MaterialPermit { get; private set; }

        private string material;
        public string Material
        {
            get { return material; }
            set { SetField("material", value); }
        }

        private string materialUnit;
        public string MaterialUnit
        {
            get { return materialUnit; }
            set { SetField("materialUnit", value); }
        }

        private decimal quantity;
        public decimal Quantity
        {
            get { return quantity; }
            set { SetField("quantity", value); }
        }

        private decimal tonnage;
        public decimal Tonnage
        {
            get { return tonnage; }
            set { SetField("tonnage", value); }
        }

        #region Запросы

        public new string TableName
        {
            get
            {
                return DispatcherService.Resources.Doc.MaterialPermit.ItemTableName;
            }
        }

        protected override string QueryInsert
        {
            get
            {
                return DispatcherService.Resources.Doc.MaterialPermit.ItemInsert;
            }
        }

        protected override string QueryUpdate
        {
            get
            {
                return DispatcherService.Resources.Doc.MaterialPermit.ItemUpdate;
            }
        }

        protected override string QueryDelete
        {
            get
            {
                return DispatcherService.Resources.Doc.MaterialPermit.ItemDelete;
            }
        }

        private static string QueryLoadList
        {
            get
            {
                return DispatcherService.Resources.Doc.MaterialPermit.ItemLoadList;
            }
        }

        #endregion
        #endregion

        #region Конструкторы

        public MaterialPermitItem(MaterialPermit document)
        {
            id = -1;
            MaterialPermit = document;
            material = "";
            materialUnit = "шт.";
            quantity = 1;
            tonnage = 0;

            Insert();
        }

        public MaterialPermitItem(MaterialPermit document, DbDataReader reader)
        {
            id = (int)reader["id"];
            MaterialPermit = document;
            material = (string)reader["material"];
            materialUnit = (string)reader["materialUnit"];
            quantity = (decimal)reader["quantity"];
            tonnage = (decimal)reader["tonnage"];
        }

        #endregion

        #region Методы

        public static List<MaterialPermitItem> LoadList(MaterialPermit document, EPVDatabase database)
        {
            List<MaterialPermitItem> itemList = new List<MaterialPermitItem>();

            QueryParameters parameters = new QueryParameters("document", document.Id);

            using (DbDataReader reader = database.ExecuteReader(QueryLoadList, parameters))
            {
                while (reader.Read())
                    itemList.Add(new MaterialPermitItem(document, reader));

                reader.Close();
            }

            return itemList;
        }

        public override void Save(EPVDatabase database)
        {
            switch (State)
            {
                case RowState.Inserted:
                    SaveInsertedRow(database);
                    break;

                case RowState.Modified:
                    SaveModifiedRow(database);
                    break;

                case RowState.Deleted:
                    SaveDeletedRow(database);
                    break;
            }

            State = RowState.Readed;
        }

        private void SaveInsertedRow(EPVDatabase database)
        {
            Id = ((FirebirdDatabase)database).Generator(TableName);
            database.ExecuteQuery(QueryInsert, CreateParameters());
        }

        private QueryParameters CreateParameters()
        {
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("document", MaterialPermit.Id);
            parameters.Add("material", Material);
            parameters.Add("materialUnit", MaterialUnit);
            parameters.Add("quantity", Quantity);
            parameters.Add("tonnage", Tonnage);

            return parameters;
        }

        private void SaveModifiedRow(EPVDatabase database)
        {
            database.ExecuteQuery(QueryUpdate, CreateParameters());
        }

        private void SaveDeletedRow(EPVDatabase database)
        {
            QueryParameters parameters = new QueryParameters("id", Id);

            database.ExecuteQuery(QueryDelete, parameters);
        }

        #endregion
    }
}
