namespace GUI
{
    partial class FormDangNhap
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
            this.BTNThoat = new System.Windows.Forms.Button();
            this.BTNDangNhap = new System.Windows.Forms.Button();
            this.TextBoxMK = new System.Windows.Forms.TextBox();
            this.textBoxUser1 = new LibraryCustomControl.TextBoxUser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // BTNThoat
            // 
            this.BTNThoat.BackColor = System.Drawing.Color.White;
            this.BTNThoat.ForeColor = System.Drawing.Color.Black;
            this.BTNThoat.Location = new System.Drawing.Point(223, 263);
            this.BTNThoat.Name = "BTNThoat";
            this.BTNThoat.Size = new System.Drawing.Size(93, 38);
            this.BTNThoat.TabIndex = 4;
            this.BTNThoat.Text = "Thoát";
            this.BTNThoat.UseVisualStyleBackColor = false;
            this.BTNThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNDangNhap
            // 
            this.BTNDangNhap.BackColor = System.Drawing.Color.White;
            this.BTNDangNhap.ForeColor = System.Drawing.Color.Black;
            this.BTNDangNhap.Location = new System.Drawing.Point(57, 263);
            this.BTNDangNhap.Name = "BTNDangNhap";
            this.BTNDangNhap.Size = new System.Drawing.Size(125, 38);
            this.BTNDangNhap.TabIndex = 3;
            this.BTNDangNhap.Text = "Đăng Nhập";
            this.BTNDangNhap.UseVisualStyleBackColor = false;
            this.BTNDangNhap.Click += new System.EventHandler(this.BTNDangNhap_Click);
            // 
            // TextBoxMK
            // 
            this.TextBoxMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMK.Location = new System.Drawing.Point(156, 186);
            this.TextBoxMK.Name = "TextBoxMK";
            this.TextBoxMK.Size = new System.Drawing.Size(160, 30);
            this.TextBoxMK.TabIndex = 2;
            this.TextBoxMK.UseSystemPasswordChar = true;
            // 
            // textBoxUser1
            // 
            this.textBoxUser1.BackColor = System.Drawing.Color.White;
            this.textBoxUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser1.Location = new System.Drawing.Point(156, 116);
            this.textBoxUser1.Name = "textBoxUser1";
            this.textBoxUser1.Size = new System.Drawing.Size(160, 30);
            this.textBoxUser1.TabIndex = 1;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(387, 338);
            this.Controls.Add(this.TextBoxMK);
            this.Controls.Add(this.BTNDangNhap);
            this.Controls.Add(this.BTNThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUser1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNThoat;
        private System.Windows.Forms.Button BTNDangNhap;
        private LibraryCustomControl.TextBoxUser textBoxUser1;
        private System.Windows.Forms.TextBox TextBoxMK;
    }
}