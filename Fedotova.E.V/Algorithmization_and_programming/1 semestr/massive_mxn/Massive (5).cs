using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = ReadArray();

        int count = CountPairsWithSameElements(array);
        Console.WriteLine(" оличество пар строк с одинаковыми элементами: " + count);
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

    static int CountPairsWithSameElements(int[,] array)
    {
        int count = 0;
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        List<string> pairs = new List<string>();

        for (int i = 0; i < m; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                bool hasEqualElements = true;
                for (int k = 0; k < n; k++)
                {
                    if (array[i, k] != array[j, k])
                    {
                        hasEqualElements = false;
                        break;
                    }
                }

                if (hasEqualElements)
                {
                    string pair = string.Format("({0}, {1})", i, j);
                    pairs.Add(pair);
                }
            }
        }

        count = pairs.Count;
        return count;
    }
}