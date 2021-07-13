namespace GUI
{
    partial class FormNhanVien
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
            this.TBUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBDiaChi = new System.Windows.Forms.TextBox();
            this.DGVNhanVien = new System.Windows.Forms.DataGridView();
            this.BTNThem = new System.Windows.Forms.Button();
            this.BTNXoa = new System.Windows.Forms.Button();
            this.BTNSua = new System.Windows.Forms.Button();
            this.BTNTroVe = new System.Windows.Forms.Button();
            this.textBoxPhone1 = new LibraryCustomControl.TextBoxPhone();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(730, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(394, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // TBUser
            // 
            this.TBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.Location = new System.Drawing.Point(190, 48);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(181, 27);
            this.TBUser.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(503, 44);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(181, 27);
            this.tbPass.TabIndex = 2;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTen.Location = new System.Drawing.Point(857, 46);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(181, 27);
            this.tbHoTen.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(64, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(394, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // TBDiaChi
            // 
            this.TBDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDiaChi.Location = new System.Drawing.Point(503, 98);
            this.TBDiaChi.Name = "TBDiaChi";
            this.TBDiaChi.Size = new System.Drawing.Size(535, 27);
            this.TBDiaChi.TabIndex = 5;
            // 
            // DGVNhanVien
            // 
            this.DGVNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNhanVien.Location = new System.Drawing.Point(325, 147);
            this.DGVNhanVien.Name = "DGVNhanVien";
            this.DGVNhanVien.RowTemplate.Height = 24;
            this.DGVNhanVien.Size = new System.Drawing.Size(713, 328);
            this.DGVNhanVien.TabIndex = 11;
            this.DGVNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNhanVien_CellClick);
            // 
            // BTNThem
            // 
            this.BTNThem.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNThem.ForeColor = System.Drawing.Color.Brown;
            this.BTNThem.Location = new System.Drawing.Point(61, 177);
            this.BTNThem.Name = "BTNThem";
            this.BTNThem.Size = new System.Drawing.Size(213, 47);
            this.BTNThem.TabIndex = 7;
            this.BTNThem.Text = "Thêm";
            this.BTNThem.UseVisualStyleBackColor = true;
            this.BTNThem.Click += new System.EventHandler(this.BTNThem_Click);
            // 
            // BTNXoa
            // 
            this.BTNXoa.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNXoa.ForeColor = System.Drawing.Color.Brown;
            this.BTNXoa.Location = new System.Drawing.Point(61, 246);
            this.BTNXoa.Name = "BTNXoa";
            this.BTNXoa.Size = new System.Drawing.Size(213, 47);
            this.BTNXoa.TabIndex = 8;
            this.BTNXoa.Text = "Xóa";
            this.BTNXoa.UseVisualStyleBackColor = true;
            this.BTNXoa.Click += new System.EventHandler(this.BTNXoa_Click);
            // 
            // BTNSua
            // 
            this.BTNSua.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSua.ForeColor = System.Drawing.Color.Brown;
            this.BTNSua.Location = new System.Drawing.Point(61, 315);
            this.BTNSua.Name = "BTNSua";
            this.BTNSua.Size = new System.Drawing.Size(213, 47);
            this.BTNSua.TabIndex = 9;
            this.BTNSua.Text = "Sửa";
            this.BTNSua.UseVisualStyleBackColor = true;
            this.BTNSua.Click += new System.EventHandler(this.BTNSua_Click);
            // 
            // BTNTroVe
            // 
            this.BTNTroVe.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTroVe.ForeColor = System.Drawing.Color.Brown;
            this.BTNTroVe.Location = new System.Drawing.Point(61, 394);
            this.BTNTroVe.Name = "BTNTroVe";
            this.BTNTroVe.Size = new System.Drawing.Size(213, 47);
            this.BTNTroVe.TabIndex = 10;
            this.BTNTroVe.Text = "Trở về";
            this.BTNTroVe.UseVisualStyleBackColor = true;
            this.BTNTroVe.Click += new System.EventHandler(this.BTNTroVe_Click);
            // 
            // textBoxPhone1
            // 
            this.textBoxPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone1.Location = new System.Drawing.Point(190, 102);
            this.textBoxPhone1.Name = "textBoxPhone1";
            this.textBoxPhone1.Size = new System.Drawing.Size(181, 27);
            this.textBoxPhone1.TabIndex = 4;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1050, 487);
            this.Controls.Add(this.textBoxPhone1);
            this.Controls.Add(this.BTNTroVe);
            this.Controls.Add(this.BTNSua);
            this.Controls.Add(this.BTNXoa);
            this.Controls.Add(this.BTNThem);
            this.Controls.Add(this.DGVNhanVien);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.TBDiaChi);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhanVien";
            this.Text = "Form Nhân Viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBDiaChi;
        private System.Windows.Forms.DataGridView DGVNhanVien;
        private System.Windows.Forms.Button BTNThem;
        private System.Windows.Forms.Button BTNXoa;
        private System.Windows.Forms.Button BTNSua;
        private System.Windows.Forms.Button BTNTroVe;
        private LibraryCustomControl.TextBoxPhone textBoxPhone1;
    }
}