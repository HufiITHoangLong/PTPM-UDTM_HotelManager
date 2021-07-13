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
    public partial class FormChiTietHD : Form
    {
        HotelManagerDataContext db = new HotelManagerDataContext();
        public FormChiTietHD()
        {
            InitializeComponent();
        }

        private string MAHD;
        private string MAPH;
        private string TENKH;
        public void TinhTien()
        {
            var result = from hd in db.HOADONPHs
                         join p in db.PHONGs on hd.MAPH equals p.MAPHONG
                         join ct in db.CHITIETHDs.GroupBy(t => t.MAHD)
                         on hd.MAHD equals ct.First().MAHD
                         select new
                         {
                             MAHD = hd.MAHD,
                             MAPH = p.MAPHONG,
                             TENKH = hd.MAKH,
                             TONGTIENDV = hd.SOLUONGDV * hd.DONGIADV,
                             TONGTIENPHONG = ((TimeSpan)((DateTime)hd.NGAYRA - (DateTime)hd.NGAYVAO)).TotalDays * hd.DONGIAP,
                             THANHTIEN = (hd.SOLUONGDV * hd.DONGIADV) + ((TimeSpan)((DateTime)hd.NGAYRA - (DateTime)hd.NGAYVAO)).TotalDays * hd.DONGIAP
                         };
            DGVcthd.DataSource = result;
        }

        private void FormChiTietHD_Load(object sender, EventArgs e)
        {
            TinhTien();
        }
    }
}
