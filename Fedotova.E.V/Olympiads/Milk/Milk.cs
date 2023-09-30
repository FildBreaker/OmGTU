using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Создание папки "results", если она не существует
        if (!Directory.Exists("results"))
        {
            Directory.CreateDirectory("results");
        }

        for (int i = 1; i <= 10; i++)
        {
            string inputFilename = $"data\\input{i}.txt";
            string outputFilename = $"results\\output{i}.txt";  // Файлы помещаются в папку "results"

            using (StreamWriter outputfile = new StreamWriter(outputFilename))
            {
                float minPrice = float.PositiveInfinity;  // Инициализируем минимальную цену как положительную бесконечность
                int firm = 0;  // Переменная для хранения номера фирмы с минимальной ценой

                string[] inputLines = File.ReadAllLines(inputFilename);
                int n = int.Parse(inputLines[0]);  // Читаем количество фирм из файла

                // Читаем данные для каждой фирмы и рассчитываем цену на молоко
                for (int j = 1; j <= n; j++)
                {
                    string[] parameters = inputLines[j].Split();

                    // Читаем значения параметров фирмы из файла и присваиваем значения переменным
                    float x1 = float.Parse(parameters[0]);
                    float y1 = float.Parse(parameters[1]);
                    float z1 = float.Parse(parameters[2]);
                    float x2 = float.Parse(parameters[3]);
                    float y2 = float.Parse(parameters[4]);
                    float z2 = float.Parse(parameters[5]);
                    float p1 = float.Parse(parameters[6]);
                    float p2 = float.Parse(parameters[7]);

                    // Расчет объема и площади первого и второго сосудов
                    float v1 = x1 * y1 * z1;
                    float s1 = 2 * x1 * y1 + 2 * y1 * z1 + 2 * z1 * x1;

                    float v2 = x2 * y2 * z2;
                    float s2 = 2 * x2 * y2 + 2 * y2 * z2 + 2 * z2 * x2;

                    // Рассчитываем цену на молоко для текущей фирмы
                    float milkPrice = (p2 * s1 - p1 * s2) / (v2 * s1 - v1 * s2);

                    // Если цена на молоко меньше текущей минимальной цены, обновляем значения минимальной цены и номера фирмы
                    if (milkPrice < minPrice)
                    {
                        minPrice = milkPrice;
                        firm = j;
                    }
                }

                minPrice = (float)Math.Round(minPrice * 1000, 2);  // Переводим минимальную цену в тысячи и округляем до двух знаков после запятой

                outputfile.WriteLine($"{firm} {minPrice}");  // Записываем результаты в файл вывода
            }
        }
    }
}