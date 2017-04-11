namespace DispatcherService
{
    partial class FormDispatcher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewAppoints = new System.Windows.Forms.DataGridView();
            this.ColumnPermit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAppoints = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxTimeToUpdate = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxProperty = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxLookup = new System.Windows.Forms.ToolStripTextBox();
            this.btnPermit = new System.Windows.Forms.Button();
            this.buttonSetOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.buttonAppointEdit = new System.Windows.Forms.Button();
            this.panelEmpty1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAppointNew = new System.Windows.Forms.Button();
            this.timerDispatcher = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAppoints)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelEmpty1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.splitContainer1);
            this.panelData.Size = new System.Drawing.Size(888, 412);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(2870, 15);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 412);
            this.panelBottom.Size = new System.Drawing.Size(888, 50);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewAppoints);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnPermit);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSetOut);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNextStep);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAppointEdit);
            this.splitContainer1.Panel2.Controls.Add(this.panelEmpty1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAppointNew);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(888, 412);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewAppoints
            // 
            this.dataGridViewAppoints.AllowUserToAddRows = false;
            this.dataGridViewAppoints.AllowUserToDeleteRows = false;
            this.dataGridViewAppoints.AutoGenerateColumns = false;
            this.dataGridViewAppoints.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewAppoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPermit,
            this.columnDate,
            this.columnTrack,
            this.columnDriver,
            this.columnUnit,
            this.columnPoint,
            this.columnReason});
            this.dataGridViewAppoints.DataSource = this.bindingSourceAppoints;
            this.dataGridViewAppoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAppoints.Location = new System.Drawing.Point(0, 34);
            this.dataGridViewAppoints.Name = "dataGridViewAppoints";
            this.dataGridViewAppoints.ReadOnly = true;
            this.dataGridViewAppoints.RowHeadersWidth = 21;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppoints.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAppoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppoints.Size = new System.Drawing.Size(600, 378);
            this.dataGridViewAppoints.TabIndex = 2;
            this.dataGridViewAppoints.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewAppoints_RowPostPaint);
            // 
            // ColumnPermit
            // 
            this.ColumnPermit.DataPropertyName = "HasPermit";
            this.ColumnPermit.HeaderText = "пропуск";
            this.ColumnPermit.Name = "ColumnPermit";
            this.ColumnPermit.ReadOnly = true;
            this.ColumnPermit.Width = 50;
            // 
            // columnDate
            // 
            this.columnDate.DataPropertyName = "dateComing";
            this.columnDate.HeaderText = "дата прибытия";
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            this.columnDate.Width = 75;
            // 
            // columnTrack
            // 
            this.columnTrack.DataPropertyName = "TrackInfo";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.columnTrack.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnTrack.HeaderText = "транспорт";
            this.columnTrack.Name = "columnTrack";
            this.columnTrack.ReadOnly = true;
            // 
            // columnDriver
            // 
            this.columnDriver.DataPropertyName = "DriverInfo";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDriver.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnDriver.HeaderText = "водитель";
            this.columnDriver.Name = "columnDriver";
            this.columnDriver.ReadOnly = true;
            this.columnDriver.Width = 150;
            // 
            // columnUnit
            // 
            this.columnUnit.DataPropertyName = "UnitInfo";
            this.columnUnit.HeaderText = "подразделение доверенность (груз)";
            this.columnUnit.Name = "columnUnit";
            this.columnUnit.ReadOnly = true;
            // 
            // columnPoint
            // 
            this.columnPoint.DataPropertyName = "PointInfo";
            this.columnPoint.HeaderText = "пункт погрузки/выгрузки  дата принятия";
            this.columnPoint.Name = "columnPoint";
            this.columnPoint.ReadOnly = true;
            this.columnPoint.Width = 175;
            // 
            // columnReason
            // 
            this.columnReason.DataPropertyName = "IdleReason";
            this.columnReason.HeaderText = "причина";
            this.columnReason.Name = "columnReason";
            this.columnReason.ReadOnly = true;
            this.columnReason.Width = 200;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxTimeToUpdate,
            this.toolStripButtonRefresh,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripComboBoxProperty,
            this.toolStripTextBoxLookup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBoxTimeToUpdate
            // 
            this.toolStripTextBoxTimeToUpdate.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripTextBoxTimeToUpdate.Name = "toolStripTextBoxTimeToUpdate";
            this.toolStripTextBoxTimeToUpdate.ReadOnly = true;
            this.toolStripTextBoxTimeToUpdate.Size = new System.Drawing.Size(25, 34);
            this.toolStripTextBoxTimeToUpdate.Text = "30";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.AutoSize = false;
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(75, 22);
            this.toolStripButtonRefresh.Text = "обновить";
            this.toolStripButtonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 31);
            this.toolStripLabel1.Text = "Поиск";
            // 
            // toolStripComboBoxProperty
            // 
            this.toolStripComboBoxProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxProperty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBoxProperty.Items.AddRange(new object[] {
            "машина",
            "водитель",
            "доверенность"});
            this.toolStripComboBoxProperty.Name = "toolStripComboBoxProperty";
            this.toolStripComboBoxProperty.Size = new System.Drawing.Size(121, 34);
            // 
            // toolStripTextBoxLookup
            // 
            this.toolStripTextBoxLookup.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripTextBoxLookup.Name = "toolStripTextBoxLookup";
            this.toolStripTextBoxLookup.Size = new System.Drawing.Size(100, 34);
            this.toolStripTextBoxLookup.TextChanged += new System.EventHandler(this.toolStripTextBoxLookup_TextChanged);
            // 
            // btnPermit
            // 
            this.btnPermit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPermit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPermit.Location = new System.Drawing.Point(5, 357);
            this.btnPermit.Name = "btnPermit";
            this.btnPermit.Size = new System.Drawing.Size(274, 50);
            this.btnPermit.TabIndex = 6;
            this.btnPermit.Text = "Печать пропуска";
            this.btnPermit.UseVisualStyleBackColor = true;
            this.btnPermit.Click += new System.EventHandler(this.btnPermit_Click);
            // 
            // buttonSetOut
            // 
            this.buttonSetOut.BackColor = System.Drawing.Color.Salmon;
            this.buttonSetOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetOut.Location = new System.Drawing.Point(5, 175);
            this.buttonSetOut.Name = "buttonSetOut";
            this.buttonSetOut.Size = new System.Drawing.Size(274, 50);
            this.buttonSetOut.TabIndex = 5;
            this.buttonSetOut.Text = "Отказать в приеме";
            this.buttonSetOut.UseVisualStyleBackColor = false;
            this.buttonSetOut.Click += new System.EventHandler(this.buttonSetOut_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 10);
            this.panel2.TabIndex = 4;
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.BackColor = System.Drawing.Color.Khaki;
            this.buttonNextStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextStep.Location = new System.Drawing.Point(5, 115);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(274, 50);
            this.buttonNextStep.TabIndex = 3;
            this.buttonNextStep.Text = "Отправить на обработку";
            this.buttonNextStep.UseVisualStyleBackColor = false;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // buttonAppointEdit
            // 
            this.buttonAppointEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAppointEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAppointEdit.Location = new System.Drawing.Point(5, 65);
            this.buttonAppointEdit.Name = "buttonAppointEdit";
            this.buttonAppointEdit.Size = new System.Drawing.Size(274, 50);
            this.buttonAppointEdit.TabIndex = 2;
            this.buttonAppointEdit.Text = "Изменение данных";
            this.buttonAppointEdit.UseVisualStyleBackColor = true;
            this.buttonAppointEdit.Click += new System.EventHandler(this.buttonAppointEdit_Click);
            // 
            // panelEmpty1
            // 
            this.panelEmpty1.Controls.Add(this.panel1);
            this.panelEmpty1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpty1.Location = new System.Drawing.Point(5, 55);
            this.panelEmpty1.Name = "panelEmpty1";
            this.panelEmpty1.Size = new System.Drawing.Size(274, 10);
            this.panelEmpty1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 10);
            this.panel1.TabIndex = 2;
            // 
            // buttonAppointNew
            // 
            this.buttonAppointNew.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAppointNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAppointNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAppointNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAppointNew.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonAppointNew.Location = new System.Drawing.Point(5, 5);
            this.buttonAppointNew.Name = "buttonAppointNew";
            this.buttonAppointNew.Size = new System.Drawing.Size(274, 50);
            this.buttonAppointNew.TabIndex = 0;
            this.buttonAppointNew.Text = "Прибытие транспорта";
            this.buttonAppointNew.UseVisualStyleBackColor = false;
            this.buttonAppointNew.Click += new System.EventHandler(this.buttonAppointNew_Click);
            // 
            // timerDispatcher
            // 
            this.timerDispatcher.Interval = 1000;
            this.timerDispatcher.Tick += new System.EventHandler(this.timerDispatcher_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DocState";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "номер а/м";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Unit";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "прицеп";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LicensePlate";
            this.dataGridViewTextBoxColumn3.HeaderText = "номер а/м";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Trailer";
            this.dataGridViewTextBoxColumn4.HeaderText = "прицеп";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Citizen";
            this.dataGridViewTextBoxColumn5.HeaderText = "стр";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DriverName";
            this.dataGridViewTextBoxColumn6.HeaderText = "водитель";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cargo";
            this.dataGridViewTextBoxColumn7.HeaderText = "груз";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // FormDispatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 462);
            this.Name = "FormDispatcher";
            this.Text = "Диспетчерская";
            this.Activated += new System.EventHandler(this.FormDispatcher_Activated);
            this.Load += new System.EventHandler(this.FormDispatcher_Load);
            this.panelData.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAppoints)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelEmpty1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource bindingSourceAppoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonAppointNew;
        private System.Windows.Forms.Panel panelEmpty1;
        private System.Windows.Forms.Button buttonAppointEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxTimeToUpdate;
        private System.Windows.Forms.Timer timerDispatcher;
        private System.Windows.Forms.DataGridView dataGridViewAppoints;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.Button buttonSetOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxProperty;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxLookup;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnPermit;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReason;
        private System.Windows.Forms.Button btnPermit;
    }
}