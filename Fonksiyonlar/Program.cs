internal class Program
{
    private static void Main(string[] args)
    {
        /*
        int boyut = 4;
        Random r = new Random();
        int[] dizi = new int[boyut];
        dizi[0] = r.Next(1, 100);
        dizi[1] = r.Next(1, 100);
        dizi[2] = r.Next(1, 100);
        dizi[3] = r.Next(1, 100);

        for(int i=0; i<boyut; i++)
        {
            Console.Write(dizi[i]+" ");
        }
        Console.WriteLine();
        foreach(int eleman in dizi)
        {
            Console.Write(eleman + " ");
        }
        Console.WriteLine();
        string metin = "Prog ram lama Temel leri";

        foreach (char eleman in metin)
        {
            Console.Write(eleman + " ");
        }
        Console.WriteLine();

        for(int i=0; i<metin.Length; i++)
        {
            if(metin[i] != ' ')
            {
                Console.Write(metin[i] + "");
            }
        }
        */

        /*
         Klavyeden girilen n adet ile bir dizi oluşturun.
         dizinin içerisine 1 ile 1000 arasında random değerler atayın.
         dizi içerisindeki eb ve ek sayiyi bulun.
         */
        /*
        Random r = new Random();
        Console.Write("Boyutu giriniz: ");
        int n = int.Parse(Console.ReadLine());
        int[] dizi = new int[n];
        int eb, ek;
        dizi[0] = r.Next(1, 1000);
        eb = ek = dizi[0];

        for (int i=1; i<n; i++)
        {
            dizi[i] = r.Next(1, 1000);

            if (dizi[i] > eb) eb = dizi[i];
            if(dizi[i] < ek) ek = dizi[i];
        }

        Console.WriteLine("En büyük eleman = " + eb);
        Console.WriteLine("En küçük eleman = " + ek);
        */

        /*
        Console.Write("Boyutu giriniz: ");
        int n = int.Parse(Console.ReadLine());
        int[] dizi = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i+1}. elemanı gir =");
            dizi[i] = int.Parse(Console.ReadLine());
        }
        */

        /*
        int[] a = { 1, 2, 3, 4, 5, 6, 5, 2, 3, 4, 5, 6, 5, 2, 3, 4, 5, 6, 5, 2, 3, 4, 5, 6, 5, 2, 3, 4, 5, 6, 5, 2, 3, 4, 5, 6, 5, 2, 3, 4, 5, 6, 5, 2, 3, 4, 5, 6, 5, 2, 3, 4, 5, 6, 5, 2, 3, 4, 5, 6, 5 };

        for(int i=0; i<a.Length; i++)
        {
            Console.Write(a[i]+" ");
        }
        */

        /*
        int[,] dizi = { { 5, 1, 10, 5 }, { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        int toplam = 0;
        for(int i = 0; i < 4; i++)
        {
            for(int j= 0; j < 4; j++)
            {
                //Console.WriteLine($"{i},{j}");
                Console.WriteLine($"{dizi[i,j]}");
                toplam += dizi[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("Dizi toplamı = " + toplam);
        */

        /*
        ekranaYaz();

        Console.Write("İsminizi giriniz :"); //
        Yaz(Console.ReadLine());

        Console.Write("Sayı gir :"); //
        int sayi = int.Parse(Console.ReadLine());

        faktoriyel(sayi);

        Console.WriteLine("Geriye dönen faktoriyel sonucu = " + fakt(sayi));
        // a! / b!

        int n, r;

        n = 5;
        r = 3;

        int sonuc = fakt(n)/fakt(r)*fakt(n-r);
    }
    */
        /*
        static void ekranaYaz()
        {
            Console.WriteLine("Merhaba c# !");
        }

        static void Yaz(string isim)
        {
            Console.WriteLine("Merhaba "+isim);
        }

        static void faktoriyel(int x)
        {
            int f = 1;
            for (int i = 1; i <= x; i++)
            {
                f *= i;
            }
            Console.WriteLine("Faktoriyel = " + f);
        }

        static int fakt(int x)
        {
            int f = 1;
            for (int i = 1; i <= x; i++)
            {
                f *= i;
            }
            return f;
        }*/

        /*Console.WriteLine(isim("1", 1));

        static int isim(string x, int y)
        {
            return int.Parse(x)+y;
        }*/

        // int[] dizi = new int[4];
        //dizi.Length;


        //int[,] dizi = new int[4, 4];
        int[,] dizi = { 
            {1,2,3,4 }, 
            {5,6,7,8}, 
            {9,10,11,12}, 
            {13,14,15,16} 
        };

        //Console.WriteLine(dizi.GetLength(1));
        int j = 3, t=0;

        for(int i=0; i<dizi.GetLength(0); i++)
        {
            Console.WriteLine(dizi[i,j]);
            j--;
            //Console.WriteLine($"[{i},0]");
        }
        Console.WriteLine("--------");

        for (int i = 0; i < dizi.GetLength(0); i++)
        {
            for(j=0; j<dizi.GetLength(1); j++)
            {
                t += dizi[i, j];
                Console.WriteLine(dizi[i, j]);
            }
        }
        int ort = t / dizi.Length;

        for (int i = 0; i < dizi.GetLength(0); i++)
        {
            for (j = 0; j < dizi.GetLength(1); j++)
            {
                if (dizi[i,j]>ort)
                    Console.WriteLine(dizi[i, j]);
            }
        }

    }
       
}