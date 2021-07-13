using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL_DAL
{
    public class KhachHang
    {
        HotelManagerDataContext db = new HotelManagerDataContext();
        public KhachHang()
        {

        }

        public IQueryable GetDataKH()
        {
            var kh = from khs in db.KHACHHANGs
                     select new
                     {
                         khs.MAKH,
                         khs.TENKH,
                         khs.CMND,
                         khs.GIOITINH,
                         khs.DTHOAI,
                         khs.DCHI
                     };
            return kh;
        }

        public bool Add(string aMakh, string aHoten, string aCMND, string aDienThoai, string aDiaChi, string aGT)
        {
            try
            {
                KHACHHANG kh = new KHACHHANG
                {
                    MAKH = aMakh,
                    TENKH = aHoten,
                    CMND = aCMND,
                    DTHOAI = aDienThoai,
                    DCHI = aDiaChi,
                    GIOITINH = aGT
                };
                db.KHACHHANGs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable GetDataKHs()
        {
            var kh = from khs in db.KHACHHANGs
                     select new
                     {
                         khs.MAKH,
                         khs.TENKH
                     };
            return kh;
        }
        public bool Delete(string aMAKH)
        {
            try
            {
                KHACHHANG XoaKH = db.KHACHHANGs.Where(t => t.MAKH == aMAKH).First();
                db.KHACHHANGs.DeleteOnSubmit(XoaKH);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(string aMakh,string aHoten, string aCMND, string aDienThoai, string aDiaChi, string aGT)
        {
            try
            {
                KHACHHANG XoaKH = db.KHACHHANGs.Where(t => t.MAKH == aMakh).First();
                db.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
