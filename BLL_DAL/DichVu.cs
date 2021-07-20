using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL_DAL
{
    public class DichVu
    {
        HotelManagerDataContext data = new HotelManagerDataContext();
        public DichVu() { }

        public IQueryable GetDataDV()
        {
            var dv = from dvs in data.DICHVUs
                     select new
                     {                     
                         dvs.MADV,
                         dvs.TENDV
                     };
            return dv;
        }

        public IQueryable GetDGDV(string aMaDV)
        {
            var dv = from dvs in data.DICHVUs.Where(x => x.MADV == aMaDV)
                     select new
                     {
                         dvs.DONGIA
                     };
            return dv;
        }

        public IQueryable getMaDV()
        {
            var dv = from dvs in data.DICHVUs
                     select new
                     {
                         dvs.MADV,
                         dvs.TENDV
                     };
            return dv;
        }

        public IQueryable GetDataDVs()
        {
            var dv = from dvs in data.DICHVUs
                     select new
                     {
                         dvs.MADV,
                         dvs.TENDV,
                         dvs.DONGIA
                     };
            return dv;
        }

        public bool Add(string aMadv, string aTenDV, int aDonGia)
        {
            try
            {
                DICHVU dv = new DICHVU
           {
               MADV = aMadv,
               TENDV = aTenDV,
               DONGIA = aDonGia
           };
                data.DICHVUs.InsertOnSubmit(dv);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string aMadv)
        {
            try
            {
                DICHVU XoaDV = data.DICHVUs.Where(t => t.MADV == aMadv).First();
                data.DICHVUs.DeleteOnSubmit(XoaDV);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
 

    }
}
