namespace DispatcherService
{
    partial class FormBrakeOrOut
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
            this.textBoxIdleReason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNoPaper = new System.Windows.Forms.Button();
            this.buttonTooMany = new System.Windows.Forms.Button();
            this.buttonNoWarrant = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.buttonNoWarrant);
            this.panelData.Controls.Add(this.buttonTooMany);
            this.panelData.Controls.Add(this.buttonNoPaper);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.textBoxIdleReason);
            this.panelData.Controls.Add(this.textBoxLicensePlate);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Controls.Add(this.textBoxCargo);
            this.panelData.Size = new System.Drawing.Size(396, 159);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonSave);
            this.panelBottom.Location = new System.Drawing.Point(0, 159);
            this.panelBottom.Size = new System.Drawing.Size(396, 50);
            this.panelBottom.Controls.SetChildIndex(this.buttonClose, 0);
            this.panelBottom.Controls.SetChildIndex(this.buttonSave, 0);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(284, 15);
            // 
            // textBoxIdleReason
            // 
            this.textBoxIdleReason.Location = new System.Drawing.Point(128, 69);
            this.textBoxIdleReason.Multiline = true;
            this.textBoxIdleReason.Name = "textBoxIdleReason";
            this.textBoxIdleReason.Size = new System.Drawing.Size(259, 51);
            this.textBoxIdleReason.TabIndex = 30;
            this.textBoxIdleReason.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Причина простоя";
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.Font = new System.Drawing.Font("Arial", 28.25F);
            this.textBoxLicensePlate.Location = new System.Drawing.Point(12, 12);
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.ReadOnly = true;
            this.textBoxLicensePlate.Size = new System.Drawing.Size(188, 51);
            this.textBoxLicensePlate.TabIndex = 27;
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
            this.textBoxCargo.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Груз";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(178, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNoPaper
            // 
            this.buttonNoPaper.Location = new System.Drawing.Point(128, 126);
            this.buttonNoPaper.Name = "buttonNoPaper";
            this.buttonNoPaper.Size = new System.Drawing.Size(75, 23);
            this.buttonNoPaper.TabIndex = 32;
            this.buttonNoPaper.TabStop = false;
            this.buttonNoPaper.Text = "нет бумаги";
            this.buttonNoPaper.UseVisualStyleBackColor = true;
            this.buttonNoPaper.Click += new System.EventHandler(this.buttonNoPaper_Click);
            // 
            // buttonTooMany
            // 
            this.buttonTooMany.Location = new System.Drawing.Point(209, 126);
            this.buttonTooMany.Name = "buttonTooMany";
            this.buttonTooMany.Size = new System.Drawing.Size(75, 23);
            this.buttonTooMany.TabIndex = 33;
            this.buttonTooMany.TabStop = false;
            this.buttonTooMany.Text = "очередь";
            this.buttonTooMany.UseVisualStyleBackColor = true;
            this.buttonTooMany.Click += new System.EventHandler(this.buttonTooMany_Click);
            // 
            // buttonNoWarrant
            // 
            this.buttonNoWarrant.Location = new System.Drawing.Point(290, 126);
            this.buttonNoWarrant.Name = "buttonNoWarrant";
            this.buttonNoWarrant.Size = new System.Drawing.Size(75, 23);
            this.buttonNoWarrant.TabIndex = 34;
            this.buttonNoWarrant.Text = "нет довер.";
            this.buttonNoWarrant.UseVisualStyleBackColor = true;
            this.buttonNoWarrant.Click += new System.EventHandler(this.buttonNoWarrant_Click);
            // 
            // FormBrakeOrOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 209);
            this.Name = "FormBrakeOrOut";
            this.Text = "Причина простоя";
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdleReason;
        private System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNoPaper;
        private System.Windows.Forms.Button buttonNoWarrant;
        private System.Windows.Forms.Button buttonTooMany;
    }
}