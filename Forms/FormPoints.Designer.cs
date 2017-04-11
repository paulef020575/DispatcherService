namespace DispatcherService
{
    partial class FormPoints
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
            this.panelFilter = new System.Windows.Forms.Panel();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epvGridPoints = new EPV.Data.EPVGrid();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.epvGridPoints);
            this.panelData.Controls.Add(this.panelFilter);
            this.panelData.Size = new System.Drawing.Size(887, 382);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 382);
            this.panelBottom.Size = new System.Drawing.Size(887, 50);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(775, 15);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.comboBoxUnits);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(887, 35);
            this.panelFilter.TabIndex = 0;
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Location = new System.Drawing.Point(105, 6);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(169, 21);
            this.comboBoxUnits.TabIndex = 1;
            this.comboBoxUnits.SelectedValueChanged += new System.EventHandler(this.comboBoxUnits_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подразделение";
            // 
            // epvGridPoints
            // 
            this.epvGridPoints.ColoredBackground = false;
            this.epvGridPoints.Database = null;
            this.epvGridPoints.DataSource = null;
            this.epvGridPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epvGridPoints.EditAtGrid = true;
            this.epvGridPoints.Footer = "";
            this.epvGridPoints.Location = new System.Drawing.Point(0, 35);
            this.epvGridPoints.Name = "epvGridPoints";
            this.epvGridPoints.Position = -1;
            this.epvGridPoints.ReadOnly = false;
            this.epvGridPoints.Size = new System.Drawing.Size(887, 347);
            this.epvGridPoints.TabIndex = 1;
            this.epvGridPoints.Title = "Список";
            // 
            // FormPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 432);
            this.Name = "FormPoints";
            this.Text = "FormPoints";
            this.panelData.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label label1;
        private EPV.Data.EPVGrid epvGridPoints;
    }
}