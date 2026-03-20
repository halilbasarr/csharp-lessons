using System;

namespace SezarSifreleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Metin Şifreleme ve Çözme Aracı (Caesar Cipher) ===");

            Console.Write("Lütfen şifrelenecek metni girin: ");
            string metin = Console.ReadLine();

            Console.Write("Kaydırma miktarını girin (Örn: 3): ");

            
            if (int.TryParse(Console.ReadLine(), out int anahtar))
            {
               
                string sifreliMetin = Sifrele(metin, anahtar);
                Console.WriteLine($"\n[+] Şifrelenmiş Metin: {sifreliMetin}");

                string cozulenMetin = SifreCoz(sifreliMetin, anahtar);
                Console.WriteLine($"[+] Çözülen Metin: {cozulenMetin}");
            }
            else
            {
                Console.WriteLine("Hata: Lütfen geçerli bir tam sayı girin.");
            }

            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }

        static string Sifrele(string metin, int anahtar)
        {
            char[] karakterler = metin.ToCharArray();

            for (int i = 0; i < karakterler.Length; i++)
            {
                char c = karakterler[i];

                if (char.IsLetter(c))
                {
                    char baslangic = char.IsUpper(c) ? 'A' : 'a';

                    karakterler[i] = (char)((((c + anahtar) - baslangic) % 26) + baslangic);
                }
            }
            return new string(karakterler);
        }


        static string SifreCoz(string metin, int anahtar)
        {
            
            int tersAnahtar = 26 - (anahtar % 26);
            return Sifrele(metin, tersAnahtar);
        }
    }
}