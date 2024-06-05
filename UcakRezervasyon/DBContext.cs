using Microsoft.EntityFrameworkCore;
using UcakRezervasyon.Models;

namespace UcakRezervasyon
{
    public partial class DBContext : DbContext
    {
        private static string DBYolu = "rezervasyon.db";
        public static bool KontrolDB()
        {
            return File.Exists(DBYolu);
        }
        public virtual DbSet<Plane> Ucaklar { get; set; }
        public virtual DbSet<Location> Lokasyonlar { get; set; }
        public virtual DbSet<Reservation> Rezervasyonlar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DBYolu}");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plane>(entity =>
            {
                entity.ToTable("Ucak");
                entity.HasKey(e => e.IdUcak);
                entity.Property(e => e.UcakModel).HasColumnType("TEXT");
                entity.Property(e => e.UcakMarka).HasColumnType("TEXT");
                entity.Property(e => e.UcakSeriNo).HasColumnType("TEXT");
                entity.Property(e => e.UcakKoltukKapasitesi).HasColumnType("INTEGER");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Lokasyon");
                entity.HasKey(e => e.IdLokasyon);
                entity.Property(e => e.Ulke).HasColumnType("TEXT");
                entity.Property(e => e.Sehir).HasColumnType("TEXT");
                entity.Property(e => e.Havaalani).HasColumnType("TEXT");
                entity.Property(e => e.AktifPasif).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Rezervasyon");
                entity.HasKey(e => e.IdRezervasyon);
                entity.Property(e => e.UcakId).HasColumnType("INTEGER");
                entity.Property(e => e.LokasyonId).HasColumnType("INTEGER");
                entity.Property(e => e.Tarih).HasColumnType("TEXT");
                entity.Property(e => e.MusteriKimlikNo).HasColumnType("TEXT");
                entity.Property(e => e.MusteriAd).HasColumnType("TEXT");
                entity.Property(e => e.MusteriSoyad).HasColumnType("TEXT");
                entity.Property(e => e.MusteriCinsiyet).HasColumnType("TEXT");
                entity.Property(e => e.KoltukNo).HasColumnType("INTEGER");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
