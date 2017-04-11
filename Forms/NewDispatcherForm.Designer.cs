namespace DispatcherService.Forms
{
    partial class NewDispatcherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.factPage = new System.Windows.Forms.TabPage();
            this.workPage = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSetOut = new System.Windows.Forms.Button();
            this.buttonAppointEdit = new System.Windows.Forms.Button();
            this.buttonAppointNew = new System.Windows.Forms.Button();
            this.dgvDispatcher = new System.Windows.Forms.DataGridView();
            this.columnDateComing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTrackInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDriverInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUnitInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPointInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdleReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAppoints = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.planPage = new System.Windows.Forms.TabPage();
            this.tablePlanPage = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClosePlan = new System.Windows.Forms.Button();
            this.buttonGetPlan = new System.Windows.Forms.Button();
            this.dgvPlanAppoints = new System.Windows.Forms.DataGridView();
            this.columnPlanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPlanTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPlanDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPlanAppoints = new System.Windows.Forms.BindingSource(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.factPage.SuspendLayout();
            this.workPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAppoints)).BeginInit();
            this.planPage.SuspendLayout();
            this.tablePlanPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanAppoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanAppoints)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonClear);
            this.panelTop.Controls.Add(this.btnFindNext);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.lblTimer);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1091, 50);
            this.panelTop.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = global::DispatcherService.Properties.Resources.delete2;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClear.Location = new System.Drawing.Point(219, 0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(25, 25);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.TabStop = false;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.BackgroundImage = global::DispatcherService.Properties.Resources.find_next;
            this.btnFindNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindNext.Location = new System.Drawing.Point(188, 0);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(25, 25);
            this.btnFindNext.TabIndex = 4;
            this.btnFindNext.TabStop = false;
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(134, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(50, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(70, 51);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "45";
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
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.factPage);
            this.tabControl.Controls.Add(this.planPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1091, 532);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // factPage
            // 
            this.factPage.Controls.Add(this.workPage);
            this.factPage.Location = new System.Drawing.Point(4, 22);
            this.factPage.Name = "factPage";
            this.factPage.Padding = new System.Windows.Forms.Padding(3);
            this.factPage.Size = new System.Drawing.Size(1083, 506);
            this.factPage.TabIndex = 0;
            this.factPage.Text = "Очередь";
            this.factPage.UseVisualStyleBackColor = true;
            // 
            // workPage
            // 
            this.workPage.ColumnCount = 2;
            this.workPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.workPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.workPage.Controls.Add(this.buttonSetOut, 1, 3);
            this.workPage.Controls.Add(this.buttonAppointEdit, 0, 1);
            this.workPage.Controls.Add(this.buttonAppointNew, 0, 0);
            this.workPage.Controls.Add(this.dgvDispatcher, 0, 0);
            this.workPage.Controls.Add(this.buttonNextStep, 1, 2);
            this.workPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPage.Location = new System.Drawing.Point(3, 3);
            this.workPage.Name = "workPage";
            this.workPage.RowCount = 5;
            this.workPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.workPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.workPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.workPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.workPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.workPage.Size = new System.Drawing.Size(1077, 500);
            this.workPage.TabIndex = 0;
            // 
            // buttonSetOut
            // 
            this.buttonSetOut.BackColor = System.Drawing.Color.Salmon;
            this.buttonSetOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetOut.Location = new System.Drawing.Point(877, 150);
            this.buttonSetOut.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSetOut.Name = "buttonSetOut";
            this.buttonSetOut.Size = new System.Drawing.Size(200, 50);
            this.buttonSetOut.TabIndex = 6;
            this.buttonSetOut.Text = "Отказать в приеме";
            this.buttonSetOut.UseVisualStyleBackColor = false;
            this.buttonSetOut.Click += new System.EventHandler(this.buttonSetOut_Click);
            // 
            // buttonAppointEdit
            // 
            this.buttonAppointEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAppointEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAppointEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAppointEdit.Location = new System.Drawing.Point(877, 50);
            this.buttonAppointEdit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAppointEdit.Name = "buttonAppointEdit";
            this.buttonAppointEdit.Size = new System.Drawing.Size(200, 50);
            this.buttonAppointEdit.TabIndex = 3;
            this.buttonAppointEdit.Text = "Изменение данных";
            this.buttonAppointEdit.UseVisualStyleBackColor = true;
            this.buttonAppointEdit.Click += new System.EventHandler(this.buttonAppointEdit_Click);
            // 
            // buttonAppointNew
            // 
            this.buttonAppointNew.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAppointNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAppointNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAppointNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAppointNew.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonAppointNew.Location = new System.Drawing.Point(877, 0);
            this.buttonAppointNew.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAppointNew.Name = "buttonAppointNew";
            this.buttonAppointNew.Size = new System.Drawing.Size(200, 50);
            this.buttonAppointNew.TabIndex = 1;
            this.buttonAppointNew.Text = "Прибытие транспорта";
            this.buttonAppointNew.UseVisualStyleBackColor = false;
            this.buttonAppointNew.Click += new System.EventHandler(this.buttonAppointNew_Click);
            // 
            // dgvDispatcher
            // 
            this.dgvDispatcher.AllowUserToAddRows = false;
            this.dgvDispatcher.AllowUserToDeleteRows = false;
            this.dgvDispatcher.AutoGenerateColumns = false;
            this.dgvDispatcher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDispatcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispatcher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDateComing,
            this.columnTrackInfo,
            this.columnDriverInfo,
            this.columnUnitInfo,
            this.columnPointInfo,
            this.columnIdleReason});
            this.dgvDispatcher.DataSource = this.bsAppoints;
            this.dgvDispatcher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDispatcher.Location = new System.Drawing.Point(3, 3);
            this.dgvDispatcher.Name = "dgvDispatcher";
            this.dgvDispatcher.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDispatcher.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.workPage.SetRowSpan(this.dgvDispatcher, 5);
            this.dgvDispatcher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDispatcher.Size = new System.Drawing.Size(871, 494);
            this.dgvDispatcher.TabIndex = 0;
            this.dgvDispatcher.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDispatcher_CellPainting);
            // 
            // columnDateComing
            // 
            this.columnDateComing.DataPropertyName = "dateComing";
            this.columnDateComing.HeaderText = "Дата прибытия";
            this.columnDateComing.Name = "columnDateComing";
            this.columnDateComing.ReadOnly = true;
            this.columnDateComing.Width = 75;
            // 
            // columnTrackInfo
            // 
            this.columnTrackInfo.DataPropertyName = "TrackInfo";
            this.columnTrackInfo.HeaderText = "Т/средство";
            this.columnTrackInfo.Name = "columnTrackInfo";
            this.columnTrackInfo.ReadOnly = true;
            this.columnTrackInfo.Width = 125;
            // 
            // columnDriverInfo
            // 
            this.columnDriverInfo.DataPropertyName = "DriverInfo";
            this.columnDriverInfo.HeaderText = "Водитель";
            this.columnDriverInfo.Name = "columnDriverInfo";
            this.columnDriverInfo.ReadOnly = true;
            this.columnDriverInfo.Width = 150;
            // 
            // columnUnitInfo
            // 
            this.columnUnitInfo.DataPropertyName = "UnitInfo";
            this.columnUnitInfo.HeaderText = "подразделение доверенность (груз)";
            this.columnUnitInfo.Name = "columnUnitInfo";
            this.columnUnitInfo.ReadOnly = true;
            // 
            // columnPointInfo
            // 
            this.columnPointInfo.DataPropertyName = "PointInfo";
            this.columnPointInfo.HeaderText = "Пункт погрузки/выгрузки Дата принятия";
            this.columnPointInfo.Name = "columnPointInfo";
            this.columnPointInfo.ReadOnly = true;
            this.columnPointInfo.Width = 150;
            // 
            // columnIdleReason
            // 
            this.columnIdleReason.DataPropertyName = "IdleReason";
            this.columnIdleReason.HeaderText = "Причина простоя";
            this.columnIdleReason.Name = "columnIdleReason";
            this.columnIdleReason.ReadOnly = true;
            this.columnIdleReason.Width = 200;
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.BackColor = System.Drawing.Color.Khaki;
            this.buttonNextStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextStep.Location = new System.Drawing.Point(877, 100);
            this.buttonNextStep.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(200, 50);
            this.buttonNextStep.TabIndex = 4;
            this.buttonNextStep.Text = "Отправить на обработку";
            this.buttonNextStep.UseVisualStyleBackColor = false;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // planPage
            // 
            this.planPage.Controls.Add(this.tablePlanPage);
            this.planPage.Location = new System.Drawing.Point(4, 22);
            this.planPage.Name = "planPage";
            this.planPage.Padding = new System.Windows.Forms.Padding(3);
            this.planPage.Size = new System.Drawing.Size(1083, 506);
            this.planPage.TabIndex = 1;
            this.planPage.Text = "План прибытия";
            this.planPage.UseVisualStyleBackColor = true;
            // 
            // tablePlanPage
            // 
            this.tablePlanPage.ColumnCount = 2;
            this.tablePlanPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePlanPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tablePlanPage.Controls.Add(this.buttonClosePlan, 0, 1);
            this.tablePlanPage.Controls.Add(this.buttonGetPlan, 0, 0);
            this.tablePlanPage.Controls.Add(this.dgvPlanAppoints, 0, 0);
            this.tablePlanPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePlanPage.Location = new System.Drawing.Point(3, 3);
            this.tablePlanPage.Name = "tablePlanPage";
            this.tablePlanPage.RowCount = 3;
            this.tablePlanPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePlanPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePlanPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePlanPage.Size = new System.Drawing.Size(1077, 500);
            this.tablePlanPage.TabIndex = 0;
            // 
            // buttonClosePlan
            // 
            this.buttonClosePlan.BackColor = System.Drawing.Color.Salmon;
            this.buttonClosePlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClosePlan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClosePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClosePlan.Location = new System.Drawing.Point(877, 50);
            this.buttonClosePlan.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClosePlan.Name = "buttonClosePlan";
            this.buttonClosePlan.Size = new System.Drawing.Size(200, 50);
            this.buttonClosePlan.TabIndex = 7;
            this.buttonClosePlan.Text = "Отказать в приеме";
            this.buttonClosePlan.UseVisualStyleBackColor = false;
            this.buttonClosePlan.Click += new System.EventHandler(this.buttonClosePlan_Click);
            // 
            // buttonGetPlan
            // 
            this.buttonGetPlan.BackColor = System.Drawing.Color.LightGreen;
            this.buttonGetPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGetPlan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGetPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetPlan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonGetPlan.Location = new System.Drawing.Point(877, 0);
            this.buttonGetPlan.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGetPlan.Name = "buttonGetPlan";
            this.buttonGetPlan.Size = new System.Drawing.Size(200, 50);
            this.buttonGetPlan.TabIndex = 2;
            this.buttonGetPlan.Text = "Прибытие транспорта";
            this.buttonGetPlan.UseVisualStyleBackColor = false;
            this.buttonGetPlan.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPlanAppoints
            // 
            this.dgvPlanAppoints.AllowUserToAddRows = false;
            this.dgvPlanAppoints.AllowUserToDeleteRows = false;
            this.dgvPlanAppoints.AutoGenerateColumns = false;
            this.dgvPlanAppoints.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvPlanAppoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanAppoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnPlanDate,
            this.columnPlanTrack,
            this.columnPlanDriver});
            this.dgvPlanAppoints.DataSource = this.bsPlanAppoints;
            this.dgvPlanAppoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanAppoints.Location = new System.Drawing.Point(3, 3);
            this.dgvPlanAppoints.Name = "dgvPlanAppoints";
            this.dgvPlanAppoints.ReadOnly = true;
            this.tablePlanPage.SetRowSpan(this.dgvPlanAppoints, 3);
            this.dgvPlanAppoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanAppoints.Size = new System.Drawing.Size(871, 494);
            this.dgvPlanAppoints.TabIndex = 0;
            this.dgvPlanAppoints.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDispatcher_CellPainting);
            // 
            // columnPlanDate
            // 
            this.columnPlanDate.DataPropertyName = "PlanDate";
            this.columnPlanDate.HeaderText = "план прибытия";
            this.columnPlanDate.Name = "columnPlanDate";
            this.columnPlanDate.ReadOnly = true;
            // 
            // columnPlanTrack
            // 
            this.columnPlanTrack.DataPropertyName = "TrackInfo";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnPlanTrack.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnPlanTrack.HeaderText = "т/средство";
            this.columnPlanTrack.Name = "columnPlanTrack";
            this.columnPlanTrack.ReadOnly = true;
            this.columnPlanTrack.Width = 200;
            // 
            // columnPlanDriver
            // 
            this.columnPlanDriver.DataPropertyName = "DriverInfo";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnPlanDriver.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnPlanDriver.HeaderText = "водитель";
            this.columnPlanDriver.Name = "columnPlanDriver";
            this.columnPlanDriver.ReadOnly = true;
            this.columnPlanDriver.Width = 200;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dateComing";
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата прибытия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TrackInfo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Т/средство";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DriverInfo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Водитель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UnitInfo";
            this.dataGridViewTextBoxColumn4.HeaderText = "подразделение доверенность (груз)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PointInfo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Пункт погрузки/выгрузки Дата принятия";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdleReason";
            this.dataGridViewTextBoxColumn6.HeaderText = "Причина простоя";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PlanDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "план прибытия";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TrackInfo";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn8.HeaderText = "т/средство";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DriverInfo";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn9.HeaderText = "водитель";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // NewDispatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 582);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelTop);
            this.Name = "NewDispatcherForm";
            this.Text = "Новая диспетчерская";
            this.Load += new System.EventHandler(this.NewDispatcherForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.factPage.ResumeLayout(false);
            this.workPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAppoints)).EndInit();
            this.planPage.ResumeLayout(false);
            this.tablePlanPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanAppoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanAppoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage factPage;
        private System.Windows.Forms.TabPage planPage;
        private System.Windows.Forms.BindingSource bsAppoints;
        private System.Windows.Forms.TableLayoutPanel tablePlanPage;
        private System.Windows.Forms.DataGridView dgvPlanAppoints;
        private System.Windows.Forms.BindingSource bsPlanAppoints;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPlanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPlanTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPlanDriver;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel workPage;
        private System.Windows.Forms.Button buttonAppointEdit;
        private System.Windows.Forms.Button buttonAppointNew;
        private System.Windows.Forms.DataGridView dgvDispatcher;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateComing;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTrackInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDriverInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUnitInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPointInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdleReason;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.Button buttonSetOut;
        private System.Windows.Forms.Button buttonClosePlan;
        private System.Windows.Forms.Button buttonGetPlan;
    }
}