using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL_DAL
{
    public class HoaDonPH
    {
        HotelManagerDataContext db = new HotelManagerDataContext();
        public HoaDonPH() { }

        public IQueryable getData()
        {
            var hd = from hds in db.HOADONPHs

                       join kh in db.KHACHHANGs on hds.MAKH equals kh.MAKH

                       join dv in db.DICHVUs on hds.MADV equals dv.MADV

                       join p in db.PHONGs on hds.MAPH equals p.MAPHONG

                       select new
                       {
                           hds.MAHD,
                           kh.TENKH,
                           dv.TENDV,
                           hds.SOLUONGDV,
                           dv.DONGIA,
                           p.MAPHONG,
                           hds.DONGIAP,
                           hds.NGAYVAO,
                           hds.NGAYRA
                       };
            return hd;
        }
        public IQueryable getDGLP()
        {
            var dglp = from dglps in db.LOAIPHONGs
                       select new
                       {
                           dglps.DONGIA
                       };
            return dglp;
        }

        public bool Add(string aMahd, string aMakh, string aMaDV, int aSoluongdv, int aDGDV, string aMap, int aDGP, DateTime aNgayVao, DateTime aNgayRa)
        {
            HOADONPH dvnp = new HOADONPH
            {
                MAHD = aMahd,
                MAKH = aMakh,
                MADV = aMaDV,
                SOLUONGDV = aSoluongdv,
                DONGIADV = aDGDV,
                MAPH = aMap,
                DONGIAP = aDGP,
                NGAYVAO = aNgayVao,
                NGAYRA = aNgayRa
            };
            db.HOADONPHs.InsertOnSubmit(dvnp);
            db.SubmitChanges();
            return true;
        }

        public bool Delete(string aMAhd)
        {
            HOADONPH Xoact = db.HOADONPHs.Where(x => x.MAHD == aMAhd).First();
            db.HOADONPHs.DeleteOnSubmit(Xoact);
            db.SubmitChanges();
                return true;
        }


        

        
    }
}
