using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = ReadArray();

        int count = CountMultiplesOfFive(array);
        Console.WriteLine(" оличество элементов, кратных 5: " + count);
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

    static int CountMultiplesOfFive(int[,] array)
    {
        int count = 0;
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] % 5 == 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
}