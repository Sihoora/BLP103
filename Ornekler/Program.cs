internal class Program
{
    static void MukemmelSayi(int x)
    {
        int t = 0;
        for (int i = 1; i < x; i++)
        {
            if (x % i == 0)
            {
                t += i;
            }
        }
        // Console.WriteLine("Toplam: " + t);

        if (x == t) Console.WriteLine("Mükemmel Sayıdır..");
        else Console.WriteLine("Mükemmel Sayı Değildir ...");
    }

    static bool MukemmelSay(int x)
    {
        int t = 0;
        for (int i = 1; i < x; i++)
        {
            if (x % i == 0)
            {
                t += i;
            }
        }

        if (x == t)
            return true;
        else
            return false;
    }

    private static void Main(string[] args)
    {
        /* Random random = new Random();
         int[,] dizi = new int[20, 100];
         int satirToplam, sayi;

         for (int i = 0; i < 5; i++)
         {
             satirToplam = 0;
             for (int j = 0; j < 10; j++)
             {
                 sayi = random.Next(1, 100);
                 dizi[i, j] = sayi;
                 satirToplam += sayi;
                 Console.Write(dizi[i, j]+" ");
             }
             Console.Write("=> "+satirToplam) ;
             Console.WriteLine();
         }*/

        Random r = new Random();
        int olanSay = 0, olmayanSay = 0;
        int[] dizi = new int[100];
        // int sayi;
        // Console.Write("Sayı girin: ");
        //sayi = int.Parse(Console.ReadLine());

        //MukemmelSayi(sayi);

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = r.Next(1, 100);
            Console.WriteLine(dizi[i]);
            MukemmelSayi(dizi[i]);
            if (MukemmelSay(dizi[i]))
            {
                olanSay++;
            }
            else
            {
                olmayanSay++;
            }
        }

        Console.WriteLine("Toplam mükemmel sayı = " + olanSay);
        Console.WriteLine("Toplam mükemmel olmayan sayı = " + olmayanSay);

        /*
        int t = 0, sayi;

        do
        {
            Console.Write("Sayı girin: ");
            sayi = int.Parse(Console.ReadLine());
            t += sayi;
        } while (t<21);
        */

        /*
            Console.Write("Sayı girin: ");
            sayi = int.Parse(Console.ReadLine());
            t += sayi;
         while (t < 21)
        {
            Console.Write("Sayı girin: ");
            sayi = int.Parse(Console.ReadLine());
            t += sayi;

        }

        Console.WriteLine("Toplamlar: " + t);
        */

        /*
        int kat, daire, toplamKisi = 0;
        int a=0, b=0;
        Console.Write("Binanın kat sayısını giriniz: ");
        kat = int.Parse(Console.ReadLine());
        Console.Write("Her kattaki daire sayısını giriniz: ");
        daire = int.Parse(Console.ReadLine());
        int[,] bina = new int[kat, daire];

        for(int i=0; i<kat; i++) //2
        {
            for(int j=0; j<bina.GetLength(1); j++) //2
            {
                //Console.WriteLine($"bina[{i},{j}]");
                Console.Write($"bina[{i+1},{j+1}]. dairedeki kişi sayısı: ");
                bina[i, j] = int.Parse(Console.ReadLine());
                toplamKisi += bina[i, j];
            }
        }

        Console.WriteLine($"Binada toplam {toplamKisi} kişi vardır.");

        for(int i=0; i<kat; i++)
        {
            a += bina[i, 0];
            b += bina[i, 1];
        }
        double ort = (double)a / b;

        Console.WriteLine($"{a} {b} {ort}");
        */
        /*
         int boslukSayisi = 0;
         string metin = "This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.";

         for (int i = 0; i < metin.Length; i++)
         {
             if(metin[i] == ' ')
             {
                 boslukSayisi++;
             }
         }
         Console.WriteLine("Kelime sayisi = " + (boslukSayisi + 1));


        //string metin = "This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.This tutorial will teach you JavaScript from basic to advanced.";
        string[] parcalanmis = metin.Split('.');

        for(int i = 0; i < parcalanmis.Length; i++)
        {
            Console.WriteLine(parcalanmis[i]);
        }
        Console.Write(" " + parcalanmis.Length);
        */
    }
}