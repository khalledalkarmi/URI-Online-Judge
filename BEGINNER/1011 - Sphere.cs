using System;

class URI
{

    static void Main(string[] args)
    {

        double R = double.Parse(Console.ReadLine());
        double sphere = (4.0 / 3) * 3.14159 * Math.Pow(R, 3);
        Console.WriteLine("VOLUME = " + sphere.ToString("0.000"));


    }

}