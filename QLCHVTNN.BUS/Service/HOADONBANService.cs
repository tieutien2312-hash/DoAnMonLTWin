using QLCHVTNN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHVTNN.BUS
{
    public class HOADONBANService
    {
        QLCHContextDB db = new QLCHContextDB();
        public List<HOADONBAN> GetAll()
        {
            return db.HOADONBANs.ToList();
        }
        public HOADONBAN FindByID(string id)
        {
            return db.HOADONBANs.FirstOrDefault(n => n.MaHD == id);
        }
        public List<HOADONBAN> FindByIDKH(string id)
        {
            return db.HOADONBANs.Where(n => n.MaKH == id).ToList();
        }
        public void Them(HOADONBAN pn)
        {
            db.HOADONBANs.Add(pn);
            db.SaveChanges();
        }
    }
}
