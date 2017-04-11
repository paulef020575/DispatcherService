namespace DispatcherService
{
    partial class FormUnits
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
            this.epvGridUnits = new EPV.Data.EPVGrid();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.epvGridUnits);
            this.panelData.Size = new System.Drawing.Size(670, 372);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 372);
            this.panelBottom.Size = new System.Drawing.Size(670, 50);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(558, 15);
            // 
            // epvGridUnits
            // 
            this.epvGridUnits.ColoredBackground = false;
            this.epvGridUnits.Database = null;
            this.epvGridUnits.DataSource = null;
            this.epvGridUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epvGridUnits.EditAtGrid = true;
            this.epvGridUnits.Footer = "";
            this.epvGridUnits.Location = new System.Drawing.Point(0, 0);
            this.epvGridUnits.Name = "epvGridUnits";
            this.epvGridUnits.Position = -1;
            this.epvGridUnits.ReadOnly = false;
            this.epvGridUnits.Size = new System.Drawing.Size(670, 372);
            this.epvGridUnits.TabIndex = 0;
            this.epvGridUnits.Title = "Список";
            // 
            // FormUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 422);
            this.Name = "FormUnits";
            this.Text = "FormUnits";
            this.panelData.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EPV.Data.EPVGrid epvGridUnits;
    }
}