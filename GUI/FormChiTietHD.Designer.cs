namespace GUI
{
    partial class FormChiTietHD
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
            this.DGVcthd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcthd)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVcthd
            // 
            this.DGVcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcthd.Location = new System.Drawing.Point(12, 140);
            this.DGVcthd.Name = "DGVcthd";
            this.DGVcthd.RowTemplate.Height = 24;
            this.DGVcthd.Size = new System.Drawing.Size(506, 211);
            this.DGVcthd.TabIndex = 0;
            // 
            // FormChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(530, 363);
            this.Controls.Add(this.DGVcthd);
            this.Name = "FormChiTietHD";
            this.Text = "Form chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.FormChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcthd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVcthd;
    }
}