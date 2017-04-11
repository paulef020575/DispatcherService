namespace DispatcherService.Forms
{
    partial class PlanAppointLstForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pickPlan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            this.listTools = new System.Windows.Forms.ToolStrip();
            this.addPlanTool = new System.Windows.Forms.ToolStripButton();
            this.editPlanTool = new System.Windows.Forms.ToolStripButton();
            this.deletePlanTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshListTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reportTool = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClosed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnPlanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDriverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAppoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            this.listTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pickPlan);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(677, 50);
            this.panelTop.TabIndex = 2;
            // 
            // pickPlan
            // 
            this.pickPlan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickPlan.Location = new System.Drawing.Point(103, 12);
            this.pickPlan.Name = "pickPlan";
            this.pickPlan.Size = new System.Drawing.Size(94, 20);
            this.pickPlan.TabIndex = 1;
            this.pickPlan.ValueChanged += new System.EventHandler(this.pickPlan_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата прибытия";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 433);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(677, 50);
            this.panelBottom.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(565, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dgvList);
            this.panelData.Controls.Add(this.listTools);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 50);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(677, 383);
            this.panelData.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClosed,
            this.columnPlanDate,
            this.columnTrack,
            this.DriverName,
            this.columnDriverPhone,
            this.columnCargo,
            this.columnAppoint,
            this.columnNotes});
            this.dgvList.DataSource = this.bsList;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 25);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(677, 358);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            this.dgvList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvList_CellPainting);
            this.dgvList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvList_RowPrePaint);
            this.dgvList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvList_KeyDown);
            // 
            // listTools
            // 
            this.listTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlanTool,
            this.editPlanTool,
            this.deletePlanTool,
            this.toolStripSeparator1,
            this.refreshListTool,
            this.toolStripSeparator2,
            this.reportTool});
            this.listTools.Location = new System.Drawing.Point(0, 0);
            this.listTools.Name = "listTools";
            this.listTools.Size = new System.Drawing.Size(677, 25);
            this.listTools.TabIndex = 0;
            this.listTools.Text = "toolStrip1";
            // 
            // addPlanTool
            // 
            this.addPlanTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addPlanTool.Image = global::DispatcherService.Properties.Resources.document_add;
            this.addPlanTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addPlanTool.Name = "addPlanTool";
            this.addPlanTool.Size = new System.Drawing.Size(23, 22);
            this.addPlanTool.Text = "добавить";
            this.addPlanTool.Click += new System.EventHandler(this.addPlanTool_Click);
            // 
            // editPlanTool
            // 
            this.editPlanTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editPlanTool.Image = global::DispatcherService.Properties.Resources.document_edit;
            this.editPlanTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPlanTool.Name = "editPlanTool";
            this.editPlanTool.Size = new System.Drawing.Size(23, 22);
            this.editPlanTool.Text = "изменить";
            this.editPlanTool.Click += new System.EventHandler(this.editPlanTool_Click);
            // 
            // deletePlanTool
            // 
            this.deletePlanTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deletePlanTool.Image = global::DispatcherService.Properties.Resources.document_delete;
            this.deletePlanTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletePlanTool.Name = "deletePlanTool";
            this.deletePlanTool.Size = new System.Drawing.Size(23, 22);
            this.deletePlanTool.Text = "удалить";
            this.deletePlanTool.Click += new System.EventHandler(this.deletePlanTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshListTool
            // 
            this.refreshListTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshListTool.Image = global::DispatcherService.Properties.Resources.refresh1;
            this.refreshListTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshListTool.Name = "refreshListTool";
            this.refreshListTool.Size = new System.Drawing.Size(23, 22);
            this.refreshListTool.Text = "обновить";
            this.refreshListTool.Click += new System.EventHandler(this.refreshListTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // reportTool
            // 
            this.reportTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reportTool.Image = global::DispatcherService.Properties.Resources.printer3;
            this.reportTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportTool.Name = "reportTool";
            this.reportTool.Size = new System.Drawing.Size(23, 22);
            this.reportTool.Text = "печать";
            this.reportTool.Click += new System.EventHandler(this.reportTool_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlanDate";
            dataGridViewCellStyle11.Format = "g";
            dataGridViewCellStyle11.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.HeaderText = "план прибытия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TrackInfo";
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn2.HeaderText = "Т/средство";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DriverName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Водитель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DriverPhone";
            this.dataGridViewTextBoxColumn4.HeaderText = "телефон";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cargo";
            this.dataGridViewTextBoxColumn5.HeaderText = "груз";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn6.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // ColumnClosed
            // 
            this.ColumnClosed.DataPropertyName = "IsClosed";
            this.ColumnClosed.HeaderText = "закр.";
            this.ColumnClosed.Name = "ColumnClosed";
            this.ColumnClosed.ReadOnly = true;
            this.ColumnClosed.Width = 35;
            // 
            // columnPlanDate
            // 
            this.columnPlanDate.DataPropertyName = "PlanDate";
            dataGridViewCellStyle9.Format = "g";
            dataGridViewCellStyle9.NullValue = null;
            this.columnPlanDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.columnPlanDate.HeaderText = "план прибытия";
            this.columnPlanDate.Name = "columnPlanDate";
            this.columnPlanDate.ReadOnly = true;
            // 
            // columnTrack
            // 
            this.columnTrack.DataPropertyName = "TrackInfo";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnTrack.DefaultCellStyle = dataGridViewCellStyle10;
            this.columnTrack.HeaderText = "Т/средство";
            this.columnTrack.Name = "columnTrack";
            this.columnTrack.ReadOnly = true;
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "DriverName";
            this.DriverName.HeaderText = "Водитель";
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            this.DriverName.Width = 150;
            // 
            // columnDriverPhone
            // 
            this.columnDriverPhone.DataPropertyName = "DriverPhone";
            this.columnDriverPhone.HeaderText = "телефон";
            this.columnDriverPhone.Name = "columnDriverPhone";
            this.columnDriverPhone.ReadOnly = true;
            // 
            // columnCargo
            // 
            this.columnCargo.DataPropertyName = "Cargo";
            this.columnCargo.HeaderText = "груз";
            this.columnCargo.Name = "columnCargo";
            this.columnCargo.ReadOnly = true;
            // 
            // columnAppoint
            // 
            this.columnAppoint.DataPropertyName = "DateAppoint";
            this.columnAppoint.HeaderText = "прибытие";
            this.columnAppoint.Name = "columnAppoint";
            this.columnAppoint.ReadOnly = true;
            // 
            // columnNotes
            // 
            this.columnNotes.DataPropertyName = "Notes";
            this.columnNotes.HeaderText = "Примечание";
            this.columnNotes.Name = "columnNotes";
            this.columnNotes.ReadOnly = true;
            this.columnNotes.Width = 250;
            // 
            // PlanAppointLstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 483);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "PlanAppointLstForm";
            this.Text = "Ожидаемое прибытие";
            this.Load += new System.EventHandler(this.PlanAppointLstForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            this.listTools.ResumeLayout(false);
            this.listTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DateTimePicker pickPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.ToolStrip listTools;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.BindingSource bsList;
        private System.Windows.Forms.ToolStripButton addPlanTool;
        private System.Windows.Forms.ToolStripButton editPlanTool;
        private System.Windows.Forms.ToolStripButton deletePlanTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshListTool;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton reportTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnClosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPlanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDriverPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAppoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNotes;
    }
}