using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMainS : Form
    {
        public FormMainS()
        {
            InitializeComponent();
        }

        private void FormMainS_Load(object sender, EventArgs e)
        {
            LabelXinChaoStaff.Text = "Staff";
            string[] thu = { "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy", "Chủ Nhật" };
            int ngay = DateTime.Now.DayOfWeek.GetHashCode();
            LabelNgay.Text = LabelNgay.Text + thu[ngay].ToString() + " Ngày " + DateTime.Today.Day.ToString() + " Tháng " + DateTime.Today.Month.ToString() + " Năm " + DateTime.Today.Year.ToString();
        }

        private void BTNSPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPhong fp = new FormPhong();
            fp.ShowDialog();              
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPhong fp = new FormPhong();
            fp.ShowDialog();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLienHe flh = new FormLienHe();
            flh.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhachHang fkh = new FormKhachHang();
            fkh.ShowDialog();
        }
        public static int GiaPhong;
        private void btnTPT1_Click(object sender, EventArgs e)
        {
            GiaPhong = 400000;
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GiaPhong = 600000;
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GiaPhong = 900000;
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap fdn = new FormDangNhap();
            fdn.Show();
            this.Hide();
        }

        private void btnOutpt1_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormChiTietHD fcthd = new FormChiTietHD();
            fcthd.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormChiTietHD fcthd = new FormChiTietHD();
            fcthd.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormChiTietHD fcthd = new FormChiTietHD();
            fcthd.ShowDialog();
        }
    }
}
