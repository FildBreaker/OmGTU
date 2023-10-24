using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение аргумента t: ");
        double t = Convert.ToDouble(Console.ReadLine());

        double a = -0.5;
        double b = 2;
        double z;

        if (t < 1)
        {
            z = 1;
        }
        else if (t >= 1 && t <= 2)
        {
            z = a * Math.Pow(t, 2) * Math.Log(t);
        }
        else
        {
            z = Math.Exp(a * t) * Math.Cos(b * t);
        }

        Console.WriteLine("Значение функции z: " + z);
    }
}
