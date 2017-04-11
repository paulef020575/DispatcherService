namespace DispatcherService
{
    partial class UserControlPoint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelState = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewAppoints = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStop = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnMove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnMP = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppoints)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.labelState);
            this.panelHeader.Controls.Add(this.labelName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(290, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(5, 31);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 13);
            this.labelState.TabIndex = 1;
            this.labelState.Text = "label1";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(5, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // dataGridViewAppoints
            // 
            this.dataGridViewAppoints.AllowUserToAddRows = false;
            this.dataGridViewAppoints.AllowUserToDeleteRows = false;
            this.dataGridViewAppoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppoints.ColumnHeadersVisible = false;
            this.dataGridViewAppoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTrack,
            this.columnTime,
            this.columnStop,
            this.columnMove,
            this.ColumnMP});
            this.dataGridViewAppoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAppoints.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewAppoints.Name = "dataGridViewAppoints";
            this.dataGridViewAppoints.ReadOnly = true;
            this.dataGridViewAppoints.RowHeadersVisible = false;
            this.dataGridViewAppoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppoints.Size = new System.Drawing.Size(290, 178);
            this.dataGridViewAppoints.TabIndex = 1;
            this.dataGridViewAppoints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppoints_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LicensePlate";
            this.dataGridViewTextBoxColumn1.HeaderText = "транспорт";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DocStateDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "время поступления";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // columnTrack
            // 
            this.columnTrack.DataPropertyName = "LicensePlate";
            this.columnTrack.HeaderText = "транспорт";
            this.columnTrack.Name = "columnTrack";
            this.columnTrack.ReadOnly = true;
            this.columnTrack.Width = 75;
            // 
            // columnTime
            // 
            this.columnTime.DataPropertyName = "DocStateDate";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.columnTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnTime.HeaderText = "время поступления";
            this.columnTime.Name = "columnTime";
            this.columnTime.ReadOnly = true;
            this.columnTime.Width = 50;
            // 
            // columnStop
            // 
            this.columnStop.HeaderText = "завершение";
            this.columnStop.Name = "columnStop";
            this.columnStop.ReadOnly = true;
            this.columnStop.Text = "завершение";
            this.columnStop.UseColumnTextForButtonValue = true;
            this.columnStop.Width = 75;
            // 
            // columnMove
            // 
            this.columnMove.HeaderText = "переезд";
            this.columnMove.Name = "columnMove";
            this.columnMove.ReadOnly = true;
            this.columnMove.Text = "переезд";
            this.columnMove.UseColumnTextForButtonValue = true;
            this.columnMove.Width = 75;
            // 
            // ColumnMP
            // 
            this.ColumnMP.HeaderText = "Мат. пропуск";
            this.ColumnMP.Name = "ColumnMP";
            this.ColumnMP.ReadOnly = true;
            this.ColumnMP.Text = "Мат. пропуск";
            this.ColumnMP.Visible = false;
            // 
            // UserControlPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.dataGridViewAppoints);
            this.Controls.Add(this.panelHeader);
            this.Name = "UserControlPoint";
            this.Size = new System.Drawing.Size(290, 228);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.DataGridView dataGridViewAppoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTime;
        private System.Windows.Forms.DataGridViewButtonColumn columnStop;
        private System.Windows.Forms.DataGridViewButtonColumn columnMove;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnMP;
    }
}
