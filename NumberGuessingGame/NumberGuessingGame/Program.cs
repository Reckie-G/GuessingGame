class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int TutulanSayi = rnd.Next(0, 1000);
        int Sayi = 0, TahminHakki = 10;

        while (TahminHakki > 0)
        {
            Console.WriteLine("1-1000 arasında sayı giriniz:");
            Sayi = Convert.ToInt32(Console.ReadLine());
            TahminHakki--;

            if (TutulanSayi == Sayi)
            {
                Console.WriteLine("Sayıyı {0}. hakkında doğru tahmin ettiniz.", TahminHakki);
                break;
            }
            else
                if (TutulanSayi > Sayi)
            {
                Console.WriteLine("Tutulan sayı daha büyük");
            }
            else if (TutulanSayi < Sayi)
            {
                Console.WriteLine("Tutulan sayı daha küçük");
            }
            Console.WriteLine("Kalan tahmin hakkınız {0}", TahminHakki);
        }
        if (TahminHakki == 0)
        {
            Console.WriteLine("Sayıyı tahmin edemediniz. Tutulan sayı = {0}", TutulanSayi);
        }
        Console.ReadLine();
    }
}