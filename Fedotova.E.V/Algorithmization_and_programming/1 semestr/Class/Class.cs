using System;

class Student
{
    public string FullName { get; set; }
    public int BirthYear { get; set; }
    public string Group { get; set; }

    public Student(string fullName, int birthYear, string group)
    {
        FullName = fullName;
        BirthYear = birthYear;
        Group = group;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("������� ���������� ���������:");
        int ������������������� = int.Parse(Console.ReadLine());

        Student[] students = new Student[�������������������];

        for (int i = 0; i < �������������������; i++)
        {
            Console.WriteLine($"������� ��� �������� {i + 1}:");
            string ��� = Console.ReadLine();

            Console.WriteLine($"������� ��� �������� �������� {i + 1}:");
            int ����������� = int.Parse(Console.ReadLine());

            Console.WriteLine($"������� ������ �������� {i + 1}:");
            string ������ = Console.ReadLine();

            students[i] = new Student(���, �����������, ������);
        }

        // ���������� ��������� �� ���� ��������
        Array.Sort(students, (x, y) => x.BirthYear.CompareTo(y.BirthYear));

        // ����� ��������������� ��������� �� ���� ��������
        Console.WriteLine("��������, ��������������� �� ���� ��������:");
        foreach (Student student in students)
        {
            Console.WriteLine($"{student.FullName} - {student.BirthYear} - {student.Group}");
        }

        Console.WriteLine();

        // ����������� ��������� �� ������
        Array.Sort(students, (x, y) => x.Group.CompareTo(y.Group));

        // ����� ���������, ��������������� �� ������
        Console.WriteLine("��������, ��������������� �� ������:");
        foreach (Student student in students)
        {
            Console.WriteLine($"{student.FullName} - {student.BirthYear} - {student.Group}");
        }
    }
}
