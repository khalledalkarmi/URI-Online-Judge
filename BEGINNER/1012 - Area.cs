using System;

class URI
{

    static void Main(string[] args)
    {

        String[] tokinz = Console.ReadLine().Split(' ');
        double a = double.Parse(tokinz[0]);
        double b = double.Parse(tokinz[1]);
        double c = double.Parse(tokinz[2]);

        double TRIANGULO = (.5 * a * c);
        double CIRCULO = Math.Pow(c, 2) * 3.14159;
        double TRAPEZIO = ((a + b) / 2) * c;
        double QUADRADO = Math.Pow(b, 2);
        double RETANGULO = a * b;

        Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("0.000"));
        Console.WriteLine("CIRCULO: " + CIRCULO.ToString("0.000"));
        Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("0.000"));
        Console.WriteLine("QUADRADO: " + QUADRADO.ToString("0.000"));
        Console.WriteLine("RETANGULO: " + RETANGULO.ToString("0.000"));

    }

}