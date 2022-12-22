/*
        int[] dizi2 = { 1, 2, 3, 4, 5, 6, 7, 8, 2, 3, 4, 5, 6, 7, 8, 2, 3, 4, 5, 6, 7, 8, 2, 3, 4, 5};

        for(int i=0; i < dizi2.Length; i++)
        {
            Console.Write(dizi2[i] + " ");
        }
        */


/*string isimler = "Bilgisayar Programcılığı";

for (int i = 0; i < isimler.Length; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(isimler[j]);
    }
    Console.WriteLine();
} */


/*
Random random = new Random();
int n;
Console.Write("Kaç elamanlı dizi istersin ? ");
n = int.Parse(Console.ReadLine());

int[] dizi = new int[n];

for(int i = 0; i < n; i++)
{
   dizi[i] = random.Next(1,100);
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"dizi[{i}] = {dizi[i]}");
}

*/

//Console.Write($"Dizinin 3. elamanı dizi[3] = {dizi[3]}");

/*
int[] dizi = {5,-1,0,10};
int eb, ek, gecici;
eb = ek = dizi[0];

for(int i=0; i<dizi.Length; i++)
{
    if (dizi[i] > eb) eb = dizi[i];

    if(dizi[i] < ek)  ek = dizi[i];

    for(int j=0; j<dizi.Length; j++)
    {
        if(dizi[j] > dizi[i])
        {
            gecici = dizi[i];
            dizi[i] = dizi[j];
            dizi[j] = gecici;
        }
    }
}

foreach (var i in dizi)
{
    Console.Write(i+" ");
}

//dizi içinde ara


for (int i = 0; i < dizi.Length; i++)
{ 
    if(5 == dizi[i])
    {
        Console.WriteLine("BULDUM !"+i+". numara"); break;
    }
}

Console.WriteLine($"EB={eb}, EK={ek}"); 

*/

