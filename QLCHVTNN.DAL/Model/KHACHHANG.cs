namespace QLCHVTNN.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            CONGNOes = new HashSet<CONGNO>();
            HOADONBANs = new HashSet<HOADONBAN>();
            PHIEUTHUNOes = new HashSet<PHIEUTHUNO>();
        }

        [Key]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKH { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        public bool? LoaiKH { get; set; }

        public decimal? TongNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGNO> CONGNOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONBAN> HOADONBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUNO> PHIEUTHUNOes { get; set; }
    }
}
