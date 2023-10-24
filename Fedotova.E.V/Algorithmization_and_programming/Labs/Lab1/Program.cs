using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 1.5;
        double b = 2;
        double c = -0.7;

        double x1 = 1;
        double x2 = 2;

        double w1 = a * Math.Exp(-Math.Sqrt(x1)) * Math.Cos(b * x1) + Math.Pow(c, 5);
        double w2 = a * Math.Exp(-Math.Sqrt(x2)) * Math.Cos(b * x2) + Math.Pow(c, 5);

        Console.WriteLine("w1 = " + w1);
        Console.WriteLine("w2 = " + w2);
    }
}