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
    public partial class FormDichVu : Form
    {
        DichVu dv = new DichVu();
        HotelManagerDataContext data = new HotelManagerDataContext();
      
        public FormDichVu()
        {
            InitializeComponent();
        }
        private DataGridViewRow r;
        private void FormDichVu_Load(object sender, EventArgs e)
        {
            DGVDichVu.DataSource = dv.GetDataDVs();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaDV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDV.Select();
                return;
            }
            if (String.IsNullOrEmpty(txtTenDV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDV.Select();
                return;
            }
            if (String.IsNullOrEmpty(txtDG.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDG.Select();
                return;
            }
            dv.Add(txtMaDV.Text, txtTenDV.Text, int.Parse(txtDG.Text));
            MessageBox.Show("Thêm thành công");
            DGVDichVu.DataSource = dv.GetDataDVs();
            txtMaDV.Text = txtTenDV.Text = txtDG.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DGVDichVu.DataSource = dv.Delete(txtMaDV.Text);
            DGVDichVu.DataSource = dv.GetDataDVs();
            MessageBox.Show("Xóa thành công");
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtDG.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ hàng muốn cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dvs = data.DICHVUs.SingleOrDefault(x => x.MADV == r.Cells["MADV"].Value.ToString());
            dvs.TENDV = txtTenDV.Text;
            dvs.DONGIA = int.Parse(txtDG.Text);
            data.SubmitChanges();
            DGVDichVu.DataSource = dv.GetDataDVs();
            MessageBox.Show("Cập nhật thông tin dịch vụ thành công");
            txtMaDV.Text = txtTenDV.Text = txtDG.Text = null;
        }

        private void DGVDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = DGVDichVu.Rows[e.RowIndex];
                txtMaDV.Text = r.Cells["MADV"].Value.ToString();
                txtTenDV.Text = r.Cells["TENDV"].Value.ToString();
                txtDG.Text = r.Cells["DONGIA"].Value.ToString();
            }                
        }
    }
}
