namespace DispatcherService.Forms
{
    partial class PointAppointsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cboxPoint = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tboxFind = new System.Windows.Forms.TextBox();
            this.buttonClearFind = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.queueColumnTrackInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueColumnDriverInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueColumnDateState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueColumnReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPointPositions = new System.Windows.Forms.Panel();
            this.dgvLoading = new System.Windows.Forms.DataGridView();
            this.loadingColumnTrackInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadingColumnDateState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadingColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadingColumnReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSetToLoading = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonRequeue = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsQueue = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.panelPointPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cboxPoint);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.tboxFind);
            this.panelTop.Controls.Add(this.buttonClearFind);
            this.panelTop.Controls.Add(this.lblTimer);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(969, 50);
            this.panelTop.TabIndex = 0;
            // 
            // cboxPoint
            // 
            this.cboxPoint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxPoint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxPoint.BackColor = System.Drawing.SystemColors.Window;
            this.cboxPoint.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboxPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxPoint.FormattingEnabled = true;
            this.cboxPoint.Location = new System.Drawing.Point(89, 0);
            this.cboxPoint.Name = "cboxPoint";
            this.cboxPoint.Size = new System.Drawing.Size(301, 50);
            this.cboxPoint.TabIndex = 6;
            this.cboxPoint.SelectedValueChanged += new System.EventHandler(this.eventRefreshData);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::DispatcherService.Properties.Resources.find_next;
            this.pictureBox1.Location = new System.Drawing.Point(681, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tboxFind
            // 
            this.tboxFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.tboxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxFind.Location = new System.Drawing.Point(731, 0);
            this.tboxFind.Name = "tboxFind";
            this.tboxFind.Size = new System.Drawing.Size(188, 49);
            this.tboxFind.TabIndex = 3;
            this.tboxFind.TabStop = false;
            this.tboxFind.TextChanged += new System.EventHandler(this.tboxFind_TextChanged);
            // 
            // buttonClearFind
            // 
            this.buttonClearFind.BackgroundImage = global::DispatcherService.Properties.Resources.delete2;
            this.buttonClearFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClearFind.Location = new System.Drawing.Point(919, 0);
            this.buttonClearFind.Name = "buttonClearFind";
            this.buttonClearFind.Size = new System.Drawing.Size(50, 50);
            this.buttonClearFind.TabIndex = 4;
            this.buttonClearFind.TabStop = false;
            this.buttonClearFind.UseVisualStyleBackColor = true;
            this.buttonClearFind.Click += new System.EventHandler(this.buttonClearFind_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(50, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(39, 42);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::DispatcherService.Properties.Resources.refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 50);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 515);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(969, 50);
            this.panelBottom.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvQueue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelPointPositions, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSetToLoading, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonFinish, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonRequeue, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(969, 465);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvQueue
            // 
            this.dgvQueue.AllowUserToAddRows = false;
            this.dgvQueue.AllowUserToDeleteRows = false;
            this.dgvQueue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.queueColumnTrackInfo,
            this.queueColumnDriverInfo,
            this.queueColumnDateState,
            this.queueColumnTime,
            this.queueColumnReason});
            this.dgvQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQueue.Location = new System.Drawing.Point(3, 3);
            this.dgvQueue.MultiSelect = false;
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.ReadOnly = true;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQueue.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tableLayoutPanel1.SetRowSpan(this.dgvQueue, 4);
            this.dgvQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueue.Size = new System.Drawing.Size(378, 459);
            this.dgvQueue.TabIndex = 0;
            this.dgvQueue.VirtualMode = true;
            this.dgvQueue.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvQueue_CellValueNeeded);
            this.dgvQueue.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvQueue_RowPrePaint);
            this.dgvQueue.Enter += new System.EventHandler(this.dgvQueue_Enter);
            // 
            // queueColumnTrackInfo
            // 
            this.queueColumnTrackInfo.DataPropertyName = "TrackInfo";
            this.queueColumnTrackInfo.HeaderText = "Т/С";
            this.queueColumnTrackInfo.Name = "queueColumnTrackInfo";
            this.queueColumnTrackInfo.ReadOnly = true;
            // 
            // queueColumnDriverInfo
            // 
            this.queueColumnDriverInfo.DataPropertyName = "DriverInfo";
            this.queueColumnDriverInfo.HeaderText = "водитель";
            this.queueColumnDriverInfo.Name = "queueColumnDriverInfo";
            this.queueColumnDriverInfo.ReadOnly = true;
            // 
            // queueColumnDateState
            // 
            this.queueColumnDateState.DataPropertyName = "Date";
            this.queueColumnDateState.HeaderText = "отправлен";
            this.queueColumnDateState.Name = "queueColumnDateState";
            this.queueColumnDateState.ReadOnly = true;
            // 
            // queueColumnTime
            // 
            this.queueColumnTime.HeaderText = "время";
            this.queueColumnTime.Name = "queueColumnTime";
            this.queueColumnTime.ReadOnly = true;
            // 
            // queueColumnReason
            // 
            this.queueColumnReason.DataPropertyName = "IdleReason";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.queueColumnReason.DefaultCellStyle = dataGridViewCellStyle5;
            this.queueColumnReason.HeaderText = "сообщение";
            this.queueColumnReason.Name = "queueColumnReason";
            this.queueColumnReason.ReadOnly = true;
            // 
            // panelPointPositions
            // 
            this.panelPointPositions.Controls.Add(this.dgvLoading);
            this.panelPointPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPointPositions.Location = new System.Drawing.Point(587, 3);
            this.panelPointPositions.Name = "panelPointPositions";
            this.tableLayoutPanel1.SetRowSpan(this.panelPointPositions, 4);
            this.panelPointPositions.Size = new System.Drawing.Size(379, 459);
            this.panelPointPositions.TabIndex = 1;
            // 
            // dgvLoading
            // 
            this.dgvLoading.AllowUserToAddRows = false;
            this.dgvLoading.AllowUserToDeleteRows = false;
            this.dgvLoading.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvLoading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoading.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loadingColumnTrackInfo,
            this.dataGridViewTextBoxColumn2,
            this.loadingColumnDateState,
            this.loadingColumnTime,
            this.loadingColumnReason});
            this.dgvLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoading.Location = new System.Drawing.Point(0, 0);
            this.dgvLoading.MultiSelect = false;
            this.dgvLoading.Name = "dgvLoading";
            this.dgvLoading.ReadOnly = true;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoading.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLoading.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoading.Size = new System.Drawing.Size(379, 459);
            this.dgvLoading.TabIndex = 2;
            this.dgvLoading.VirtualMode = true;
            this.dgvLoading.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvQueue_CellValueNeeded);
            this.dgvLoading.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvQueue_RowPrePaint);
            this.dgvLoading.Enter += new System.EventHandler(this.dgvLoading_Enter);
            // 
            // loadingColumnTrackInfo
            // 
            this.loadingColumnTrackInfo.DataPropertyName = "TrackInfo";
            this.loadingColumnTrackInfo.HeaderText = "Т/С";
            this.loadingColumnTrackInfo.Name = "loadingColumnTrackInfo";
            this.loadingColumnTrackInfo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DriverInfo";
            this.dataGridViewTextBoxColumn2.HeaderText = "водитель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // loadingColumnDateState
            // 
            this.loadingColumnDateState.DataPropertyName = "Date";
            this.loadingColumnDateState.HeaderText = "поставлен";
            this.loadingColumnDateState.Name = "loadingColumnDateState";
            this.loadingColumnDateState.ReadOnly = true;
            // 
            // loadingColumnTime
            // 
            this.loadingColumnTime.HeaderText = "время";
            this.loadingColumnTime.Name = "loadingColumnTime";
            this.loadingColumnTime.ReadOnly = true;
            // 
            // loadingColumnReason
            // 
            this.loadingColumnReason.DataPropertyName = "IdleReason";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loadingColumnReason.DefaultCellStyle = dataGridViewCellStyle7;
            this.loadingColumnReason.HeaderText = "сообщение";
            this.loadingColumnReason.Name = "loadingColumnReason";
            this.loadingColumnReason.ReadOnly = true;
            // 
            // buttonSetToLoading
            // 
            this.buttonSetToLoading.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSetToLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetToLoading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetToLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetToLoading.Location = new System.Drawing.Point(384, 0);
            this.buttonSetToLoading.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSetToLoading.Name = "buttonSetToLoading";
            this.buttonSetToLoading.Size = new System.Drawing.Size(200, 50);
            this.buttonSetToLoading.TabIndex = 2;
            this.buttonSetToLoading.Text = "Погрузка / выгрузка";
            this.buttonSetToLoading.UseVisualStyleBackColor = false;
            this.buttonSetToLoading.Click += new System.EventHandler(this.buttonSetToLoading_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.BackColor = System.Drawing.Color.Salmon;
            this.buttonFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFinish.Location = new System.Drawing.Point(384, 50);
            this.buttonFinish.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(200, 50);
            this.buttonFinish.TabIndex = 3;
            this.buttonFinish.Text = "Завершение погрузки / выгрузки";
            this.buttonFinish.UseVisualStyleBackColor = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonRequeue
            // 
            this.buttonRequeue.BackColor = System.Drawing.Color.Khaki;
            this.buttonRequeue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRequeue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRequeue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRequeue.Location = new System.Drawing.Point(384, 100);
            this.buttonRequeue.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRequeue.Name = "buttonRequeue";
            this.buttonRequeue.Size = new System.Drawing.Size(200, 50);
            this.buttonRequeue.TabIndex = 4;
            this.buttonRequeue.Text = "Переадресация";
            this.buttonRequeue.UseVisualStyleBackColor = false;
            this.buttonRequeue.Click += new System.EventHandler(this.buttonRequeue_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TrackInfo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Т/С";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "отправлен";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "время";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TrackInfo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Т/С";
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
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "отправлен";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "время";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // PointAppointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 565);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "PointAppointsForm";
            this.Text = "Отгрузка транспорта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PointAppointsForm_FormClosed);
            this.Load += new System.EventHandler(this.PointAppointsForm_Load);
            this.Shown += new System.EventHandler(this.PointAppointsForm_Shown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.panelPointPositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQueue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.BindingSource bsQueue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.Panel panelPointPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dgvLoading;
        private System.Windows.Forms.Button buttonSetToLoading;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonRequeue;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueColumnTrackInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueColumnDriverInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueColumnDateState;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn queueColumnReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadingColumnTrackInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadingColumnDateState;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadingColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadingColumnReason;
        private System.Windows.Forms.TextBox tboxFind;
        private System.Windows.Forms.Button buttonClearFind;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboxPoint;
    }
}