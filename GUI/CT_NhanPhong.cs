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
using System.Globalization;

namespace GUI
{
    public partial class CT_NhanPhong : Form
    {
        HotelManagerDataContext db = new HotelManagerDataContext();
        DichVu dv = new DichVu();
        Phong p = new Phong();
        KhachHang kh = new KhachHang();
        HoaDonPH hd = new HoaDonPH();
        public CT_NhanPhong()
        {
            InitializeComponent();
        }
       
        private void CT_NhanPhong_Load(object sender, EventArgs e)
        {
            txtGiaPhong.Text = FormMain.GiaPhong.ToString();
            CBMADV.DisplayMember = "TENDV";
            CBMADV.ValueMember = "MADV";
            CBMADV.DataSource = dv.getMaDV();

            CBKH.DisplayMember = "TENKH";
            CBKH.ValueMember = "MAKH";
            CBKH.DataSource = kh.GetDataKHs();

            CBBMAPhong.DisplayMember = "MAPHONG";
            CBBMAPhong.ValueMember = "MAPHONG";
            CBBMAPhong.DataSource = p.GetMP();

            DGVNhanPhong.DataSource = hd.getData();       
        }       
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHD.Select();
                return;
            }

            if (String.IsNullOrEmpty(txtSLDv.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSLDv.Select();
                return;
            }
            
            if (String.IsNullOrEmpty(txtDGDV.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDGDV.Select();
                return;
            }
            if (String.IsNullOrEmpty(txtSLDv.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSLDv.Select();
                return;
                
            }
            hd.Add(txtMaHD.Text,CBKH.SelectedValue.ToString(),CBMADV.SelectedValue.ToString(), int.Parse(txtSLDv.Text),int.Parse(txtDGDV.Text), CBBMAPhong.SelectedValue.ToString(), FormMain.GiaPhong, DateTime.Now, DTPIn.Value);
            DGVNhanPhong.DataSource = hd.getData();
            string idp = CBBMAPhong.SelectedValue.ToString();
            var ttp = db.PHONGs.SingleOrDefault(x => x.MAPHONG == idp);
            ttp.TRANGTHAI = 1;
            db.SubmitChanges();
            CBBMAPhong.DataSource = p.GetMP();
            MessageBox.Show("Thêm thành công");
            txtMaHD.Text = txtSLDv.Text = null;
        }
        private DataGridViewRow r;
        private void BTNXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            hd.Delete(txtMaHD.Text);
            DGVNhanPhong.DataSource = hd.getData();
            string idp = CBBMAPhong.SelectedValue.ToString();
            var ttp = db.PHONGs.SingleOrDefault(x => x.MAPHONG == idp);
            ttp.TRANGTHAI = 0;
            db.SubmitChanges();
            CBBMAPhong.DataSource = p.GetMP();
            MessageBox.Show("Xóa thành công");
            txtMaHD.Clear();
            txtSLDv.Clear();
            
        }
        
        private void BTNSua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var update = db.HOADONPHs.SingleOrDefault(x => x.MAHD == r.Cells["MAHD"].Value.ToString());
            update.MAHD = txtMaHD.Text;
            update.MAKH = CBKH.SelectedValue.ToString();
            update.MADV = CBMADV.SelectedValue.ToString();
            update.SOLUONGDV = int.Parse(txtSLDv.Text);
            update.DONGIADV = int.Parse(txtDGDV.Text);
            update.NGAYRA = DTPIn.Value;
            string idp = CBBMAPhong.SelectedValue.ToString();
            var ttp = db.PHONGs.SingleOrDefault(x => x.MAPHONG == idp);
            ttp.TRANGTHAI = 1;
            db.SubmitChanges();
            CBBMAPhong.DataSource = p.GetMP();
            DGVNhanPhong.DataSource = hd.getData();
            MessageBox.Show("Cập nhật thông tin phiếu nhập thành công");
            txtMaHD.Text = txtSLDv.Text = txtDGDV.Text = null;
        }

        private void BTNTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }

        private void DGVNhanPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = DGVNhanPhong.Rows[e.RowIndex];
                txtMaHD.Text = r.Cells["MAHD"].Value.ToString();
                txtSLDv.Text = r.Cells["SOLUONGDV"].Value.ToString();
            }
              
        }
    }
}
