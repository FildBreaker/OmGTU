using System;

class Program
{
    static void Main(string[] args)
    {
        /*¬вод строки пользователем*/
        Console.WriteLine("¬ведите строку:");
        string str = Console.ReadLine();

        int maxLength = 0; /*Ќаибольша€ длинна полиндрома*/
        int start = 0; /*индекс начала палиндрома*/

        /*÷икл проверки палиндрома с центром на каждом символе строки*/
        for (int i = 0; i < str.Length; i++)
        {
            int len1 = ExpandFromCenter(str, i, i); // проверка палиндрома с центром на одном символе
            int len2 = ExpandFromCenter(str, i, i + 1); // проверка палиндрома с центром на двух символах

            int len = Math.Max(len1, len2); // выбор максимальной длины палиндрома

            if (len > maxLength)
            {
                maxLength = len;
                start = i - (len - 1) / 2; // нахождение начала палиндрома
            }
        }

        string longestPalindrome = str.Substring(start, maxLength); /*»звлечение самого длинного палиндрома*/
        Console.WriteLine("Ќаибольша€ длина палиндрома: {maxLength}");
        Console.WriteLine("—амый длинный палиндром: {longestPalindrome}");
    }
    /*ћетод дл€ проверки палиндрома с центром в left; right*/
    static int ExpandFromCenter(string str, int left, int right)
    {
        /*ѕроверка символов слева и справа от центра пока символы 
        совпадают и строка не закончилась*/
        while (left >= 0 && right < str.Length && str[left] == str[right])
        {
            left--; /*—двиг указател€ влево*/
            right++; /*—двиг указател€ вправо*/
        }

        return right - left - 1; /*¬озвращение длинны палиндрома*/
    }
}