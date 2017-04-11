namespace DispatcherService
{
    partial class FormGetAppoint
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
            this.comboBoxPoints = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerSetting = new System.Windows.Forms.DateTimePicker();
            this.labelReason = new System.Windows.Forms.Label();
            this.textBoxIdleReason = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.textBoxIdleReason);
            this.panelData.Controls.Add(this.labelReason);
            this.panelData.Controls.Add(this.comboBoxPoints);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.label7);
            this.panelData.Controls.Add(this.textBoxLicensePlate);
            this.panelData.Controls.Add(this.dateTimePickerSetting);
            this.panelData.Controls.Add(this.textBoxCargo);
            this.panelData.Size = new System.Drawing.Size(404, 191);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(292, 15);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonSave);
            this.panelBottom.Location = new System.Drawing.Point(0, 191);
            this.panelBottom.Size = new System.Drawing.Size(404, 50);
            this.panelBottom.Controls.SetChildIndex(this.buttonClose, 0);
            this.panelBottom.Controls.SetChildIndex(this.buttonSave, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Груз";
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCargo.Location = new System.Drawing.Point(224, 28);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.ReadOnly = true;
            this.textBoxCargo.Size = new System.Drawing.Size(163, 35);
            this.textBoxCargo.TabIndex = 16;
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.Font = new System.Drawing.Font("Arial", 28.25F);
            this.textBoxLicensePlate.Location = new System.Drawing.Point(12, 12);
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.ReadOnly = true;
            this.textBoxLicensePlate.Size = new System.Drawing.Size(188, 51);
            this.textBoxLicensePlate.TabIndex = 15;
            // 
            // comboBoxPoints
            // 
            this.comboBoxPoints.FormattingEnabled = true;
            this.comboBoxPoints.Location = new System.Drawing.Point(162, 69);
            this.comboBoxPoints.Name = "comboBoxPoints";
            this.comboBoxPoints.Size = new System.Drawing.Size(225, 21);
            this.comboBoxPoints.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Пункт погрузки/выгрузки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Время приема";
            // 
            // dateTimePickerSetting
            // 
            this.dateTimePickerSetting.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerSetting.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSetting.Location = new System.Drawing.Point(162, 96);
            this.dateTimePickerSetting.Name = "dateTimePickerSetting";
            this.dateTimePickerSetting.ShowUpDown = true;
            this.dateTimePickerSetting.Size = new System.Drawing.Size(132, 20);
            this.dateTimePickerSetting.TabIndex = 21;
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(25, 138);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(94, 13);
            this.labelReason.TabIndex = 25;
            this.labelReason.Text = "Причина простоя";
            // 
            // textBoxIdleReason
            // 
            this.textBoxIdleReason.Location = new System.Drawing.Point(127, 133);
            this.textBoxIdleReason.Multiline = true;
            this.textBoxIdleReason.Name = "textBoxIdleReason";
            this.textBoxIdleReason.Size = new System.Drawing.Size(259, 51);
            this.textBoxIdleReason.TabIndex = 26;
            this.textBoxIdleReason.WordWrap = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(186, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGetAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 241);
            this.Name = "FormGetAppoint";
            this.Text = "Принимаем транспорт";
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.ComboBox comboBoxPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerSetting;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.TextBox textBoxIdleReason;
        private System.Windows.Forms.Button buttonSave;
    }
}