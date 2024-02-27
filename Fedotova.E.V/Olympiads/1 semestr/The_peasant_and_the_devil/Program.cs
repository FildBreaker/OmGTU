using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите начальное количество монет (N):");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество монет, отдаваемых черту (K):");
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество переходов через мост (Z):");
        int Z = int.Parse(Console.ReadLine());

        int count = 0;

        if (CalculateMoney(N, K, Z) == 0)
        {
            count++;
        }

        Console.WriteLine("Количество комбинаций условий перехода через мост: " + count);
    }

    static int CalculateMoney(int N, int K, int Z)
    {
        int money = N;

        for (int i = 1; i <= Z; i++)
        {
            money *= 2;
            money -= K;

            if (money < 0)
            {
                return money;
            }
        }

        return money;
    }
}
