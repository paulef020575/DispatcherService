namespace DispatcherService
{
    partial class FormAccepting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.textBoxLookup = new System.Windows.Forms.TextBox();
            this.comboBoxProperties = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewInWay = new System.Windows.Forms.DataGridView();
            this.columnTransportInWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDriverInWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPointInWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWarrantInWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGetTools = new System.Windows.Forms.Panel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonToPoint = new System.Windows.Forms.Button();
            this.panelGetHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDispatcherTools = new System.Windows.Forms.Panel();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonIdle = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.dataGridViewDispatcher = new System.Windows.Forms.DataGridView();
            this.сolumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWarrant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdleReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPoints = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInWay)).BeginInit();
            this.panelGetTools.SuspendLayout();
            this.panelGetHeader.SuspendLayout();
            this.panelDispatcherTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDispatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.splitContainer1);
            this.panelData.Controls.Add(this.panelFilter);
            this.panelData.Size = new System.Drawing.Size(871, 622);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 622);
            this.panelBottom.Size = new System.Drawing.Size(871, 50);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(2694, 15);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.textBoxLookup);
            this.panelFilter.Controls.Add(this.comboBoxProperties);
            this.panelFilter.Controls.Add(this.label5);
            this.panelFilter.Controls.Add(this.buttonRefresh);
            this.panelFilter.Controls.Add(this.textBoxTimer);
            this.panelFilter.Controls.Add(this.label3);
            this.panelFilter.Controls.Add(this.comboBoxUnits);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(871, 63);
            this.panelFilter.TabIndex = 0;
            // 
            // textBoxLookup
            // 
            this.textBoxLookup.Location = new System.Drawing.Point(338, 35);
            this.textBoxLookup.Name = "textBoxLookup";
            this.textBoxLookup.Size = new System.Drawing.Size(178, 20);
            this.textBoxLookup.TabIndex = 7;
            this.textBoxLookup.TextChanged += new System.EventHandler(this.textBoxLookup_TextChanged);
            // 
            // comboBoxProperties
            // 
            this.comboBoxProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProperties.FormattingEnabled = true;
            this.comboBoxProperties.Items.AddRange(new object[] {
            "машина",
            "водитель",
            "доверенность"});
            this.comboBoxProperties.Location = new System.Drawing.Point(212, 35);
            this.comboBoxProperties.Name = "comboBoxProperties";
            this.comboBoxProperties.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProperties.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(162, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Поиск";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Location = new System.Drawing.Point(570, 1);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(525, 3);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(39, 20);
            this.textBoxTimer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ожидают у диспетчера";
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Location = new System.Drawing.Point(96, 3);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(287, 21);
            this.comboBoxUnits.TabIndex = 1;
            this.comboBoxUnits.TabStop = false;
            this.comboBoxUnits.SelectedValueChanged += new System.EventHandler(this.comboBoxUnits_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подразделение";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewInWay);
            this.splitContainer1.Panel1.Controls.Add(this.panelGetTools);
            this.splitContainer1.Panel1.Controls.Add(this.panelGetHeader);
            this.splitContainer1.Panel1.Controls.Add(this.panelDispatcherTools);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewDispatcher);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel2.Controls.Add(this.panelPoints);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(871, 559);
            this.splitContainer1.SplitterDistance = 567;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridViewInWay
            // 
            this.dataGridViewInWay.AllowUserToAddRows = false;
            this.dataGridViewInWay.AllowUserToDeleteRows = false;
            this.dataGridViewInWay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInWay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInWay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTransportInWay,
            this.columnDriverInWay,
            this.columnPointInWay,
            this.columnWarrantInWay});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInWay.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInWay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInWay.Location = new System.Drawing.Point(0, 442);
            this.dataGridViewInWay.Name = "dataGridViewInWay";
            this.dataGridViewInWay.ReadOnly = true;
            this.dataGridViewInWay.RowHeadersWidth = 21;
            this.dataGridViewInWay.Size = new System.Drawing.Size(460, 117);
            this.dataGridViewInWay.TabIndex = 6;
            // 
            // columnTransportInWay
            // 
            this.columnTransportInWay.DataPropertyName = "TrackInfo";
            this.columnTransportInWay.HeaderText = "транспорт";
            this.columnTransportInWay.Name = "columnTransportInWay";
            this.columnTransportInWay.ReadOnly = true;
            // 
            // columnDriverInWay
            // 
            this.columnDriverInWay.DataPropertyName = "DriverInfo";
            this.columnDriverInWay.HeaderText = "водитель";
            this.columnDriverInWay.Name = "columnDriverInWay";
            this.columnDriverInWay.ReadOnly = true;
            // 
            // columnPointInWay
            // 
            this.columnPointInWay.DataPropertyName = "PointInfo";
            this.columnPointInWay.HeaderText = "пункт по/выгрузки   /  время";
            this.columnPointInWay.Name = "columnPointInWay";
            this.columnPointInWay.ReadOnly = true;
            this.columnPointInWay.Width = 150;
            // 
            // columnWarrantInWay
            // 
            this.columnWarrantInWay.DataPropertyName = "WarrantInfo";
            this.columnWarrantInWay.HeaderText = "доверенность / груз";
            this.columnWarrantInWay.Name = "columnWarrantInWay";
            this.columnWarrantInWay.ReadOnly = true;
            // 
            // panelGetTools
            // 
            this.panelGetTools.Controls.Add(this.buttonReturn);
            this.panelGetTools.Controls.Add(this.buttonNegative);
            this.panelGetTools.Controls.Add(this.buttonToPoint);
            this.panelGetTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGetTools.Location = new System.Drawing.Point(460, 442);
            this.panelGetTools.Name = "panelGetTools";
            this.panelGetTools.Size = new System.Drawing.Size(107, 117);
            this.panelGetTools.TabIndex = 5;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Location = new System.Drawing.Point(0, 100);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(107, 50);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Возврат";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonNegative
            // 
            this.buttonNegative.BackColor = System.Drawing.Color.Salmon;
            this.buttonNegative.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNegative.Location = new System.Drawing.Point(0, 50);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(107, 50);
            this.buttonNegative.TabIndex = 1;
            this.buttonNegative.Text = "Отказ";
            this.buttonNegative.UseVisualStyleBackColor = false;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
            // 
            // buttonToPoint
            // 
            this.buttonToPoint.BackColor = System.Drawing.Color.LightGreen;
            this.buttonToPoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonToPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToPoint.Location = new System.Drawing.Point(0, 0);
            this.buttonToPoint.Name = "buttonToPoint";
            this.buttonToPoint.Size = new System.Drawing.Size(107, 50);
            this.buttonToPoint.TabIndex = 0;
            this.buttonToPoint.Text = "Погрузка/ выгрузка";
            this.buttonToPoint.UseVisualStyleBackColor = false;
            this.buttonToPoint.Click += new System.EventHandler(this.buttonToPoint_Click);
            // 
            // panelGetHeader
            // 
            this.panelGetHeader.Controls.Add(this.label2);
            this.panelGetHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGetHeader.Location = new System.Drawing.Point(0, 412);
            this.panelGetHeader.Name = "panelGetHeader";
            this.panelGetHeader.Size = new System.Drawing.Size(567, 30);
            this.panelGetHeader.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "На пути к месту погрузки/выгрузки";
            // 
            // panelDispatcherTools
            // 
            this.panelDispatcherTools.Controls.Add(this.buttonOut);
            this.panelDispatcherTools.Controls.Add(this.buttonIdle);
            this.panelDispatcherTools.Controls.Add(this.buttonAccept);
            this.panelDispatcherTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDispatcherTools.Location = new System.Drawing.Point(0, 362);
            this.panelDispatcherTools.Name = "panelDispatcherTools";
            this.panelDispatcherTools.Size = new System.Drawing.Size(567, 50);
            this.panelDispatcherTools.TabIndex = 1;
            // 
            // buttonOut
            // 
            this.buttonOut.BackColor = System.Drawing.Color.Salmon;
            this.buttonOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOut.Location = new System.Drawing.Point(300, 0);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(267, 50);
            this.buttonOut.TabIndex = 2;
            this.buttonOut.Text = "отказываем";
            this.buttonOut.UseVisualStyleBackColor = false;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonIdle
            // 
            this.buttonIdle.BackColor = System.Drawing.Color.Khaki;
            this.buttonIdle.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonIdle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIdle.Location = new System.Drawing.Point(150, 0);
            this.buttonIdle.Name = "buttonIdle";
            this.buttonIdle.Size = new System.Drawing.Size(150, 50);
            this.buttonIdle.TabIndex = 1;
            this.buttonIdle.Text = "задерживаем";
            this.buttonIdle.UseVisualStyleBackColor = false;
            this.buttonIdle.Click += new System.EventHandler(this.buttonIdle_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAccept.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Location = new System.Drawing.Point(0, 0);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(150, 50);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "принимаем";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // dataGridViewDispatcher
            // 
            this.dataGridViewDispatcher.AllowUserToAddRows = false;
            this.dataGridViewDispatcher.AllowUserToDeleteRows = false;
            this.dataGridViewDispatcher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDispatcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDispatcher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.сolumnDate,
            this.columnTrack,
            this.columnDriver,
            this.columnWarrant,
            this.columnPoint,
            this.columnIdleReason});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDispatcher.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDispatcher.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewDispatcher.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDispatcher.Name = "dataGridViewDispatcher";
            this.dataGridViewDispatcher.ReadOnly = true;
            this.dataGridViewDispatcher.RowHeadersWidth = 21;
            this.dataGridViewDispatcher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDispatcher.Size = new System.Drawing.Size(567, 362);
            this.dataGridViewDispatcher.TabIndex = 0;
            this.dataGridViewDispatcher.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewDispatcher_RowPostPaint);
            // 
            // сolumnDate
            // 
            this.сolumnDate.DataPropertyName = "DocStateDate";
            this.сolumnDate.HeaderText = "дата прибытия";
            this.сolumnDate.Name = "сolumnDate";
            this.сolumnDate.ReadOnly = true;
            this.сolumnDate.Width = 75;
            // 
            // columnTrack
            // 
            this.columnTrack.DataPropertyName = "TrackInfo";
            this.columnTrack.HeaderText = "транспорт";
            this.columnTrack.Name = "columnTrack";
            this.columnTrack.ReadOnly = true;
            // 
            // columnDriver
            // 
            this.columnDriver.DataPropertyName = "DriverInfo";
            this.columnDriver.HeaderText = "водитель";
            this.columnDriver.Name = "columnDriver";
            this.columnDriver.ReadOnly = true;
            // 
            // columnWarrant
            // 
            this.columnWarrant.DataPropertyName = "WarrantInfo";
            this.columnWarrant.HeaderText = "доверенность / груз";
            this.columnWarrant.Name = "columnWarrant";
            this.columnWarrant.ReadOnly = true;
            this.columnWarrant.Width = 150;
            // 
            // columnPoint
            // 
            this.columnPoint.DataPropertyName = "PointInfo";
            this.columnPoint.HeaderText = "пункт разгрузки / время";
            this.columnPoint.Name = "columnPoint";
            this.columnPoint.ReadOnly = true;
            // 
            // columnIdleReason
            // 
            this.columnIdleReason.DataPropertyName = "IdleReason";
            this.columnIdleReason.HeaderText = "Причина простоя";
            this.columnIdleReason.Name = "columnIdleReason";
            this.columnIdleReason.ReadOnly = true;
            this.columnIdleReason.Width = 150;
            // 
            // panelPoints
            // 
            this.panelPoints.AutoScroll = true;
            this.panelPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPoints.Location = new System.Drawing.Point(0, 0);
            this.panelPoints.Name = "panelPoints";
            this.panelPoints.Size = new System.Drawing.Size(300, 559);
            this.panelPoints.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "идет обновление данных...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TrackInfo";
            this.dataGridViewTextBoxColumn1.HeaderText = "транспорт";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DriverInfo";
            this.dataGridViewTextBoxColumn2.HeaderText = "водитель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PointInfo";
            this.dataGridViewTextBoxColumn3.HeaderText = "пункт по/выгрузки   /  время";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "WarrantInfo";
            this.dataGridViewTextBoxColumn4.HeaderText = "доверенность / груз";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TrackInfo";
            this.dataGridViewTextBoxColumn5.HeaderText = "транспорт";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DriverInfo";
            this.dataGridViewTextBoxColumn6.HeaderText = "водитель";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "WarrantInfo";
            this.dataGridViewTextBoxColumn7.HeaderText = "доверенность / груз";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PointInfo";
            this.dataGridViewTextBoxColumn8.HeaderText = "пункт разгрузки / время";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdleReason";
            this.dataGridViewTextBoxColumn9.HeaderText = "Причина простоя";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // FormAccepting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 672);
            this.Controls.Add(this.panel1);
            this.Name = "FormAccepting";
            this.Text = "Прием автотранспорта";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAccepting_Load);
            this.SizeChanged += new System.EventHandler(this.FormAccepting_SizeChanged);
            this.Shown += new System.EventHandler(this.FormAccepting_SizeChanged);
            this.Activated += new System.EventHandler(this.FormAccepting_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAccepting_FormClosing);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panelBottom, 0);
            this.Controls.SetChildIndex(this.panelData, 0);
            this.panelData.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInWay)).EndInit();
            this.panelGetTools.ResumeLayout(false);
            this.panelGetHeader.ResumeLayout(false);
            this.panelGetHeader.PerformLayout();
            this.panelDispatcherTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDispatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewDispatcher;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDispatcherTools;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonIdle;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Panel panelGetHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelGetTools;
        private System.Windows.Forms.DataGridView dataGridViewInWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTransportInWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDriverInWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPointInWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWarrantInWay;
        private System.Windows.Forms.Button buttonToPoint;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn сolumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWarrant;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdleReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLookup;
        private System.Windows.Forms.ComboBox comboBoxProperties;
        private System.Windows.Forms.Button buttonReturn;

    }
}