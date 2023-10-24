using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());

        double x = 0;
        double Z;

        while (x <= 3.6)
        {
            if (x >= 0 && x <= 2)
            {
                Z = Math.Pow(x, 2) * Math.Exp(-Math.Pow(x, 2) / 2);
            }
            else if (x > 2 && x <= 3.6)
            {
                Z = Math.Exp(Math.Pow(x, 2)) / 2 - 1;
            }
            else
            {
                break;
            }

            Console.WriteLine("x = " + x + ", Z = " + Z);

            x += a / 2;
        }
    }
}

