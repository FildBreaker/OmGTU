using System;
using System.Collections.Generic;

public class Car
{
    public int YearOfManufacture { get; set; }
    public string Color { get; set; }
    public string Brand { get; set; }
    public string OwnerFullName { get; set; }
    public int YearOfInspection { get; set; }

    public Car(int yearOfManufacture, string color, string brand, string ownerFullName, int yearOfInspection)
    {
        YearOfManufacture = yearOfManufacture;
        Color = color;
        Brand = brand;
        OwnerFullName = ownerFullName;
        YearOfInspection = yearOfInspection;
    }
}

public class CarProcessor
{
    private List<Car> cars = new List<Car>();

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public IEnumerable<Car> SelectByYear(int year)
    {
        foreach (var car in cars)
        {
            if (car.YearOfManufacture == year)
                yield return car;
        }
    }

    public IEnumerable<Car> SelectByBrand(string brand)
    {
        foreach (var car in cars)
        {
            if (car.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                yield return car;
        }
    }

    public IEnumerable<Car> SelectByYearOfInspection(int year)
    {
        foreach (var car in cars)
        {
            if (car.YearOfInspection == year)
                yield return car;
        }
    }

    public void PrintCars(IEnumerable<Car> selectedCars)
    {
        foreach (var car in selectedCars)
        {
            Console.WriteLine($"Год выпуска: {car.YearOfManufacture}, Цвет: {car.Color}, Марка: {car.Brand}, " +
                              $"ФИО владельца: {car.OwnerFullName}, Год прохождения тех. осмотра: {car.YearOfInspection}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CarProcessor carProcessor = new CarProcessor();

        // Добавим несколько машин для примера
        carProcessor.AddCar(new Car(2010, "Красный", "Toyota", "Иванов Иван Иванович", 2020));
        carProcessor.AddCar(new Car(2015, "Синий", "Honda", "Петров Петр Петрович", 2019));
        carProcessor.AddCar(new Car(2010, "Черный", "Toyota", "Сидоров Сидр Сидорович", 2021));

        Console.WriteLine("Выборка по году выпуска (2010):");
        carProcessor.PrintCars(carProcessor.SelectByYear(2010));

        Console.WriteLine("\nВыборка по марке (Toyota):");
        carProcessor.PrintCars(carProcessor.SelectByBrand("Toyota"));

        Console.WriteLine("\nВыборка по году прохождения тех. осмотра (2020):");
        carProcessor.PrintCars(carProcessor.SelectByYearOfInspection(2020));
    }
}
