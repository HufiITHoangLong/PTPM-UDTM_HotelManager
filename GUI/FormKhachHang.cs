using DemoBuoi7;
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
    public partial class FormKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            WordExport word = new WordExport();

            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            string diachi = "133, Nguyễn Huệ, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh";
            string sotokhai = "TKYT01";
            string hoten = txtHoTen.Text;
            string CMND = txtCMND.Text;
            string dienthoai = textBoxPhone1.Text;
         
            word.ToKhaiYTe(diachi, sotokhai , ngay, thang, nam, hoten, CMND, dienthoai);
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            
            DGVKhachHang.DataSource = kh.GetDataKH();
            DGVKhachHang.Columns["MAKH"].HeaderText = "Mã khách";
            DGVKhachHang.Columns["TENKH"].HeaderText = "Tên khách";
            DGVKhachHang.Columns["CMND"].HeaderText = "CMND/Căn cước";
            DGVKhachHang.Columns["GIOITINH"].HeaderText = "Giới tính";
            DGVKhachHang.Columns["DTHOAI"].HeaderText = "Điện thoại";
            DGVKhachHang.Columns["DCHI"].HeaderText = "Địa chỉ";
            
        }

        private void BtnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMakhach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhach.Select();
                return;
            }
            if (String.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Select();
                return;
            }

            if (String.IsNullOrEmpty(txtCMND.Text))
            {
                MessageBox.Show("Vui lòng nhập CMND/Căn cước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCMND.Select();
                return;
            }
            if (String.IsNullOrEmpty(textBoxPhone1.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại liên hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPhone1.Select();
                return;
            }

            if (String.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Select();
                return;
            }

            DGVKhachHang.DataSource = kh.Add(txtMakhach.Text, txtHoTen.Text, txtCMND.Text, textBoxPhone1.Text, txtDiaChi.Text, txtGT.Text);
            MessageBox.Show("Thêm phòng thành công");
            DGVKhachHang.DataSource = kh.GetDataKH();
            txtMakhach.Text = txtHoTen.Text = txtCMND.Text = textBoxPhone1.Text = txtDiaChi.Text = txtGT.Text = null;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            DGVKhachHang.DataSource = kh.Delete(txtMakhach.Text);
            DGVKhachHang.DataSource = kh.GetDataKH();
            MessageBox.Show("Xóa thành công");
            txtMakhach.Clear();
            txtHoTen.Clear();
            txtCMND.Clear();
            textBoxPhone1.Clear();
            txtGT.Clear();
        }
        private DataGridViewRow r;
        HotelManagerDataContext db = new HotelManagerDataContext();
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var hk = db.KHACHHANGs.SingleOrDefault(x => x.MAKH == r.Cells["MAKH"].Value.ToString());
            hk.TENKH = txtHoTen.Text;
            hk.CMND = txtCMND.Text;
            hk.GIOITINH = txtGT.Text;
            hk.DTHOAI = textBoxPhone1.Text;
            hk.DCHI = txtDiaChi.Text;
            db.SubmitChanges();
            DGVKhachHang.DataSource = kh.GetDataKH();
            MessageBox.Show("Cập nhật thông tin phiếu nhập thành công");
            txtCMND.Text =  txtCMND.Text =  txtCMND.Text = textBoxPhone1.Text = txtDiaChi.Text = null;
        }
        
        private void DGVKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0)
             {
                 r = DGVKhachHang.Rows[e.RowIndex];
                 txtMakhach.Text = r.Cells["MAKH"].Value.ToString();
                 txtHoTen.Text = r.Cells["TENKH"].Value.ToString();
                 txtCMND.Text = r.Cells["CMND"].Value.ToString();
                 textBoxPhone1.Text = r.Cells["DTHOAI"].Value.ToString();
                 txtDiaChi.Text = r.Cells["DCHI"].Value.ToString();
                 txtGT.Text = r.Cells["GIOITINH"].Value.ToString();
             }
              
                
        }
    }
}
