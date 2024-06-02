namespace TunaTuranli.Models
{
    public partial class Lokasyon
    {
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
            new Ucus("", "", ""),
            new Ucus("Azerbeycan", "Bakü", "Haydar Aliyev Uluslararası Havalimanı (GYD)"),
            new Ucus("Azerbeycan", "Gence", "Gence Havalimanı (GNJ)"),
            new Ucus("Azerbeycan", "Nahçıvan", "Nahçıvan Havalimanı (NAJ)"),
            new Ucus("Kazakistan", "Aktav", "Aktav Havalimanı (SCO)"),
            new Ucus("Kazakistan", "Almatı", "Almatı Havalimanı (ALA)"),
            new Ucus("Kazakistan", "Astana", "Nursultan Nazarbayev Uluslararası Havalimanı (NQZ)"),
            new Ucus("Kazakistan", "Türkistan", "Hazret Sultan Uluslararası Havalimanı (HSA)"),
            new Ucus("Kırgızistan", "Bişkek", "Manas Uluslararası Havalimanı (FRU)"),
            new Ucus("Kuzey Kıbrıs Türk Cumhuriyeti", "Lefkoşa", "Ercan Uluslararası Havalimanı (ECN)"),
            new Ucus("Özbekistan", "Buhara", "Buhara Havalimanı (BHK)"),
            new Ucus("Özbekistan", "Fergana", "Fergana Havalimanı (FEG)"),
            new Ucus("Özbekistan", "Navoi", "Navoi International Airport (NVI)"),
            new Ucus("Özbekistan", "Semerkant", "Semerkant Uluslararası Havalimanı (SKD)"),
            new Ucus("Özbekistan", "Taşkent", "Taşkent Uluslararası Havalimanı (TAS)"),
            new Ucus("Özbekistan", "Termez", "Termez Havalimanı (TMJ)"),
            new Ucus("Özbekistan", "Ürgenç", "Ürgenç Havalimanı (UGC)"),
            new Ucus("Türkiye", "Adana", "Adana Havalimanı (ADA)"),
            new Ucus("Türkiye", "Adana", "Çukurova Havalimanı (COV)"),
            new Ucus("Türkiye", "Adıyaman", "Adıyaman Havalimanı (ADF)"),
            new Ucus("Türkiye", "Ağrı", "Ağrı Havalimanı (AJI)"),
            new Ucus("Türkiye", "Alanya", "Gazipaşa Alanya Havalimanı (GZP)"),
            new Ucus("Türkiye", "Amasya", "Amasya Merzifon Havalimanı (MZH)"),
            new Ucus("Türkiye", "Ankara", "Ankara Esenboğa Havalimanı (ESB)"),
            new Ucus("Türkiye", "Antalya", "Antalya Havalimanı (AYT)"),
            new Ucus("Türkiye", "Balıkesir - Edremit", "Koca Seyit Havalimanı (EDO)"),
            new Ucus("Türkiye", "Batman", "Batman Havalimanı (BAL)"),
            new Ucus("Türkiye", "Bingöl", "Bingöl Havalimanı (BGG)"),
            new Ucus("Türkiye", "Bursa", "Bursa Yenişehir Havalimanı (YEI)"),
            new Ucus("Türkiye", "Çanakkale", "Çanakkale Havalimanı (CKZ)"),
            new Ucus("Türkiye", "Denizli", "Denizli Çardak Havalimanı (DNZ)"),
            new Ucus("Türkiye", "Diyarbakır", "Diyarbakır Havalimanı (DIY)"),
            new Ucus("Türkiye", "Elazığ", "Elazığ Havalimanı (EZS)"),
            new Ucus("Türkiye", "Erzincan", "Erzincan Yıldırım Akbulut Havalimanı (ERC)"),
            new Ucus("Türkiye", "Erzurum", "Erzurum Havalimanı (ERZ)"),
            new Ucus("Türkiye", "Eskişehir", "Hasan Polatkan Havalimanı (AOE)"),
            new Ucus("Türkiye", "Gaziantep", "Gaziantep Havalimanı (GZT)"),
            new Ucus("Türkiye", "Hakkari", "Yüksekova Havalimanı (YKO)"),
            new Ucus("Türkiye", "Hatay", "Hatay Havalimanı (HTY)"),
            new Ucus("Türkiye", "Iğdır", "Iğdır Şehit Bülent Aydın Havalimanı (IGD)"),
            new Ucus("Türkiye", "Isparta", "Isparta Süleyman Demirel Havalimanı (ISE)"),
            new Ucus("Türkiye", "İstanbul", "İstanbul Havalimanı (IST)"),
            new Ucus("Türkiye", "İstanbul", "Sabiha Gökçen Havalimanı (SAW)"),
            new Ucus("Türkiye", "İzmir", "İzmir Adnan Menderes Havalimanı (ADB)"),
            new Ucus("Türkiye", "Kahramanmaraş", "Kahramanmaraş Havalimanı (KCM)"),
            new Ucus("Türkiye", "Kars", "Kars Harakani Havalimanı (KSY)"),
            new Ucus("Türkiye", "Kastamonu", "Kastamonu Havalimanı (KFS)"),
            new Ucus("Türkiye", "Kayseri", "Kayseri Havalimanı (ASR)"),
            new Ucus("Türkiye", "Kocaeli", "Kocaeli Cengiz Topel Havalimanı (KCO)"),
            new Ucus("Türkiye", "Konya", "Konya Havalimanı (KYA)"),
            new Ucus("Türkiye", "Kütahya", "Zafer Bölgesel Havalimanı (KZR)"),
            new Ucus("Türkiye", "Malatya", "Malatya Havalimanı (MLX)"),
            new Ucus("Türkiye", "Mardin", "Mardin Prof. Dr. Aziz Sancar Havalimanı (MQM)"),
            new Ucus("Türkiye", "Muğla-Bodrum", "Milas-Bodrum Havalimanı (BJV)"),
            new Ucus("Türkiye", "Muğla-Dalaman", "Dalaman Havalimanı (DLM)"),
            new Ucus("Türkiye", "Muş", "Muş Havalimanı (MSR)"),
            new Ucus("Türkiye", "Nevşehir", "Nevşehir Kapadokya Havalimanı (NAV)"),
            new Ucus("Türkiye", "Ordu-Giresun", "Ordu-Giresun Havalimanı (OGU)"),
            new Ucus("Türkiye", "Rize", "Rize Artvin Havalimanı (RZV)"),
            new Ucus("Türkiye", "Samsun", "Samsun Çarşamba Havalimanı (SZF)"),
            new Ucus("Türkiye", "Siirt", "Siirt Havalimanı (SXZ)"),
            new Ucus("Türkiye", "Sinop", "Sinop Havalimanı (NOP)"),
            new Ucus("Türkiye", "Sivas", "Sivas Nuri Demirağ Havalimanı (VAS)"),
            new Ucus("Türkiye", "Şanlıurfa", "Şanlıurfa GAP Havalimanı (GNY)"),
            new Ucus("Türkiye", "Şırnak", "Şırnak Şerafettin Elçi Havalimanı (NKT)"),
            new Ucus("Türkiye", "Tokat", "Tokat Havalimanı (TJK)"),
            new Ucus("Türkiye", "Trabzon", "Trabzon Havalimanı (TZX)"),
            new Ucus("Türkiye", "Uşak", "Uşak Havalimanı (USQ)"),
            new Ucus("Türkiye", "Van", "Van Ferit Melen Havalimanı (VAN)"),
            new Ucus("Türkiye", "Zonguldak", "Zonguldak Havalimanı (ONQ)"),
            new Ucus("Türkmenistan", "Aşkabat", "Aşkabat Uluslararası Havalimanı (ASB)"),
            new Ucus("Türkmenistan", "Türkmenabat", "Türkmenabat Uluslararası Havalimanı (CRZ)"),
            new Ucus("Türkmenistan", "Türkmenbaşı", "Türkmenbaşı Uluslararası Havalimanı (KRW)")
        };
    }
}
