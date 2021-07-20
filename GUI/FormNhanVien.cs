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
    public partial class FormNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            DGVNhanVien.DataSource = nv.GetData();
            
        }

        private void BTNTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }
        private DataGridViewRow r;
        
        private void BTNSua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var updatenv = db.NHANVIENs.FirstOrDefault(x => x.USERNAME == r.Cells["USERNAME"].Value.ToString());
            updatenv.PASSWORD = tbPass.Text;
            updatenv.HOTENNV = tbHoTen.Text;
            updatenv.DIENTHOAI = textBoxPhone1.Text;
            updatenv.DIACHI = TBDiaChi.Text;
            db.SubmitChanges();
            MessageBox.Show("Cập nhật thông tin nhân viên thành công");
            DGVNhanVien.DataSource = nv.GetData();
            TBUser.Text = tbPass.Text = tbHoTen.Text = textBoxPhone1.Text = TBDiaChi.Text = null;
           
        }

        private void BTNXoa_Click(object sender, EventArgs e)
        {
             if (r == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            DGVNhanVien.DataSource = nv.Delete(TBUser.Text);
            DGVNhanVien.DataSource = nv.GetData();
            MessageBox.Show("Xóa thành công");
            TBUser.Clear();
            tbPass.Clear();
            tbHoTen.Clear();
            textBoxPhone1.Clear();
            TBDiaChi.Clear();
           
        }

        HotelManagerDataContext db = new HotelManagerDataContext();
        
        private void BTNThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBUser.Text))
            {
                MessageBox.Show("Vui lòng nhập Username cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBUser.Select();
                return;
            }
            if (String.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Vui lòng nhập Password cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPass.Select();
                return;
            }

            if (String.IsNullOrEmpty(tbHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbHoTen.Select();
                return;
            }
            if (String.IsNullOrEmpty(textBoxPhone1.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại liên hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPhone1.Select();
                return;
            }

            if (String.IsNullOrEmpty(TBDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBDiaChi.Select();
                return;
            }

            var nvs = new NHANVIEN();
            nvs.USERNAME = TBUser.Text;
            nvs.HOTENNV = tbHoTen.Text;
            nvs.PASSWORD = tbPass.Text;
            nvs.DIENTHOAI = textBoxPhone1.Text;
            nvs.DIACHI = TBDiaChi.Text;
            //nvs.QUYEN = CBBQuyen.SelectedValue.ToString();
            db.NHANVIENs.InsertOnSubmit(nvs);
            db.SubmitChanges();
            MessageBox.Show("Thêm nhân viên thành công");
            DGVNhanVien.DataSource = nv.GetData();
            TBUser.Text = tbPass.Text = tbHoTen.Text = textBoxPhone1.Text = TBDiaChi.Text = null;
            
        }       
        private void DGVNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = DGVNhanVien.Rows[e.RowIndex];
                TBUser.Text = r.Cells["USERNAME"].Value.ToString();
                tbPass.Text = r.Cells["PASSWORD"].Value.ToString();
                tbHoTen.Text = r.Cells["HOTENNV"].Value.ToString();
                TBDiaChi.Text = r.Cells["DIACHI"].Value.ToString();
                textBoxPhone1.Text = r.Cells["DIENTHOAI"].Value.ToString();
            }
        }
        
    }
}
