internal class Program
{
    private static void Main(string[] args)
    {
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
    }
}