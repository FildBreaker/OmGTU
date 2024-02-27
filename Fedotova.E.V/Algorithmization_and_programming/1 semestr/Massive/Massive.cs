using System;
using System.Collections.Generic;

public class Program
{
    public static int SumOfDigits(int num)
    {
        return Math.Abs(num).ToString().ToCharArray().Sum(digit => int.Parse(digit.ToString()));
    }

    public static void Main()
    {
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }

        int max_even = int.MinValue;
        int count_with_5 = 0;
        int min_sum_digits = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                if (num > max_even)
                {
                    max_even = num;
                }
            }

            bool has_5 = false;
            int current_num = Math.Abs(num);
            while (current_num > 0)
            {
                if (current_num % 10 == 5)
                {
                    has_5 = true;
                    break;
                }
                current_num /= 10;
            }
            if (has_5)
            {
                count_with_5++;
            }

            if (SumOfDigits(num) < min_sum_digits)
            {
                min_sum_digits = SumOfDigits(num);
            }
        }

        Console.WriteLine("Максимальное среди четных чисел: " + max_even);
        Console.WriteLine("Количество чисел с цифрой 5: " + count_with_5);
        Console.WriteLine("Элемент с наименьшей суммой цифр: " + min_sum_digits);
    }
}
