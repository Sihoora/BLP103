using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("****");
        Console.WriteLine("****");
        Console.WriteLine("****");
        Console.WriteLine("****");
        */
        /*
        for(int i = 1; i <=4; i++)
        {
            Console.Write("*");
        }

        Console.WriteLine();

        for (int i = 1; i <= 4; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        for (int i = 1; i <= 4; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int i = 1; i <= 4; i++)
        {
            Console.Write("*");
        }*/

        /*
        for(int i=1; i<=10; i++)
        {
            Console.Write($"{i}\t");
            for (int j=1; j<=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = 10; i >=1; i--)
        {
            Console.Write($"{i}\t");
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        */

        // FOR DÖNGÜSÜ
        /*int i, n;
        Console.Write("N adeti giriniz : ");
        n = int.Parse(Console.ReadLine());  
        
        for (i = 1; i <= n; i+=1)
        {
            //Console.WriteLine(i+". Merhaba !");
            //Console.WriteLine("{0}. Merhaba !",i);
           //Console.WriteLine($"{i}. Merhaba !");

            if(i % 3 == 0)
            {
                Console.WriteLine(i+ " sayısı 3 'e tam bölünür bu nedenle karesini alıyoruz.");
                Console.WriteLine("Karesi : "+ (i*i));
            }

        }*/


        /*
        int toplam=0;
        for(int s = 1; s<=100; s = s + 1)
        {
            Console.WriteLine("Komut =>"+s);
            if (s % 2 != 0) toplam += s;
        }
        Console.WriteLine("Döngü bitti. Toplam: "+toplam);
        */


        // For kullanımı -> break ve continue kavramlarını deneyiniz ...
        /*
        for (i = 1; i <= n; i++)
        {
            if (i == 10) continue;
            Console.Write(i + " ");
            //if (i == 100) break;
        }*/

        /*
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            if (i == 11) break;
            Console.WriteLine(i);
        }*/


        //LMS'de bulunan çalışma sorularından çözüm
        /*for (int i = 10; i <= 200; i++)
        {
            if ((i * 3 + 2) % 5 == 0)
            {
                Console.WriteLine($"{i} bu sayı = {(i * 3 + 2)}");
            }
        }*/

        //LMS'de bulunan çalışma sorularından çözüm
        /*
        int s, eb, ek, n = 10;

        Console.Write($"1. sayı girin: ");
        s = int.Parse(Console.ReadLine());

        eb = ek = s;

        for (int i = 1; i < n; i++)
        {
            Console.Write($"{i + 1}. sayı girin: ");
            s = int.Parse(Console.ReadLine());
            if (s > eb) eb = s;
            if (s < ek) ek = s;
        }
        Console.WriteLine($"En küçük: {ek}, En büyük: {eb}");
        */

        //LMS'de bulunan çalışma sorularından çözüm
        /*
        int s, n, tt = 0, tc = 1;
        double ckt = 0;

        Console.Write("N sayısını girin: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i+1}. sayı girin: ");
            s = int.Parse(Console.ReadLine());
            if (s % 2 == 0)
            {
                ckt += Math.Pow(s, 2);
            }
            else
            {
                tt += s;
                tc *= s;
            }
        }
        
        Console.WriteLine($"Tek toplamlar: {tt}, tek carpimlar: {tc}, cift kare toplamlar: {ckt}");*/

        /*for (int i = 0; i < 100; i++)
        {
            Console.Write($"{random.Next(1, 1000)} ");
        }*/

        /*
        int t = 0, toplamPuan = 0, dogruSayisi = 0, yanlisSayisi = 0, s1, s2;
        char devamMi = '\0';

        Random random = new Random();
        do
        {
            s1 = random.Next(1, 10);
            s2 = random.Next(1, 10);

            Console.WriteLine($"{s1} + {s2} = ?");
            Console.Write("Cevabınızı giriniz: ");

            t = int.Parse(Console.ReadLine());

            if (t == (s1 + s2))
            {
                dogruSayisi++;
                toplamPuan += 5;
            }
            else
            {
                yanlisSayisi++;
                toplamPuan -= 5;
            }

            Console.Write("Oyuna devam etmek istiyor musunuz ? e/E => ");
            devamMi = char.Parse(Console.ReadLine());
        }
        while (devamMi == 'e' || devamMi == 'E');
        

        Console.WriteLine($"Doğru sayısı:{dogruSayisi} Yanlış sayısı:{yanlisSayisi} Toplam Puan:{toplamPuan} ");
        */

        /*
        int tahmin = 0, s1, denemeSayisi = 0;
        char devamMi = '\0';
        bool bulundu = false;

        Random random = new Random();
        s1 = random.Next(1, 10);
        Console.WriteLine(s1);

        do
        {
            Console.Write("1 ile 10 arasında rasgele bir sayı atandı, tahmin ediniz: ");
            tahmin = int.Parse(Console.ReadLine());
            denemeSayisi++;

            if (tahmin == s1) bulundu = true;

        }
        while (denemeSayisi != 5 && tahmin!=s1);


        if (bulundu)
        {
            Console.WriteLine($"TEBRİKLER ! {denemeSayisi} adımda tahmini buldunuz !");
        }
        else
        {
            Console.WriteLine($"Maalesef :( deneme sayısı bitti. Sayıyı bulamadınız !!!");
        }
        */

        /*
        Console.WriteLine("i \t j");
        Console.WriteLine("_ \t _\n");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine($"{i} \t {j}");
            }
            Console.WriteLine();
        }*/


        /*
        Console.WriteLine("{i} \t {j}");
        Console.WriteLine("__ \t __");
        for (int i = 1; i<=3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.WriteLine($"{i} \t {j}");
            }
            Console.WriteLine();
        }*/

        /*
        int z = 1, x = 8, y=1;
        while (y <= x)
        {
            z *= y;
            y++;
        }
        Console.Write($"{x}! = {z}");
        */

        /*
        int kare = 10;

        for(int i=1; i<=kare; i++)
        {
            for (int j = 1; j <= kare; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        */
        /*
        int deger = 10;

        for (int i = 1; i <= deger; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        */
        //1'den 100'e kadar 100 adet sayıdan kaç tanesi
        //çift kaç tanesi tek bulunuz.

        /*
        int rasgeleSayi, ts = 0, cs = 0;
        Random rnd = new Random();

        for (int i = 0; i <100; i++)
        {
            rasgeleSayi = rnd.Next(1, 100);
            if (rasgeleSayi % 2 == 0) cs++; else ts++;
        }

        Console.WriteLine($"Bulunan çift sayı adedi {cs}, " +
            $"Bulunan tek sayı adedi {ts}");

        */

        string isim = "İÇĞÜÇ";
        char[] turkishChars = { 'ı', 'ğ', 'İ', 'Ğ', 'ç', 'Ç', 'ş', 'Ş', 'ö', 'Ö', 'ü', 'Ü', ' ' };
        char[] englishChars = { 'i', 'g', 'I', 'G', 'c', 'C', 's', 'S', 'o', 'O', 'u', 'U', '\0' };

        for (int i = 0; i < turkishChars.Length; i++)
        {
            Console.WriteLine(turkishChars[i] + "" + englishChars[i]);
            isim = isim.Replace(turkishChars[i], englishChars[i]);
        }
        Console.WriteLine(isim);

    }
}