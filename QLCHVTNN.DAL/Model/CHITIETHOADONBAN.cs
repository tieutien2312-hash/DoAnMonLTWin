namespace QLCHVTNN.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADONBAN")]
    public partial class CHITIETHOADONBAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaMH { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ThanhTien { get; set; }

        public virtual HOADONBAN HOADONBAN { get; set; }

        public virtual MATHANG MATHANG { get; set; }
    }
}
