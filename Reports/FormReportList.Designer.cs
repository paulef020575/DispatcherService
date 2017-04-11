namespace DispatcherService
{
    partial class FormReportList
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pickerTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.pickerTimeTo = new System.Windows.Forms.DateTimePicker();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.pickerTimeTo);
            this.panelData.Controls.Add(this.pickerTimeFrom);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.comboBoxUnits);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Controls.Add(this.dateTimePickerTo);
            this.panelData.Controls.Add(this.dateTimePickerFrom);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Size = new System.Drawing.Size(356, 106);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(61, 15);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonPrint);
            this.panelBottom.Location = new System.Drawing.Point(0, 106);
            this.panelBottom.Size = new System.Drawing.Size(356, 50);
            this.panelBottom.Controls.SetChildIndex(this.buttonClose, 0);
            this.panelBottom.Controls.SetChildIndex(this.buttonPrint, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Период";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(114, 13);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(218, 13);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(138, 15);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(100, 23);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Подразделение";
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Location = new System.Drawing.Point(114, 42);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(202, 21);
            this.comboBoxUnits.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Смена";
            // 
            // pickerTimeFrom
            // 
            this.pickerTimeFrom.CustomFormat = "HH:mm";
            this.pickerTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerTimeFrom.Location = new System.Drawing.Point(114, 69);
            this.pickerTimeFrom.Name = "pickerTimeFrom";
            this.pickerTimeFrom.ShowUpDown = true;
            this.pickerTimeFrom.Size = new System.Drawing.Size(62, 20);
            this.pickerTimeFrom.TabIndex = 6;
            this.pickerTimeFrom.Value = new System.DateTime(2013, 8, 2, 0, 0, 0, 0);
            // 
            // pickerTimeTo
            // 
            this.pickerTimeTo.CustomFormat = "HH:mm";
            this.pickerTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerTimeTo.Location = new System.Drawing.Point(182, 69);
            this.pickerTimeTo.Name = "pickerTimeTo";
            this.pickerTimeTo.ShowUpDown = true;
            this.pickerTimeTo.Size = new System.Drawing.Size(62, 20);
            this.pickerTimeTo.TabIndex = 7;
            this.pickerTimeTo.Value = new System.DateTime(2013, 8, 2, 0, 0, 0, 0);
            // 
            // FormReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 156);
            this.Name = "FormReportList";
            this.Text = "Список прибывшего автотранспорта";
            this.Load += new System.EventHandler(this.FormReportList_Load);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker pickerTimeTo;
        private System.Windows.Forms.DateTimePicker pickerTimeFrom;
    }
}