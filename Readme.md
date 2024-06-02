# Proje Varlıkları
* Models => Islem.cs, Lokasyon.cs, Rezervasyon.cs ve Ucak.cs adlı dosyaları içeren klasördür.
* Resources => Picturebox nesnelerinde kullanılan resim dosyalarını içeren klasördür.
* Veritabani.db => Lokasyon, Rezervasyon ve Ucak tablolarını içeren veritabanıdır.
* Islem.cs => DbContext sınıfını miras alan bir sınıftır. DbSet ve modelBuilder nesneleri için oluşturulan sınıftır.
* Lokasyon.cs => Lokasyon veritabanı modeli için oluşturulan sınıftır.
* Rezervasyon.cs => Rezervasyon veritabanı modeli için oluşturulan sınıftır.
* Ucak.cs => Ucak veritabanı modeli için oluşturulan sınıftır.

## Islem.cs
```
public virtual DbSet<Ucak> Ucaklar { get; set; }
public virtual DbSet<Lokasyon> Lokasyonlar { get; set; }
public virtual DbSet<Rezervasyon> Rezervasyonlar { get; set; }
```
* protected override void OnConfiguring(DbContextOptionsBuilder) => Veritabanı bağlantı ayarlarını yapılandırmak için kullanılan metotdur.
* protected override void OnModelCreating(ModelBuilder) => Veritabanı modelini oluşturmak için kullanılan metotdur.

## Lokasyon.cs
```
public int LoksayonId { get; set; }
public string Ulke { get; set; }
public string Sehir { get; set; }
public string Havaalani { get; set; }
public struct Ucus(string ulke, string sehir, string havaalani)
{
    public string Ulke { get; set; } = ulke;
    public string Sehir { get; set; } = sehir;
    public string Havaalani { get; set;} = havaalani;
}
public List<Ucus> ucuslar = new List<Ucus>
{
    ...
}
```

## Rezervasyon.cs
```
public int RezervasyonId { get; set; }
public int UcakId { get; set; }
public int LokasyonId { get; set; }
public DateTime UcusTarihi { get; set; }
public string Isim { get; set; }
public string Soyisim { get; set; }
public string Cinsiyet { get; set; }
public int Koltuk { get; set; }
```

## Ucak.cs
```
public int UcakId { get; set; }
public string Model { get; set; }
public string Marka { get; set; }
public string SeriNo { get; set; }
public int KoltukSayisi { get; set; }
```

## Modeller

Projede 3 tane model oluşturulmuştur.

1. Ucak
```
modelBuilder.Entity<Ucak>(entity =>
{
    entity.ToTable("Ucak");
    entity.HasKey(e => e.UcakId);
    entity.Property(e => e.Model).HasColumnType("TEXT");
    entity.Property(e => e.Marka).HasColumnType("TEXT");
    entity.Property(e => e.SeriNo).HasColumnType("TEXT");
    entity.Property(e => e.KoltukSayisi).HasColumnType("INTEGER");
});
```

2. Lokasyon
```
modelBuilder.Entity<Lokasyon>(entity =>
{
    entity.ToTable("Lokasyon");
    entity.HasKey(e => e.LoksayonId);
    entity.Property(e => e.Ulke).HasColumnType("TEXT");
    entity.Property(e => e.Sehir).HasColumnType("TEXT");
    entity.Property(e => e.Havaalani).HasColumnType("TEXT");
});
```

3. Rezervasyon
```
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
```

# Nasıl Çalışır
* Uygulama çalıştırıldığında Form1 ekranı gelmektedir. Uçak, lokasyon veya rezervasyon bilgilerini kayıt etmek için ilgili picturebox nesnesine tıklanır. Bilgiler ilgili alanlara girilerek kayıt edilir.

## Uçak Resmi
* Uçak kayıt ekranı açılmaktadır.
* Model, marka, seri no ve koltuk sayısı bilgileri girilir. Kaydet butonuna basılır ve veriler kayıt edilir. İlgili veriler datagridview nesnesinde görüntülenir.

## Konum Resmi
* Lokasyon kayıt ekranı açılmaktadır.
* Ülke seçilir. Ülkeye göre şehir seçilir. Şehire göre havaalanı seçilir. Kaydet butonuna basılır ve veriler kayıt edilir. İlgili veriler datagridview nesnesinde görüntülenir.
* Not => Lokasyon bilgileri Lokasyon sınıfında tanımlanmıştır. Aktif lokasyon oluşturmak için seçimler ve kayıtlar yapılmaktadır.
```
public List<Ucus> ucuslar = new List<Ucus>
{
    new Ucus("", "", ""),
    new Ucus("Azerbeycan", "Bakü", "Haydar Aliyev Uluslararası Havalimanı (GYD)"),
    ...
    new Ucus("Türkmenistan", "Türkmenbaşı", "Türkmenbaşı Uluslararası Havalimanı (KRW)")
};
```

## Ajanda Resmi
* Rezervasyon kayıt ekranı açılmaktadır.
* İsim, soyisim ve cinsiyet bilgileri girilir. Uçak, lokasyon ve tarih bilgisi seçilir. Kaydet butonuna basılır ve veriler kayıt edilir. İlgili veriler datagridview nesnesinde görüntülenir. Koltuk düzeni panel1 nesnesinde listelenir. 2 sol, 2 sağ olmak üzere her satırda 4 koltuk vardır.
* Not => Koltuk düzeni seçilen uçağın KoltukSayisi alanına göre yapılmaktadır.

# Önemli Notlar
* Not: Uygulamanın çalıştırıldığı dizinde 'Veritabani.db' veritabanı dosyasının, TunaTuranli ve Microsoft.EntityFrameworkCore.Sqlite NuGet paketinin dll dosyalarının olması gerekmektedir.