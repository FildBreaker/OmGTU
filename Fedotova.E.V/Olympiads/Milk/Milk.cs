using System;
using System.IO;

class Program
{
    static void Main()
    {
        
        if (!Directory.Exists("results"))
        {
            Directory.CreateDirectory("results");
        }

        for (int i = 1; i <= 10; i++)
        {
            string inputFilename = $"data\\input{i}.txt";
            string outputFilename = $"results\\output{i}.txt";  

            using (StreamWriter outputfile = new StreamWriter(outputFilename))
            {
                float minPrice = float.PositiveInfinity;  
                int firm = 0;  

                string[] inputLines = File.ReadAllLines(inputFilename);
                int n = int.Parse(inputLines[0]);  

               
                for (int j = 1; j <= n; j++)
                {
                    string[] parameters = inputLines[j].Split();

                   
                    float x1 = float.Parse(parameters[0]);
                    float y1 = float.Parse(parameters[1]);
                    float z1 = float.Parse(parameters[2]);
                    float x2 = float.Parse(parameters[3]);
                    float y2 = float.Parse(parameters[4]);
                    float z2 = float.Parse(parameters[5]);
                    float p1 = float.Parse(parameters[6]);
                    float p2 = float.Parse(parameters[7]);

              
                    float v1 = x1 * y1 * z1;
                    float s1 = 2 * x1 * y1 + 2 * y1 * z1 + 2 * z1 * x1;

                    float v2 = x2 * y2 * z2;
                    float s2 = 2 * x2 * y2 + 2 * y2 * z2 + 2 * z2 * x2;

                  
                    float milkPrice = (p2 * s1 - p1 * s2) / (v2 * s1 - v1 * s2);

                  
                    if (milkPrice < minPrice)
                    {
                        minPrice = milkPrice;
                        firm = j;
                    }
                }

                minPrice = (float)Math.Round(minPrice * 1000, 2); 

                outputfile.WriteLine($"{firm} {minPrice}");  
            }
        }
    }
}
