using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CTHD
    {
        HotelManagerDataContext db = new HotelManagerDataContext();
        public CTHD()
        {

        }

        public IQueryable GetCTHD()
        {
            var kq = from cthd in db.CHITIETHDs
                     join hd in db.HOADONPHs on cthd.MAHD equals hd.MAHD
                     join p in db.PHONGs on hd.MAPH equals p.MAPHONG
                     select new
                     {
                         hd.MAHD,
                         hd.MAPH,
                         hd.MAKH,
                         cthd.TONGTIENDV,
                         cthd.TONGTIENPHONG,
                         cthd.THANHTIEN
                     };
            return kq;
        }
        public bool Add(string aMahd, string aMaph, string aTenkh, int aTTDV, int aTTP, int TT)
        {
            return true;
                     
        }
    }
}
