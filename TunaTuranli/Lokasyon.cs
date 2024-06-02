using TunaTuranli.Models;

namespace TunaTuranli
{
    public partial class Lokasyon : Form
    {
        Islem islem = new Islem();
        Models.Lokasyon lokasyon = new Models.Lokasyon();

        public Lokasyon()
        {
            InitializeComponent();
            dataGridView1.DataSource = islem.Lokasyonlar.ToList();

            var ulkeler = lokasyon.ucuslar.Select(nesne => nesne.Ulke).Distinct().ToList();
            comboBox1.DataSource = ulkeler;
            comboBox1.SelectedIndex = -1;
            comboBox2.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.Lokasyon lokasyon = new Models.Lokasyon
            {
                Ulke = comboBox1.SelectedItem.ToString(),
                Sehir = comboBox2.SelectedItem.ToString(),
                Havaalani = comboBox3.SelectedItem.ToString()
            };

            islem.Lokasyonlar.Add(lokasyon);
            islem.SaveChanges();

            dataGridView1.DataSource = islem.Lokasyonlar.ToList();

            comboBox1.SelectedItem = "";
            comboBox2.SelectedItem = "";
            comboBox3.SelectedItem = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                var sehirler = lokasyon.ucuslar.Where(nesne => nesne.Ulke == comboBox1.SelectedItem.ToString()).Select(nesne => nesne.Sehir).Distinct().ToList();
                comboBox2.DataSource = sehirler;
                comboBox2.SelectedIndex = -1;
                comboBox3.DataSource = null;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                var havaalanlari = lokasyon.ucuslar.Where(nesne => nesne.Ulke == comboBox1.SelectedItem.ToString() && nesne.Sehir == comboBox2.SelectedItem.ToString()).Select(nesne => nesne.Havaalani).Distinct().ToList();
                comboBox3.DataSource = havaalanlari;
                comboBox3.SelectedIndex = -1;
            }
        }
    }
}
