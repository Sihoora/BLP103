internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.Write("Puan giriniz: (A,B,C,D,F)");
        char puan;
        puan = char.Parse(Console.ReadLine());

        switch (char.ToUpper(puan))
        {
            case 'a':
            case 'A':
                Console.WriteLine("Pekiyi");
                break;
            case 'B':
                Console.WriteLine("İyi");
                break;
            case 'C':
                Console.WriteLine("Orta");
                break;
            case 'D':
                Console.WriteLine("Hmmmmmm...");
                break;
            case 'F':
                Console.WriteLine("Kaldı !!!");
                break;
            default:
                //herhangi bir case uygun değer yoksa çalışır.
                Console.WriteLine("Yanlış giriş.");
                break;
        }
        */

        /*
        yenidenGiris:
        Console.Write("Ay sayısını giriniz (1-12) : ");
        // 1 ... 12

        int ay; 
        ay = int.Parse(Console.ReadLine());

        switch (ay)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Ocak-Şubat-Mart ayı"); 
                break;
            default:
                //herhangi bir case uygun değer yoksa çalışır.
                Console.WriteLine("Yanlış giriş. Lütfen 1-12 arasında giriniz.");
                goto yenidenGiris;
        }
        Console.WriteLine("Break kodundan sonra burası gelir.");
        */

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


        /*
        string isim;

        veriGirisi:
        Console.Write("İsim giriniz: ");
        isim = Console.ReadLine();


        switch (isim.ToLower())
        {
            case "ismail":
                Console.WriteLine("Kulup Başkanı");
                break;
            case "yasemin":
                Console.WriteLine("Kulup Başkan Yardımcısı");
                break;
            case "öykü":
                Console.WriteLine("ARGE Başkanı");
                break;
            default:
                Console.WriteLine("Bu kişi kulup içerisinde yer almıyor.");
                goto veriGirisi;
        }

        Console.WriteLine("Blok kırıldı !");
        */




        /* //////////////ÖDEV
          KLAVYEDEN 2 ADET SAYI GİRİŞİ İSTEYİNİZ.
         GİRİŞ YAPTIKTAN SONRA EKRANA AŞAĞIDAKİ GİBİ BİR MENÜ ÇIKSIN.

         *** MENÜ ***
         1- TOPLA
         2- ÇIKAR
         3- ÇARP
         4- BÖL
         5- MOD
         6- ÜS
         7- KAREKÖK

         SEÇİME GÖRE İŞLEMLERİ YAPIP EKRANA YAZINIZ. SEÇİM DIŞINDAKİ İŞLEMLERDE
         HATALI GİRİŞ MESAJI VERİP YENİDEN GİRİŞ ALINIZ.
          */

    }
}