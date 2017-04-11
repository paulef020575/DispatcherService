using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EPV.Data;
using System.Data.Common;
using EPV.Database;
using System.Drawing;
using EPV.Forms;
using System.ComponentModel;
using System.IO;

namespace DispatcherService.Classes
{
    [DataTable("docMaterialPermit")]
    public class MaterialPermit : EPVDataRow
    {
        #region Поля и свойства

        private Unit unit;
        public Unit Unit
        {
            get { return unit; }
            set { SetField("unit", value); }
        }

        private string docNumber;
        public string DocNumber
        {
            get { return docNumber; }
            set { SetField("docNumber", value); }
        }

        private DateTime docDate;
        public DateTime DocDate
        {
            get { return docDate; }
            set { SetField("docDate", value); }
        }

        public string Header { get { return ToString(); } }

        private string person;
        public string Person
        {
            get { return person; }
            set { SetField("person", value); }
        }

        private string vehicleMark;
        public string VehicleMark
        {
            get { return vehicleMark; }
            set { SetField("vehicleMark", value); }
        }

        private string licensePlate;
        public string LicensePlate
        {
            get { return licensePlate; }
            set { SetField("licensePlate", value); }
        }

        public string Vehicle { get { return VehicleMark + " " + LicensePlate; } }

        private short createFlag;
        public short CreateFlag
        {
            get { return createFlag; }
            set { SetField("createFlag", value); }
        }

        public Image CreateFlagImage { get { return GetImage(CreateFlag); } }

        private SecurityUser creator;
        public SecurityUser Creator
        {
            get { return creator; }
            set { SetField("creator", value); }
        }

        private DateTime createDate;
        public DateTime CreateDate
        {
            get { return createDate; }
            set { SetField("createDate", value); }
        }

        private short signedFlag;
        public short SignedFlag
        {
            get { return signedFlag; }
            set { SetField("signedFlag", value); }
        }

        public Image SignedFlagImage { get { return GetImage(SignedFlag); } }

        private SecurityUser signer;
        public SecurityUser Signer
        {
            get { return signer; }
            set { SetField("signer", value); }
        }

        private DateTime signDate;
        public DateTime SignDate
        {
            get { return signDate; }
            set { SetField("signDate", value); }
        }

        private short entryFlag;
        public short EntryFlag
        {
            get { return entryFlag; }
            set { SetField("entryFlag", value); }
        }

        public Image EntryFlagImage { get { return GetImage(EntryFlag); } }
        
        private EntryPoint entryPoint;
        public EntryPoint EntryPoint
        {
            get { return entryPoint; }
            set { SetField("entryPoint", value); }
        }

        private DateTime entryDate;
        public DateTime EntryDate
        {
            get { return entryDate; }
            set { SetField("entryDate", value); }
        }

        private string comment;
        public string Comment
        {
            get { return comment; }
            set { SetField("comment", value); }
        }

        public ISystemUser Modifier { get; private set; }

        public int PermitId { get; private set; }

        private string baseDocument;
        public string BaseDocument
        {
            get { return baseDocument; }
            set { SetField("baseDocument", value); }
        }

        private string baseDocNumber;
        public string BaseDocNumber
        {
            get { return baseDocNumber; }
            set { SetField("baseDocNumber", value); }
        }

        private DateTime baseDocDate;
        public DateTime BaseDocDate
        {
            get { return baseDocDate; }
            set { SetField("baseDocDate", value); }
        }

        public string BaseDocString 
        { 
            get { return BaseDocument + " №" + BaseDocNumber + " от " + BaseDocDate.ToShortDateString(); } 
        }

        public bool IsNew { get; private set; }

        #region Запросы

        
        protected override string QueryInsert
        {
            get
            {
                return DispatcherService.Resources.Doc.MaterialPermit.Insert; 
            }
        }

        protected override string QueryUpdate
        {
            get
            {
                return DispatcherService.Resources.Doc.MaterialPermit.Update;
            }
        }

        protected override string QueryDelete
        {
            get
            {
                return DispatcherService.Resources.Doc.MaterialPermit.Delete;
            }
        }

        private static string LoadQuery
        {
            get
            {
                return DispatcherService.Resources.Doc.MaterialPermit.Load;
            }
        }

        private static string LoadListQuery
        {
            get
            {
                return DispatcherService.Resources.Doc.MaterialPermit.LoadList;
            }
        }

        #endregion

        private BindingList<MaterialPermitItem> itemList;

        private List<MaterialPermitItem> removedItemList;

        #endregion

        #region Конструкторы

        public MaterialPermit(Unit unit)
        {
            id = 0;
            this.unit = unit;
            docNumber = "";
            docDate = DateTime.Today;
            person = "";
            vehicleMark = "";
            licensePlate = "";

            createFlag = 0;
            creator = null;
            createDate = DateTime.MinValue;

            signedFlag = 0;
            signer = null;
            signDate = DateTime.MinValue;

            entryFlag = 0;
            entryPoint = null;
            entryDate = DateTime.MinValue;

            comment = "";

            PermitId = 0;

            baseDocument = "доверенность";
            baseDocNumber = "";
            baseDocDate = DateTime.Today;

            IsNew = false;

            Insert();
        }

        public MaterialPermit(Appoint appoint)
        {
            id = 0;
            this.unit = appoint.Unit;
            docNumber = "";
            docDate = DateTime.Today;
            person = appoint.DriverName;
            vehicleMark = appoint.TrackMark;
            licensePlate = appoint.LicensePlate;

            createFlag = 0;
            creator = null;
            createDate = DateTime.MinValue;

            signedFlag = 0;
            signer = null;
            signDate = DateTime.MinValue;

            entryFlag = 0;
            entryPoint = null;
            entryDate = DateTime.MinValue;

            comment = "";

            PermitId = appoint.PermitId;

            baseDocument = "доверенность";
            baseDocNumber = appoint.Warrant;
            baseDocDate = DateTime.Today;

            IsNew = false;
            Insert();
        }

        public MaterialPermit(Permit permit)
        {
            id = 0;
            this.unit = Unit.Empty;
            docNumber = "";
            docDate = DateTime.Today;
            person = permit.DriverName;
            vehicleMark = permit.Vehicle.VehicleMark.ToString();
            licensePlate = permit.Vehicle.LicensePlate;

            createFlag = 0;
            creator = null;
            createDate = DateTime.MinValue;

            signedFlag = 0;
            signer = null;
            signDate = DateTime.MinValue;

            entryFlag = 0;
            entryPoint = null;
            entryDate = DateTime.MinValue;

            comment = "К пропуску № " + permit.ToString();

            PermitId = permit.Id;

            baseDocument = "доверенность";
            baseDocNumber = "";
            baseDocDate = DateTime.Today;

            IsNew = false;

            Insert();
        }

        public MaterialPermit(DbDataReader reader)
        {
            id = (int)reader["id"];
            unit = new Unit((int)reader["unitId"], (string)reader["unitName"]);
            docNumber = (string)reader["docNumber"];
            docDate = (DateTime)reader["docDate"];

            person = (string)reader["person"];
            vehicleMark = (string)reader["vehicleMark"];
            licensePlate = (string)reader["licensePlate"];

            createFlag = (short)reader["createFlag"];
            if (!DBNull.Value.Equals(reader["creator"]))
            {
                creator = new SecurityUser((int)reader["creator"], (string)reader["creatorName"]);
                createDate = (DateTime)reader["createDate"];
            }
            else
            {
                creator = null;
                createDate = DateTime.MinValue;
            }

            signedFlag = (short)reader["signedFlag"];
            if (!DBNull.Value.Equals(reader["signer"]))
            {
                signer = new SecurityUser((int)reader["signer"], (string)reader["signerName"]);
                signDate = (DateTime)reader["signDate"];
            }
            else
            {
                signer = null;
                signDate = DateTime.MinValue;
            }

            entryFlag = (short)reader["entryFlag"];
            if (!DBNull.Value.Equals(reader["entryPoint"]))
            {
                entryPoint = new EntryPoint((int)reader["entryPoint"], (string)reader["entryPointName"]);
                entryDate = (DateTime)reader["entryDate"];
            }
            else
            {
                entryPoint = null;
                entryDate = DateTime.MinValue;
            }

            comment = (string)reader["comment"];

            PermitId = (int)(DBNull.Value.Equals(reader["autoPermit"]) ? 0 : reader["autoPermit"]);

            baseDocument = (string)(DBNull.Value.Equals(reader["baseDocument"]) ? "" : reader["baseDocument"]);
            baseDocNumber = (string)(DBNull.Value.Equals(reader["baseDocNumber"]) ? "" : reader["baseDocNumber"]);
            baseDocDate = (DateTime)(DBNull.Value.Equals(reader["baseDocDate"]) ? DateTime.Today : reader["baseDocDate"]);

            IsNew = ((short)reader["isNew"] > 0);
        }

        #endregion

        #region  Методы

        public static MaterialPermit Load(EPVDatabase database, int id)
        {
            MaterialPermit materialPermit = null;
            QueryParameters parameters = new QueryParameters("id", id);

            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    materialPermit = new MaterialPermit(reader);

                reader.Close();
            }

            if (materialPermit == null)
                throw new ArgumentException(DispatcherService.Resources.Error.WrongIdentifier);

            return materialPermit;
        }

        public MaterialPermit LoadCopy(EPVDatabase database)
        {
            return MaterialPermit.Load(database, Id);
        }

        public static List<MaterialPermit> LoadList(EPVDatabase database, Unit unit,
                                                    DateTime dateFrom, DateTime dateTo, ISystemUser user)
        {
            List<MaterialPermit> documentList = new List<MaterialPermit>();


            QueryParameters parameters = new QueryParameters("unit", unit.Id);
            parameters.Add("dateFrom", dateFrom);
            parameters.Add("dateTo", dateTo);
            parameters.Add("userId", user.Id);

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery, parameters))
            {
                while (reader.Read())
                    documentList.Add(new MaterialPermit(reader));

                reader.Close();
            }

            return documentList;
        }

        public void Save(EPVDatabase database, ISystemUser modifier)
        {
            Modifier = modifier;
            Save(database);
        }

        private new void Save(EPVDatabase database)
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

            SaveItems(database);
            State = RowState.Readed;
        }

        private void SaveInsertedRow(EPVDatabase database)
        {
            id = ((FirebirdDatabase)database).Generator(TableName);

            database.ExecuteQuery(QueryInsert, CreateParameters());
        }

        private  QueryParameters CreateParameters()
        {
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("unitId", Unit.Id);
            parameters.Add("docNumber", DocNumber);
            parameters.Add("docDate", DocDate);
            parameters.Add("person", Person);
            parameters.Add("vehicleMark", VehicleMark);
            parameters.Add("licensePlate", LicensePlate);
            
            parameters.Add("createFlag", CreateFlag);
            if (Creator != null)
            {
                parameters.Add("creator", Creator.Id);
                parameters.Add("createDate", CreateDate);
            }
            else
            {
                parameters.Add("creator", DBNull.Value);
                parameters.Add("createDate", DBNull.Value);
            }

            parameters.Add("signedFlag", SignedFlag);
            if (Signer != null)
            {
                parameters.Add("signer", Signer.Id);
                parameters.Add("signDate", SignDate);
            }
            else
            {
                parameters.Add("signer", DBNull.Value);
                parameters.Add("signDate", DBNull.Value);
            }

            parameters.Add("entryFlag", EntryFlag);
            if (EntryPoint != null)
            {
                parameters.Add("entryPoint", EntryPoint.Id);
                parameters.Add("entryDate", EntryDate);
            }
            else
            {
                parameters.Add("entryPoint", DBNull.Value);
                parameters.Add("entryDate", DBNull.Value);
            }

            parameters.Add("comment", Comment);
            parameters.Add("modifier", Modifier.Id);

            if (PermitId > 0)
                parameters.Add("autoPermit", PermitId);
            else
                parameters.Add("autoPermit", DBNull.Value);

            parameters.Add("baseDocument", BaseDocument);
            parameters.Add("baseDocNumber", BaseDocNumber);
            parameters.Add("baseDocDate", baseDocDate);

            return parameters;
        }

        private void SaveModifiedRow(EPVDatabase database)
        {
            database.ExecuteQuery(QueryUpdate, CreateParameters());
        }

        private void SaveDeletedRow(EPVDatabase database)
        {
            QueryParameters parameters = new QueryParameters("id", Id);
            parameters.Add("userId", Modifier.Id);
            database.ExecuteQuery(QueryDelete, parameters);
        }

        private void SaveItems(EPVDatabase database)
        {
            if (itemList != null)
                foreach (MaterialPermitItem item in itemList)
                    item.Save(database);

            if (removedItemList != null)
            {
                foreach (MaterialPermitItem item in removedItemList)
                {
                    item.Delete();
                    item.Save(database);
                }

                removedItemList.Clear();
            }
        }

        public BindingList<MaterialPermitItem> GetItemList(EPVDatabase database)
        {
            if (itemList == null)
                itemList = new BindingList<MaterialPermitItem>(MaterialPermitItem.LoadList(this, database));

            return itemList;
        }

        public Image GetImage(short flag)
        {
            switch (flag)
            {
                case -1:
                    return DispatcherService.Resources.Image.Failed;

                case 1:
                    return DispatcherService.Resources.Image.Checked;

                default:
                    return DispatcherService.Resources.Image.Quest;
            }
        }

        public override string ToString()
        {
            return DocNumber + " от " + DocDate.ToShortDateString();
        }

        public MaterialPermitItem AddItem()
        {
            if (itemList == null)
                itemList = new BindingList<MaterialPermitItem>();

            int id = -1;

            foreach (MaterialPermitItem item in itemList)
                if (id >= item.Id)
                    id = item.Id - 1;

            MaterialPermitItem newItem = new MaterialPermitItem(this);
            newItem.Id = id;

            itemList.Add(newItem);

            SetState();
            return newItem;
        }

        public void RemoveItem(MaterialPermitItem item)
        {
            if (itemList != null)
                itemList.Remove(item);

            if (removedItemList == null)
                removedItemList = new List<MaterialPermitItem>();

            removedItemList.Add(item);

            SetState();
        }
        #endregion

        internal void MarkCreated(short value, EPVDatabase database, ISystemUser user)
        {
            CreateFlag = value;
            Creator = (SecurityUser)user;
            CreateDate = DateTime.Now;

            Save(database, user);
        }

        internal void MarkSigned(short value, EPVDatabase Database, ISystemUser User)
        {
            SignedFlag = value;
            Signer = (SecurityUser)User;
            SignDate = DateTime.Now;

            Save(Database, User);
        }

        internal void ClearNew(EPVDatabase database, ISystemUser user)
        {
            string query = DispatcherService.Resources.Doc.MaterialPermit.ClearNew;
            QueryParameters parameters = new QueryParameters("documentId", Id);
            parameters.Add("userId", user.Id);

            database.ExecuteQuery(query, parameters);

            IsNew = false;
        }

    }
}
