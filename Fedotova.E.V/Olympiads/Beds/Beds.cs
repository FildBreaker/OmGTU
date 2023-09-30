using System;

class Program
{
    static void Main()
    {
        int[] K = { 1, 2, 3, 20 };

        // Формула
        Console.WriteLine("Вычисление с формулой:");
        foreach (int k in K)
        {
            int l = 7;
            int n = 5;
            int m = 10;

            int s = k * (2 * l + 2 * n) + (k * k + k) * m;

            Console.WriteLine($"{k}: {s}");
        }

        Console.WriteLine();

        // Цикл
        Console.WriteLine("Вычисление с помощью цикла:");
        foreach (int k in K)
        {
            int l = 7;
            int n = 5;
            int m = 10;

            int s = 0;
            for (int j = 0; j < k; j++)
            {
                s += 2 * l + 2 * n + j * 2 * m; // Исправлено путем удаления лишнего слагаемого 2 * m
            }
            Console.WriteLine($"{k}: {s}");
        }

        Console.ReadLine();
    }
}