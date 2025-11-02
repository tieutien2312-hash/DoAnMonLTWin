using QLCHVTNN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHVTNN.BUS
{
    public class KHACHHANGService
    {
        QLCHContextDB db = new QLCHContextDB();
        public List<KHACHHANG> GetAll()
        {
            return db.KHACHHANGs.ToList();
        }
        public KHACHHANG FindByID(string id)
        {
            return db.KHACHHANGs.FirstOrDefault(n => n.MaKH == id);
        }
        public List<KHACHHANG> DSKhachNo()
        {
            return db.KHACHHANGs.Where(k=>k.TongNo>0).ToList();
        }
        public void AddKHACHHANG(KHACHHANG khachHang)
        {
            db.KHACHHANGs.Add(khachHang);
            db.SaveChanges();
        }

        public void UpdateKHACHHANG(KHACHHANG khachHang)
        {
            var existingKH = db.KHACHHANGs.FirstOrDefault(kh => kh.MaKH == khachHang.MaKH);
            if (existingKH != null)
            {
                existingKH.TenKH = khachHang.TenKH;
                existingKH.DiaChi = khachHang.DiaChi;
                existingKH.SDT = khachHang.SDT;
                existingKH.TongNo = khachHang.TongNo;
                db.SaveChanges();
            }
        }

        public void DeleteKHACHHANG(string maKH)
        {
            var khachHang = db.KHACHHANGs.FirstOrDefault(kh => kh.MaKH == maKH);
            if (khachHang != null)
            {
                db.KHACHHANGs.Remove(khachHang);
                db.SaveChanges();
            }
        }

        public List<KHACHHANG> SearchKHACHHANGs(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAll();
            }
            return db.KHACHHANGs
                     .Where(kh => kh.TenKH.ToLower().Contains(keyword) ||
                                    kh.SDT.ToLower().Contains(keyword))
                     .ToList();
        }
        public List<KHACHHANG> TimKiemKHNo(string keyword)
        {            
            return DSKhachNo().Where(kh => kh.TenKH.ToLower().Contains(keyword) ||
                                    kh.SDT.ToLower().Contains(keyword)).ToList();
        }

    }
}
