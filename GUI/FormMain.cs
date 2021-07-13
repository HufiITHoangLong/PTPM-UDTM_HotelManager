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
        HotelManagerDataContext db = new HotelManagerDataContext();
        public FormMain()
        {
            InitializeComponent();
        }    
        //public void Quyen()
        //{

        //    if (q.QUYEN == "Admin")
        //    {
        //        MessageBox.Show("Xin chào " + q.QUYEN, "Thông báo", MessageBoxButtons.OK);
        //        BTNNhanVien.Enabled = true;
        //        BTNThongKe.Enabled = true;
        //        BTNDichVu.Enabled = true;
        //    }
        //    else
        //    {
        //        BTNNhanVien.Enabled = false;
        //        BTNThongKe.Enabled = false;
        //        BTNDichVu.Enabled = false;
        //    }
        //}
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

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongKe ftk = new FormThongKe();
            ftk.ShowDialog();
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
            btnTPV1.BackColor = Color.Lime;
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void btnTPT2_Click(object sender, EventArgs e)
        {
            GiaPhong = 400000;
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void btnTPD2_Click(object sender, EventArgs e)
        {
            GiaPhong = 600000;
            btnTPD2.BackColor = Color.Lime;
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

        private void btnTPV2_Click(object sender, EventArgs e)
        {
            GiaPhong = 900000;
            btnTPV2.BackColor = Color.Lime;
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHoaDon fhd = new FormHoaDon();
            fhd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelNgayDenpt1.Text = "...";
            LabelNgayDipt1.Text = "...";
            labelSoKOpt1.Text = "...";
            btnTPT1.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelNgayDenpv2.Text = "...";
            LabelNgayDipv2.Text = "...";
            labelSoKOpv2.Text = "...";
            btnTPV2.BackColor = Color.Red;
        }

        private void btnOutpd1_Click(object sender, EventArgs e)
        {
            labelNgayDenpd1.Text = "...";
            LabelNgayDipd1.Text = "...";
            labelSoKOpd1.Text = "...";
            btnTPD1.BackColor = Color.Red;
        }

        private void btnOutpv1_Click(object sender, EventArgs e)
        {
            labelNgayDenpv1.Text = "...";
            LabelNgayDipv1.Text = "...";
            labelSoKOpv1.Text = "...";
            btnTPV1.BackColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            labelNgayDenpt2.Text = "...";
            LabelNgayDipt2.Text = "...";
            labelSoKOpt2.Text = "...";
            btnTPT2.BackColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelNgayDenpd2.Text = "...";
            LabelNgayDipd2.Text = "...";
            labelSoKOpd2.Text = "...";
            btnTPD2.BackColor = Color.Red;
        }

       

        

        }
    }

