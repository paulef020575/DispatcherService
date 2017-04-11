namespace DispatcherService
{
    partial class MaterialPermitListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialPermitListForm));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ColumnDocNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreateFlag = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnSignedFlag = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnEntryFlag = new System.Windows.Forms.DataGridViewImageColumn();
            this.bsDocumentList = new System.Windows.Forms.BindingSource(this.components);
            this.listToolStrip = new System.Windows.Forms.ToolStrip();
            this.addDocumentTool = new System.Windows.Forms.ToolStripButton();
            this.editDocumentTool = new System.Windows.Forms.ToolStripButton();
            this.deleteDocumentTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshListTool = new System.Windows.Forms.ToolStripButton();
            this.refreshingLabel = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.periodPicker1 = new EPV.Controls.PeriodPicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gboxComment = new System.Windows.Forms.GroupBox();
            this.tboxComment = new System.Windows.Forms.TextBox();
            this.tboxBaseDocument = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxVehicle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxHeader = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEntryPoint = new System.Windows.Forms.Label();
            this.lblSigner = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnFailSign = new System.Windows.Forms.Button();
            this.btnFailCreate = new System.Windows.Forms.Button();
            this.pboxEntryFlag = new System.Windows.Forms.PictureBox();
            this.pboxSignedFlag = new System.Windows.Forms.PictureBox();
            this.pboxCreateFlag = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblCreator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxPerson = new System.Windows.Forms.TextBox();
            this.gboxItemList = new System.Windows.Forms.GroupBox();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.ColumnMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaterialUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTonnage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgRefreshing = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconTimer = new System.Windows.Forms.Timer(this.components);
            this.clearNewTimer = new System.Windows.Forms.Timer(this.components);
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentList)).BeginInit();
            this.listToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gboxComment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEntryFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSignedFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCreateFlag)).BeginInit();
            this.gboxItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.button1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 482);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(5);
            this.panelBottom.Size = new System.Drawing.Size(888, 35);
            this.panelBottom.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(783, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvList);
            this.splitContainer1.Panel1.Controls.Add(this.listToolStrip);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(888, 482);
            this.splitContainer1.SplitterDistance = 534;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDocNumber,
            this.ColumnDocDate,
            this.ColumnCreateFlag,
            this.ColumnSignedFlag,
            this.ColumnEntryFlag});
            this.dgvList.DataSource = this.bsDocumentList;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 56);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(534, 426);
            this.dgvList.TabIndex = 1;
            this.dgvList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvList_RowPrePaint);
            // 
            // ColumnDocNumber
            // 
            this.ColumnDocNumber.DataPropertyName = "DocNumber";
            this.ColumnDocNumber.HeaderText = "№ документа";
            this.ColumnDocNumber.Name = "ColumnDocNumber";
            this.ColumnDocNumber.ReadOnly = true;
            // 
            // ColumnDocDate
            // 
            this.ColumnDocDate.DataPropertyName = "DocDate";
            this.ColumnDocDate.HeaderText = "Дата документа";
            this.ColumnDocDate.Name = "ColumnDocDate";
            this.ColumnDocDate.ReadOnly = true;
            // 
            // ColumnCreateFlag
            // 
            this.ColumnCreateFlag.DataPropertyName = "CreateFlagImage";
            this.ColumnCreateFlag.HeaderText = "кладовщик";
            this.ColumnCreateFlag.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnCreateFlag.Name = "ColumnCreateFlag";
            this.ColumnCreateFlag.ReadOnly = true;
            // 
            // ColumnSignedFlag
            // 
            this.ColumnSignedFlag.DataPropertyName = "SignedFlagImage";
            this.ColumnSignedFlag.HeaderText = "руковод.";
            this.ColumnSignedFlag.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnSignedFlag.Name = "ColumnSignedFlag";
            this.ColumnSignedFlag.ReadOnly = true;
            // 
            // ColumnEntryFlag
            // 
            this.ColumnEntryFlag.DataPropertyName = "EntryFlagImage";
            this.ColumnEntryFlag.HeaderText = "выезд";
            this.ColumnEntryFlag.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnEntryFlag.Name = "ColumnEntryFlag";
            this.ColumnEntryFlag.ReadOnly = true;
            // 
            // bsDocumentList
            // 
            this.bsDocumentList.CurrentChanged += new System.EventHandler(this.bsDocumentList_CurrentChanged);
            // 
            // listToolStrip
            // 
            this.listToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDocumentTool,
            this.editDocumentTool,
            this.deleteDocumentTool,
            this.toolStripSeparator1,
            this.refreshListTool,
            this.refreshingLabel});
            this.listToolStrip.Location = new System.Drawing.Point(0, 31);
            this.listToolStrip.Name = "listToolStrip";
            this.listToolStrip.Size = new System.Drawing.Size(534, 25);
            this.listToolStrip.TabIndex = 0;
            this.listToolStrip.Text = "toolStrip1";
            // 
            // addDocumentTool
            // 
            this.addDocumentTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addDocumentTool.Image = ((System.Drawing.Image)(resources.GetObject("addDocumentTool.Image")));
            this.addDocumentTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addDocumentTool.Name = "addDocumentTool";
            this.addDocumentTool.Size = new System.Drawing.Size(23, 22);
            this.addDocumentTool.Text = "Новый документ";
            this.addDocumentTool.Click += new System.EventHandler(this.addDocumentTool_Click);
            // 
            // editDocumentTool
            // 
            this.editDocumentTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editDocumentTool.Image = ((System.Drawing.Image)(resources.GetObject("editDocumentTool.Image")));
            this.editDocumentTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editDocumentTool.Name = "editDocumentTool";
            this.editDocumentTool.Size = new System.Drawing.Size(23, 22);
            this.editDocumentTool.Text = "Изменить документ";
            this.editDocumentTool.Click += new System.EventHandler(this.editDocumentTool_Click);
            // 
            // deleteDocumentTool
            // 
            this.deleteDocumentTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteDocumentTool.Image = ((System.Drawing.Image)(resources.GetObject("deleteDocumentTool.Image")));
            this.deleteDocumentTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteDocumentTool.Name = "deleteDocumentTool";
            this.deleteDocumentTool.Size = new System.Drawing.Size(23, 22);
            this.deleteDocumentTool.Text = "Удалить документ";
            this.deleteDocumentTool.Click += new System.EventHandler(this.deleteDocumentTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshListTool
            // 
            this.refreshListTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshListTool.Image = ((System.Drawing.Image)(resources.GetObject("refreshListTool.Image")));
            this.refreshListTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshListTool.Name = "refreshListTool";
            this.refreshListTool.Size = new System.Drawing.Size(23, 22);
            this.refreshListTool.Text = "Обновить список";
            this.refreshListTool.Click += new System.EventHandler(this.refreshListTool_Click);
            // 
            // refreshingLabel
            // 
            this.refreshingLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshingLabel.Name = "refreshingLabel";
            this.refreshingLabel.Size = new System.Drawing.Size(97, 22);
            this.refreshingLabel.Text = "обновляем...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.periodPicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboxUnit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(534, 31);
            this.panel1.TabIndex = 2;
            // 
            // periodPicker1
            // 
            this.periodPicker1.DateFrom = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.periodPicker1.DateTo = new System.DateTime(2016, 3, 31, 23, 59, 59, 0);
            this.periodPicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.periodPicker1.Location = new System.Drawing.Point(290, 5);
            this.periodPicker1.MinimumSize = new System.Drawing.Size(200, 0);
            this.periodPicker1.Mode = EPV.Controls.PeriodPicker.PeriodPickerMode.Other;
            this.periodPicker1.Name = "periodPicker1";
            this.periodPicker1.Quarter = 0;
            this.periodPicker1.Size = new System.Drawing.Size(200, 21);
            this.periodPicker1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(233, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Период";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxUnit
            // 
            this.cboxUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboxUnit.FormattingEnabled = true;
            this.cboxUnit.Location = new System.Drawing.Point(96, 5);
            this.cboxUnit.Name = "cboxUnit";
            this.cboxUnit.Size = new System.Drawing.Size(137, 21);
            this.cboxUnit.TabIndex = 1;
            this.cboxUnit.SelectedIndexChanged += new System.EventHandler(this.cboxUnit_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Подразделение";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gboxComment, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tboxBaseDocument, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tboxVehicle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tboxHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxPerson, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gboxItemList, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 482);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gboxComment
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gboxComment, 2);
            this.gboxComment.Controls.Add(this.tboxComment);
            this.gboxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxComment.Location = new System.Drawing.Point(3, 427);
            this.gboxComment.Name = "gboxComment";
            this.gboxComment.Size = new System.Drawing.Size(344, 52);
            this.gboxComment.TabIndex = 11;
            this.gboxComment.TabStop = false;
            this.gboxComment.Text = "Комментарий";
            // 
            // tboxComment
            // 
            this.tboxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxComment.Location = new System.Drawing.Point(3, 16);
            this.tboxComment.Multiline = true;
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.ReadOnly = true;
            this.tboxComment.Size = new System.Drawing.Size(338, 33);
            this.tboxComment.TabIndex = 0;
            // 
            // tboxBaseDocument
            // 
            this.tboxBaseDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxBaseDocument.Location = new System.Drawing.Point(153, 286);
            this.tboxBaseDocument.Name = "tboxBaseDocument";
            this.tboxBaseDocument.ReadOnly = true;
            this.tboxBaseDocument.Size = new System.Drawing.Size(194, 20);
            this.tboxBaseDocument.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(84, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Основание";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxVehicle
            // 
            this.tboxVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxVehicle.Location = new System.Drawing.Point(153, 260);
            this.tboxVehicle.Name = "tboxVehicle";
            this.tboxVehicle.ReadOnly = true;
            this.tboxVehicle.Size = new System.Drawing.Size(194, 20);
            this.tboxVehicle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(78, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Автомобиль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Документ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxHeader
            // 
            this.tboxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxHeader.Location = new System.Drawing.Point(153, 3);
            this.tboxHeader.Name = "tboxHeader";
            this.tboxHeader.ReadOnly = true;
            this.tboxHeader.Size = new System.Drawing.Size(194, 20);
            this.tboxHeader.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подписи";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblEntryPoint, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblSigner, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSign, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnFailSign, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnFailCreate, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pboxEntryFlag, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.pboxSignedFlag, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pboxCreateFlag, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCreate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCreator, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(338, 180);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblEntryPoint
            // 
            this.lblEntryPoint.AutoSize = true;
            this.lblEntryPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntryPoint.Location = new System.Drawing.Point(51, 120);
            this.lblEntryPoint.Name = "lblEntryPoint";
            this.lblEntryPoint.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.SetRowSpan(this.lblEntryPoint, 2);
            this.lblEntryPoint.Size = new System.Drawing.Size(184, 60);
            this.lblEntryPoint.TabIndex = 11;
            this.lblEntryPoint.Text = "label2";
            this.lblEntryPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSigner
            // 
            this.lblSigner.AutoSize = true;
            this.lblSigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSigner.Location = new System.Drawing.Point(51, 60);
            this.lblSigner.Name = "lblSigner";
            this.lblSigner.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.SetRowSpan(this.lblSigner, 2);
            this.lblSigner.Size = new System.Drawing.Size(184, 60);
            this.lblSigner.TabIndex = 10;
            this.lblSigner.Text = "label2";
            this.lblSigner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSign
            // 
            this.btnSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSign.Location = new System.Drawing.Point(241, 63);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(94, 24);
            this.btnSign.TabIndex = 8;
            this.btnSign.Text = "подписать";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnFailSign
            // 
            this.btnFailSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFailSign.Location = new System.Drawing.Point(241, 93);
            this.btnFailSign.Name = "btnFailSign";
            this.btnFailSign.Size = new System.Drawing.Size(94, 24);
            this.btnFailSign.TabIndex = 5;
            this.btnFailSign.Text = "отклонить";
            this.btnFailSign.UseVisualStyleBackColor = true;
            this.btnFailSign.Click += new System.EventHandler(this.btnFailSign_Click);
            // 
            // btnFailCreate
            // 
            this.btnFailCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFailCreate.Location = new System.Drawing.Point(241, 33);
            this.btnFailCreate.Name = "btnFailCreate";
            this.btnFailCreate.Size = new System.Drawing.Size(94, 24);
            this.btnFailCreate.TabIndex = 4;
            this.btnFailCreate.Text = "отклонить";
            this.btnFailCreate.UseVisualStyleBackColor = true;
            this.btnFailCreate.Click += new System.EventHandler(this.btnFailCreate_Click);
            // 
            // pboxEntryFlag
            // 
            this.pboxEntryFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxEntryFlag.Location = new System.Drawing.Point(3, 123);
            this.pboxEntryFlag.Name = "pboxEntryFlag";
            this.tableLayoutPanel2.SetRowSpan(this.pboxEntryFlag, 2);
            this.pboxEntryFlag.Size = new System.Drawing.Size(42, 54);
            this.pboxEntryFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxEntryFlag.TabIndex = 2;
            this.pboxEntryFlag.TabStop = false;
            // 
            // pboxSignedFlag
            // 
            this.pboxSignedFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxSignedFlag.Location = new System.Drawing.Point(3, 63);
            this.pboxSignedFlag.Name = "pboxSignedFlag";
            this.tableLayoutPanel2.SetRowSpan(this.pboxSignedFlag, 2);
            this.pboxSignedFlag.Size = new System.Drawing.Size(42, 54);
            this.pboxSignedFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxSignedFlag.TabIndex = 1;
            this.pboxSignedFlag.TabStop = false;
            // 
            // pboxCreateFlag
            // 
            this.pboxCreateFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxCreateFlag.Location = new System.Drawing.Point(3, 3);
            this.pboxCreateFlag.Name = "pboxCreateFlag";
            this.tableLayoutPanel2.SetRowSpan(this.pboxCreateFlag, 2);
            this.pboxCreateFlag.Size = new System.Drawing.Size(42, 54);
            this.pboxCreateFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxCreateFlag.TabIndex = 0;
            this.pboxCreateFlag.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.Location = new System.Drawing.Point(241, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 24);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "подписать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreator.Location = new System.Drawing.Point(51, 0);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.SetRowSpan(this.lblCreator, 2);
            this.lblCreator.Size = new System.Drawing.Size(184, 60);
            this.lblCreator.TabIndex = 9;
            this.lblCreator.Text = "label2";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(66, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Предъявитель";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxPerson
            // 
            this.tboxPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxPerson.Location = new System.Drawing.Point(153, 234);
            this.tboxPerson.Name = "tboxPerson";
            this.tboxPerson.ReadOnly = true;
            this.tboxPerson.Size = new System.Drawing.Size(194, 20);
            this.tboxPerson.TabIndex = 4;
            // 
            // gboxItemList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gboxItemList, 2);
            this.gboxItemList.Controls.Add(this.dgvItemList);
            this.gboxItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxItemList.Location = new System.Drawing.Point(3, 312);
            this.gboxItemList.Name = "gboxItemList";
            this.gboxItemList.Size = new System.Drawing.Size(344, 109);
            this.gboxItemList.TabIndex = 9;
            this.gboxItemList.TabStop = false;
            this.gboxItemList.Text = "Материалы";
            // 
            // dgvItemList
            // 
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaterial,
            this.ColumnMaterialUnit,
            this.ColumnQuantity,
            this.ColumnTonnage});
            this.dgvItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemList.Location = new System.Drawing.Point(3, 16);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.Size = new System.Drawing.Size(338, 90);
            this.dgvItemList.TabIndex = 0;
            // 
            // ColumnMaterial
            // 
            this.ColumnMaterial.DataPropertyName = "Material";
            this.ColumnMaterial.FillWeight = 400F;
            this.ColumnMaterial.HeaderText = "груз";
            this.ColumnMaterial.Name = "ColumnMaterial";
            this.ColumnMaterial.ReadOnly = true;
            // 
            // ColumnMaterialUnit
            // 
            this.ColumnMaterialUnit.DataPropertyName = "MaterialUnit";
            this.ColumnMaterialUnit.HeaderText = "ед. изм";
            this.ColumnMaterialUnit.Name = "ColumnMaterialUnit";
            this.ColumnMaterialUnit.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            this.ColumnQuantity.HeaderText = "кол-во";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            // 
            // ColumnTonnage
            // 
            this.ColumnTonnage.DataPropertyName = "Tonnage";
            this.ColumnTonnage.HeaderText = "вес";
            this.ColumnTonnage.Name = "ColumnTonnage";
            this.ColumnTonnage.ReadOnly = true;
            // 
            // bgRefreshing
            // 
            this.bgRefreshing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgRefreshing_DoWork);
            this.bgRefreshing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgRefreshing_RunWorkerCompleted);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DocNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "№ документа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DocDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата документа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Material";
            this.dataGridViewTextBoxColumn3.FillWeight = 400F;
            this.dataGridViewTextBoxColumn3.HeaderText = "груз";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 191;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaterialUnit";
            this.dataGridViewTextBoxColumn4.HeaderText = "ед. изм";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 48;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "кол-во";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 48;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tonnage";
            this.dataGridViewTextBoxColumn6.HeaderText = "вес";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 48;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon.Text = "Материальные пропуска";
            this.notifyIcon.Visible = true;
            // 
            // iconTimer
            // 
            this.iconTimer.Interval = 1000;
            this.iconTimer.Tick += new System.EventHandler(this.iconTimer_Tick);
            // 
            // clearNewTimer
            // 
            this.clearNewTimer.Interval = 5000;
            this.clearNewTimer.Tick += new System.EventHandler(this.clearNewTimer_Tick);
            // 
            // MaterialPermitListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 517);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelBottom);
            this.Name = "MaterialPermitListForm";
            this.Text = "Материальные пропуска";
            this.panelBottom.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentList)).EndInit();
            this.listToolStrip.ResumeLayout(false);
            this.listToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gboxComment.ResumeLayout(false);
            this.gboxComment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEntryFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSignedFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCreateFlag)).EndInit();
            this.gboxItemList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ToolStrip listToolStrip;
        private System.Windows.Forms.BindingSource bsDocumentList;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker bgRefreshing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocDate;
        private System.Windows.Forms.DataGridViewImageColumn ColumnCreateFlag;
        private System.Windows.Forms.DataGridViewImageColumn ColumnSignedFlag;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEntryFlag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pboxEntryFlag;
        private System.Windows.Forms.PictureBox pboxSignedFlag;
        private System.Windows.Forms.PictureBox pboxCreateFlag;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnFailSign;
        private System.Windows.Forms.Button btnFailCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblEntryPoint;
        private System.Windows.Forms.Label lblSigner;
        private System.Windows.Forms.TextBox tboxVehicle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxPerson;
        private System.Windows.Forms.TextBox tboxBaseDocument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboxComment;
        private System.Windows.Forms.GroupBox gboxItemList;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaterialUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTonnage;
        private System.Windows.Forms.TextBox tboxComment;
        private EPV.Controls.PeriodPicker periodPicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton addDocumentTool;
        private System.Windows.Forms.ToolStripButton editDocumentTool;
        private System.Windows.Forms.ToolStripButton deleteDocumentTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshListTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripLabel refreshingLabel;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer iconTimer;
        private System.Windows.Forms.Timer clearNewTimer;
    }
}