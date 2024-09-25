using System;
using System.Collections.Generic;

// Клас автобуса
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

// Клас станції автобусів (агрегація)
public class BusStation
{
    private string stationName;                  // Назва станції
    private List<Bus> buses;                     // Список автобусів

    // Конструктор
    public BusStation(string stationName)
    {
        this.stationName = stationName;
        buses = new List<Bus>();
    }

    // Метод для додавання автобуса
    public void AddBus(Bus bus)
    {
        buses.Add(bus);
        Console.WriteLine($"Bus added: {bus.BusNumber}");
    }

    // Метод для видалення автобуса
    public void RemoveBus(int busNumber)
    {
        Bus busToRemove = buses.Find(b => b.BusNumber == busNumber);
        if (busToRemove != null)
        {
            buses.Remove(busToRemove);
            Console.WriteLine($"Bus removed: {busNumber}");
        }
        else
        {
            Console.WriteLine($"Bus {busNumber} not found.");
        }
    }

    // Метод для показу всіх автобусів на станції
    public void ShowBuses()
    {
        Console.WriteLine($"Buses at {stationName}:");
        foreach (var bus in buses)
        {
            bus.ShowInfo();
        }
    }
}

// Головна програма
class task04_1
{
    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        BusStation station = new BusStation("Central Bus Station");

        // Генерація списку автобусів
        List<Bus> busList = GenerateBusList(5);

        // Додавання автобусів до станції
        foreach (var bus in busList)
        {
            station.AddBus(bus);
        }

        // Відображення автобусів на станції
        station.ShowBuses();

        // Видалення автобуса
        Console.WriteLine("Enter bus number to remove:");
        int busNumberToRemove = int.Parse(Console.ReadLine());
        station.RemoveBus(busNumberToRemove);

        // Відображення автобусів на станції після видалення
        station.ShowBuses();

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
}
