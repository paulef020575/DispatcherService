namespace DispatcherService.Forms
{
    partial class PlanAppointForm
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLst = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.pickPlanDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxDriverPhone = new System.Windows.Forms.TextBox();
            this.tboxDriverName = new System.Windows.Forms.TextBox();
            this.tboxLicensePlate = new System.Windows.Forms.TextBox();
            this.tboxTrackMark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bsRow = new System.Windows.Forms.BindingSource(this.components);
            this.chkClosed = new System.Windows.Forms.CheckBox();
            this.panelBottom.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnSave);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 298);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(463, 50);
            this.panelBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(351, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(245, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ОК";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.chkClosed);
            this.panelData.Controls.Add(this.textBoxCargo);
            this.panelData.Controls.Add(this.label7);
            this.panelData.Controls.Add(this.button5);
            this.panelData.Controls.Add(this.button4);
            this.panelData.Controls.Add(this.button3);
            this.panelData.Controls.Add(this.button2);
            this.panelData.Controls.Add(this.button1);
            this.panelData.Controls.Add(this.buttonLst);
            this.panelData.Controls.Add(this.buttonPaper);
            this.panelData.Controls.Add(this.pickPlanDate);
            this.panelData.Controls.Add(this.label6);
            this.panelData.Controls.Add(this.tboxNotes);
            this.panelData.Controls.Add(this.label5);
            this.panelData.Controls.Add(this.tboxDriverPhone);
            this.panelData.Controls.Add(this.tboxDriverName);
            this.panelData.Controls.Add(this.tboxLicensePlate);
            this.panelData.Controls.Add(this.tboxTrackMark);
            this.panelData.Controls.Add(this.label4);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(463, 298);
            this.panelData.TabIndex = 0;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCargo.Location = new System.Drawing.Point(127, 142);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(163, 20);
            this.textBoxCargo.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Груз";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(331, 165);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 23);
            this.button5.TabIndex = 36;
            this.button5.TabStop = false;
            this.button5.Text = "топ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(297, 165);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 35;
            this.button4.TabStop = false;
            this.button4.Text = "мзт";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(263, 165);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 23);
            this.button3.TabIndex = 34;
            this.button3.TabStop = false;
            this.button3.Text = "орг";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(229, 165);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 33;
            this.button2.TabStop = false;
            this.button2.Text = "крт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(195, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 32;
            this.button1.TabStop = false;
            this.button1.Text = "држ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLst
            // 
            this.buttonLst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLst.Location = new System.Drawing.Point(161, 165);
            this.buttonLst.Margin = new System.Windows.Forms.Padding(1);
            this.buttonLst.Name = "buttonLst";
            this.buttonLst.Size = new System.Drawing.Size(35, 23);
            this.buttonLst.TabIndex = 31;
            this.buttonLst.TabStop = false;
            this.buttonLst.Text = "лст";
            this.buttonLst.UseVisualStyleBackColor = true;
            this.buttonLst.Click += new System.EventHandler(this.buttonLst_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPaper.Location = new System.Drawing.Point(127, 165);
            this.buttonPaper.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(35, 23);
            this.buttonPaper.TabIndex = 30;
            this.buttonPaper.TabStop = false;
            this.buttonPaper.Text = "бмг";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // pickPlanDate
            // 
            this.pickPlanDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.pickPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickPlanDate.Location = new System.Drawing.Point(127, 12);
            this.pickPlanDate.Name = "pickPlanDate";
            this.pickPlanDate.ShowUpDown = true;
            this.pickPlanDate.Size = new System.Drawing.Size(179, 20);
            this.pickPlanDate.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Плановое прибытие";
            // 
            // tboxNotes
            // 
            this.tboxNotes.Location = new System.Drawing.Point(123, 210);
            this.tboxNotes.Multiline = true;
            this.tboxNotes.Name = "tboxNotes";
            this.tboxNotes.Size = new System.Drawing.Size(328, 47);
            this.tboxNotes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Примечание";
            // 
            // tboxDriverPhone
            // 
            this.tboxDriverPhone.Location = new System.Drawing.Point(127, 116);
            this.tboxDriverPhone.Name = "tboxDriverPhone";
            this.tboxDriverPhone.Size = new System.Drawing.Size(179, 20);
            this.tboxDriverPhone.TabIndex = 4;
            // 
            // tboxDriverName
            // 
            this.tboxDriverName.Location = new System.Drawing.Point(127, 90);
            this.tboxDriverName.Name = "tboxDriverName";
            this.tboxDriverName.Size = new System.Drawing.Size(179, 20);
            this.tboxDriverName.TabIndex = 3;
            // 
            // tboxLicensePlate
            // 
            this.tboxLicensePlate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tboxLicensePlate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxLicensePlate.Location = new System.Drawing.Point(127, 64);
            this.tboxLicensePlate.Name = "tboxLicensePlate";
            this.tboxLicensePlate.Size = new System.Drawing.Size(179, 20);
            this.tboxLicensePlate.TabIndex = 2;
            this.tboxLicensePlate.Leave += new System.EventHandler(this.tboxLicensePlate_Leave);
            // 
            // tboxTrackMark
            // 
            this.tboxTrackMark.Location = new System.Drawing.Point(127, 38);
            this.tboxTrackMark.Name = "tboxTrackMark";
            this.tboxTrackMark.Size = new System.Drawing.Size(179, 20);
            this.tboxTrackMark.TabIndex = 1;
            this.tboxTrackMark.Leave += new System.EventHandler(this.tboxTrackMark_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Водитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рег. номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка ТС";
            // 
            // chkClosed
            // 
            this.chkClosed.AutoSize = true;
            this.chkClosed.Location = new System.Drawing.Point(331, 15);
            this.chkClosed.Name = "chkClosed";
            this.chkClosed.Size = new System.Drawing.Size(69, 17);
            this.chkClosed.TabIndex = 39;
            this.chkClosed.Text = "закрыта";
            this.chkClosed.UseVisualStyleBackColor = true;
            // 
            // PlanAppointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 348);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelBottom);
            this.Name = "PlanAppointForm";
            this.Text = "Планируемое прибытие";
            this.Load += new System.EventHandler(this.PlanAppointForm_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.TextBox tboxDriverPhone;
        private System.Windows.Forms.TextBox tboxDriverName;
        private System.Windows.Forms.TextBox tboxLicensePlate;
        private System.Windows.Forms.TextBox tboxTrackMark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsRow;
        private System.Windows.Forms.TextBox tboxNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker pickPlanDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLst;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkClosed;
    }
}