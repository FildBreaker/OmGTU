using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = ReadArray();

        int product = MultiplyNonNegativeEvenElements(array);
        Console.WriteLine("ѕроизведение неотрицательных чЄтных элементов массива: " + product);
    }

    static int[,] ReadArray()
    {
        Console.Write("¬ведите количество строк: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("¬ведите количество столбцов: ");
        int n = int.Parse(Console.ReadLine());

        int[,] array = new int[m, n];

        Console.WriteLine("¬ведите элементы массива:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Ёлемент[{0}, {1}]: ", i, j);
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return array;
    }

    static int MultiplyNonNegativeEvenElements(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        int product = 1;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] >= 0 && array[i, j] % 2 == 0)
                {
                    product *= array[i, j];
                }
            }
        }

        return product;
    }
}