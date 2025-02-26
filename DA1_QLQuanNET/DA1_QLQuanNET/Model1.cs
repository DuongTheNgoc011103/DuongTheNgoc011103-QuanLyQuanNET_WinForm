using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DA1_QLQuanNET
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CTHOADON> CTHOADONs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTHOADON>()
                .Property(e => e.MaCTHD)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOADON>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOADON>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaMay)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsUnicode(false);
        }
    }
}
