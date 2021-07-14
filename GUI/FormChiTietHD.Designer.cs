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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNSD = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDGDV = new System.Windows.Forms.TextBox();
            this.txtSoLuongSD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienDichVu = new System.Windows.Forms.TextBox();
            this.btnTinhTienDV = new System.Windows.Forms.Button();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTienP = new System.Windows.Forms.TextBox();
            this.btnTP = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.labelTT = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcthd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVcthd
            // 
            this.DGVcthd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVcthd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVcthd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcthd.Location = new System.Drawing.Point(12, 47);
            this.DGVcthd.Name = "DGVcthd";
            this.DGVcthd.RowTemplate.Height = 24;
            this.DGVcthd.Size = new System.Drawing.Size(704, 262);
            this.DGVcthd.TabIndex = 0;
            this.DGVcthd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcthd_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1053, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNSD
            // 
            this.txtNSD.Location = new System.Drawing.Point(24, 463);
            this.txtNSD.Name = "txtNSD";
            this.txtNSD.Size = new System.Drawing.Size(139, 22);
            this.txtNSD.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tính ngày sử dụng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxNV
            // 
            this.textBoxNV.Location = new System.Drawing.Point(117, 341);
            this.textBoxNV.Name = "textBoxNV";
            this.textBoxNV.Size = new System.Drawing.Size(205, 22);
            this.textBoxNV.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày vào";
            // 
            // textBoxNR
            // 
            this.textBoxNR.Location = new System.Drawing.Point(117, 402);
            this.textBoxNR.Name = "textBoxNR";
            this.textBoxNR.Size = new System.Drawing.Size(205, 22);
            this.textBoxNR.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày ra";
            // 
            // txtDGDV
            // 
            this.txtDGDV.Location = new System.Drawing.Point(510, 345);
            this.txtDGDV.Name = "txtDGDV";
            this.txtDGDV.Size = new System.Drawing.Size(205, 22);
            this.txtDGDV.TabIndex = 5;
            // 
            // txtSoLuongSD
            // 
            this.txtSoLuongSD.Location = new System.Drawing.Point(510, 402);
            this.txtSoLuongSD.Name = "txtSoLuongSD";
            this.txtSoLuongSD.Size = new System.Drawing.Size(205, 22);
            this.txtSoLuongSD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đon giá dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng sử dụng";
            // 
            // txtTienDichVu
            // 
            this.txtTienDichVu.Location = new System.Drawing.Point(384, 463);
            this.txtTienDichVu.Name = "txtTienDichVu";
            this.txtTienDichVu.Size = new System.Drawing.Size(179, 22);
            this.txtTienDichVu.TabIndex = 7;
            // 
            // btnTinhTienDV
            // 
            this.btnTinhTienDV.Location = new System.Drawing.Point(588, 459);
            this.btnTinhTienDV.Name = "btnTinhTienDV";
            this.btnTinhTienDV.Size = new System.Drawing.Size(127, 31);
            this.btnTinhTienDV.TabIndex = 2;
            this.btnTinhTienDV.Text = "Tính tiền dịch vụ";
            this.btnTinhTienDV.UseVisualStyleBackColor = true;
            this.btnTinhTienDV.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTT
            // 
            this.txtTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.Location = new System.Drawing.Point(780, 346);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(365, 27);
            this.txtTT.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1165, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thành tiền";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(117, 515);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(205, 22);
            this.txtGiaPhong.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giá phòng";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(743, 47);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(546, 262);
            this.dgvThongKe.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(795, 498);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 35);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTienP
            // 
            this.txtTienP.Location = new System.Drawing.Point(384, 515);
            this.txtTienP.Name = "txtTienP";
            this.txtTienP.Size = new System.Drawing.Size(179, 22);
            this.txtTienP.TabIndex = 14;
            // 
            // btnTP
            // 
            this.btnTP.Location = new System.Drawing.Point(588, 515);
            this.btnTP.Name = "btnTP";
            this.btnTP.Size = new System.Drawing.Size(127, 26);
            this.btnTP.TabIndex = 15;
            this.btnTP.Text = "Tính tiền phòng";
            this.btnTP.UseVisualStyleBackColor = true;
            this.btnTP.Click += new System.EventHandler(this.btnTP_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(927, 499);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(110, 34);
            this.btnTK.TabIndex = 16;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // labelTT
            // 
            this.labelTT.AutoSize = true;
            this.labelTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTT.Location = new System.Drawing.Point(789, 407);
            this.labelTT.Name = "labelTT";
            this.labelTT.Size = new System.Drawing.Size(0, 32);
            this.labelTT.TabIndex = 17;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.Location = new System.Drawing.Point(1169, 499);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1301, 576);
            this.Controls.Add(this.labelTT);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnTP);
            this.Controls.Add(this.txtTienP);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.txtGiaPhong);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.btnTinhTienDV);
            this.Controls.Add(this.txtTienDichVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuongSD);
            this.Controls.Add(this.txtDGDV);
            this.Controls.Add(this.textBoxNR);
            this.Controls.Add(this.textBoxNV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNSD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVcthd);
            this.Name = "FormChiTietHD";
            this.Text = "Form chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.FormChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcthd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVcthd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNSD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDGDV;
        private System.Windows.Forms.TextBox txtSoLuongSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTienDichVu;
        private System.Windows.Forms.Button btnTinhTienDV;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTienP;
        private System.Windows.Forms.Button btnTP;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label labelTT;
        private System.Windows.Forms.Button btnThoat;
    }
}