namespace DispatcherService
{
    partial class MaterialPermitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialPermitForm));
            this.bsDocument = new System.Windows.Forms.BindingSource(this.components);
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.pickBaseDocDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxBaseDocNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxBaseDocument = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxLicensePlate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxVehicleMark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxDocNumber = new System.Windows.Forms.TextBox();
            this.pickDocDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxPermit = new System.Windows.Forms.TextBox();
            this.btnFindPermit = new System.Windows.Forms.Button();
            this.gboxItemList = new System.Windows.Forms.GroupBox();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.ColumnMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaterialUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTonnage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsItemList = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addItemTool = new System.Windows.Forms.ToolStripButton();
            this.tboxComment = new System.Windows.Forms.TextBox();
            this.deleteItemTool = new System.Windows.Forms.ToolStripButton();
            this.lboxAutoComplete = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelData.SuspendLayout();
            this.gboxItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnOK);
            this.panelBottom.Controls.Add(this.btnSave);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 448);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(5);
            this.panelBottom.Size = new System.Drawing.Size(784, 35);
            this.panelBottom.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(479, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(579, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(679, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelData
            // 
            this.panelData.ColumnCount = 3;
            this.panelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.panelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelData.Controls.Add(this.label10, 0, 9);
            this.panelData.Controls.Add(this.pickBaseDocDate, 1, 7);
            this.panelData.Controls.Add(this.label9, 0, 7);
            this.panelData.Controls.Add(this.tboxBaseDocNumber, 1, 6);
            this.panelData.Controls.Add(this.label8, 0, 6);
            this.panelData.Controls.Add(this.tboxBaseDocument, 1, 5);
            this.panelData.Controls.Add(this.label7, 0, 5);
            this.panelData.Controls.Add(this.tboxLicensePlate, 1, 4);
            this.panelData.Controls.Add(this.label5, 0, 4);
            this.panelData.Controls.Add(this.tboxVehicleMark, 1, 3);
            this.panelData.Controls.Add(this.label4, 0, 3);
            this.panelData.Controls.Add(this.tboxPerson, 1, 2);
            this.panelData.Controls.Add(this.label3, 0, 2);
            this.panelData.Controls.Add(this.label2, 0, 1);
            this.panelData.Controls.Add(this.label1, 0, 0);
            this.panelData.Controls.Add(this.tboxDocNumber, 1, 0);
            this.panelData.Controls.Add(this.pickDocDate, 1, 1);
            this.panelData.Controls.Add(this.label6, 2, 0);
            this.panelData.Controls.Add(this.tboxPermit, 2, 1);
            this.panelData.Controls.Add(this.btnFindPermit, 2, 2);
            this.panelData.Controls.Add(this.gboxItemList, 1, 8);
            this.panelData.Controls.Add(this.tboxComment, 1, 9);
            this.panelData.Controls.Add(this.lboxAutoComplete, 0, 8);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 0);
            this.panelData.Name = "panelData";
            this.panelData.Padding = new System.Windows.Forms.Padding(5);
            this.panelData.RowCount = 10;
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.panelData.Size = new System.Drawing.Size(784, 448);
            this.panelData.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(125, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 75);
            this.label10.TabIndex = 20;
            this.label10.Text = "Комментарий";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pickBaseDocDate
            // 
            this.pickBaseDocDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pickBaseDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickBaseDocDate.Location = new System.Drawing.Point(208, 193);
            this.pickBaseDocDate.Name = "pickBaseDocDate";
            this.pickBaseDocDate.Size = new System.Drawing.Size(120, 20);
            this.pickBaseDocDate.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Location = new System.Drawing.Point(169, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Дата";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxBaseDocNumber
            // 
            this.tboxBaseDocNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.tboxBaseDocNumber.Location = new System.Drawing.Point(208, 167);
            this.tboxBaseDocNumber.Name = "tboxBaseDocNumber";
            this.tboxBaseDocNumber.Size = new System.Drawing.Size(120, 20);
            this.tboxBaseDocNumber.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(161, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Номер";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxBaseDocument
            // 
            this.tboxBaseDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxBaseDocument.Location = new System.Drawing.Point(208, 141);
            this.tboxBaseDocument.Name = "tboxBaseDocument";
            this.tboxBaseDocument.Size = new System.Drawing.Size(281, 20);
            this.tboxBaseDocument.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(139, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Основание";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxLicensePlate
            // 
            this.tboxLicensePlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxLicensePlate.Location = new System.Drawing.Point(208, 115);
            this.tboxLicensePlate.Name = "tboxLicensePlate";
            this.tboxLicensePlate.Size = new System.Drawing.Size(281, 20);
            this.tboxLicensePlate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(139, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Гос. номер";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxVehicleMark
            // 
            this.tboxVehicleMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxVehicleMark.Location = new System.Drawing.Point(208, 89);
            this.tboxVehicleMark.Name = "tboxVehicleMark";
            this.tboxVehicleMark.Size = new System.Drawing.Size(281, 20);
            this.tboxVehicleMark.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(98, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Марка автомобиля";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxPerson
            // 
            this.tboxPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxPerson.Location = new System.Drawing.Point(208, 60);
            this.tboxPerson.Name = "tboxPerson";
            this.tboxPerson.Size = new System.Drawing.Size(281, 20);
            this.tboxPerson.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(121, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Предъявитель";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(112, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата документа";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(127, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ документа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxDocNumber
            // 
            this.tboxDocNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.tboxDocNumber.Location = new System.Drawing.Point(208, 8);
            this.tboxDocNumber.Name = "tboxDocNumber";
            this.tboxDocNumber.Size = new System.Drawing.Size(120, 20);
            this.tboxDocNumber.TabIndex = 0;
            // 
            // pickDocDate
            // 
            this.pickDocDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pickDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDocDate.Location = new System.Drawing.Point(208, 34);
            this.pickDocDate.Name = "pickDocDate";
            this.pickDocDate.Size = new System.Drawing.Size(120, 20);
            this.pickDocDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(624, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "К автомобильному пропуску";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tboxPermit
            // 
            this.tboxPermit.Dock = System.Windows.Forms.DockStyle.Right;
            this.tboxPermit.Location = new System.Drawing.Point(627, 34);
            this.tboxPermit.Name = "tboxPermit";
            this.tboxPermit.Size = new System.Drawing.Size(149, 20);
            this.tboxPermit.TabIndex = 11;
            this.tboxPermit.TabStop = false;
            // 
            // btnFindPermit
            // 
            this.btnFindPermit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFindPermit.Location = new System.Drawing.Point(676, 60);
            this.btnFindPermit.Name = "btnFindPermit";
            this.btnFindPermit.Size = new System.Drawing.Size(100, 23);
            this.btnFindPermit.TabIndex = 12;
            this.btnFindPermit.TabStop = false;
            this.btnFindPermit.Text = "Найти...";
            this.btnFindPermit.UseVisualStyleBackColor = true;
            // 
            // gboxItemList
            // 
            this.panelData.SetColumnSpan(this.gboxItemList, 2);
            this.gboxItemList.Controls.Add(this.dgvItemList);
            this.gboxItemList.Controls.Add(this.toolStrip1);
            this.gboxItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxItemList.Location = new System.Drawing.Point(208, 219);
            this.gboxItemList.Name = "gboxItemList";
            this.gboxItemList.Size = new System.Drawing.Size(568, 146);
            this.gboxItemList.TabIndex = 8;
            this.gboxItemList.TabStop = false;
            this.gboxItemList.Text = "Список материалов";
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.AutoGenerateColumns = false;
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaterial,
            this.ColumnMaterialUnit,
            this.ColumnQuantity,
            this.ColumnTonnage});
            this.dgvItemList.DataSource = this.bsItemList;
            this.dgvItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemList.Location = new System.Drawing.Point(3, 41);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.Size = new System.Drawing.Size(562, 102);
            this.dgvItemList.TabIndex = 0;
            // 
            // ColumnMaterial
            // 
            this.ColumnMaterial.DataPropertyName = "Material";
            this.ColumnMaterial.FillWeight = 300F;
            this.ColumnMaterial.HeaderText = "Материал";
            this.ColumnMaterial.Name = "ColumnMaterial";
            // 
            // ColumnMaterialUnit
            // 
            this.ColumnMaterialUnit.DataPropertyName = "MaterialUnit";
            this.ColumnMaterialUnit.FillWeight = 50F;
            this.ColumnMaterialUnit.HeaderText = "Ед. измер.";
            this.ColumnMaterialUnit.Name = "ColumnMaterialUnit";
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            this.ColumnQuantity.FillWeight = 50F;
            this.ColumnQuantity.HeaderText = "Кол-во";
            this.ColumnQuantity.Name = "ColumnQuantity";
            // 
            // ColumnTonnage
            // 
            this.ColumnTonnage.DataPropertyName = "Tonnage";
            this.ColumnTonnage.FillWeight = 50F;
            this.ColumnTonnage.HeaderText = "Вес (т.)";
            this.ColumnTonnage.Name = "ColumnTonnage";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemTool,
            this.deleteItemTool});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(562, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Список материалов";
            // 
            // addItemTool
            // 
            this.addItemTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addItemTool.Image = ((System.Drawing.Image)(resources.GetObject("addItemTool.Image")));
            this.addItemTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addItemTool.Name = "addItemTool";
            this.addItemTool.Size = new System.Drawing.Size(23, 22);
            this.addItemTool.Text = "добавить строку";
            this.addItemTool.Click += new System.EventHandler(this.addItemTool_Click);
            // 
            // tboxComment
            // 
            this.panelData.SetColumnSpan(this.tboxComment, 2);
            this.tboxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxComment.Location = new System.Drawing.Point(208, 371);
            this.tboxComment.Multiline = true;
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.Size = new System.Drawing.Size(568, 69);
            this.tboxComment.TabIndex = 9;
            // 
            // deleteItemTool
            // 
            this.deleteItemTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteItemTool.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemTool.Image")));
            this.deleteItemTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteItemTool.Name = "deleteItemTool";
            this.deleteItemTool.Size = new System.Drawing.Size(23, 22);
            this.deleteItemTool.Text = "toolStripButton1";
            this.deleteItemTool.Click += new System.EventHandler(this.deleteItemTool_Click);
            // 
            // lboxAutoComplete
            // 
            this.lboxAutoComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxAutoComplete.FormattingEnabled = true;
            this.lboxAutoComplete.Location = new System.Drawing.Point(8, 219);
            this.lboxAutoComplete.Name = "lboxAutoComplete";
            this.lboxAutoComplete.Size = new System.Drawing.Size(194, 146);
            this.lboxAutoComplete.TabIndex = 21;
            this.lboxAutoComplete.DoubleClick += new System.EventHandler(this.lboxAutoComplete_DoubleClick);
            // 
            // MaterialPermitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 483);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelBottom);
            this.Name = "MaterialPermitForm";
            this.Text = "MaterialPermitForm";
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.gboxItemList.ResumeLayout(false);
            this.gboxItemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDocument;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel panelData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker pickBaseDocDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxBaseDocNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxBaseDocument;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxLicensePlate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxVehicleMark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxDocNumber;
        private System.Windows.Forms.DateTimePicker pickDocDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxPermit;
        private System.Windows.Forms.Button btnFindPermit;
        private System.Windows.Forms.GroupBox gboxItemList;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaterialUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTonnage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox tboxComment;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripButton addItemTool;
        private System.Windows.Forms.BindingSource bsItemList;
        private System.Windows.Forms.ToolStripButton deleteItemTool;
        private System.Windows.Forms.ListBox lboxAutoComplete;
    }
}