namespace PTWEB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAI_SP> LOAI_SP { get; set; }
        public virtual DbSet<SAN_PHAM> SAN_PHAM { get; set; }
        public virtual DbSet<SP_HD> SP_HD { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.SP_HD)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.sdt)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.quyen)
                .IsFixedLength();

            modelBuilder.Entity<SAN_PHAM>()
                .Property(e => e.mota)
                .IsFixedLength();

            modelBuilder.Entity<SAN_PHAM>()
                .HasMany(e => e.SP_HD)
                .WithRequired(e => e.SAN_PHAM)
                .WillCascadeOnDelete(false);
        }
    }
}
