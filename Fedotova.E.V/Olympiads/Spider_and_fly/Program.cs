using System;

class Program
{
    static void Main()
    {
        // Чтение входных данных
        Console.WriteLine("Введите ширину, глубину и высоту комнаты (через пробел):");
        string[] dimensions = Console.ReadLine().Split(' ');
        int a = int.Parse(dimensions[0]);
        int b = int.Parse(dimensions[1]);
        int c = int.Parse(dimensions[2]);

        Console.WriteLine("Введите координаты паука (Sx, Sy, Sz) относительно начала комнаты (0, 0) (через пробел):");
        string[] spiderCoords = Console.ReadLine().Split(' ');
        int Sx = int.Parse(spiderCoords[0]);
        int Sy = int.Parse(spiderCoords[1]);
        int Sz = int.Parse(spiderCoords[2]);

        Console.WriteLine("Введите координаты мухи (Fx, Fy, Fz) относительно начала комнаты (0, 0) (через пробел):");
        string[] flyCoords = Console.ReadLine().Split(' ');
        int Fx = int.Parse(flyCoords[0]);
        int Fy = int.Parse(flyCoords[1]);
        int Fz = int.Parse(flyCoords[2]);

        // Вычисление минимального расстояния
        double distance = Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(Sz - Fz, 2));

        // Вывод результата
        Console.WriteLine("Минимальное расстояние, которое необходимо проползти пауку, чтобы добраться до мухи: {0:F3}", distance);
    }
}