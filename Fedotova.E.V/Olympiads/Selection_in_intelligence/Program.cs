using System;

class Program
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int count = 0;

        while (N > 3)
        {
            if (N % 2 == 0)
            {
                count++;
                N = N / 2;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(count);
    }
}
