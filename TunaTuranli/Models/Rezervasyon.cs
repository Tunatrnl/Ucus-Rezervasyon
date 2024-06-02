namespace TunaTuranli.Models
{
    public partial class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public int UcakId { get; set; }
        public int LokasyonId { get; set; }
        public DateTime UcusTarihi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Cinsiyet { get; set; }
        public int Koltuk { get; set; }
    }
}
