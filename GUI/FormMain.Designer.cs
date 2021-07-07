namespace GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNPhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelTENNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelNgay = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelNv = new System.Windows.Forms.ToolStripStatusLabel();
            this.BTNDangXuat = new System.Windows.Forms.Button();
            this.BTNKhachHang = new System.Windows.Forms.Button();
            this.BTNDichVu = new System.Windows.Forms.Button();
            this.BTNTrangThietBi = new System.Windows.Forms.Button();
            this.BTNNhanVien = new System.Windows.Forms.Button();
            this.BTNThongKe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelXinChao = new System.Windows.Forms.Label();
            this.BTNDatPhong = new System.Windows.Forms.Button();
            this.BTNHoaDon = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LabelXinChaoAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTNPhong
            // 
            this.BTNPhong.BackColor = System.Drawing.Color.White;
            this.BTNPhong.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPhong.ForeColor = System.Drawing.Color.Maroon;
            this.BTNPhong.Location = new System.Drawing.Point(255, 230);
            this.BTNPhong.Name = "BTNPhong";
            this.BTNPhong.Size = new System.Drawing.Size(174, 90);
            this.BTNPhong.TabIndex = 2;
            this.BTNPhong.Text = "Quản Lý Phòng";
            this.BTNPhong.UseVisualStyleBackColor = false;
            this.BTNPhong.Click += new System.EventHandler(this.BTNPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(480, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelTENNV,
            this.LabelNgay,
            this.LabelNv});
            this.statusStrip1.Location = new System.Drawing.Point(0, 756);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1262, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelTENNV
            // 
            this.LabelTENNV.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTENNV.Name = "LabelTENNV";
            this.LabelTENNV.Size = new System.Drawing.Size(0, 17);
            // 
            // LabelNgay
            // 
            this.LabelNgay.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNgay.Name = "LabelNgay";
            this.LabelNgay.Size = new System.Drawing.Size(0, 17);
            // 
            // LabelNv
            // 
            this.LabelNv.Name = "LabelNv";
            this.LabelNv.Size = new System.Drawing.Size(0, 17);
            // 
            // BTNDangXuat
            // 
            this.BTNDangXuat.BackColor = System.Drawing.Color.White;
            this.BTNDangXuat.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDangXuat.ForeColor = System.Drawing.Color.Red;
            this.BTNDangXuat.Location = new System.Drawing.Point(255, 686);
            this.BTNDangXuat.Name = "BTNDangXuat";
            this.BTNDangXuat.Size = new System.Drawing.Size(174, 50);
            this.BTNDangXuat.TabIndex = 9;
            this.BTNDangXuat.Text = "Đăng Xuất";
            this.BTNDangXuat.UseVisualStyleBackColor = false;
            this.BTNDangXuat.Click += new System.EventHandler(this.BTNDangXuat_Click);
            // 
            // BTNKhachHang
            // 
            this.BTNKhachHang.BackColor = System.Drawing.Color.White;
            this.BTNKhachHang.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTNKhachHang.ForeColor = System.Drawing.Color.Maroon;
            this.BTNKhachHang.Location = new System.Drawing.Point(46, 343);
            this.BTNKhachHang.Name = "BTNKhachHang";
            this.BTNKhachHang.Size = new System.Drawing.Size(174, 90);
            this.BTNKhachHang.TabIndex = 3;
            this.BTNKhachHang.Text = "Khách Hàng";
            this.BTNKhachHang.UseVisualStyleBackColor = false;
            this.BTNKhachHang.Click += new System.EventHandler(this.BTNKhachHang_Click);
            // 
            // BTNDichVu
            // 
            this.BTNDichVu.BackColor = System.Drawing.Color.White;
            this.BTNDichVu.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTNDichVu.ForeColor = System.Drawing.Color.Maroon;
            this.BTNDichVu.Location = new System.Drawing.Point(255, 571);
            this.BTNDichVu.Name = "BTNDichVu";
            this.BTNDichVu.Size = new System.Drawing.Size(174, 90);
            this.BTNDichVu.TabIndex = 8;
            this.BTNDichVu.Text = "Dịch Vụ";
            this.BTNDichVu.UseVisualStyleBackColor = false;
            this.BTNDichVu.Click += new System.EventHandler(this.BTNDichVu_Click);
            // 
            // BTNTrangThietBi
            // 
            this.BTNTrangThietBi.BackColor = System.Drawing.Color.White;
            this.BTNTrangThietBi.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTNTrangThietBi.ForeColor = System.Drawing.Color.Maroon;
            this.BTNTrangThietBi.Location = new System.Drawing.Point(255, 343);
            this.BTNTrangThietBi.Name = "BTNTrangThietBi";
            this.BTNTrangThietBi.Size = new System.Drawing.Size(174, 90);
            this.BTNTrangThietBi.TabIndex = 4;
            this.BTNTrangThietBi.Text = "Trang Thiết Bị";
            this.BTNTrangThietBi.UseVisualStyleBackColor = false;
            this.BTNTrangThietBi.Click += new System.EventHandler(this.BTNTrangThietBi_Click);
            // 
            // BTNNhanVien
            // 
            this.BTNNhanVien.BackColor = System.Drawing.Color.White;
            this.BTNNhanVien.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTNNhanVien.ForeColor = System.Drawing.Color.Maroon;
            this.BTNNhanVien.Location = new System.Drawing.Point(255, 458);
            this.BTNNhanVien.Name = "BTNNhanVien";
            this.BTNNhanVien.Size = new System.Drawing.Size(174, 90);
            this.BTNNhanVien.TabIndex = 6;
            this.BTNNhanVien.Text = "Nhân Viên";
            this.BTNNhanVien.UseVisualStyleBackColor = false;
            this.BTNNhanVien.Click += new System.EventHandler(this.BTNNhanVien_Click);
            // 
            // BTNThongKe
            // 
            this.BTNThongKe.BackColor = System.Drawing.Color.White;
            this.BTNThongKe.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTNThongKe.ForeColor = System.Drawing.Color.Maroon;
            this.BTNThongKe.Location = new System.Drawing.Point(46, 571);
            this.BTNThongKe.Name = "BTNThongKe";
            this.BTNThongKe.Size = new System.Drawing.Size(174, 90);
            this.BTNThongKe.TabIndex = 7;
            this.BTNThongKe.Text = "Thống kê";
            this.BTNThongKe.UseVisualStyleBackColor = false;
            this.BTNThongKe.Click += new System.EventHandler(this.BTNThongKe_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(46, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelXinChao
            // 
            this.LabelXinChao.AutoSize = true;
            this.LabelXinChao.BackColor = System.Drawing.Color.White;
            this.LabelXinChao.ForeColor = System.Drawing.Color.Maroon;
            this.LabelXinChao.Location = new System.Drawing.Point(25, 126);
            this.LabelXinChao.Name = "LabelXinChao";
            this.LabelXinChao.Size = new System.Drawing.Size(0, 17);
            this.LabelXinChao.TabIndex = 4;
            // 
            // BTNDatPhong
            // 
            this.BTNDatPhong.BackColor = System.Drawing.Color.White;
            this.BTNDatPhong.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDatPhong.ForeColor = System.Drawing.Color.Maroon;
            this.BTNDatPhong.Location = new System.Drawing.Point(46, 230);
            this.BTNDatPhong.Name = "BTNDatPhong";
            this.BTNDatPhong.Size = new System.Drawing.Size(174, 90);
            this.BTNDatPhong.TabIndex = 1;
            this.BTNDatPhong.Text = "Đặt Phòng";
            this.BTNDatPhong.UseVisualStyleBackColor = false;
            this.BTNDatPhong.Click += new System.EventHandler(this.BTNPhong_Click);
            // 
            // BTNHoaDon
            // 
            this.BTNHoaDon.BackColor = System.Drawing.Color.White;
            this.BTNHoaDon.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTNHoaDon.ForeColor = System.Drawing.Color.Maroon;
            this.BTNHoaDon.Location = new System.Drawing.Point(46, 458);
            this.BTNHoaDon.Name = "BTNHoaDon";
            this.BTNHoaDon.Size = new System.Drawing.Size(174, 90);
            this.BTNHoaDon.TabIndex = 5;
            this.BTNHoaDon.Text = "Hóa Đơn";
            this.BTNHoaDon.UseVisualStyleBackColor = false;
            this.BTNHoaDon.Click += new System.EventHandler(this.BTNThongKe_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // LabelXinChaoAd
            // 
            this.LabelXinChaoAd.AutoSize = true;
            this.LabelXinChaoAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelXinChaoAd.Location = new System.Drawing.Point(204, 131);
            this.LabelXinChaoAd.Name = "LabelXinChaoAd";
            this.LabelXinChaoAd.Size = new System.Drawing.Size(0, 29);
            this.LabelXinChaoAd.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1262, 778);
            this.Controls.Add(this.LabelXinChaoAd);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LabelXinChao);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNDangXuat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNHoaDon);
            this.Controls.Add(this.BTNThongKe);
            this.Controls.Add(this.BTNNhanVien);
            this.Controls.Add(this.BTNTrangThietBi);
            this.Controls.Add(this.BTNDichVu);
            this.Controls.Add(this.BTNKhachHang);
            this.Controls.Add(this.BTNDatPhong);
            this.Controls.Add(this.BTNPhong);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.Text = "Giao Diện Chính";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button BTNDangXuat;
        private System.Windows.Forms.Button BTNKhachHang;
        private System.Windows.Forms.Button BTNDichVu;
        private System.Windows.Forms.Button BTNTrangThietBi;
        private System.Windows.Forms.Button BTNNhanVien;
        private System.Windows.Forms.Button BTNThongKe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel LabelNgay;
        private System.Windows.Forms.ToolStripStatusLabel LabelTENNV;
        private System.Windows.Forms.Label LabelXinChao;
        private System.Windows.Forms.Button BTNDatPhong;
        private System.Windows.Forms.ToolStripStatusLabel LabelNv;
        private System.Windows.Forms.Button BTNHoaDon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LabelXinChaoAd;

    }
}