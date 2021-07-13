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
        DichVuNhanPhong np = new DichVuNhanPhong();
        DichVu dv = new DichVu();
        Phong p = new Phong();
        KhachHang kh = new KhachHang();
        CT_NHANPHONG ctnp = new CT_NHANPHONG();
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

            DGVNhanPhong.DataSource = np.getData();       
        }       
        private void BtnThem_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtMaPhieuNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhận phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPhieuNhap.Select();
                return;
            }
            if (DTPIn.Value > DTPout.Value)
            {
                MessageBox.Show("Ngày Checkin phải nhỏ hơn ngày Checkout", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DTPIn.Select();
                return;
            }  
            
            if (String.IsNullOrEmpty(txtSLDv.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSLDv.Select();
                return;
                
            }
            np.Add(txtMaPhieuNhap.Text, CBKH.SelectedValue.ToString(), CBMADV.SelectedValue.ToString(), int.Parse(txtSLDv.Text), FormMain.GiaPhong, DTPIn.Value, DTPout.Value);
            db.SubmitChanges();
            DGVNhanPhong.DataSource = np.getData();
            MessageBox.Show("Thêm thành công");
            txtMaPhieuNhap.Text = txtSLDv.Text = null;
        }
        private DataGridViewRow r;
        private void BTNXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            np.Delete(txtMaPhieuNhap.Text);
            DGVNhanPhong.DataSource = np.getData();
            MessageBox.Show("Xóa thành công");
            txtMaPhieuNhap.Clear();
            
            //txtSLDv.Clear();
        }
        
        private void BTNSua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dv = db.CT_NHANPHONGs.SingleOrDefault(x => x.MAPN == r.Cells["MAPN"].Value.ToString());
            dv.MADV = CBMADV.SelectedValue.ToString();
            dv.MAKH = CBKH.SelectedValue.ToString();
            dv.SOLUONG = int.Parse(txtSLDv.Text);
            db.SubmitChanges();
            DGVNhanPhong.DataSource = np.getData();
            MessageBox.Show("Cập nhật thông tin phiếu nhập thành công");
            txtMaPhieuNhap.Text =  txtSLDv.Text = null;
        }

        private void BTNTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button Save
            
        }

        private void DGVNhanPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = DGVNhanPhong.Rows[e.RowIndex];
                txtMaPhieuNhap.Text = r.Cells["MAPN"].Value.ToString();
                txtSLDv.Text = r.Cells["SOLUONG"].Value.ToString();
            }
              
        }

        private void BtnTaoHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHoaDon fhd = new FormHoaDon();
            fhd.ShowDialog();
        }

        

    }
}
