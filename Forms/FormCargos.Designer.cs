namespace DispatcherService
{
    partial class FormCargos
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
            this.epvGridCargos = new EPV.Data.EPVGrid();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.epvGridCargos);
            // 
            // epvGridCargos
            // 
            this.epvGridCargos.ColoredBackground = false;
            this.epvGridCargos.Database = null;
            this.epvGridCargos.DataSource = null;
            this.epvGridCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epvGridCargos.EditAtGrid = true;
            this.epvGridCargos.Footer = "";
            this.epvGridCargos.Location = new System.Drawing.Point(0, 0);
            this.epvGridCargos.Name = "epvGridCargos";
            this.epvGridCargos.Position = -1;
            this.epvGridCargos.ReadOnly = false;
            this.epvGridCargos.Size = new System.Drawing.Size(539, 236);
            this.epvGridCargos.TabIndex = 0;
            this.epvGridCargos.Title = "Список";
            // 
            // FormCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 286);
            this.Name = "FormCargos";
            this.Text = "Справочник грузов";
            this.panelData.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EPV.Data.EPVGrid epvGridCargos;
    }
}