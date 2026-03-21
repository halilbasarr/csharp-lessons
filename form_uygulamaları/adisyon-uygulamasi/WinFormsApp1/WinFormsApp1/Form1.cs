namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAdiTxt.Text;
            string sifre = sifreTxt.Text;

            if (kullaniciAdi == "admin" && sifre == "12345")
            {
                MessageBox.Show("Giriþ baþarýlý!");

                Form2 adisyonEkrani = new Form2();

                adisyonEkrani.Show();

                   this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ!");
            }

        }

        private void sifreTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciAdiTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
