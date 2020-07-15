using System;

class URI
{

    static void Main(string[] args)
    {

        String[] tokins = Console.ReadLine().Split(' ');
        int Num = Int32.Parse(tokins[0]);
        int Unit = Int32.Parse(tokins[1]);
        double Price = double.Parse(tokins[2]);
        double Total = (Unit * Price);
        //  Console.WriteLine(Total);

        String[] tokins2 = Console.ReadLine().Split(' ');
        int Num1 = Int32.Parse(tokins2[0]);
        int Unit1 = Int32.Parse(tokins2[1]);
        double Price1 = double.Parse(tokins2[2]);
        double Total1 = (Unit1 * Price1);
        // Console.WriteLine(Total1);

        Console.WriteLine("VALOR A PAGAR: R$ " + (Total + Total1).ToString("0.00"));


    }

}