namespace DispatcherService
{
    partial class ReferenceBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowReference = new System.Windows.Forms.Button();
            this.tboxItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowReference
            // 
            this.btnShowReference.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowReference.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowReference.Location = new System.Drawing.Point(306, 0);
            this.btnShowReference.Name = "btnShowReference";
            this.btnShowReference.Size = new System.Drawing.Size(25, 20);
            this.btnShowReference.TabIndex = 0;
            this.btnShowReference.TabStop = false;
            this.btnShowReference.Text = "...";
            this.btnShowReference.UseVisualStyleBackColor = true;
            this.btnShowReference.Click += new System.EventHandler(this.btnShowReference_Click);
            // 
            // tboxItem
            // 
            this.tboxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxItem.Location = new System.Drawing.Point(0, 0);
            this.tboxItem.Name = "tboxItem";
            this.tboxItem.Size = new System.Drawing.Size(306, 20);
            this.tboxItem.TabIndex = 1;
            this.tboxItem.Validating += new System.ComponentModel.CancelEventHandler(this.tboxItem_Validating);
            // 
            // ReferenceBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.tboxItem);
            this.Controls.Add(this.btnShowReference);
            this.Name = "ReferenceBox";
            this.Size = new System.Drawing.Size(331, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowReference;
        private System.Windows.Forms.TextBox tboxItem;
    }
}
