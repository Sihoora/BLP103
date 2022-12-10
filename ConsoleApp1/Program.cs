internal class Program
{
    private static void Main(string[] args)
    {
        //0 girilene kadar sayı girişi yapılıyor
        int sayi, sayac = 0;

        tekrar:
        sayac++;
        Console.WriteLine(sayac+". sayıyı gir:");
        sayi = int.Parse(Console.ReadLine());

        if (sayi!=0)
        {
            goto tekrar;
        }
        else
        {
            Console.WriteLine("0'a basıldı. Deneme sayısı: "+sayac);
        }

        //Sayaç ile döngü kullanımı
        /*
        int s = 1, t =0, tt=0, ct=0;
        merhabaYaz:
        Console.WriteLine($"{s} Merhaba !");
        s++;
        t += s;

        // ct = ct + s;
        if (s % 2 == 0) ct += s; else tt += s;

        if(s<=100)  goto merhabaYaz;

        Console.WriteLine("Program tamamlandı, toplam değer ="+t);
        Console.WriteLine($"Tek toplam : {tt}, Çift toplam: {ct} => Oran: {(double)tt/ct}");*/

    }
}