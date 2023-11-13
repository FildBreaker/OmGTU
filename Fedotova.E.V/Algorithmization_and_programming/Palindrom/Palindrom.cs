using System;

class Program
{
    static void Main(string[] args)
    {
        /*���� ������ �������������*/
        Console.WriteLine("������� ������:");
        string str = Console.ReadLine();

        int maxLength = 0; /*���������� ������ ����������*/
        int start = 0; /*������ ������ ����������*/

        /*���� �������� ���������� � ������� �� ������ ������� ������*/
        for (int i = 0; i < str.Length; i++)
        {
            int len1 = ExpandFromCenter(str, i, i); // �������� ���������� � ������� �� ����� �������
            int len2 = ExpandFromCenter(str, i, i + 1); // �������� ���������� � ������� �� ���� ��������

            int len = Math.Max(len1, len2); // ����� ������������ ����� ����������

            if (len > maxLength)
            {
                maxLength = len;
                start = i - (len - 1) / 2; // ���������� ������ ����������
            }
        }

        string longestPalindrome = str.Substring(start, maxLength); /*���������� ������ �������� ����������*/
        Console.WriteLine("���������� ����� ����������: {maxLength}");
        Console.WriteLine("����� ������� ���������: {longestPalindrome}");
    }
    /*����� ��� �������� ���������� � ������� � left; right*/
    static int ExpandFromCenter(string str, int left, int right)
    {
        /*�������� �������� ����� � ������ �� ������ ���� ������� 
        ��������� � ������ �� �����������*/
        while (left >= 0 && right < str.Length && str[left] == str[right])
        {
            left--; /*����� ��������� �����*/
            right++; /*����� ��������� ������*/
        }

        return right - left - 1; /*����������� ������ ����������*/
    }
}