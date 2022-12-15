/*
        int[] dizi2 = { 1, 2, 3, 4, 5, 6, 7, 8, 2, 3, 4, 5, 6, 7, 8, 2, 3, 4, 5, 6, 7, 8, 2, 3, 4, 5};

        for(int i=0; i < dizi2.Length; i++)
        {
            Console.Write(dizi2[i] + " ");
        }
        */

string isimler = "Bilgisayar Programcılığı";

for (int i = 0; i < isimler.Length; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(isimler[j]);
    }
    Console.WriteLine();
}


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
