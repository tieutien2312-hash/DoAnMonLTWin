using QLCHVTNN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHVTNN.BUS.Service
{
    public class PHIEUNHAPService
    {
        QLCHContextDB db = new QLCHContextDB();
        private readonly NHACUNGCAPService nHACUNGCAPService=new NHACUNGCAPService();
        
        public void Them(PHIEUNHAP pn)
        {
            db.PHIEUNHAPs.Add(pn);
            db.SaveChanges();
        }
        public PHIEUNHAP FindByID(string id)
        {
            return db.PHIEUNHAPs.FirstOrDefault(p => p.MaPN == id);
        }
        public BCNhap TongNhapNCC(string id,DateTime from,DateTime to) 
        {
            List<PHIEUNHAP> ds = db.PHIEUNHAPs.Where(m => m.MaNCC == id&&m.NgayNhap>=from&&m.NgayNhap<=to).ToList();
            decimal tongTien = 0;

            if (ds.Any()) // kiểm tra có dữ liệu không
            {
                tongTien =(decimal)ds.Sum(m => m.TongTienNhap);
            }

            BCNhap ph = new BCNhap
            {
                Ma = id,
                Ten=nHACUNGCAPService.FindByID(id).TenNCC,
                TongTienNhap = tongTien
            };
            return ph;
        }
        


    }
}
