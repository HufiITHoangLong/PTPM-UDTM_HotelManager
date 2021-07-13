using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    
    public class Phong 
    {
        HotelManagerDataContext db = new HotelManagerDataContext();
        public Phong()
        {

        }
        public IQueryable getDataP()
        {
            var data = from phong in db.PHONGs
                       join lp in db.LOAIPHONGs on phong.MALOAIPHONG equals lp.MALOAIPHONG
                      select new 
                      {
                          phong.MAPHONG,
                          phong.TRANGTHAI,
                          phong.SUCCHUA,
                          lp.TENLOAIPHONG
                      };
            return data;
        }

        public IQueryable getMaLP()
        {
            var lp = from lps in db.LOAIPHONGs
                     select new
                     {
                         lps.DONGIA
                     };
            return lp;
        }

        public IQueryable getSC()
        {
            var sc = from scs in db.PHONGs
                     select new
                     {
                         scs.SUCCHUA
                     };
            return sc;    
        }

        public IQueryable getLP()
        {
            var lp = from pls in db.LOAIPHONGs
                     select new
                     {
                         pls.TENLOAIPHONG
                     };
            return lp;
        }

        public IQueryable getTenLPByID(string Maloai)
        {
            var tenlp = from id in db.LOAIPHONGs
                        from ten in id.TENLOAIPHONG
                      where id.MALOAIPHONG == int.Parse(Maloai)
                      select ten;

            return tenlp;
        }

        public bool Add(string aMAPHONG, int aTRANGTHAI, int aSUCCHUA, int aMaLoaiPhong)
        {
            try
            {
                PHONG p = new PHONG
                {
                    MAPHONG = aMAPHONG,
                    TRANGTHAI = aTRANGTHAI,
                    SUCCHUA = aSUCCHUA,
                    MALOAIPHONG = aMaLoaiPhong
                };
                db.PHONGs.InsertOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Delete(string aMAPHONG)
        {
            try
            {
                PHONG XoaP = db.PHONGs.Where(t => t.MAPHONG == aMAPHONG).First();
                db.PHONGs.DeleteOnSubmit(XoaP);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(string aMAPHONG, int aTRANGTHAI, int aSUCCHUA)
        {
            try
            {
                PHONG UpdateP = db.PHONGs.Where(t => t.MAPHONG == aMAPHONG).First();
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
