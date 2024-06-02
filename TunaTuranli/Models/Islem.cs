using Microsoft.EntityFrameworkCore;

namespace TunaTuranli.Models
{
    public partial class Islem : DbContext
    {
        public virtual DbSet<Ucak> Ucaklar { get; set; }
        public virtual DbSet<Lokasyon> Lokasyonlar { get; set; }
        public virtual DbSet<Rezervasyon> Rezervasyonlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=Veritabani.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ucak>(entity =>
            {
                entity.ToTable("Ucak");
                entity.HasKey(e => e.UcakId);
                entity.Property(e => e.Model).HasColumnType("TEXT");
                entity.Property(e => e.Marka).HasColumnType("TEXT");
                entity.Property(e => e.SeriNo).HasColumnType("TEXT");
                entity.Property(e => e.KoltukSayisi).HasColumnType("INTEGER");
            });

            modelBuilder.Entity<Lokasyon>(entity =>
            {
                entity.ToTable("Lokasyon");
                entity.HasKey(e => e.LoksayonId);
                entity.Property(e => e.Ulke).HasColumnType("TEXT");
                entity.Property(e => e.Sehir).HasColumnType("TEXT");
                entity.Property(e => e.Havaalani).HasColumnType("TEXT");
            });

            modelBuilder.Entity<Rezervasyon>(entity =>
            {
                entity.ToTable("Rezervasyon");
                entity.HasKey(e => e.RezervasyonId);
                entity.Property(e => e.UcakId).HasColumnType("INTEGER");
                entity.Property(e => e.LokasyonId).HasColumnType("INTEGER");
                entity.Property(e => e.UcusTarihi).HasColumnType("TEXT");
                entity.Property(e => e.Isim).HasColumnType("TEXT");
                entity.Property(e => e.Soyisim).HasColumnType("TEXT");
                entity.Property(e => e.Cinsiyet).HasColumnType("TEXT");
                entity.Property(e => e.Koltuk).HasColumnType("INTEGER");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
