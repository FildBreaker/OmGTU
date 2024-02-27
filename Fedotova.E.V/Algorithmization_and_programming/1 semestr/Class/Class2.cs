using System;
using System.Collections.Generic;

public class Car
{
    public string Name { get; set; }
    public int Year { get; set; }
    public List<string> Owners { get; set; }
    public List<int> TechnicalInspectionYears { get; set; }
    public string Color { get; set; }
    public string EngineNumber { get; set; }

    public Car(string name, int year, List<string> owners, List<int> technicalInspectionYears, string color, string engineNumber)
    {
        Name = name;
        Year = year;
        Owners = owners;
        TechnicalInspectionYears = technicalInspectionYears;
        Color = color;
        EngineNumber = engineNumber;
    }
}

public class Program
{
    public static List<string> GetOwnersOfCar(Car car)
    {
        return car.Owners;
    }

    public static List<Car> GetCarsByTechnicalInspectionYear(List<Car> cars, int year)
    {
        List<Car> carsByYear = new List<Car>();
        foreach (var car in cars)
        {
            if (car.TechnicalInspectionYears.Contains(year))
            {
                carsByYear.Add(car);
            }
        }
        return carsByYear;
    }

    public static List<Car> GetCarsWithSingleOwner(List<Car> cars)
    {
        List<Car> carsWithSingleOwner = new List<Car>();
        foreach (var car in cars)
        {
            if (car.Owners.Count == 1)
            {
                carsWithSingleOwner.Add(car);
            }
        }
        return carsWithSingleOwner;
    }

    public static void Main()
    {
        // Пример использования
        List<Car> cars = new List<Car>
        {
            new Car("Car1", 2010, new List<string>{"Owner1", "Owner2"}, new List<int>{2018, 2019, 2020}, "Red", "1234"),
            new Car("Car2", 2008, new List<string>{"Owner3"}, new List<int>{2019, 2020}, "Blue", "5678"),
            new Car("Car3", 2015, new List<string>{"Owner4", "Owner5", "Owner6"}, new List<int>{2020}, "Black", "91011")
        };

        var ownersOfCar1 = GetOwnersOfCar(cars[0]);
        Console.WriteLine("Owners of Car1: " + string.Join(", ", ownersOfCar1));

        var carsByYear2020 = GetCarsByTechnicalInspectionYear(cars, 2020);
        Console.WriteLine("Cars with technical inspection in 2020: ");
        foreach (var car in carsByYear2020)
        {
            Console.WriteLine(car.Name);
        }

        var carsWithSingleOwner = GetCarsWithSingleOwner(cars);
        Console.WriteLine("Cars with only one owner: ");
        foreach (var car in carsWithSingleOwner)
        {
            Console.WriteLine(car.Name);
        }
    }
}
