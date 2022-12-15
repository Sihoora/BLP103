/*
       Console.WriteLine("WHILE");
       int i = 10;

       while (i <= 5)
       {
           Console.Write(i+" ");
           i++;
       }
       Console.WriteLine("END WHILE");

       Console.WriteLine("DO WHILE");
       int j = 10;
       do{
           Console.Write(j + " ");
           j++;
       }
       while (j <= 5) ;
       Console.WriteLine("END DO WHILE");
       */
// rasgele üretilen 1-1000 arasındaki 100 adet
//sayıdan kaç tane çift kaç tane tek bulunuz.
/*
Random rnd = new Random();
int ts=0, cs=0, i = 1, rasgeleSayi;
while (i <= 100)
{
    rasgeleSayi = rnd.Next(1, 1000);
    if (rasgeleSayi % 2 == 0) {
        Console.WriteLine("ÇİFT => " + rasgeleSayi);
        cs++;
    } else {
        Console.WriteLine("TEK => " + rasgeleSayi);
        ts++;
    }
    i++;
}
Console.WriteLine($"Çitf adet: {cs}, Tek adet: {ts}");
*/

/*
int sayi, t=0, sayac = 1;
Console.Write("Bir sayı gir : ");
sayi = int.Parse(Console.ReadLine());
t += sayi; 
while(sayi != 0)
{
    Console.Write("Bir sayı gir : ");
    sayi = int.Parse(Console.ReadLine());
    t += sayi;
    sayac++;
}

Console.WriteLine($"Sayıların toplamı = {t}");
Console.WriteLine($"Sayıların miktarı = {sayac}");
*/

/*
int sayi, t = 0, sayac = 0;
do
{
    Console.Write("Bir sayı gir : ");
    sayi = int.Parse(Console.ReadLine());
    t += sayi;
    sayac++;
}
while (sayi != 0);

Console.WriteLine($"Sayıların toplamı = {t}");
Console.WriteLine($"Sayıların miktarı = {sayac}");
*/

/*
        int a = 1;

        while (a > 5)
        {
            Console.WriteLine("While döngüsü");
        }

        do
        {
            Console.WriteLine("Do While");
        } while (a > 5);
        */

/*int sayi;
Console.Write("1. sayıyı gir: ");
sayi = int.Parse(Console.ReadLine());
while(sayi != 0)
{
    Console.Write("Sayı gir: ");
    sayi = int.Parse(Console.ReadLine());
}*/

/*
int sayi, sayac = 1, t = 0;
char devamMi = '\0';
do
{
    Console.Write($"{sayac}. sayıyı gir: ");
    sayi = int.Parse(Console.ReadLine());
    t += sayi;
    sayac++;
    Console.Write("Devam etmek ister misin ? E/H: ");
    devamMi = char.Parse(Console.ReadLine());

} while (char.ToLower(devamMi) != 'h');
//while (devamMi != 'H' || devamMi != 'h');
Console.WriteLine($"Program bitti. Sayıların toplamı ={t}");
Console.WriteLine($"Program {sayac} çalıştı.");
*/