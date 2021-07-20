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
    public partial class FormMain : Form
    {
        NhanVien nv = new NhanVien();
        Phong p = new Phong();
        HoaDonPH hd = new HoaDonPH();
        HotelManagerDataContext db = new HotelManagerDataContext();
        CTHD ct = new CTHD();
        public FormMain()
        {
            InitializeComponent();
        }    
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            LabelXinChaoAd.Text = "Administrator";
            string[] thu = { "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy", "Chủ Nhật" };
            int ngay = DateTime.Now.DayOfWeek.GetHashCode();
            LabelNgay.Text = LabelNgay.Text + thu[ngay].ToString() + " Ngày " + DateTime.Today.Day.ToString() + " Tháng " + DateTime.Today.Month.ToString() + " Năm " + DateTime.Today.Year.ToString();
            

        }
        private void BTNDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap fdn = new FormDangNhap();
            fdn.Show();
            this.Hide();
            
        }

        public void SetRoom()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static int GiaPhong = 0;
            

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPhong fp = new FormPhong();
            fp.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNhanVien fnv = new FormNhanVien();
            fnv.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhachHang fkh = new FormKhachHang();
            fkh.ShowDialog();
        }

        
        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLienHe flh = new FormLienHe();
            flh.ShowDialog();
        }

        private void btnTPT1_Click(object sender, EventArgs e)
        {
            GiaPhong = 400000;
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void btnTPV1_Click(object sender, EventArgs e)
        {
            GiaPhong = 900000;
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }


        private void btnTPD1_Click(object sender, EventArgs e)
        {
            GiaPhong = 600000;
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }    
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChiTietHD fcthd = new FormChiTietHD();
            fcthd.ShowDialog();
        }

        private void btnOutpd1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChiTietHD fcthd = new FormChiTietHD();
            fcthd.ShowDialog();
        }

        private void btnOutpv1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChiTietHD fcthd = new FormChiTietHD();
            fcthd.ShowDialog();
        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDichVu fdv = new FormDichVu();
            fdv.ShowDialog();

        }

        }
    }

