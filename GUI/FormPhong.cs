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
    public partial class FormPhong : Form
    {
        HotelManagerDataContext db = new HotelManagerDataContext();
        private NHANVIEN nv = new NHANVIEN();
        
     
        Phong phong = new Phong();
        
        public FormPhong()
        {
            InitializeComponent();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
           
            DGVPhong.DataSource = phong.getDataP();
            DGVPhong.Columns["MAPHONG"].HeaderText = "Mã Phòng";
            DGVPhong.Columns["TRANGTHAI"].HeaderText = "Trạng Thái";
            DGVPhong.Columns["SUCCHUA"].HeaderText = "Sức Chứa";
            DGVPhong.Columns["TENLOAIPHONG"].HeaderText = "Loại Phòng";
           
        }


        private void BTNTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();  
            fm.ShowDialog();
        }

        private void BTNXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nv.QUYEN == "Staff")
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DGVPhong.DataSource = phong.Delete(TBMAPHONG.Text);
            DGVPhong.DataSource = phong.getDataP();
            MessageBox.Show("Xóa thành công");
            TBMAPHONG.Clear();
            TBTrangThai.Clear();
            TBSC.Clear();
            TBLoai.Clear();
        }
        
        private void BTNSua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng muốn cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var pg = db.PHONGs.SingleOrDefault(x => x.MAPHONG == r.Cells["MAPHONG"].Value.ToString());
            pg.MAPHONG = TBMAPHONG.Text;
            pg.TRANGTHAI = int.Parse(TBTrangThai.Text);
            pg.SUCCHUA = int.Parse(TBSC.Text);
            pg.MALOAIPHONG = int.Parse(TBLoai.Text);
            db.SubmitChanges();
            MessageBox.Show("Cập nhật phòng thành công");
            DGVPhong.DataSource = phong.getDataP();
            TBMAPHONG.Text = TBTrangThai.Text = TBSC.Text = null;
        }

        private void BTNThem_Click_1(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(TBMAPHONG.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBMAPHONG.Select();
                return;
            }

            if (String.IsNullOrEmpty(TBTrangThai.Text))
            {
                MessageBox.Show("Vui lòng nhập trạng thái phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBTrangThai.Select();
                return;
            }
            if (String.IsNullOrEmpty(TBSC.Text))
            {
                MessageBox.Show("Vui lòng nhập sức chứa phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TBSC.Select();
                return;
            }
            DGVPhong.DataSource = phong.Add(TBMAPHONG.Text, int.Parse(TBTrangThai.Text), int.Parse(TBSC.Text), int.Parse(TBLoai.Text));  
            MessageBox.Show("Thêm phòng thành công");
            DGVPhong.DataSource = phong.getDataP();
            TBMAPHONG.Text = TBTrangThai.Text = TBSC.Text = null;
            
        }


        private DataGridViewRow r;
        private void DGVPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = DGVPhong.Rows[e.RowIndex];
                TBMAPHONG.Text = r.Cells["MAPHONG"].Value.ToString();
                TBTrangThai.Text = r.Cells["TRANGTHAI"].Value.ToString();
                TBSC.Text = r.Cells["SUCCHUA"].Value.ToString();
                TBLoai.Text = r.Cells["TENLOAIPHONG"].Value.ToString();
            }
        }
       

       

        


        

        

        
    }
}
