string[] secenekler = { "Taş", "Kağıt", "Makas" };
string[] emojiler = { "✊", "✋", "✌️" };
Random rastgele = new();
int kazanma = 0, kaybetme = 0, beraberlik = 0;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("✊✋✌️  Taş Kağıt Makas Oyununa Hoş Geldiniz!\n");

while (true)
{
    Console.WriteLine("Seçimini yap:");
    Console.WriteLine("  1 - Taş ✊");
    Console.WriteLine("  2 - Kağıt ✋");
    Console.WriteLine("  3 - Makas ✌️");
    Console.WriteLine("  0 - Çıkış");
    Console.Write("\n> ");

    string? girdi = Console.ReadLine();

    if (girdi == "0")
        break;

    if (!int.TryParse(girdi, out int secim) || secim < 1 || secim > 3)
    {
        Console.WriteLine("Geçersiz seçim!\n");
        continue;
    }

    int bilgisayar = rastgele.Next(0, 3);
    int oyuncu = secim - 1;

    Console.WriteLine($"\nSen: {emojiler[oyuncu]} {secenekler[oyuncu]}");
    Console.WriteLine($"PC:  {emojiler[bilgisayar]} {secenekler[bilgisayar]}");

    if (oyuncu == bilgisayar)
    {
        Console.WriteLine("Berabere!\n");
        beraberlik++;
    }
    else if ((oyuncu == 0 && bilgisayar == 2) ||
             (oyuncu == 1 && bilgisayar == 0) ||
             (oyuncu == 2 && bilgisayar == 1))
    {
        Console.WriteLine("Kazandın!\n");
        kazanma++;
    }
    else
    {
        Console.WriteLine("Kaybettin!\n");
        kaybetme++;
    }

    Console.WriteLine($"Skor → Kazanma: {kazanma} | Kaybetme: {kaybetme} | Berabere: {beraberlik}");
    Console.WriteLine(new string('-', 40) + "\n");
}

Console.WriteLine($"\nFinal Skor: {kazanma}W - {kaybetme}L - {beraberlik}D");
Console.WriteLine("Güle güle!");
