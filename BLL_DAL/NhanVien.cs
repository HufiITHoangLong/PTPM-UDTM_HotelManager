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

      
        public List<NHANVIEN> GetData()
        {
            return db.NHANVIENs.Select(s => s).ToList<NHANVIEN>();
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

        
    }
}
