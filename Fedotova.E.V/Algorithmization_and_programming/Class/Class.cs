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
        Console.WriteLine("Введите количество студентов:");
        int количествоСтудентов = int.Parse(Console.ReadLine());

        Student[] students = new Student[количествоСтудентов];

        for (int i = 0; i < количествоСтудентов; i++)
        {
            Console.WriteLine($"Введите ФИО студента {i + 1}:");
            string ФИО = Console.ReadLine();

            Console.WriteLine($"Введите год рождения студента {i + 1}:");
            int годРождения = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите группу студента {i + 1}:");
            string группа = Console.ReadLine();

            students[i] = new Student(ФИО, годРождения, группа);
        }

        // Сортировка студентов по году рождения
        Array.Sort(students, (x, y) => x.BirthYear.CompareTo(y.BirthYear));

        // Вывод отсортированных студентов по году рождения
        Console.WriteLine("Студенты, отсортированные по году рождения:");
        foreach (Student student in students)
        {
            Console.WriteLine($"{student.FullName} - {student.BirthYear} - {student.Group}");
        }

        Console.WriteLine();

        // Группировка студентов по группе
        Array.Sort(students, (x, y) => x.Group.CompareTo(y.Group));

        // Вывод студентов, сгруппированных по группе
        Console.WriteLine("Студенты, сгруппированные по группе:");
        foreach (Student student in students)
        {
            Console.WriteLine($"{student.FullName} - {student.BirthYear} - {student.Group}");
        }
    }
}
