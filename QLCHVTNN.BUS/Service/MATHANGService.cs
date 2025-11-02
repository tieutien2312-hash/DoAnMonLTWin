using QLCHVTNN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHVTNN.BUS
{
    public class MATHANGService
    {
        QLCHContextDB db = new QLCHContextDB();
        public List<MATHANG> GetAll()
        {
            return db.MATHANGs.ToList();
        }
        public MATHANG FindByID(string id) 
        {
            return db.MATHANGs.FirstOrDefault(m=>m.MaMH==id);
        }
        public List<MATHANG> DSByID(string id)
        {
            return db.MATHANGs.Where(m => m.MaNCC == id).ToList();
        }
        public void AddMATHANG(MATHANG mh)
        {
            db.MATHANGs.Add(mh);
            db.SaveChanges();
        }
        public void UpdateMATHANG(MATHANG mh)
        {
            var existingMH = FindByID(mh.MaMH);
            if (existingMH != null)
            {
                existingMH.TenMH = mh.TenMH;
                existingMH.MaLoai = mh.MaLoai;
                existingMH.MaNCC = mh.MaNCC;
                existingMH.DonViTinh = mh.DonViTinh;
                existingMH.GiaBanTienMat = mh.GiaBanTienMat;
                existingMH.GiaBanGhiNo = mh.GiaBanGhiNo;
                existingMH.SoLuongTon = mh.SoLuongTon;
                db.SaveChanges();
            }
        }
        public void DeleteMATHANG(string maMH)
        {
            var mh = FindByID(maMH);
            if (mh != null)
            {
                db.MATHANGs.Remove(mh);
                db.SaveChanges();
            }
        }

        public List<MATHANG> SearchMATHANGByName(string tenMH)
        {
            return db.MATHANGs.Where(mh => mh.TenMH.Contains(tenMH)).ToList();
        }
        public List<string> DSID()
        {
            return db.MATHANGs.Select(m => m.MaMH).ToList();
        }

    }
}
