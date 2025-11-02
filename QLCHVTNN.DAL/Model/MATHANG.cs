namespace QLCHVTNN.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MATHANG")]
    public partial class MATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATHANG()
        {
            CHITIETHOADONBANs = new HashSet<CHITIETHOADONBAN>();
            CHITIETPHIEUNHAPs = new HashSet<CHITIETPHIEUNHAP>();
        }

        [Key]
        [StringLength(10)]
        public string MaMH { get; set; }

        [Required]
        [StringLength(100)]
        public string TenMH { get; set; }

        [StringLength(10)]
        public string MaLoai { get; set; }

        [StringLength(10)]
        public string MaNCC { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        public decimal GiaBanTienMat { get; set; }

        public decimal GiaBanGhiNo { get; set; }

        public int? SoLuongTon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONBAN> CHITIETHOADONBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }

        public virtual LOAIHANG LOAIHANG { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
