using QLCHVTNN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHVTNN.BUS
{
    public class NHACUNGCAPService
    {
        QLCHContextDB db = new QLCHContextDB();
        public List<NHACUNGCAP> GetAll()
        {
            return db.NHACUNGCAPs.ToList();
        }
        public NHACUNGCAP FindByID(string id)
        {
            return db.NHACUNGCAPs.FirstOrDefault(n=>n.MaNCC==id);
        }
        public void AddNCC(NHACUNGCAP ncc)
        {
            db.NHACUNGCAPs.Add(ncc);
            db.SaveChanges();
        }
        public NHACUNGCAP GetNCCById(string maNCC)
        {
            var ncc = db.NHACUNGCAPs.FirstOrDefault(kh => kh.MaNCC == maNCC);
            return ncc;
        }

        public void UpdateNCC(NHACUNGCAP ncc)
        {
            var existingNCC = db.NHACUNGCAPs.Find(ncc.MaNCC);
            if (existingNCC != null)
            {
                existingNCC.TenNCC = ncc.TenNCC;
                existingNCC.DiaChi = ncc.DiaChi;
                existingNCC.SDT = ncc.SDT;
                db.SaveChanges();
            }
        }

        public void DeleteNCC(string maNCC)
        {
            var ncc = db.NHACUNGCAPs.Find(maNCC);
            if (ncc != null)
            {
                db.NHACUNGCAPs.Remove(ncc);
                db.SaveChanges();
            }
        }

        public List<NHACUNGCAP> SearchNCCs(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAll();
            }
            return db.NHACUNGCAPs
                .Where(ncc => ncc.MaNCC.Contains(keyword) ||
                            ncc.TenNCC.Contains(keyword))
                .ToList();
        }
        public List<string> DSID()
        {
            return db.NHACUNGCAPs.Select(m=>m.MaNCC).ToList();
        }
    }
}
