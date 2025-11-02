using QLCHVTNN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHVTNN.BUS.Service
{
    public class CHITIETPHIEUNHAPService
    {
        private readonly MATHANGService mATHANGService = new MATHANGService();
        QLCHContextDB db = new QLCHContextDB();
        public List<CHITIETPHIEUNHAP> FindByID(string id)
        {
            return db.CHITIETPHIEUNHAPs.Where(p=>p.MaPN==id).ToList();  
        }
        public void ThemSua(CHITIETPHIEUNHAP ct)
        {
            db.CHITIETPHIEUNHAPs.AddOrUpdate(ct);
            db.SaveChanges();
        }
        public void Xoa(string maPh,string maMH)
        {
            var ct=db.CHITIETPHIEUNHAPs.FirstOrDefault(c=>c.MaPN==maPh&&c.MaMH==maMH);
            db.CHITIETPHIEUNHAPs.Remove(ct);
            db.SaveChanges();
        }
        public BCNhap TongNhapMH(string id, DateTime from, DateTime to)
        {
            List<CHITIETPHIEUNHAP> ds = db.CHITIETPHIEUNHAPs.Where(m => m.MaMH == id && m.PHIEUNHAP.NgayNhap >= from && m.PHIEUNHAP.NgayNhap <= to).ToList();
            decimal tongTien = 0;

            if (ds.Any()) // kiểm tra có dữ liệu không
            {
                tongTien = (decimal)ds.Sum(m => m.ThanhTien);
            }

            BCNhap ph = new BCNhap
            {
                Ma = id,
                Ten = mATHANGService.FindByID(id).TenMH,
                TongTienNhap = tongTien
            };
            return ph;
        }
        public decimal GiaNhap(string id)
        {
            var temp = db.CHITIETPHIEUNHAPs
                         .Where(m => m.MaMH == id)
                         .OrderByDescending(n => n.PHIEUNHAP.NgayNhap)
                         .FirstOrDefault();

            if (temp != null && temp.DonGiaNhap != null)
                return (decimal)temp.DonGiaNhap;

            return 0; // hoặc bạn có thể return -1 để báo lỗi không có dữ liệu
        }
    }
}
