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
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void btnTPV1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void btnTPT2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void btnTPD2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void btnTPD1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

        private void btnTPV2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CT_NhanPhong ctnp = new CT_NhanPhong();
            ctnp.ShowDialog();
        }

       

        

        }
    }

