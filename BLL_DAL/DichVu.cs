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
                         dvs.TENDV
                     };
            return dv;
        }
    }
}
