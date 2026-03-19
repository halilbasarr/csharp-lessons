using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci_bilgileri ogrenci1 = new ogrenci_bilgileri(12345, "Ahmet", "Yılmaz", 80, 85, 90, "Ankara Üniversitesi");
            ogrenci_bilgileri ogrenci2 = new ogrenci_bilgileri(54321, "Ayşe", "Demir", 75, 80, 85, "İstanbul Üniversitesi");
            ogrenci_bilgileri ogrenci3 = new ogrenci_bilgileri(67890, "Mehmet", "Kara", 70, 75, 80, "Ege Üniversitesi");
            ogrenci_bilgileri ogrenci4 = new ogrenci_bilgileri(98765, "Elif", "Çelik", 85, 90, 95, "Boğaziçi Üniversitesi");

            Console.WriteLine("....Hoşgeldiniz, aşağıdaki seçeneklerden birini seçiniz....\n");
            Console.WriteLine("1-Öğrenci Bilgilerini Göster");
            Console.WriteLine("2-Öğrenci Ortalamasını Göster");
            Console.WriteLine("3-Öğrenci Okulunu Göster");
            Console.WriteLine("4-Çıkış");



            while (true)
            {
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenci_bilgilerini_goster();
                        break;

                    case "2":
                        ogrenci1.ogrenci_not_hesapla();
                        break;
                    
                    case "3":
                        ogrenci1.okul_bilgilerini_goster();
                        break;

                    case "4":
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;

                }
            }

            


        }
    }
}
