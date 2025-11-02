namespace QLCHVTNN.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONGNO")]
    public partial class CONGNO
    {
        [Key]
        [StringLength(10)]
        public string MaNo { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(10)]
        public string MaHD { get; set; }

        public decimal SoTienNo { get; set; }

        public DateTime? NgayPhatSinh { get; set; }

        public DateTime? HanTra { get; set; }

        public decimal? DaTra { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ConLai { get; set; }

        public bool? CoTinhLai { get; set; }

        public decimal? LaiPhatSinh { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        public virtual HOADONBAN HOADONBAN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
