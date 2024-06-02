using TunaTuranli.Models;

namespace TunaTuranli
{
    public partial class Rezervasyon : Form
    {
        Islem islem = new Islem();
        int koltuk = 0;
        int koltukSayisi = 0;

        public Rezervasyon()
        {
            InitializeComponent();
            dataGridView1.DataSource = islem.Rezervasyonlar.Select(nesne => new { nesne.Isim, nesne.Soyisim, nesne.Cinsiyet, nesne.Koltuk }).ToList();

            var ucaklar = new List<Models.Ucak> { new Models.Ucak { UcakId = -1, SeriNo = string.Empty } };
            ucaklar.AddRange(islem.Ucaklar.ToList());
            comboBox1.DataSource = ucaklar;
            comboBox1.DisplayMember = "SeriNo";
            comboBox1.ValueMember = "UcakId";
            comboBox1.SelectedIndex = 0;

            var lokasyonlar = new List<Models.Lokasyon> { new Models.Lokasyon { LoksayonId = -1, Havaalani = string.Empty } };
            lokasyonlar.AddRange(islem.Lokasyonlar.ToList());
            comboBox2.DataSource = lokasyonlar;
            comboBox2.DisplayMember = "Havaalani";
            comboBox2.ValueMember = "LoksayonId";
            comboBox2.SelectedIndex = 0;

            koltukDiz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cinsiyet = string.Empty;

            if (radioButton1.Checked)
                cinsiyet = "Kadın";
            if (radioButton2.Checked)
                cinsiyet = "Erkek";

            Models.Rezervasyon rezervasyon = new Models.Rezervasyon
            {
                UcakId = (int) comboBox1.SelectedValue,
                LokasyonId = (int) comboBox2.SelectedValue,
                UcusTarihi = dateTimePicker1.Value,
                Isim = textBox1.Text,
                Soyisim = textBox2.Text,
                Cinsiyet = cinsiyet,
                Koltuk = koltuk
            };

            islem.Rezervasyonlar.Add(rezervasyon);
            islem.SaveChanges();

            dataGridView1.DataSource = islem.Rezervasyonlar.Select(nesne => new { nesne.Isim, nesne.Soyisim, nesne.Cinsiyet, nesne.Koltuk }).ToList();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            koltuk = 0;

            koltukDiz();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                int UcakId = (int) comboBox1.SelectedValue;
                var Ucak = islem.Ucaklar.FirstOrDefault(nesne => nesne.UcakId == UcakId);

                if (Ucak != null)
                {
                    koltukSayisi = Ucak.KoltukSayisi;
                    koltukDiz();
                }
            }
        }

        private void koltukDiz()
        {
            panel1.Controls.Clear();

            List<int> koltuklar = islem.Rezervasyonlar.Select(nesne => nesne.Koltuk).ToList();

            int x = 30;
            int y = 30;
            int buttonWidth = 75;
            int buttonHeight = 23;
            int tabIndex = 1;

            for (int row = 0; row < Math.Ceiling(koltukSayisi / 4.0); row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (tabIndex > koltukSayisi)
                        break;

                    Button button = new Button();
                    button.Text = $"{tabIndex}";
                    button.Location = new Point(x, y);
                    button.Size = new Size(buttonWidth, buttonHeight);
                    button.TabIndex = tabIndex;
                    if (koltuklar.Contains(tabIndex))
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                    else
                        button.BackColor = Color.Green;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Click += button_Click;
                    panel1.Controls.Add(button);

                    x += buttonWidth + 1;
                    tabIndex++;

                    if (col == 1)
                    {
                        x += (buttonWidth * 70 / 100) + 1;
                    }
                }

                x = 30;
                y += buttonHeight + 1;
            }

            Label label = new Label();
            label.Location = new Point(x, y);
            label.Size = new Size(buttonWidth, buttonHeight + (int) (buttonHeight * 0.5));
            panel1.Controls.Add(label);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int koltuk = int.Parse(button.Text);
                this.koltuk = koltuk;
            }
        }
    }
}
