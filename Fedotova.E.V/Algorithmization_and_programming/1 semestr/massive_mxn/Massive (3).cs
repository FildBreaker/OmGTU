using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = ReadArray();

        int[] minElements = FindMinElementsInColumns(array);

        Console.WriteLine("����������� �������� � ������ �������:");

        for (int i = 0; i < minElements.Length; i++)
        {
            Console.WriteLine("������� {0}: {1}", i, minElements[i]);
        }
    }

    static int[,] ReadArray()
    {
        Console.Write("������� ���������� �����: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("������� ���������� ��������: ");
        int n = int.Parse(Console.ReadLine());

        int[,] array = new int[m, n];

        Console.WriteLine("������� �������� �������:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("�������[{0}, {1}]: ", i, j);
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return array;
    }

    static int[] FindMinElementsInColumns(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        int[] minElements = new int[n];

        for (int j = 0; j < n; j++)
        {
            int min = int.MaxValue;
            for (int i = 0; i < m; i++)
            {

                if (array[i, j] < min)
                {
                    min = array[i, j];
                }
            }

            minElements[j] = min;
        }

        return minElements;
    }
}