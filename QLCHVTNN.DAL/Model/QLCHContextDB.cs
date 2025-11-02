using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLCHVTNN.DAL.Model
{
    public partial class QLCHContextDB : DbContext
    {
        public QLCHContextDB()
            : base("name=QLCHContextDB")
        {
        }

        public virtual DbSet<CHITIETHOADONBAN> CHITIETHOADONBANs { get; set; }
        public virtual DbSet<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
        public virtual DbSet<CONGNO> CONGNOes { get; set; }
        public virtual DbSet<HOADONBAN> HOADONBANs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LAISUAT> LAISUATs { get; set; }
        public virtual DbSet<LOAIHANG> LOAIHANGs { get; set; }
        public virtual DbSet<MATHANG> MATHANGs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<PHIEUTHUNO> PHIEUTHUNOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETHOADONBAN>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADONBAN>()
                .Property(e => e.MaMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADONBAN>()
                .Property(e => e.ThanhTien)
                .HasPrecision(29, 2);

            modelBuilder.Entity<CHITIETPHIEUNHAP>()
                .Property(e => e.MaPN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETPHIEUNHAP>()
                .Property(e => e.MaMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETPHIEUNHAP>()
                .Property(e => e.ThanhTien)
                .HasPrecision(29, 2);

            modelBuilder.Entity<CONGNO>()
                .Property(e => e.MaNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONGNO>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONGNO>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONGNO>()
                .Property(e => e.ConLai)
                .HasPrecision(19, 2);

            modelBuilder.Entity<HOADONBAN>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADONBAN>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADONBAN>()
                .HasMany(e => e.CHITIETHOADONBANs)
                .WithRequired(e => e.HOADONBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<LAISUAT>()
                .Property(e => e.MaLai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LAISUAT>()
                .Property(e => e.TyLeLai)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LOAIHANG>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MATHANG>()
                .Property(e => e.MaMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MATHANG>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MATHANG>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MATHANG>()
                .HasMany(e => e.CHITIETHOADONBANs)
                .WithRequired(e => e.MATHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MATHANG>()
                .HasMany(e => e.CHITIETPHIEUNHAPs)
                .WithRequired(e => e.MATHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MaPN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .HasMany(e => e.CHITIETPHIEUNHAPs)
                .WithRequired(e => e.PHIEUNHAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUTHUNO>()
                .Property(e => e.MaPhieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUNO>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
