using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL_DAL
{
    public class DichVuNhanPhong
    {
        HotelManagerDataContext db = new HotelManagerDataContext();
        public DichVuNhanPhong() { }

        public IQueryable getData()
        {
            var dvnp = from dvnps in db.CT_NHANPHONGs

                       join kh in db.KHACHHANGs on dvnps.MAKH equals kh.MAKH

                       join dv in db.DICHVUs on dvnps.MADV equals dv.MADV

                       select new
                       {
                           dvnps.MAPN,
                           kh.TENKH,
                           dvnps.MADV,
                           dvnps.SOLUONG,
                           dvnps.NGAYVAO,
                           dvnps.NGAYDI,
                       };
            return dvnp;
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

        public bool Add(string aMapn, string aMakh, string aMaDV, int aSoluong, int aGiaPhong, DateTime aNgayVao, DateTime aNgayRa)
        {
            CT_NHANPHONG dvnp = new CT_NHANPHONG
            {
                MAPN = aMapn,
                MAKH = aMakh,
                MADV = aMaDV,
                SOLUONG = aSoluong,
                DONGIA = aGiaPhong,
                NGAYVAO = aNgayVao,
                NGAYDI = aNgayRa,
            };
            db.CT_NHANPHONGs.InsertOnSubmit(dvnp);
            db.SubmitChanges();
            return true;

        }

        public bool Delete(string aMAPN)
        {
                CT_NHANPHONG Xoact = db.CT_NHANPHONGs.Where(x => x.MAPN == aMAPN).First();
                db.CT_NHANPHONGs.DeleteOnSubmit(Xoact);
                db.SubmitChanges();
                return true;
        }

    }
}
