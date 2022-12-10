internal class Program
{
    private static void Main(string[] args)
    {
        //int a;
        //int b;
        //const int a=2, b=5;

        /*
        int a = 2, b = 5, toplama = 0;

        toplama = a + b;

        Console.WriteLine(a+"+"+b+"="+toplama*2);
        Console.WriteLine("{0}+{1}={2}", a, b, toplama * 2);
        //Console.WriteLine("{3} ! {2} {0}", a, b, toplama, "Merhaba ");
        //Console.WriteLine("{3} ! {2} {0}",0,1,2,3");
        Console.WriteLine($"{a} + {b} = {toplama*2}");
        */

        //int -> tam sayı; double -> ondalıklı bool -> true / false

        // tip dönüşümleri
        //double sayi = 5.0/2.0;
        //Console.WriteLine(sayi);

        /*double x=2, y=4;
        Console.WriteLine($"{x}^{y}={Math.Pow(x,y)}");

        Console.WriteLine($"{x} karekök = {Math.Sqrt(x)}");

        Console.WriteLine($"{x} karekök = {Math.Pow(x, 1/2f)}");
        Console.WriteLine($"{x} karekök = {Math.Pow(x, (double)1/y)}");
        */

        /*
        int a;
        string b;
        b = "3";
        a = int.Parse(b);
        Console.WriteLine(a*2);
        */

        // klavyeden girilen ismi "Merhaba isim !" olarak ekrana yazın.

        /*
        string ad;
        Console.Write("İsminizi giriniz : ");
        ad = Console.ReadLine();

        Console.WriteLine($"Merhaba ! {ad}");
        */

        /*  int taban, kuvvet;
          double us;

          Console.Write("Taban sayıyı gir: ");
          taban = int.Parse(Console.ReadLine());

          Console.Write("Kuvvet sayıyı gir: ");
          kuvvet = int.Parse(Console.ReadLine());

          us = Math.Pow(taban, kuvvet);
          Console.WriteLine($"{taban}^{kuvvet}={us}");
        */

        string ad;   // "ad" isimli bir değişken tanımladık.
        Console.WriteLine("Lütfen Adınızı Giriniz");  //Kullanıcıdan adını sorduk
        ad = Console.Read().ToString(); // Girilen Adı Console.Read ile hafızaya aldık
        Console.WriteLine(ad); // Ekrana girilen adın ilk karakterinin ASCII karşılığını yazdırdık

        Console.ReadKey(); // Konsol Ekranının Hemen Kapanmaması için yazdık.
    }
}