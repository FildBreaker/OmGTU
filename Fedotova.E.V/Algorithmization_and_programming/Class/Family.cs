using System;
using System.Linq;
using System.Collections.Generic;

class Family
{
    public string FullName { get; set; }
    public string Gender { get; set; }
    public int YearOfBirth { get; set; }
    public string CityOfBirth { get; set; }
    public string MotherFullName { get; set; }
    public string FatherFullName { get; set; }
    public List<int> SchoolNumbers { get; set; }
}

class Program
{
    static void Main()
    {
        List<Family> families = new List<Family>();

        // ���������� ������ families �������

        // 1. ���������� ��������� � ���������� ����������� �����.
        var parentsWithMostChildren = families.GroupBy(family => family.MotherFullName + family.FatherFullName)
                                              .OrderByDescending(group => group.Count())
                                              .First().Key;

        // 2. ���������� ���������� �����, ������� �������� � �������� ���.
        int specifiedYear = 2000; // ������
        int childrenBornInSpecifiedYear = families.Count(family => family.YearOfBirth == specifiedYear);

        // 3. ���������� ����� ����� ����� ���� ����� �����������.
        var mostFrequentSchoolNumber = families.SelectMany(family => family.SchoolNumbers)
                                               .GroupBy(number => number)
                                               .OrderByDescending(group => group.Count())
                                               .First().Key;

        // 4. ������ ��� �����, ������� ������� ������ � ����� �����.
        var childrenAttendedOneSchool = families.Where(family => family.SchoolNumbers.Distinct().Count() == 1)
                                               .Select(family => family.FullName);

        // ����� �����������
        Console.WriteLine("�������� � ���������� ����������� �����: " + parentsWithMostChildren);
        Console.WriteLine("���������� �����, ���������� � " + specifiedYear + " ����: " + childrenBornInSpecifiedYear);
        Console.WriteLine("����� �����, ������� ���� ����� �����������: " + mostFrequentSchoolNumber);
        Console.WriteLine("����, ��������� ������ � ����� �����: " + string.Join(", ", childrenAttendedOneSchool));
    }
}
