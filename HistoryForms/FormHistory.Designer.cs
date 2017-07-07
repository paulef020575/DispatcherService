namespace DispatcherService
{
    partial class FormHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tboxCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pickDateTo = new System.Windows.Forms.DateTimePicker();
            this.pickDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxLicensePlate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxUnitList = new System.Windows.Forms.ComboBox();
            this.chkGroup = new System.Windows.Forms.CheckBox();
            this.pbarLoad = new System.Windows.Forms.ProgressBar();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDriverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWhereTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMore = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5576F));
            this.tableLayoutPanel1.Controls.Add(this.tboxCargo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboxLicensePlate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboxUnitList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkGroup, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pbarLoad, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dgvData, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tboxCargo
            // 
            this.tboxCargo.Location = new System.Drawing.Point(127, 88);
            this.tboxCargo.Name = "tboxCargo";
            this.tboxCargo.Size = new System.Drawing.Size(135, 20);
            this.tboxCargo.TabIndex = 7;
            this.tboxCargo.TextChanged += new System.EventHandler(this.pickDateFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Груз";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Период";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pickDateTo);
            this.panel1.Controls.Add(this.pickDateFrom);
            this.panel1.Location = new System.Drawing.Point(127, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 26);
            this.panel1.TabIndex = 1;
            // 
            // pickDateTo
            // 
            this.pickDateTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.pickDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickDateTo.Location = new System.Drawing.Point(144, 3);
            this.pickDateTo.Name = "pickDateTo";
            this.pickDateTo.ShowUpDown = true;
            this.pickDateTo.Size = new System.Drawing.Size(132, 20);
            this.pickDateTo.TabIndex = 1;
            this.pickDateTo.ValueChanged += new System.EventHandler(this.pickDateFrom_ValueChanged);
            // 
            // pickDateFrom
            // 
            this.pickDateFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.pickDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickDateFrom.Location = new System.Drawing.Point(3, 3);
            this.pickDateFrom.Name = "pickDateFrom";
            this.pickDateFrom.ShowUpDown = true;
            this.pickDateFrom.Size = new System.Drawing.Size(132, 20);
            this.pickDateFrom.TabIndex = 0;
            this.pickDateFrom.ValueChanged += new System.EventHandler(this.pickDateFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(61, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер т/с";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxLicensePlate
            // 
            this.tboxLicensePlate.Location = new System.Drawing.Point(127, 35);
            this.tboxLicensePlate.Name = "tboxLicensePlate";
            this.tboxLicensePlate.Size = new System.Drawing.Size(135, 20);
            this.tboxLicensePlate.TabIndex = 3;
            this.tboxLicensePlate.TextChanged += new System.EventHandler(this.pickDateFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подразделение";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxUnitList
            // 
            this.cboxUnitList.FormattingEnabled = true;
            this.cboxUnitList.Location = new System.Drawing.Point(127, 61);
            this.cboxUnitList.Name = "cboxUnitList";
            this.cboxUnitList.Size = new System.Drawing.Size(279, 21);
            this.cboxUnitList.TabIndex = 5;
            this.cboxUnitList.SelectedValueChanged += new System.EventHandler(this.pickDateFrom_ValueChanged);
            // 
            // chkGroup
            // 
            this.chkGroup.AutoSize = true;
            this.chkGroup.Location = new System.Drawing.Point(127, 114);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Size = new System.Drawing.Size(90, 17);
            this.chkGroup.TabIndex = 8;
            this.chkGroup.Text = "группировка";
            this.chkGroup.UseVisualStyleBackColor = true;
            this.chkGroup.CheckedChanged += new System.EventHandler(this.pickDateFrom_ValueChanged);
            // 
            // pbarLoad
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pbarLoad, 2);
            this.pbarLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbarLoad.Location = new System.Drawing.Point(3, 514);
            this.pbarLoad.Name = "pbarLoad";
            this.pbarLoad.Size = new System.Drawing.Size(998, 23);
            this.pbarLoad.TabIndex = 9;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImage,
            this.ColumnVehicle,
            this.ColumnDriver,
            this.ColumnDriverPhone,
            this.ColumnCargo,
            this.ColumnDateFrom,
            this.ColumnWhereTo,
            this.ColumnOperation,
            this.ColumnPoint,
            this.ColumnDateTo,
            this.ColumnReason});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvData, 2);
            this.dgvData.DataSource = this.bSource;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 162);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(998, 346);
            this.dgvData.TabIndex = 10;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
            this.dgvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvData_RowPrePaint);
            // 
            // ColumnImage
            // 
            this.ColumnImage.DataPropertyName = "ItemImage";
            this.ColumnImage.Frozen = true;
            this.ColumnImage.HeaderText = "";
            this.ColumnImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnImage.Width = 25;
            // 
            // ColumnVehicle
            // 
            this.ColumnVehicle.DataPropertyName = "Vehicle";
            this.ColumnVehicle.HeaderText = "Т/средство";
            this.ColumnVehicle.Name = "ColumnVehicle";
            this.ColumnVehicle.ReadOnly = true;
            // 
            // ColumnDriver
            // 
            this.ColumnDriver.DataPropertyName = "Driver";
            this.ColumnDriver.HeaderText = "Водитель";
            this.ColumnDriver.Name = "ColumnDriver";
            this.ColumnDriver.ReadOnly = true;
            // 
            // ColumnDriverPhone
            // 
            this.ColumnDriverPhone.DataPropertyName = "DriverPhone";
            this.ColumnDriverPhone.HeaderText = "Телефон";
            this.ColumnDriverPhone.Name = "ColumnDriverPhone";
            this.ColumnDriverPhone.ReadOnly = true;
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.DataPropertyName = "Cargo";
            this.ColumnCargo.HeaderText = "Груз";
            this.ColumnCargo.Name = "ColumnCargo";
            this.ColumnCargo.ReadOnly = true;
            // 
            // ColumnDateFrom
            // 
            this.ColumnDateFrom.DataPropertyName = "DateFrom";
            this.ColumnDateFrom.HeaderText = "Дата операции";
            this.ColumnDateFrom.Name = "ColumnDateFrom";
            this.ColumnDateFrom.ReadOnly = true;
            // 
            // ColumnWhereTo
            // 
            this.ColumnWhereTo.DataPropertyName = "WhereTo";
            this.ColumnWhereTo.HeaderText = "Направление";
            this.ColumnWhereTo.Name = "ColumnWhereTo";
            this.ColumnWhereTo.ReadOnly = true;
            // 
            // ColumnOperation
            // 
            this.ColumnOperation.DataPropertyName = "Operation";
            this.ColumnOperation.HeaderText = "Операция ";
            this.ColumnOperation.Name = "ColumnOperation";
            this.ColumnOperation.ReadOnly = true;
            // 
            // ColumnPoint
            // 
            this.ColumnPoint.DataPropertyName = "Point";
            this.ColumnPoint.HeaderText = "Точка";
            this.ColumnPoint.Name = "ColumnPoint";
            this.ColumnPoint.ReadOnly = true;
            // 
            // ColumnDateTo
            // 
            this.ColumnDateTo.DataPropertyName = "DateTo";
            this.ColumnDateTo.HeaderText = "Дата завершения";
            this.ColumnDateTo.Name = "ColumnDateTo";
            this.ColumnDateTo.ReadOnly = true;
            // 
            // ColumnReason
            // 
            this.ColumnReason.DataPropertyName = "Reason";
            this.ColumnReason.HeaderText = "Примечание";
            this.ColumnReason.Name = "ColumnReason";
            this.ColumnReason.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 2);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMore,
            this.btnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 134);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMore
            // 
            this.btnMore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMore.Image = ((System.Drawing.Image)(resources.GetObject("btnMore.Image")));
            this.btnMore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(23, 22);
            this.btnMore.Text = "Подробности";
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = global::DispatcherService.Properties.Resources.printer3;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "Печать";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 300;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Vehicle";
            this.dataGridViewTextBoxColumn1.HeaderText = "Т/средство";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Driver";
            this.dataGridViewTextBoxColumn2.HeaderText = "Водитель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DriverPhone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cargo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Груз";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateFrom";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата операции";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "WhereTo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Направление";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Operation";
            this.dataGridViewTextBoxColumn7.HeaderText = "Операция ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Point";
            this.dataGridViewTextBoxColumn8.HeaderText = "Точка";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateTo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Дата завершения";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Reason";
            this.dataGridViewTextBoxColumn10.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "FormHistory";
            this.Text = "История приемки автотранспорта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHistory_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker pickDateTo;
        private System.Windows.Forms.DateTimePicker pickDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxLicensePlate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxUnitList;
        private System.Windows.Forms.TextBox tboxCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkGroup;
        private System.Windows.Forms.ProgressBar pbarLoad;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.BindingSource bSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDriverPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWhereTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReason;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMore;
        private System.Windows.Forms.ToolStripButton btnPrint;
    }
}