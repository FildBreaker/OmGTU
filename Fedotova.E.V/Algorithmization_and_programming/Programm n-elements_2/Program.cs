using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество пар элементов: ");
        int n;
        bool isValidInput = int.TryParse(Console.ReadLine(), out n);

        if (!isValidInput || n <= 0)
        {
            Console.WriteLine("Количество пар должно быть положительным числом!");
            return;
        }

        int[] pairs = new int[n * 2];
        for (int i = 0; i < n * 2; i++)
        {
            Console.Write("Введите элемент пары №" + (i / 2 + 1) + ": ");
            isValidInput = int.TryParse(Console.ReadLine(), out pairs[i]);
            if (!isValidInput)
            {
                Console.WriteLine("Неправильный ввод. Введите целое число.");
                i--; // Повторяем ввод для текущего элемента пары
            }
        }

        int maxSum = FindMaxSum(pairs, n);
        if (maxSum == -1)
        {
            Console.WriteLine("Невозможно получить сумму элементов пар, кратную трем.");
        }
        else
        {
            Console.WriteLine("Максимальная сумма элементов пар, кратную трем: " + maxSum);
        }
    }

    static int FindMaxSum(int[] pairs, int n)
    {
        int[][] dp = new int[n + 1][];
        for (int i = 0; i <= n; i++)
        {
            dp[i] = new int[3];
        }

        for (int i = 1; i <= n; i++)
        {
            int num1 = pairs[(i - 1) * 2];
            int num2 = pairs[(i - 1) * 2 + 1];
            for (int j = 0; j < 3; j++)
            {
                dp[i][j] = Math.Max(dp[i - 1][j], dp[i - 1][(j - num1 % 3 + 3) % 3] + num1);
                dp[i][j] = Math.Max(dp[i][j], dp[i - 1][(j - num2 % 3 + 3) % 3] + num2);
            }
        }

        return dp[n][0] == 0 ? -1 : dp[n][0];
    }
}