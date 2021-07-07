using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL_DAL;

namespace GUI
{

    public partial class FormDangNhap : Form
    {
        HotelManagerDataContext db = new HotelManagerDataContext();
        NhanVien nv = new NhanVien();
        public FormDangNhap()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
       
        private void BTNDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUser1.Text) || string.IsNullOrEmpty(TextBoxMK.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUser1.Select();
                return;
            }
            var dn = db.NHANVIENs.SingleOrDefault(x => x.USERNAME == textBoxUser1.Text && x.PASSWORD == TextBoxMK.Text);
            
            if (dn != null && dn.QUYEN != "Admin")
            {
                MessageBox.Show("Xin chào " + dn.QUYEN, "Thông báo", MessageBoxButtons.OK);
                FormMainS fms = new FormMainS();
                fms.ShowDialog();
                textBoxUser1.Clear();
                TextBoxMK.Clear();
            }
            else if (dn.QUYEN == "Admin")
            {
                MessageBox.Show("Xin chào " + dn.QUYEN, "Thông báo", MessageBoxButtons.OK);
                FormMain fm = new FormMain();
                fm.ShowDialog();
                textBoxUser1.Clear();
                TextBoxMK.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập và mật khẩu", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUser1.Select();
                return;
            }
        }

        
    }
}
