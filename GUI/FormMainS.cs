using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMainS : Form
    {
        public FormMainS()
        {
            InitializeComponent();
        }

        private void FormMainS_Load(object sender, EventArgs e)
        {
            LabelXinChaoStaff.Text = "Staff";
            string[] thu = { "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy", "Chủ Nhật" };
            int ngay = DateTime.Now.DayOfWeek.GetHashCode();
            LabelNgay.Text = LabelNgay.Text + thu[ngay].ToString() + " Ngày " + DateTime.Today.Day.ToString() + " Tháng " + DateTime.Today.Month.ToString() + " Năm " + DateTime.Today.Year.ToString();
        }

        private void BTNSPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPhong fp = new FormPhong();
            fp.ShowDialog();              
        }
    }
}
