namespace DispatcherService
{
    partial class PlanAppointListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pboxFind = new System.Windows.Forms.PictureBox();
            this.tboxFind = new System.Windows.Forms.TextBox();
            this.pboxFindNext = new System.Windows.Forms.PictureBox();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWhereTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPermit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFindNext)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pboxFindNext);
            this.panelTop.Controls.Add(this.tboxFind);
            this.panelTop.Controls.Add(this.pboxFind);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop.Size = new System.Drawing.Size(714, 30);
            this.panelTop.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 273);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(5);
            this.panelBottom.Size = new System.Drawing.Size(714, 35);
            this.panelBottom.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCargo,
            this.ColumnVehicle,
            this.ColumnDriverName,
            this.ColumnContact,
            this.ColumnWhereTo,
            this.ColumnCreatorName,
            this.ColumnCreateDate,
            this.ColumnPermit});
            this.dgvList.DataSource = this.bsList;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 30);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(714, 243);
            this.dgvList.TabIndex = 2;
            this.dgvList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvList_CellPainting);
            // 
            // pboxFind
            // 
            this.pboxFind.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxFind.Location = new System.Drawing.Point(5, 5);
            this.pboxFind.Name = "pboxFind";
            this.pboxFind.Size = new System.Drawing.Size(20, 20);
            this.pboxFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxFind.TabIndex = 0;
            this.pboxFind.TabStop = false;
            // 
            // tboxFind
            // 
            this.tboxFind.Dock = System.Windows.Forms.DockStyle.Left;
            this.tboxFind.Location = new System.Drawing.Point(25, 5);
            this.tboxFind.Name = "tboxFind";
            this.tboxFind.Size = new System.Drawing.Size(100, 20);
            this.tboxFind.TabIndex = 1;
            this.tboxFind.TabStop = false;
            this.tboxFind.TextChanged += new System.EventHandler(this.tboxFind_TextChanged);
            // 
            // pboxFindNext
            // 
            this.pboxFindNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxFindNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxFindNext.Location = new System.Drawing.Point(125, 5);
            this.pboxFindNext.Name = "pboxFindNext";
            this.pboxFindNext.Size = new System.Drawing.Size(20, 20);
            this.pboxFindNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxFindNext.TabIndex = 2;
            this.pboxFindNext.TabStop = false;
            this.pboxFindNext.Click += new System.EventHandler(this.pboxFindNext_Click);
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.DataPropertyName = "Cargo";
            this.ColumnCargo.HeaderText = "Груз";
            this.ColumnCargo.Name = "ColumnCargo";
            this.ColumnCargo.ReadOnly = true;
            // 
            // ColumnVehicle
            // 
            this.ColumnVehicle.DataPropertyName = "Vehicle";
            this.ColumnVehicle.HeaderText = "Т/средство";
            this.ColumnVehicle.Name = "ColumnVehicle";
            this.ColumnVehicle.ReadOnly = true;
            // 
            // ColumnDriverName
            // 
            this.ColumnDriverName.DataPropertyName = "DriverName";
            this.ColumnDriverName.HeaderText = "Водитель";
            this.ColumnDriverName.Name = "ColumnDriverName";
            this.ColumnDriverName.ReadOnly = true;
            // 
            // ColumnContact
            // 
            this.ColumnContact.DataPropertyName = "Contact";
            this.ColumnContact.HeaderText = "Конт. информация";
            this.ColumnContact.Name = "ColumnContact";
            this.ColumnContact.ReadOnly = true;
            // 
            // ColumnWhereTo
            // 
            this.ColumnWhereTo.DataPropertyName = "WhereTo";
            this.ColumnWhereTo.HeaderText = "П. назначения";
            this.ColumnWhereTo.Name = "ColumnWhereTo";
            this.ColumnWhereTo.ReadOnly = true;
            // 
            // ColumnCreatorName
            // 
            this.ColumnCreatorName.DataPropertyName = "CreatorName";
            this.ColumnCreatorName.HeaderText = "Инициатор";
            this.ColumnCreatorName.Name = "ColumnCreatorName";
            this.ColumnCreatorName.ReadOnly = true;
            // 
            // ColumnCreateDate
            // 
            this.ColumnCreateDate.DataPropertyName = "CreateDate";
            this.ColumnCreateDate.HeaderText = "Дата создания";
            this.ColumnCreateDate.Name = "ColumnCreateDate";
            this.ColumnCreateDate.ReadOnly = true;
            // 
            // ColumnPermit
            // 
            this.ColumnPermit.DataPropertyName = "HasPermit";
            this.ColumnPermit.HeaderText = "пропуск";
            this.ColumnPermit.Name = "ColumnPermit";
            this.ColumnPermit.ReadOnly = true;
            // 
            // PlanAppointListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "PlanAppointListControl";
            this.Size = new System.Drawing.Size(714, 308);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFindNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.BindingSource bsList;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.PictureBox pboxFind;
        private System.Windows.Forms.TextBox tboxFind;
        private System.Windows.Forms.PictureBox pboxFindNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWhereTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreateDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnPermit;
    }
}
