using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHVTNN.DAL.Model
{
    public class BCDoanhThu
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public decimal GiaNhap{ get; set; }
        public decimal GiaBan{ get;set; }
        public int SoLuong {  get; set; }
        public decimal LoiNhuan { get; set; }
    }
}
