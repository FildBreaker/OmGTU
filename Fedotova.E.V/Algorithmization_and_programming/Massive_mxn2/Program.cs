using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк в массиве: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов в массиве: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("matrix[{0},{1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int negativeSumPositiveProductCount = 0;
        int[] maxEvenElements = new int[cols];

        for (int j = 0; j < cols; j++)
        {
            int sum = 0;
            int product = 1;
            int maxEvenElement = int.MinValue;

            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i, j];
                product *= matrix[i, j];

                if (matrix[i, j] % 2 == 0 && matrix[i, j] > maxEvenElement)
                {
                    maxEvenElement = matrix[i, j];
                }
            }

            if (sum < 0 && product > 0)
            {
                negativeSumPositiveProductCount++;
            }

            maxEvenElements[j] = maxEvenElement;
        }

        int countOfPairsWithSameElements = 0;

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = i + 1; j < rows; j++)
            {
                bool isPairWithSameElements = true;

                for (int k = 0; k < cols; k++)
                {
                    if (matrix[i, k] != matrix[j, k])
                    {
                        isPairWithSameElements = false;
                        break;
                    }
                }

                if (isPairWithSameElements)
                {
                    countOfPairsWithSameElements++;
                }
            }
        }

        int countOfNonNullElements = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] != 0)
                {
                    countOfNonNullElements++;
                }
            }
        }

        bool allRowsHaveEvenMin = true;
        int minElement = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            int minRowElement = int.MaxValue;

            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < minRowElement)
                {
                    minRowElement = matrix[i, j];
                }

                if (matrix[i, j] < minElement)
                {
                    minElement = matrix[i, j];
                }
            }

            if (minRowElement % 2 != 0)
            {
                allRowsHaveEvenMin = false;
                break;
            }
        }

        Console.WriteLine("Количество столбцов, в которых сумма элементов отрицательна, а произведение положительное: {0}", negativeSumPositiveProductCount);
        Console.WriteLine("Во всех ли строках минимальный элемент чётный: {0}", allRowsHaveEvenMin ? "Да" : "Нет");
        Console.WriteLine("Количество ненулевых элементов в массиве: {0}", countOfNonNullElements);

        Console.WriteLine("Наибольший четный элемент в каждом столбце:");

        for (int j = 0; j < cols; j++)
        {
            Console.WriteLine("Столбец {0}: {1}", j, maxEvenElements[j]);
        }

        Console.WriteLine("Количество пар строк, состоящих из одинаковых элементов: {0}", countOfPairsWithSameElements);
    }
}