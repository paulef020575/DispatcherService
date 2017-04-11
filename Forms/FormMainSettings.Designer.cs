namespace DispatcherService
{
    partial class FormMainSettings
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSecondsToRefresh = new System.Windows.Forms.TextBox();
            this.textBoxMinutesToSign = new System.Windows.Forms.TextBox();
            this.textBoxDaysOld = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.textBoxDaysOld);
            this.panelData.Controls.Add(this.textBoxMinutesToSign);
            this.panelData.Controls.Add(this.textBoxSecondsToRefresh);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Size = new System.Drawing.Size(367, 135);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonSave);
            this.panelBottom.Location = new System.Drawing.Point(0, 135);
            this.panelBottom.Size = new System.Drawing.Size(367, 50);
            this.panelBottom.Controls.SetChildIndex(this.buttonSave, 0);
            this.panelBottom.Controls.SetChildIndex(this.buttonClose, 0);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(255, 15);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Частота обновления списков (сек)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Подсветка требующих отправления (мин)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Долгое ожидание (сут)";
            // 
            // textBoxSecondsToRefresh
            // 
            this.textBoxSecondsToRefresh.Location = new System.Drawing.Point(264, 19);
            this.textBoxSecondsToRefresh.Name = "textBoxSecondsToRefresh";
            this.textBoxSecondsToRefresh.Size = new System.Drawing.Size(65, 20);
            this.textBoxSecondsToRefresh.TabIndex = 3;
            // 
            // textBoxMinutesToSign
            // 
            this.textBoxMinutesToSign.Location = new System.Drawing.Point(264, 53);
            this.textBoxMinutesToSign.Name = "textBoxMinutesToSign";
            this.textBoxMinutesToSign.Size = new System.Drawing.Size(65, 20);
            this.textBoxMinutesToSign.TabIndex = 4;
            // 
            // textBoxDaysOld
            // 
            this.textBoxDaysOld.Location = new System.Drawing.Point(264, 85);
            this.textBoxDaysOld.Name = "textBoxDaysOld";
            this.textBoxDaysOld.Size = new System.Drawing.Size(65, 20);
            this.textBoxDaysOld.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(149, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormMainSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 185);
            this.Name = "FormMainSettings";
            this.Text = "Настройки системы";
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSecondsToRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMinutesToSign;
        private System.Windows.Forms.TextBox textBoxDaysOld;
        private System.Windows.Forms.Button buttonSave;
    }
}