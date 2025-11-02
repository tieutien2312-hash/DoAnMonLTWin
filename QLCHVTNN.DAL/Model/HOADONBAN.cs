namespace QLCHVTNN.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONBAN")]
    public partial class HOADONBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONBAN()
        {
            CHITIETHOADONBANs = new HashSet<CHITIETHOADONBAN>();
            CONGNOes = new HashSet<CONGNO>();
        }

        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        public DateTime? NgayBan { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(20)]
        public string LoaiThanhToan { get; set; }

        public decimal? TongTien { get; set; }

        public bool? DaThanhToan { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONBAN> CHITIETHOADONBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGNO> CONGNOes { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
