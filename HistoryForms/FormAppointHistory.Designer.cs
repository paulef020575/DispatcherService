namespace DispatcherService
{
    partial class FormAppointHistory
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
            this.bwRefresh = new System.ComponentModel.BackgroundWorker();
            this.bsAppointHistory = new System.Windows.Forms.BindingSource(this.components);
            this.bsLog = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWhereTo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDriverPhone = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbarLoading = new System.Windows.Forms.ProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpageHistory = new System.Windows.Forms.TabPage();
            this.dgvAppointHistory = new System.Windows.Forms.DataGridView();
            this.tpageLog = new System.Windows.Forms.TabPage();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.ColumnDateOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnLogOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsAppointHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLog)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointHistory)).BeginInit();
            this.tpageLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bwRefresh
            // 
            this.bwRefresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRefresh_DoWork);
            this.bwRefresh.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRefresh_RunWorkerCompleted);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.81982F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.18018F));
            this.tableLayoutPanel1.Controls.Add(this.lblWhereTo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCargo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDriverPhone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVehicle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDriverName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbarLoading, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 541);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblWhereTo
            // 
            this.lblWhereTo.AutoSize = true;
            this.lblWhereTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWhereTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWhereTo.Location = new System.Drawing.Point(157, 147);
            this.lblWhereTo.Name = "lblWhereTo";
            this.lblWhereTo.Padding = new System.Windows.Forms.Padding(5);
            this.lblWhereTo.Size = new System.Drawing.Size(617, 30);
            this.lblWhereTo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 147);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(148, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Направление";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCargo.Location = new System.Drawing.Point(157, 117);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Padding = new System.Windows.Forms.Padding(5);
            this.lblCargo.Size = new System.Drawing.Size(617, 30);
            this.lblCargo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Груз";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDriverPhone
            // 
            this.lblDriverPhone.AutoSize = true;
            this.lblDriverPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDriverPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDriverPhone.Location = new System.Drawing.Point(157, 87);
            this.lblDriverPhone.Name = "lblDriverPhone";
            this.lblDriverPhone.Padding = new System.Windows.Forms.Padding(5);
            this.lblDriverPhone.Size = new System.Drawing.Size(617, 30);
            this.lblDriverPhone.TabIndex = 4;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblVehicle, 2);
            this.lblVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVehicle.Location = new System.Drawing.Point(3, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Padding = new System.Windows.Forms.Padding(10);
            this.lblVehicle.Size = new System.Drawing.Size(771, 57);
            this.lblVehicle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(148, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Водитель";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDriverName.Location = new System.Drawing.Point(157, 57);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Padding = new System.Windows.Forms.Padding(5);
            this.lblDriverName.Size = new System.Drawing.Size(617, 30);
            this.lblDriverName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Телефон";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbarLoading
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pbarLoading, 2);
            this.pbarLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbarLoading.Location = new System.Drawing.Point(3, 515);
            this.pbarLoading.Name = "pbarLoading";
            this.pbarLoading.Size = new System.Drawing.Size(771, 23);
            this.pbarLoading.TabIndex = 9;
            // 
            // tabControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl, 2);
            this.tabControl.Controls.Add(this.tpageHistory);
            this.tabControl.Controls.Add(this.tpageLog);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 180);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(771, 329);
            this.tabControl.TabIndex = 10;
            // 
            // tpageHistory
            // 
            this.tpageHistory.Controls.Add(this.dgvAppointHistory);
            this.tpageHistory.Location = new System.Drawing.Point(4, 22);
            this.tpageHistory.Name = "tpageHistory";
            this.tpageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tpageHistory.Size = new System.Drawing.Size(763, 303);
            this.tpageHistory.TabIndex = 0;
            this.tpageHistory.Text = "Обработка";
            this.tpageHistory.UseVisualStyleBackColor = true;
            // 
            // dgvAppointHistory
            // 
            this.dgvAppointHistory.AllowUserToAddRows = false;
            this.dgvAppointHistory.AllowUserToDeleteRows = false;
            this.dgvAppointHistory.AutoGenerateColumns = false;
            this.dgvAppointHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDateOperation,
            this.ColumnOperation,
            this.ColumnPoint});
            this.dgvAppointHistory.DataSource = this.bsAppointHistory;
            this.dgvAppointHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvAppointHistory.Name = "dgvAppointHistory";
            this.dgvAppointHistory.ReadOnly = true;
            this.dgvAppointHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointHistory.Size = new System.Drawing.Size(757, 297);
            this.dgvAppointHistory.TabIndex = 0;
            // 
            // tpageLog
            // 
            this.tpageLog.Controls.Add(this.dataGridView1);
            this.tpageLog.Location = new System.Drawing.Point(4, 22);
            this.tpageLog.Name = "tpageLog";
            this.tpageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpageLog.Size = new System.Drawing.Size(763, 303);
            this.tpageLog.TabIndex = 1;
            this.tpageLog.Text = "Операторы системы";
            this.tpageLog.UseVisualStyleBackColor = true;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 300;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // ColumnDateOperation
            // 
            this.ColumnDateOperation.DataPropertyName = "DateFrom";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.ColumnDateOperation.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnDateOperation.FillWeight = 150F;
            this.ColumnDateOperation.HeaderText = "Дата операции";
            this.ColumnDateOperation.Name = "ColumnDateOperation";
            this.ColumnDateOperation.ReadOnly = true;
            this.ColumnDateOperation.Width = 150;
            // 
            // ColumnOperation
            // 
            this.ColumnOperation.DataPropertyName = "Operation";
            this.ColumnOperation.FillWeight = 200F;
            this.ColumnOperation.HeaderText = "Операция";
            this.ColumnOperation.Name = "ColumnOperation";
            this.ColumnOperation.ReadOnly = true;
            this.ColumnOperation.Width = 200;
            // 
            // ColumnPoint
            // 
            this.ColumnPoint.DataPropertyName = "Point";
            this.ColumnPoint.FillWeight = 300F;
            this.ColumnPoint.HeaderText = "Пункт выполнения";
            this.ColumnPoint.Name = "ColumnPoint";
            this.ColumnPoint.ReadOnly = true;
            this.ColumnPoint.Width = 300;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLogOperation,
            this.ColumnHostName,
            this.ColumnUserName,
            this.ColumnLogTime});
            this.dataGridView1.DataSource = this.bsLog;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(757, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnLogOperation
            // 
            this.ColumnLogOperation.DataPropertyName = "Operation";
            this.ColumnLogOperation.HeaderText = "Операция";
            this.ColumnLogOperation.Name = "ColumnLogOperation";
            this.ColumnLogOperation.ReadOnly = true;
            // 
            // ColumnHostName
            // 
            this.ColumnHostName.DataPropertyName = "HostName";
            this.ColumnHostName.HeaderText = "Имя компьютера";
            this.ColumnHostName.Name = "ColumnHostName";
            this.ColumnHostName.ReadOnly = true;
            // 
            // ColumnUserName
            // 
            this.ColumnUserName.DataPropertyName = "UserName";
            this.ColumnUserName.HeaderText = "Пользователь";
            this.ColumnUserName.Name = "ColumnUserName";
            this.ColumnUserName.ReadOnly = true;
            // 
            // ColumnLogTime
            // 
            this.ColumnLogTime.DataPropertyName = "LogTime";
            this.ColumnLogTime.HeaderText = "Время выполнения";
            this.ColumnLogTime.Name = "ColumnLogTime";
            this.ColumnLogTime.ReadOnly = true;
            // 
            // FormAppointHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "FormAppointHistory";
            this.Text = "Прибывший автотранспорт";
            this.Load += new System.EventHandler(this.FormAppointHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAppointHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLog)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpageHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointHistory)).EndInit();
            this.tpageLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bwRefresh;
        private System.Windows.Forms.BindingSource bsAppointHistory;
        private System.Windows.Forms.BindingSource bsLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblWhereTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDriverPhone;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbarLoading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpageHistory;
        private System.Windows.Forms.DataGridView dgvAppointHistory;
        private System.Windows.Forms.TabPage tpageLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPoint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogTime;
    }
}