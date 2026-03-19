using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ogrenci_bilgileri
    {
        private int ogrenci_no;
        private string ogrenci_ad;
        private string ogrenci_soyad;
        private int vize1;
        private int vize2;
        private int final;
        private string okul_ismi;

        public ogrenci_bilgileri(int ogrenci_no, string ogrenci_ad, string ogrenci_soyad, int vize1, int vize2, int final, string okul_ismi)
        {
            this.ogrenci_no = ogrenci_no;
            this.ogrenci_ad = ogrenci_ad;
            this.ogrenci_soyad = ogrenci_soyad;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.okul_ismi = okul_ismi;
        }

        public void ogrenci_bilgilerini_goster()
        {
            Console.WriteLine("Öğrenci No: " + ogrenci_no);
            Console.WriteLine("Ad: " + ogrenci_ad);
            Console.WriteLine("Soyad: " + ogrenci_soyad);
            Console.WriteLine("Vize 1: " + vize1);
            Console.WriteLine("Vize 2: " + vize2);
            Console.WriteLine("Final: " + final);
            Console.WriteLine("Okul İsmi: " + okul_ismi);
        }

        public double ogrenci_not_hesapla()
        {
            double ortalama = (vize1 * 0.2) + (vize2 * 0.2) + (final * 0.6);
            Console.WriteLine("Ortalama Not: " + ortalama);
            return ortalama;
        }

        public void okul_bilgilerini_goster()
        {
            Console.WriteLine("Okul İsmi: " + okul_ismi);
        }



    }
}
