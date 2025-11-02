using QLCHVTNN.BUS.Service;
using QLCHVTNN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHVTNN.BUS
{
    public class CHITIETHOADONBANService
    {
        private readonly MATHANGService mATHANGService= new MATHANGService();
        private readonly HOADONBANService hOADONBANService = new HOADONBANService();
        private readonly CHITIETPHIEUNHAPService cHITIETPHIEUNHAPService = new CHITIETPHIEUNHAPService();
        QLCHContextDB db = new QLCHContextDB();
        public List<CHITIETHOADONBAN> FindByID(string id)
        {
            return db.CHITIETHOADONBANs.Where(p => p.MaHD == id).ToList();
        }       
        public void ThemSua(CHITIETHOADONBAN ct)
        {
            db.CHITIETHOADONBANs.AddOrUpdate(ct);
            db.SaveChanges();
        }
        public void Xoa(string maHd, string maMH)
        {
            var ct = db.CHITIETHOADONBANs.FirstOrDefault(c => c.MaHD == maHd && c.MaMH == maMH);
            db.CHITIETHOADONBANs.Remove(ct);
            db.SaveChanges();
        }
        public List<CHITIETHOADONBAN> DSCTTheoNg(List<HOADONBAN> list, DateTime ngf, DateTime ngt)
        {
            // Lọc danh sách hóa đơn nằm trong khoảng ngày
            var maHDs = list
                .Where(hd => hd.NgayBan >= ngf && hd.NgayBan <= ngt)
                .Select(hd => hd.MaHD)
                .ToList();

            // Lấy chi tiết hóa đơn thuộc các hóa đơn trong khoảng ngày
            return db.CHITIETHOADONBANs
                     .Where(ct => maHDs.Contains(ct.MaHD))
                     .ToList();
        }
        public BCDoanhThu DoanhThuNO(string id, DateTime from, DateTime to)
        {
            var ds = db.CHITIETHOADONBANs.Where(m => m.MaMH == id && m.HOADONBAN.NgayBan >= from && m.HOADONBAN.NgayBan <= to&&m.HOADONBAN.LoaiThanhToan=="Ghi nợ").ToList();
            int sl = 0;
            if (ds.Any()) // kiểm tra có dữ liệu không
            {
                sl = (int)ds.Sum(m => m.SoLuong);

            }
            decimal gb = mATHANGService.FindByID(id).GiaBanGhiNo;
            decimal gn = cHITIETPHIEUNHAPService.GiaNhap(id);
            BCDoanhThu ph = new BCDoanhThu
            {
                MaMH = id,
                TenMH = mATHANGService.FindByID(id).TenMH,
                GiaNhap= gn,
                GiaBan= gb,
                SoLuong=sl,
                LoiNhuan=(gb-gn)*sl
            };
            return ph;
        }
        public BCDoanhThu DoanhThuTM(string id, DateTime from, DateTime to)
        {
            var ds = db.CHITIETHOADONBANs.Where(m => m.MaMH == id && m.HOADONBAN.NgayBan >= from && m.HOADONBAN.NgayBan <= to && m.HOADONBAN.LoaiThanhToan == "Tiền mặt").ToList();
            int sl = 0;
            if (ds.Any()) // kiểm tra có dữ liệu không
            {
                sl = (int)ds.Sum(m => m.SoLuong);

            }
            decimal gb = mATHANGService.FindByID(id).GiaBanTienMat;
            decimal gn = cHITIETPHIEUNHAPService.GiaNhap(id);
            BCDoanhThu ph = new BCDoanhThu
            {
                MaMH = id,
                TenMH = mATHANGService.FindByID(id).TenMH,
                GiaNhap = gn,
                GiaBan = gb,
                SoLuong = sl,
                LoiNhuan = (gb - gn) * sl
            };
            return ph;
        }

    }
}
