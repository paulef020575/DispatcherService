namespace DispatcherService
{
    partial class VehicleItemForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tboxVehicleMark = new System.Windows.Forms.TextBox();
            this.btnVehicleMarkReference = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxLicensePlate = new System.Windows.Forms.TextBox();
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottom.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 232);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBottom.Size = new System.Drawing.Size(549, 35);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(344, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 25);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(444, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlData
            // 
            this.pnlData.ColumnCount = 2;
            this.pnlData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.pnlData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlData.Controls.Add(this.panel2, 1, 0);
            this.pnlData.Controls.Add(this.label1, 0, 0);
            this.pnlData.Controls.Add(this.label2, 0, 1);
            this.pnlData.Controls.Add(this.tboxLicensePlate, 1, 1);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.RowCount = 3;
            this.pnlData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlData.Size = new System.Drawing.Size(549, 232);
            this.pnlData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tboxVehicleMark);
            this.panel2.Controls.Add(this.btnVehicleMarkReference);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(103, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 20);
            this.panel2.TabIndex = 4;
            // 
            // tboxVehicleMark
            // 
            this.tboxVehicleMark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxVehicleMark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxVehicleMark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxVehicleMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxVehicleMark.Location = new System.Drawing.Point(0, 0);
            this.tboxVehicleMark.Name = "tboxVehicleMark";
            this.tboxVehicleMark.Size = new System.Drawing.Size(416, 26);
            this.tboxVehicleMark.TabIndex = 0;
            // 
            // btnVehicleMarkReference
            // 
            this.btnVehicleMarkReference.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVehicleMarkReference.Location = new System.Drawing.Point(416, 0);
            this.btnVehicleMarkReference.Name = "btnVehicleMarkReference";
            this.btnVehicleMarkReference.Size = new System.Drawing.Size(27, 20);
            this.btnVehicleMarkReference.TabIndex = 1;
            this.btnVehicleMarkReference.TabStop = false;
            this.btnVehicleMarkReference.Text = "...";
            this.btnVehicleMarkReference.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(35, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка Т/С";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Гос. номер";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxLicensePlate
            // 
            this.tboxLicensePlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxLicensePlate.Location = new System.Drawing.Point(103, 29);
            this.tboxLicensePlate.Name = "tboxLicensePlate";
            this.tboxLicensePlate.Size = new System.Drawing.Size(443, 31);
            this.tboxLicensePlate.TabIndex = 5;
            // 
            // VehicleItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 267);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlBottom);
            this.Name = "VehicleItemForm";
            this.Text = "VehicleItemForm";
            this.pnlBottom.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TableLayoutPanel pnlData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tboxVehicleMark;
        private System.Windows.Forms.Button btnVehicleMarkReference;
        private System.Windows.Forms.TextBox tboxLicensePlate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsItem;
    }
}