using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значения переменной x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите значения переменной n: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
        }

        double result = x + sum;
        Console.WriteLine("Результат: " + result);
    }
}
