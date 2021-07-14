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

        public IQueryable getHD()
        {
            var hd = from hds in db.HOADONPHs
                     select new
                     {
                         hds.MAHD,
                         hds.DONGIADV,
                         hds.SOLUONGDV,
                         hds.DONGIAP,
                         hds.NGAYRA,
                         hds.NGAYVAO
                     };
            return hd;
        }

        public IQueryable getTTTk()
        {
            var tk = from tks in db.CHITIETHDs
                     select new
                     {
                         tks.MAHD,
                         tks.TONGTIENPHONG,
                         tks.TONGTIENDV,
                         tks.THANHTIEN
                     };
            return tk;
        }



    }
}
