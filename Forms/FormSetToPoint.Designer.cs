namespace DispatcherService
{
    partial class FormSetToPoint
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
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerSetting = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPoints = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.comboBoxPoints);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.label7);
            this.panelData.Controls.Add(this.dateTimePickerSetting);
            this.panelData.Controls.Add(this.label4);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.comboBoxUnits);
            this.panelData.Controls.Add(this.textBoxCargo);
            this.panelData.Controls.Add(this.textBoxLicensePlate);
            this.panelData.Size = new System.Drawing.Size(438, 195);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(326, 15);
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonSave);
            this.panelBottom.Location = new System.Drawing.Point(0, 195);
            this.panelBottom.Size = new System.Drawing.Size(438, 50);
            this.panelBottom.Controls.SetChildIndex(this.buttonClose, 0);
            this.panelBottom.Controls.SetChildIndex(this.buttonSave, 0);
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Location = new System.Drawing.Point(198, 88);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(170, 33);
            this.comboBoxUnits.TabIndex = 13;
            this.comboBoxUnits.SelectedValueChanged += new System.EventHandler(this.comboBoxUnits_SelectedValueChanged);
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCargo.Location = new System.Drawing.Point(12, 88);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.ReadOnly = true;
            this.textBoxCargo.Size = new System.Drawing.Size(163, 35);
            this.textBoxCargo.TabIndex = 12;
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.Font = new System.Drawing.Font("Arial", 28.25F);
            this.textBoxLicensePlate.Location = new System.Drawing.Point(12, 12);
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.ReadOnly = true;
            this.textBoxLicensePlate.Size = new System.Drawing.Size(188, 51);
            this.textBoxLicensePlate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Получатель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Груз";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Время отправки";
            // 
            // dateTimePickerSetting
            // 
            this.dateTimePickerSetting.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerSetting.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSetting.Location = new System.Drawing.Point(111, 160);
            this.dateTimePickerSetting.Name = "dateTimePickerSetting";
            this.dateTimePickerSetting.ShowUpDown = true;
            this.dateTimePickerSetting.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerSetting.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Пункт обработки";
            // 
            // comboBoxPoints
            // 
            this.comboBoxPoints.FormattingEnabled = true;
            this.comboBoxPoints.Location = new System.Drawing.Point(111, 133);
            this.comboBoxPoints.Name = "comboBoxPoints";
            this.comboBoxPoints.Size = new System.Drawing.Size(257, 21);
            this.comboBoxPoints.TabIndex = 20;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(220, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormSetToPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 245);
            this.Name = "FormSetToPoint";
            this.Text = "Отправить на обработку";
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerSetting;
        private System.Windows.Forms.ComboBox comboBoxPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
    }
}