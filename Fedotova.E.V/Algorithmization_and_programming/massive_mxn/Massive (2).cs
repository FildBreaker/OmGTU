using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = ReadArray();

        int count = CountRowsWithSumGreaterThanProduct(array);
        Console.WriteLine(" оличество строк с суммой элементов больше произведени€: " + count);
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

    static int CountRowsWithSumGreaterThanProduct(int[,] array)
    {
        int count = 0;
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            int sum = 0;
            int product = 1;
            for (int j = 0; j < n; j++)
            {
                sum += array[i, j];
                product *= array[i, j];
            }

            if (sum > product)
            {
                count++;
            }
        }

        return count;
    }
}