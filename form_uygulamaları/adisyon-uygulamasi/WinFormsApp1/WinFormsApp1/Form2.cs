using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        bool[] masalar = new bool[5];
        int suAnkiMasa = 0;

        List<Siparis>[] masaSiparisleri = new List<Siparis>[5];
        public Form2()
        {
            InitializeComponent();

            for (int i = 1; i < 5; i++)
            {
                masaSiparisleri[i] = new List<Siparis>();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void masa1btn_Click(object sender, EventArgs e)
        {
            suAnkiMasa = 1;
            masalar[1] = true;
            TabloyuYenile();


        }

        private void suBtn_Click(object sender, EventArgs e)
        {
            if (suAnkiMasa != 0 && masalar[suAnkiMasa] == true)
            {
                masaSiparisleri[suAnkiMasa].Add(new Siparis { UrunAdi = "Su", Fiyat = 10 });

                TabloyuYenile();
            }
            else if (suAnkiMasa == 0)
            {
                MessageBox.Show("Lütfen bir masa seçiniz");
            }
        }

        private void cayBtn_Click(object sender, EventArgs e)
        {
            if (suAnkiMasa != 0 && masalar[suAnkiMasa] == true)
            {
                masaSiparisleri[suAnkiMasa].Add(new Siparis { UrunAdi = "Çay", Fiyat = 15 });

                TabloyuYenile();
            }
            else if (suAnkiMasa == 0)
            {
                MessageBox.Show("Lütfen bir masa seçiniz");
            }
        }

        private void kahveBtn_Click(object sender, EventArgs e)
        {
            if (suAnkiMasa != 0 && masalar[suAnkiMasa] == true)
            {
                masaSiparisleri[suAnkiMasa].Add(new Siparis { UrunAdi = "Kahve", Fiyat = 15 });

                TabloyuYenile();
            }
            else if (suAnkiMasa == 0)
            {
                MessageBox.Show("Lütfen bir masa seçiniz");
            }
        }

        private void kolaBtn_Click(object sender, EventArgs e)
        {
            if (suAnkiMasa != 0 && masalar[suAnkiMasa] == true)
            {
                masaSiparisleri[suAnkiMasa].Add(new Siparis { UrunAdi = "Kola", Fiyat = 15 });

                TabloyuYenile();
            }
            else if (suAnkiMasa == 0)
            {
                MessageBox.Show("Lütfen bir masa seçiniz");
            }
        }
        private void ayranBtn_Click(object sender, EventArgs e)
        {
            if (suAnkiMasa != 0 && masalar[suAnkiMasa] == true)
            {
                masaSiparisleri[suAnkiMasa].Add(new Siparis { UrunAdi = "Ayran", Fiyat = 15 });

                TabloyuYenile();
            }
            else if (suAnkiMasa == 0)
            {
                MessageBox.Show("Lütfen bir masa seçiniz");
            }
        }

        private void limonataBtn_Click(object sender, EventArgs e)
        {
            if (suAnkiMasa != 0 && masalar[suAnkiMasa] == true)
            {
                masaSiparisleri[suAnkiMasa].Add(new Siparis { UrunAdi = "Limonata", Fiyat = 20 });

                TabloyuYenile();
            }
            else if (suAnkiMasa == 0)
            {
                MessageBox.Show("Lütfen bir masa seçiniz");
            }
        }

        private void ihlamurBtn_Click(object sender, EventArgs e)
        {
            if (suAnkiMasa != 0 && masalar[suAnkiMasa] == true)
            {
                masaSiparisleri[suAnkiMasa].Add(new Siparis { UrunAdi = "Ihlamur", Fiyat = 15 });

                TabloyuYenile();
            }
            else if (suAnkiMasa == 0)
            {
                MessageBox.Show("Lütfen bir masa seçiniz");
            }
        }

        private void salepBtn_Click(object sender, EventArgs e)
        {
            if (suAnkiMasa != 0 && masalar[suAnkiMasa] == true)
            {
                masaSiparisleri[suAnkiMasa].Add(new Siparis { UrunAdi = "Salep", Fiyat = 20 });

                TabloyuYenile();
            }
            else if (suAnkiMasa == 0)
            {
                MessageBox.Show("Lütfen bir masa seçiniz");
            }
        }

        public class Siparis
        {
            public string UrunAdi { get; set; }
            public int Fiyat { get; set; }
        }

        private void TabloyuYenile()
        {
            dataGridView1.Rows.Clear();

            if (suAnkiMasa != 0 && masaSiparisleri[suAnkiMasa] != null)
            {
                foreach (var siparis in masaSiparisleri[suAnkiMasa])
                {
                    dataGridView1.Rows.Add(siparis.UrunAdi, siparis.Fiyat);
                }
            }
        }

        private void secileniSilBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int seciliIndex = dataGridView1.SelectedRows[0].Index;

                masaSiparisleri[suAnkiMasa].RemoveAt(seciliIndex);

                TabloyuYenile();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırın en soluna tıklayarak seçiniz.");
            }
        }

        private void hesapKesBTN_Click(object sender, EventArgs e)
        {
            if (suAnkiMasa == 0 || masalar[suAnkiMasa] == false) return;

            int toplam = 0;
            foreach (var siparis in masaSiparisleri[suAnkiMasa])
            {
                toplam += siparis.Fiyat;
            }

            MessageBox.Show($"Masa {suAnkiMasa} Toplam Hesap: {toplam} TL");

            masaSiparisleri[suAnkiMasa].Clear();
            masalar[suAnkiMasa] = false;

            TabloyuYenile();
        }

        private void masa2btn_Click(object sender, EventArgs e)
        {
            suAnkiMasa = 2;
            masalar[2] = true;
            TabloyuYenile();
        }

        private void masa3btn_Click(object sender, EventArgs e)
        {
            suAnkiMasa = 3;
            masalar[3] = true;
            TabloyuYenile();
        }

        private void masa4btn_Click(object sender, EventArgs e)
        {
            suAnkiMasa = 4;
            masalar[4] = true;
            TabloyuYenile();
        }
    }
}
