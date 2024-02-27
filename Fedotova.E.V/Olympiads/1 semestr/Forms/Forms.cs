using System;
using System.Collections.Generic;

namespace FormsForCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<List<int>> details = new List<List<int>>();
            List<List<int>> forms = new List<List<int>>();

            for (int i = 0; i < N; i++)
            {
                List<int> detail = new List<int>();
                string[] detailInput = Console.ReadLine().Split(' ');

                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        detail.Add(int.Parse(detailInput[j * 5 + k]));
                    }
                }
                details.Add(detail);
            }

            for (int i = 0; i < 2 * N; i++)
            {
                List<int> form = new List<int>();
                string[] formInput = Console.ReadLine().Split(' ');

                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        form.Add(int.Parse(formInput[j * 5 + k]));
                    }
                }
                forms.Add(form);
            }

            for (int i = 0; i < N; i++)
            {
                bool foundMatch = false;
                for (int j = 0; j < N; j++)
                {
                    if (IsMatch(details[i], forms[j]) && IsMatch(details[i], forms[j + N]))
                    {
                        Console.WriteLine((i + 1) + " " + (j + 1));
                        foundMatch = true;
                        break;
                    }
                }
                if (!foundMatch)
                {
                    Console.WriteLine((i + 1) + " " + (i + 2));
                }
            }
        }

        static bool IsMatch(List<int> detail, List<int> form)
        {
            for (int i = 0; i < detail.Count; i++)
            {
                if (detail[i] != form[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
