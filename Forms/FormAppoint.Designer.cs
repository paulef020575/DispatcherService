namespace DispatcherService
{
    partial class FormAppoint
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
            this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTrailer = new System.Windows.Forms.TextBox();
            this.comboBoxCitizen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDriverName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWarrant = new System.Windows.Forms.TextBox();
            this.dateTimePickerComing = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTrackMark = new System.Windows.Forms.TextBox();
            this.textBoxDriverPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxWhereTo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonLst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.button5);
            this.panelData.Controls.Add(this.button4);
            this.panelData.Controls.Add(this.button3);
            this.panelData.Controls.Add(this.button2);
            this.panelData.Controls.Add(this.button1);
            this.panelData.Controls.Add(this.buttonLst);
            this.panelData.Controls.Add(this.buttonPaper);
            this.panelData.Controls.Add(this.textBoxWhereTo);
            this.panelData.Controls.Add(this.label11);
            this.panelData.Controls.Add(this.textBoxDriverPhone);
            this.panelData.Controls.Add(this.label10);
            this.panelData.Controls.Add(this.textBoxTrackMark);
            this.panelData.Controls.Add(this.label9);
            this.panelData.Controls.Add(this.label8);
            this.panelData.Controls.Add(this.label7);
            this.panelData.Controls.Add(this.dateTimePickerComing);
            this.panelData.Controls.Add(this.textBoxWarrant);
            this.panelData.Controls.Add(this.label6);
            this.panelData.Controls.Add(this.textBoxDriverName);
            this.panelData.Controls.Add(this.label5);
            this.panelData.Controls.Add(this.comboBoxUnits);
            this.panelData.Controls.Add(this.label4);
            this.panelData.Controls.Add(this.textBoxCargo);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Controls.Add(this.comboBoxCitizen);
            this.panelData.Controls.Add(this.textBoxTrailer);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.textBoxLicensePlate);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelData.Size = new System.Drawing.Size(478, 363);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(748, 15);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonSave);
            this.panelBottom.Location = new System.Drawing.Point(0, 363);
            this.panelBottom.Size = new System.Drawing.Size(860, 50);
            this.panelBottom.Controls.SetChildIndex(this.buttonClose, 0);
            this.panelBottom.Controls.SetChildIndex(this.buttonSave, 0);
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxLicensePlate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxLicensePlate.Font = new System.Drawing.Font("Arial", 28.25F);
            this.textBoxLicensePlate.Location = new System.Drawing.Point(159, 22);
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.Size = new System.Drawing.Size(307, 51);
            this.textBoxLicensePlate.TabIndex = 1;
            this.textBoxLicensePlate.Enter += new System.EventHandler(this.textBoxLicensePlate_Enter);
            this.textBoxLicensePlate.Leave += new System.EventHandler(this.textBoxLicensePlate_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "прицеп";
            // 
            // textBoxTrailer
            // 
            this.textBoxTrailer.Location = new System.Drawing.Point(61, 79);
            this.textBoxTrailer.Name = "textBoxTrailer";
            this.textBoxTrailer.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrailer.TabIndex = 2;
            // 
            // comboBoxCitizen
            // 
            this.comboBoxCitizen.FormattingEnabled = true;
            this.comboBoxCitizen.Location = new System.Drawing.Point(243, 79);
            this.comboBoxCitizen.Name = "comboBoxCitizen";
            this.comboBoxCitizen.Size = new System.Drawing.Size(70, 21);
            this.comboBoxCitizen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "страна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Груз";
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCargo.Location = new System.Drawing.Point(12, 129);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(163, 35);
            this.textBoxCargo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Получатель";
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Location = new System.Drawing.Point(198, 129);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(268, 33);
            this.comboBoxUnits.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Водитель";
            // 
            // textBoxDriverName
            // 
            this.textBoxDriverName.Location = new System.Drawing.Point(104, 205);
            this.textBoxDriverName.Name = "textBoxDriverName";
            this.textBoxDriverName.Size = new System.Drawing.Size(264, 20);
            this.textBoxDriverName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Доверенность";
            // 
            // textBoxWarrant
            // 
            this.textBoxWarrant.Location = new System.Drawing.Point(104, 254);
            this.textBoxWarrant.Name = "textBoxWarrant";
            this.textBoxWarrant.Size = new System.Drawing.Size(200, 20);
            this.textBoxWarrant.TabIndex = 8;
            // 
            // dateTimePickerComing
            // 
            this.dateTimePickerComing.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerComing.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerComing.Location = new System.Drawing.Point(104, 331);
            this.dateTimePickerComing.Name = "dateTimePickerComing";
            this.dateTimePickerComing.ShowUpDown = true;
            this.dateTimePickerComing.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerComing.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Время прибытия";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(642, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "номер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "марка";
            // 
            // textBoxTrackMark
            // 
            this.textBoxTrackMark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxTrackMark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTrackMark.Font = new System.Drawing.Font("Arial", 28.25F);
            this.textBoxTrackMark.Location = new System.Drawing.Point(12, 22);
            this.textBoxTrackMark.Name = "textBoxTrackMark";
            this.textBoxTrackMark.Size = new System.Drawing.Size(141, 51);
            this.textBoxTrackMark.TabIndex = 0;
            // 
            // textBoxDriverPhone
            // 
            this.textBoxDriverPhone.Location = new System.Drawing.Point(104, 228);
            this.textBoxDriverPhone.Name = "textBoxDriverPhone";
            this.textBoxDriverPhone.Size = new System.Drawing.Size(101, 20);
            this.textBoxDriverPhone.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Телефон";
            // 
            // textBoxWhereTo
            // 
            this.textBoxWhereTo.Location = new System.Drawing.Point(104, 300);
            this.textBoxWhereTo.Name = "textBoxWhereTo";
            this.textBoxWhereTo.Size = new System.Drawing.Size(362, 20);
            this.textBoxWhereTo.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Пункт назначения (заказчик)";
            // 
            // buttonPaper
            // 
            this.buttonPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPaper.Location = new System.Drawing.Point(12, 170);
            this.buttonPaper.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(35, 23);
            this.buttonPaper.TabIndex = 23;
            this.buttonPaper.TabStop = false;
            this.buttonPaper.Text = "бмг";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonLst
            // 
            this.buttonLst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLst.Location = new System.Drawing.Point(46, 170);
            this.buttonLst.Margin = new System.Windows.Forms.Padding(1);
            this.buttonLst.Name = "buttonLst";
            this.buttonLst.Size = new System.Drawing.Size(35, 23);
            this.buttonLst.TabIndex = 24;
            this.buttonLst.TabStop = false;
            this.buttonLst.Text = "лст";
            this.buttonLst.UseVisualStyleBackColor = true;
            this.buttonLst.Click += new System.EventHandler(this.buttonLst_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(80, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 25;
            this.button1.TabStop = false;
            this.button1.Text = "држ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(114, 170);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 26;
            this.button2.TabStop = false;
            this.button2.Text = "крт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(148, 170);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 23);
            this.button3.TabIndex = 27;
            this.button3.TabStop = false;
            this.button3.Text = "орг";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(182, 170);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 28;
            this.button4.TabStop = false;
            this.button4.Text = "мзт";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(216, 170);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 23);
            this.button5.TabIndex = 29;
            this.button5.TabStop = false;
            this.button5.Text = "топ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 413);
            this.Name = "FormAppoint";
            this.Text = "Прибывший транспорт";
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.TextBox textBoxTrailer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCitizen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.TextBox textBoxDriverName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWarrant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerComing;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxDriverPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTrackMark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxWhereTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLst;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;

    }
}