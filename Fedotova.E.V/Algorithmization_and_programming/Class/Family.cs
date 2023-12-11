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

        // Заполнение списка families данными

        // 1. Определить родителей с наибольшим количеством детей.
        var parentsWithMostChildren = families.GroupBy(family => family.MotherFullName + family.FatherFullName)
                                              .OrderByDescending(group => group.Count())
                                              .First().Key;

        // 2. Определить количество детей, которые родились в заданный год.
        int specifiedYear = 2000; // пример
        int childrenBornInSpecifiedYear = families.Count(family => family.YearOfBirth == specifiedYear);

        // 3. Определить номер какой школы чаще всего встречается.
        var mostFrequentSchoolNumber = families.SelectMany(family => family.SchoolNumbers)
                                               .GroupBy(number => number)
                                               .OrderByDescending(group => group.Count())
                                               .First().Key;

        // 4. Выдать ФИО детей, которые учились только в одной школе.
        var childrenAttendedOneSchool = families.Where(family => family.SchoolNumbers.Distinct().Count() == 1)
                                               .Select(family => family.FullName);

        // Вывод результатов
        Console.WriteLine("Родители с наибольшим количеством детей: " + parentsWithMostChildren);
        Console.WriteLine("Количество детей, родившихся в " + specifiedYear + " году: " + childrenBornInSpecifiedYear);
        Console.WriteLine("Номер школы, который чаще всего встречается: " + mostFrequentSchoolNumber);
        Console.WriteLine("Дети, учившиеся только в одной школе: " + string.Join(", ", childrenAttendedOneSchool));
    }
}
