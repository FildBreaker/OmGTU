using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filename = "input_s1_01.txt";

        Dictionary<int, int> month = new Dictionary<int, int>
        {
            { 1, 31 },
            { 2, 28 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 },
            { 7, 31 },
            { 8, 31 },
            { 9, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 }
        };

        int sdays = 0;
        int edays = 0;

        using (StreamReader sr = new StreamReader(filename))
        {
            string[] sdateStr = sr.ReadLine().Trim().Split(".");
            string[] edateStr = sr.ReadLine().Trim().Split(".");
            int gain = int.Parse(sr.ReadLine().Trim());

            int[] sdate = Array.ConvertAll(sdateStr, int.Parse);
            int[] edate = Array.ConvertAll(edateStr, int.Parse);

            int sleapyears = (sdate[2] - (sdate[2] % 4)) / 4;
            int syears = sdate[2] - sleapyears;
            sdays += (sleapyears * 366) + (syears * 365);
            int eleapyears = (edate[2] - (edate[2] % 4)) / 4;
            int eyears = edate[2] - eleapyears;
            edays += (eleapyears * 366) + (eyears * 365);

            for (int m = 1; m < sdate[1]; m++)
            {
                sdays += month[m];
            }

            for (int m = 1; m < edate[1]; m++)
            {
                edays += month[m];
            }

            sdays += sdate[0];
            edays += edate[0];

            int days = edays - sdays + 1;
            int products = (gain + days - 1 + gain) / 2 * days;
            Console.WriteLine(products);
        }
    }
}
