using System;

class Program
{
    static int CountSignChanges(int[] nums)
    {
        int count = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] * nums[i - 1] < 0)
            {
                count++;
            }
        }
        return count;
    }

    static int CountElementsLessThanNeighbors(int[] nums)
    {
        int count = 0;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] < nums[i - 1] && nums[i] < nums[i + 1])
            {
                count++;
            }
        }
        return count;
    }

    static int MaxSequenceLength(int[] nums)
    {
        int maxLength = 1;
        int currentLength = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
            }
            maxLength = Math.Max(maxLength, currentLength);
        }
        return maxLength;
    }

    static void MinNegativeSubsequence(int[] nums)
    {
        bool hasNegative = false;
        foreach (int num in nums)
        {
            if (num < 0)
            {
                hasNegative = true;
                break;
            }
        }

        if (!hasNegative)
        {
            Console.WriteLine("Нет отрицательных элементов в последовательности");
            return;
        }

        int minLength = int.MaxValue;
        int currentLength = 0;
        foreach (int num in nums)
        {
            if (num < 0)
            {
                currentLength++;
            }
            else
            {
                currentLength = 0;
            }
            minLength = Math.Min(minLength, currentLength);
        }

        Console.WriteLine("Минимальный размер подпоследовательности из отрицательных элементов: " + minLength);
    }

    static void Main()
    {
        Console.Write("Введите количество элементов: ");
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите элемент " + (i + 1) + ": ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        int result1 = CountSignChanges(nums);
        Console.WriteLine("Количество смены знака: " + result1);

        int result2 = CountElementsLessThanNeighbors(nums);
        Console.WriteLine("Количество элементов, значение которых меньше соседа слева и справа: " + result2);

        int result3 = MaxSequenceLength(nums);
        Console.WriteLine("Максимальный размер последовательности из одинаковых элементов: " + result3);

        MinNegativeSubsequence(nums);
    }
}

