using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLL_DAL
{
    public class NhanVien
    {
        HotelManagerDataContext db = new HotelManagerDataContext();
        public NhanVien() { }

      
        public IQueryable GetData()
        {
            var nv = from nvs in db.NHANVIENs
                     select new {
                         nvs.USERNAME,
                         nvs.HOTENNV,
                         nvs.PASSWORD,
                         nvs.DIENTHOAI,
                         nvs.DIACHI,
                         nvs.QUYEN
                     };
            return nv;

        }

        public IQueryable GetQuyenNV()
        {
            var quyen = from q in db.NHANVIENs
                        select new
                        {
                            q.QUYEN
                        };
            return quyen;
        }

        public bool Add(string auser, string aHotennv, string apass, string adt, string aDc, string aquyen)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN
                {
                    USERNAME = auser,
                    PASSWORD = apass,
                    HOTENNV = aHotennv,
                    DIACHI = aDc,
                    DIENTHOAI = adt,
                    QUYEN = aquyen

                };
                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string aUser)
        {
            try
            {
                NHANVIEN XoaNv = db.NHANVIENs.Where(x => x.USERNAME == aUser).First();
                db.NHANVIENs.DeleteOnSubmit(XoaNv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(string aUser, string aHoten, string aPass, string aDt, string aDc, string aQuyen)
        {
            try
            {
                NHANVIEN Xoanv = db.NHANVIENs.Where(t => t.USERNAME == aUser).First();
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
