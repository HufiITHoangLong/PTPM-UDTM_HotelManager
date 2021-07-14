using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class FormChiTietHD : Form
    {
        CTHD ct = new CTHD();
        HoaDonPH phs = new HoaDonPH();
        HotelManagerDataContext db = new HotelManagerDataContext();

        public FormChiTietHD()
        {
            InitializeComponent();
        }

        private void FormChiTietHD_Load(object sender, EventArgs e)
        {
            DGVcthd.DataSource = ct.getHD();
            dgvThongKe.DataSource = ct.getTTTk();
            //this.reportViewer1.RefreshReport();
        }

        public int TinhNgaySuDung()
        {
            DateTime ngaydb = Convert.ToDateTime(textBoxNV.Text);
            DateTime ngaykt = Convert.ToDateTime(textBoxNR.Text);
            TimeSpan time = ngaykt - ngaydb;
            int SongaySudung = time.Days;
            return SongaySudung;
        }

        public int TinhTienPhong()
        {
            int gp = int.Parse(txtGiaPhong.Text);
            int ngaysd = int.Parse(txtNSD.Text);
            int ttp = gp * ngaysd;
            return ttp;
        }

        public int TinhTienDV()
        {
            int dg = int.Parse(txtDGDV.Text);
            int sl = int.Parse(txtSoLuongSD.Text);
            int ttdv = dg * sl;
            return ttdv;
        }

        public int TinhTongTien()
        {
            int tienp = int.Parse(txtTienP.Text);
            int tiendv = int.Parse(txtTienDichVu.Text);
            int tt = tienp + tiendv;
            return tt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtNSD.Text = TinhNgaySuDung().ToString();
        }
        private DataGridViewRow r;
        private void DGVcthd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = DGVcthd.Rows[e.RowIndex];
                textBoxNV.Text = r.Cells["NGAYVAO"].Value.ToString();
                textBoxNR.Text = r.Cells["NGAYRA"].Value.ToString();
                txtDGDV.Text = r.Cells["DONGIADV"].Value.ToString();
                txtSoLuongSD.Text = r.Cells["SOLUONGDV"].Value.ToString();
                txtGiaPhong.Text = r.Cells["DONGIAP"].Value.ToString();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTienDichVu.Text = TinhTienDV().ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtTT.Text = TinhTongTien().ToString();
            labelTT.Text = txtTT.Text + "đ";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var tk = new CHITIETHD();
            tk.MAHD = r.Cells["MAHD"].Value.ToString();
            tk.TONGTIENPHONG = int.Parse(txtTienP.Text);
            tk.TONGTIENDV = int.Parse(txtTienDichVu.Text);
            tk.THANHTIEN = int.Parse(txtTT.Text);
            db.CHITIETHDs.InsertOnSubmit(tk);
            db.SubmitChanges();
            dgvThongKe.DataSource = ct.getTTTk();
            MessageBox.Show("Đã lưu");
            txtTienP.Clear();
            txtTT.Clear();
            txtTienDichVu.Clear();
            txtSoLuongSD.Clear();
            txtNSD.Clear();
            txtGiaPhong.Clear();
            txtDGDV.Clear();
            textBoxNR.Clear();
            textBoxNV.Clear();
        }

        private void btnTP_Click(object sender, EventArgs e)
        {
            txtTienP.Text = TinhTienPhong().ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTK ftk = new FormTK();
            ftk.ShowDialog();
        }
    }
}
