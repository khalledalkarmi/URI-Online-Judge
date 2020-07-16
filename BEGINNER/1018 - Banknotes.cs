using System;

class URI
{

    static void Main(string[] args)
    {

        Int32 N = Convert.ToInt32(Console.ReadLine());
        int b = N;
        int BkN100 = 0;
        int BkN50 = 0;
        int BkN20 = 0;
        int BkN10 = 0;
        int BkN5 = 0;
        int BkN2 = 0;
        int BkN1 = 0;

        if (N >= 100)
        {
            BkN100 = N / 100;
            N %= 100;

        }
        if (N >= 50)
        {
            BkN50 = N / 50;
            N %= 50;

        }
        if (N >= 20)
        {
            BkN20 = N / 20;
            N %= 20;
        }
        if (N >= 10)
        {
            BkN10 = N / 10;
            N %= 10;
        }
        if (N >= 5)
        {
            BkN5 = N / 5;
            N %= 5;
        }
        if (N >= 2)
        {
            BkN2 = N / 2;
            N %= 2;
        }
        if (N >= 1)
        {
            BkN1 = N / 1;
            N %= 1;
        }
        Console.WriteLine(b);
        Console.WriteLine(BkN100 + " nota(s) de R$ 100,00");
        Console.WriteLine(BkN50 + " nota(s) de R$ 50,00");
        Console.WriteLine(BkN20 + " nota(s) de R$ 20,00");
        Console.WriteLine(BkN10 + " nota(s) de R$ 10,00");
        Console.WriteLine(BkN5 + " nota(s) de R$ 5,00");
        Console.WriteLine(BkN2 + " nota(s) de R$ 2,00");
        Console.WriteLine(BkN1 + " nota(s) de R$ 1,00");
    }

}