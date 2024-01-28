using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 ile 1000 arasında bir sayı seçin ve ben tahmin etmeye çalışacağım.");
        Console.Write("Tutulan sayıyı girin: ");

        if (int.TryParse(Console.ReadLine(), out int tutulanSayi) && tutulanSayi >= 1 && tutulanSayi <= 1000)
        {
            int[] kuvvetler = { 512,256,128,64, 32, 16, 8, 4, 2, 1 };
            int tahmin = 0;
            int denemeSayisi = 0;
            string cevap;

            Console.WriteLine("Tahminlerimi kontrol edin tuttuğunuz sayı daha yüksekse 'y', düşükse 'd', doğruysa 'e' tuşlayın.");

            do
            {
                tahmin += kuvvetler[denemeSayisi];

                Console.WriteLine($"Tahminim: {tahmin}");
                Console.Write("Cevap (d/y/e): ");
                cevap = Console.ReadLine().ToLower();

                if (cevap == "d")
                {
                    tahmin -= kuvvetler[denemeSayisi];
                }
                else if (cevap == "y")
                {
                    tutulanSayi -= kuvvetler[denemeSayisi];
                }

                denemeSayisi++;

            } while (cevap != "e" && denemeSayisi < 10);

            if (cevap == "e")
            {
                Console.WriteLine($"{denemeSayisi}. denemede doğru tahmin ettim.");
            }
            else
            {
                Console.WriteLine($"Üzgünüm. 10 denemede doğru tahmin edemedim. Tutulan sayı: {tutulanSayi}");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girmediniz veya 1 ile 1000 arasında bir sayı girmediniz.");
        }
    }
}
