using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLy
{
    public partial class QLPhongGymDBContext : DbContext
    {
        public QLPhongGymDBContext()
            : base("name=QLPhongGymDBContext")
        {
        }

        public virtual DbSet<HoiVien> HoiViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }
        public virtual DbSet<ThietBi> ThietBis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoiVien>()
                .Property(e => e.id_hv)
                .IsUnicode(false);

            modelBuilder.Entity<HoiVien>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.id_sp)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.dongia)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.trongluong)
                .IsUnicode(false);

            modelBuilder.Entity<ThietBi>()
                .Property(e => e.id_tb)
                .IsUnicode(false);
        }
    }
}
