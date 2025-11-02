using QLCHVTNN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHVTNN.BUS
{
    public class PHIEUTHUNOService
    {
        QLCHContextDB db = new QLCHContextDB();
        public List<PHIEUTHUNO> GetAll()
        {
            return db.PHIEUTHUNOes.ToList();
        }
        public PHIEUTHUNO FindByID(string id)
        {
            return db.PHIEUTHUNOes.FirstOrDefault(n => n.MaPhieu == id);
        }
        public void Them(PHIEUTHUNO pn)
        {
            db.PHIEUTHUNOes.AddOrUpdate(pn);
            db.SaveChanges();
        }
        public void Xoa(string maPH)
        {
            var pn = db.PHIEUTHUNOes.FirstOrDefault(c => c.MaPhieu == maPH);
            db.PHIEUTHUNOes.Remove(pn);
            db.SaveChanges();
        }
    }
}
