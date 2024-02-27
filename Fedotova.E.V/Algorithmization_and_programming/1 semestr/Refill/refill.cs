using System;
using System.Collections.Generic;

class refill
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите минимальное расстояние от города до заправки:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество городов:");
        int cityCount = int.Parse(Console.ReadLine());

        List<int> distances = new List<int>();

        for (int i = 1; i <= cityCount; i++)
        {
            Console.WriteLine($"Введите расстояние от начальной точки до города {i}:");
            int distance = int.Parse(Console.ReadLine());
            distances.Add(distance);
        }

        Tuple<int, int> optimalLocation = FindOptimalFuelStation(distances, n);

        Console.WriteLine($"Оптимальное место для заправки: между городами {optimalLocation.Item1} и {optimalLocation.Item2}");
        Console.ReadLine();
    }

    static Tuple<int, int> FindOptimalFuelStation(List<int> distances, int n)
    {
        int minDistanceSum = int.MaxValue;
        Tuple<int, int> optimalLocation = null;

        // Перебираем все возможные места для заправки
        for (int i = 0; i < distances.Count - 1; i++)
        {
            for (int j = i + 1; j < distances.Count; j++)
            {
                // Проверяем условие, что расстояние от заправки до ближайших городов >= n
                if (Math.Min(distances[i], distances[j]) >= n)
                {
                    // Вычисляем сумму расстояний от всех городов до этой заправки
                    int distanceSum = distances.GetRange(i, j - i + 1).Sum();

                    // Если текущая сумма расстояний меньше минимальной, то обновляем минимальное значение и запоминаем лучшее местоположение
                    if (distanceSum < minDistanceSum)
                    {
                        minDistanceSum = distanceSum;
                        optimalLocation = new Tuple<int, int>(i + 1, j + 1);
                    }
                }
            }
        }

        return optimalLocation;
    }
}