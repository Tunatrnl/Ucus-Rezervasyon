using TunaTuranli.Models;

namespace TunaTuranli
{
    public partial class Ucak : Form
    {
        Islem islem = new Islem();

        public Ucak()
        {
            InitializeComponent();
            dataGridView1.DataSource = islem.Ucaklar.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.Ucak ucak = new Models.Ucak
            {
                Model = textBox1.Text,
                Marka = textBox3.Text,
                SeriNo = textBox2.Text,
                KoltukSayisi = int.Parse(textBox4.Text)
            };

            islem.Ucaklar.Add(ucak);
            islem.SaveChanges();

            dataGridView1.DataSource = islem.Ucaklar.ToList();

            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
