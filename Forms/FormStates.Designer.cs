namespace DispatcherService
{
    partial class FormStates
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
            this.epvGridStates = new EPV.Data.EPVGrid();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.epvGridStates);
            this.panelData.Size = new System.Drawing.Size(868, 369);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 369);
            this.panelBottom.Size = new System.Drawing.Size(868, 50);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(756, 15);
            // 
            // epvGridStates
            // 
            this.epvGridStates.ColoredBackground = false;
            this.epvGridStates.Database = null;
            this.epvGridStates.DataSource = null;
            this.epvGridStates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epvGridStates.EditAtGrid = true;
            this.epvGridStates.Footer = "";
            this.epvGridStates.Location = new System.Drawing.Point(0, 0);
            this.epvGridStates.Name = "epvGridStates";
            this.epvGridStates.Position = -1;
            this.epvGridStates.ReadOnly = false;
            this.epvGridStates.Size = new System.Drawing.Size(868, 369);
            this.epvGridStates.TabIndex = 0;
            this.epvGridStates.Title = "Список";
            // 
            // FormStates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 419);
            this.Name = "FormStates";
            this.Text = "Справочник стран";
            this.panelData.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EPV.Data.EPVGrid epvGridStates;
    }
}