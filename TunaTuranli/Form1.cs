namespace TunaTuranli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ucak form = new Ucak();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Lokasyon form = new Lokasyon();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Rezervasyon form = new Rezervasyon();
            form.Show();
        }
    }
}
