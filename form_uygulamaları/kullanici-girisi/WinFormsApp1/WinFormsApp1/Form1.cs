namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        // Sabit deðerleri (Magic Strings) yukarýda tanýmlamak profesyonel bir yaklaþýmdýr.
        private const string GecerliKullanici = "Zonguldak";
        private const string GecerliSifre = "1453";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            // 1. Veri Alma: TextBox isimlerini anlamlý hale getirdiðini varsayýyorum (txtKullanici, txtSifre)
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            // 2. Doðrulama ve Karar Yapýsý
            if (kullaniciAdi == GecerliKullanici && sifre == GecerliSifre && radioButtonBay.Checked)
            {
                GirisBasarili(kullaniciAdi);
            }
            else
            {
                GirisBasarisiz();
            }

            // Ýþlem bittikten sonra formu nötr bir renge döndürür.
            this.BackColor = Color.DarkGray;
        }

        // Metotlara bölmek kodun okunabilirliðini artýrýr.
        private void GirisBasarili(string ad)
        {
            this.BackColor = Color.Green;
            MessageBox.Show($"Hoþ geldiniz Bay: {ad}", "Giriþ Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GirisBasarisiz()
        {
            this.BackColor = Color.Red;
            MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}