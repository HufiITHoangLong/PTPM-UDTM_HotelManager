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
    public partial class FormTK : Form
    {
        public FormTK()
        {
            InitializeComponent();
        }

        private void FormTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Hotel_ManagerDataSet_ThongKe.CHITIETHD' table. You can move, or remove it, as needed.
            this.CHITIETHDTableAdapter.Fill(this.Hotel_ManagerDataSet_ThongKe.CHITIETHD);

            this.reportViewer1.RefreshReport();
        }
    }
}
