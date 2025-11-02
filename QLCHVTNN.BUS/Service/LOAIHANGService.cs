using QLCHVTNN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHVTNN.BUS
{
    public class LOAIHANGService
    {
        QLCHContextDB db = new QLCHContextDB();

        public List<LOAIHANG> GetAllLOAIHANGs()
        {
            return db.LOAIHANGs.ToList();
        }

        public void AddLOAIHANG(LOAIHANG lh)
        {
            db.LOAIHANGs.Add(lh);
            db.SaveChanges();
        }

        public void UpdateLOAIHANG(LOAIHANG lh)
        {
            var existingLH = db.LOAIHANGs.FirstOrDefault(p => p.MaLoai == lh.MaLoai);
            if (existingLH != null)
            {
                existingLH.TenLoai = lh.TenLoai;
                db.SaveChanges();
            }
        }

        public void DeleteLOAIHANG(string maLoai)
        {
            var lh = db.LOAIHANGs.FirstOrDefault(p => p.MaLoai == maLoai);
            if (lh != null)
            {
                db.LOAIHANGs.Remove(lh);
                db.SaveChanges();
            }
        }

        public LOAIHANG GetLOAIHANGById(string maLoai)
        {
            return db.LOAIHANGs.FirstOrDefault(p => p.MaLoai == maLoai);
        }

        public List<LOAIHANG> SearchLOAIHANGByName(string tenLoai)
        {
            return db.LOAIHANGs.Where(p => p.TenLoai.Contains(tenLoai)).ToList();
        }
    }
}
