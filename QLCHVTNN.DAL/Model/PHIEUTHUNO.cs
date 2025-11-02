namespace QLCHVTNN.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHUNO")]
    public partial class PHIEUTHUNO
    {
        [Key]
        [StringLength(10)]
        public string MaPhieu { get; set; }

        public DateTime? NgayThu { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        public decimal SoTienThu { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
