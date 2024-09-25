using System;
using System.Collections.Generic;

public class Bus
{
    private string driverName;    // Прізвище та ініціали водія
    private int busNumber;        // Номер автобуса
    private int routeNumber;      // Номер маршруту
    private string brand;         // Марка автобуса
    private int yearOfStart;      // Рік початку експлуатації
    private double mileage;       // Пробіг

    // Конструктор
    public Bus(string driverName, int busNumber, int routeNumber, string brand, int yearOfStart, double mileage)
    {
        this.driverName = driverName;
        this.busNumber = busNumber;
        this.routeNumber = routeNumber;
        this.brand = brand;
        this.yearOfStart = yearOfStart;
        this.mileage = mileage;
    }

    // Методи set та get
    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }

    public int BusNumber
    {
        get { return busNumber; }
        set { busNumber = value; }
    }

    public int RouteNumber
    {
        get { return routeNumber; }
        set { routeNumber = value; }
    }

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public int YearOfStart
    {
        get { return yearOfStart; }
        set { yearOfStart = value; }
    }

    public double Mileage
    {
        get { return mileage; }
        set { mileage = value; }
    }

    // Метод для відображення інформації про автобус
    public void ShowInfo()
    {
        Console.WriteLine($"Driver: {driverName}, Bus Number: {busNumber}, Route Number: {routeNumber}, Brand: {brand}, Year of Start: {yearOfStart}, Mileage: {mileage} km");
    }

    // Додатковий метод 1: Чи експлуатується автобус понад 10 років
    public bool IsOver10Years()
    {
        return (DateTime.Now.Year - yearOfStart) > 10;
    }

    // Додатковий метод 2: Чи перевищує пробіг 10 000 км
    public bool IsMileageOver10000()
    {
        return mileage > 10000;
    }
}

class task01
{
    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<Bus> busList = GenerateBusList(10);

        // Вивести список автобусів для заданого номера маршруту
        Console.WriteLine("Enter the route number to filter buses:");
        int routeNumber = int.Parse(Console.ReadLine());
        ShowBusesByRoute(busList, routeNumber);

        // Вивести список автобусів, які експлуатуються понад 10 років
        Console.WriteLine("\nBuses over 10 years in operation:");
        ShowBusesOver10Years(busList);

        // Вивести список автобусів, пробіг яких більше 10 000 км
        Console.WriteLine("\nBuses with mileage over 10,000 km:");
        ShowBusesWithMileageOver10000(busList);

        Console.ReadKey();
    }

    // Метод для генерації списку автобусів
    static List<Bus> GenerateBusList(int count)
    {
        var random = new Random();
        var busList = new List<Bus>();
        string[] driverNames = { "Ivanov I.I.", "Petrov P.P.", "Sidorov S.S.", "Kuznetsov K.K." };
        string[] brands = { "Mercedes", "Volvo", "Ikarus", "MAN" };

        for (int i = 0; i < count; i++)
        {
            string driverName = driverNames[random.Next(driverNames.Length)];
            int busNumber = random.Next(100, 999);
            int routeNumber = random.Next(1, 10);
            string brand = brands[random.Next(brands.Length)];
            int yearOfStart = random.Next(1995, DateTime.Now.Year);
            double mileage = random.Next(5000, 20000);

            busList.Add(new Bus(driverName, busNumber, routeNumber, brand, yearOfStart, mileage));
        }

        return busList;
    }

    // Метод для виведення автобусів за номером маршруту
    static void ShowBusesByRoute(List<Bus> buses, int routeNumber)
    {
        foreach (var bus in buses)
        {
            if (bus.RouteNumber == routeNumber)
            {
                bus.ShowInfo();
            }
        }
    }

    // Метод для виведення автобусів, які експлуатуються понад 10 років
    static void ShowBusesOver10Years(List<Bus> buses)
    {
        foreach (var bus in buses)
        {
            if (bus.IsOver10Years())
            {
                bus.ShowInfo();
            }
        }
    }

    // Метод для виведення автобусів з пробігом більше 10 000 км
    static void ShowBusesWithMileageOver10000(List<Bus> buses)
    {
        foreach (var bus in buses)
        {
            if (bus.IsMileageOver10000())
            {
                bus.ShowInfo();
            }
        }
    }
}
