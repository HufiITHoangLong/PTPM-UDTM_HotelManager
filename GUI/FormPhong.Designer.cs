namespace GUI
{
    partial class FormPhong
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
            this.DGVPhong = new System.Windows.Forms.DataGridView();
            this.BTNThem = new System.Windows.Forms.Button();
            this.BTNXoa = new System.Windows.Forms.Button();
            this.BTNSua = new System.Windows.Forms.Button();
            this.TBMAPHONG = new System.Windows.Forms.TextBox();
            this.LabelMaPhong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNTroVe = new System.Windows.Forms.Button();
            this.TBTrangThai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBSC = new System.Windows.Forms.TextBox();
            this.TBLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Phòng";
            // 
            // DGVPhong
            // 
            this.DGVPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPhong.Location = new System.Drawing.Point(486, 81);
            this.DGVPhong.Name = "DGVPhong";
            this.DGVPhong.RowTemplate.Height = 24;
            this.DGVPhong.Size = new System.Drawing.Size(554, 395);
            this.DGVPhong.TabIndex = 9;
            this.DGVPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPhong_CellClick);
            // 
            // BTNThem
            // 
            this.BTNThem.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNThem.Location = new System.Drawing.Point(126, 429);
            this.BTNThem.Name = "BTNThem";
            this.BTNThem.Size = new System.Drawing.Size(98, 47);
            this.BTNThem.TabIndex = 6;
            this.BTNThem.Text = "Thêm";
            this.BTNThem.UseVisualStyleBackColor = true;
            this.BTNThem.Click += new System.EventHandler(this.BTNThem_Click_1);
            // 
            // BTNXoa
            // 
            this.BTNXoa.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTNXoa.Location = new System.Drawing.Point(230, 429);
            this.BTNXoa.Name = "BTNXoa";
            this.BTNXoa.Size = new System.Drawing.Size(102, 47);
            this.BTNXoa.TabIndex = 7;
            this.BTNXoa.Text = "Xóa";
            this.BTNXoa.UseVisualStyleBackColor = true;
            this.BTNXoa.Click += new System.EventHandler(this.BTNXoa_Click);
            // 
            // BTNSua
            // 
            this.BTNSua.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTNSua.Location = new System.Drawing.Point(26, 429);
            this.BTNSua.Name = "BTNSua";
            this.BTNSua.Size = new System.Drawing.Size(94, 47);
            this.BTNSua.TabIndex = 5;
            this.BTNSua.Text = "Sửa";
            this.BTNSua.UseVisualStyleBackColor = true;
            this.BTNSua.Click += new System.EventHandler(this.BTNSua_Click);
            // 
            // TBMAPHONG
            // 
            this.TBMAPHONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMAPHONG.Location = new System.Drawing.Point(221, 43);
            this.TBMAPHONG.Name = "TBMAPHONG";
            this.TBMAPHONG.Size = new System.Drawing.Size(203, 34);
            this.TBMAPHONG.TabIndex = 1;
            // 
            // LabelMaPhong
            // 
            this.LabelMaPhong.AutoSize = true;
            this.LabelMaPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaPhong.Location = new System.Drawing.Point(53, 43);
            this.LabelMaPhong.Name = "LabelMaPhong";
            this.LabelMaPhong.Size = new System.Drawing.Size(116, 28);
            this.LabelMaPhong.TabIndex = 5;
            this.LabelMaPhong.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trạng thái";
            // 
            // BTNTroVe
            // 
            this.BTNTroVe.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTNTroVe.Location = new System.Drawing.Point(338, 429);
            this.BTNTroVe.Name = "BTNTroVe";
            this.BTNTroVe.Size = new System.Drawing.Size(130, 47);
            this.BTNTroVe.TabIndex = 8;
            this.BTNTroVe.Text = "Trở về";
            this.BTNTroVe.UseVisualStyleBackColor = true;
            this.BTNTroVe.Click += new System.EventHandler(this.BTNTroVe_Click);
            // 
            // TBTrangThai
            // 
            this.TBTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTrangThai.Location = new System.Drawing.Point(218, 115);
            this.TBTrangThai.Name = "TBTrangThai";
            this.TBTrangThai.Size = new System.Drawing.Size(203, 34);
            this.TBTrangThai.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số chỗ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại Phòng";
            // 
            // TBSC
            // 
            this.TBSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSC.Location = new System.Drawing.Point(218, 254);
            this.TBSC.Name = "TBSC";
            this.TBSC.Size = new System.Drawing.Size(80, 34);
            this.TBSC.TabIndex = 3;
            // 
            // TBLoai
            // 
            this.TBLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLoai.Location = new System.Drawing.Point(218, 319);
            this.TBLoai.Name = "TBLoai";
            this.TBLoai.Size = new System.Drawing.Size(203, 34);
            this.TBLoai.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái 0: Trống";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trạng thái 1: Có người";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "1: Phòng đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(184, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "2: Phòng đôi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(314, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "3: Phòng V.I.P";
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1050, 487);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBSC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelMaPhong);
            this.Controls.Add(this.TBLoai);
            this.Controls.Add(this.TBTrangThai);
            this.Controls.Add(this.TBMAPHONG);
            this.Controls.Add(this.BTNTroVe);
            this.Controls.Add(this.BTNSua);
            this.Controls.Add(this.BTNXoa);
            this.Controls.Add(this.BTNThem);
            this.Controls.Add(this.DGVPhong);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Brown;
            this.Name = "FormPhong";
            this.Text = "Form Phòng";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVPhong;
        private System.Windows.Forms.Button BTNThem;
        private System.Windows.Forms.Button BTNXoa;
        private System.Windows.Forms.Button BTNSua;
        private System.Windows.Forms.TextBox TBMAPHONG;
        private System.Windows.Forms.Label LabelMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNTroVe;
        private System.Windows.Forms.TextBox TBTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBSC;
        private System.Windows.Forms.TextBox TBLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}