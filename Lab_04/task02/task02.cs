using System;
using System.Collections.Generic;

// 1. Абстрактний клас Transport, що є предком для інших класів 
public abstract class Transport
{
    public string DriverName { get; set; }  // Прізвище та ініціали водія
    public int TransportNumber { get; set; }  // Номер транспортного засобу
    public string Brand { get; set; }  // Марка транспортного засобу

    public Transport(string driverName, int transportNumber, string brand)
    {
        DriverName = driverName;
        TransportNumber = transportNumber;
        Brand = brand;
    }

    public abstract void ShowInfo();  // Абстрактний метод для виведення інформації
}

// 2. Клас Bus, який є спадкоємцем першого рівня від Transport 
public class Bus : Transport
{
    public int RouteNumber { get; set; }  // Номер маршруту
    public int YearOfStart { get; set; }  // Рік початку експлуатації
    public double Mileage { get; set; }  // Пробіг

    public Bus(string driverName, int busNumber, int routeNumber, string brand, int yearOfStart, double mileage)
        : base(driverName, busNumber, brand)
    {
        RouteNumber = routeNumber;
        YearOfStart = yearOfStart;
        Mileage = mileage;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Bus - Driver: {DriverName}, Number: {TransportNumber}, Route: {RouteNumber}, Brand: {Brand}, Year: {YearOfStart}, Mileage: {Mileage} km");
    }

    // Метод для перевірки, чи автобус експлуатується понад 10 років
    public bool IsOver10Years()
    {
        return (DateTime.Now.Year - YearOfStart) > 10;
    }

    // Метод для перевірки, чи пробіг автобуса більше 10 000 км
    public bool IsMileageOver10000()
    {
        return Mileage > 10000;
    }
}

// 2. Клас Truck, який є спадкоємцем першого рівня від Transport (додано відповідні поля та методи)
public class Truck : Transport
{
    public double LoadCapacity { get; set; }  // Вантажопідйомність

    public Truck(string driverName, int truckNumber, string brand, double loadCapacity)
        : base(driverName, truckNumber, brand)
    {
        LoadCapacity = loadCapacity;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Truck - Driver: {DriverName}, Number: {TransportNumber}, Brand: {Brand}, Load Capacity: {LoadCapacity} tons");
    }
}

// 2. Клас Taxi, який є спадкоємцем першого рівня від Transport (додано відповідні поля та методи)
public class Taxi : Transport
{
    public string LicenseNumber { get; set; }  // Номер ліцензії

    public Taxi(string driverName, int taxiNumber, string brand, string licenseNumber)
        : base(driverName, taxiNumber, brand)
    {
        LicenseNumber = licenseNumber;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Taxi - Driver: {DriverName}, Number: {TransportNumber}, Brand: {Brand}, License Number: {LicenseNumber}");
    }
}

// 3. Клас ElectricBus, що є спадкоємцем другого рівня від Bus (додано додаткові поля та методи)
public class ElectricBus : Bus
{
    public int BatteryCapacity { get; set; }  // Ємність батареї у кВт·год

    public ElectricBus(string driverName, int busNumber, int routeNumber, string brand, int yearOfStart, double mileage, int batteryCapacity)
        : base(driverName, busNumber, routeNumber, brand, yearOfStart, mileage)
    {
        BatteryCapacity = batteryCapacity;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Electric Bus - Driver: {DriverName}, Number: {TransportNumber}, Route: {RouteNumber}, Brand: {Brand}, Year: {YearOfStart}, Mileage: {Mileage} km, Battery: {BatteryCapacity} kWh");
    }
}

// 3. Клас HybridBus, що є спадкоємцем другого рівня від Bus (додано додаткові поля та методи)
public class HybridBus : Bus
{
    public double FuelEfficiency { get; set; } // Ефективність використання пального (л/100 км)

    public HybridBus(string driverName, int busNumber, int routeNumber, string brand, int yearOfStart, double mileage, double fuelEfficiency)
        : base(driverName, busNumber, routeNumber, brand, yearOfStart, mileage)
    {
        FuelEfficiency = fuelEfficiency;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Hybrid Bus - Driver: {DriverName}, Number: {TransportNumber}, Route: {RouteNumber}, Brand: {Brand}, Year: {YearOfStart}, Mileage: {Mileage} km, Fuel Efficiency: {FuelEfficiency} l/100km");
    }
}

// Основна програма
class task02
{
    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 4. Створення масиву об'єктів усіх рівнів спадкування (поліморфний список)
        List<Transport> transports = new List<Transport>
        {
            new Bus("Ivanov I.I.", 101, 5, "Mercedes", 2005, 15000),
            new Truck("Petrov P.P.", 202, "Volvo", 12),
            new Taxi("Sidorov S.S.", 303, "Toyota", "AB123CD"),
            new ElectricBus("Kuznetsov K.K.", 404, 2, "Tesla", 2019, 5000, 85),
            new HybridBus("Smirnov A.A.", 505, 3, "Volvo", 2010, 12000, 5.5)
        };

        // 4. Виконання функцій над поліморфним списком
        // Вивести інформацію про всі транспортні засоби
        Console.WriteLine("All transport information:");
        foreach (var transport in transports)
        {
            transport.ShowInfo();
        }

        // Вивести тільки автобуси, що експлуатуються понад 10 років
        Console.WriteLine("\nBuses over 10 years in operation:");
        foreach (var transport in transports)
        {
            if (transport is Bus bus && bus.IsOver10Years())
            {
                bus.ShowInfo();
            }
        }

        // Вивести автобуси з пробігом більше 10 000 км
        Console.WriteLine("\nBuses with mileage over 10,000 km:");
        foreach (var transport in transports)
        {
            if (transport is Bus bus && bus.IsMileageOver10000())
            {
                bus.ShowInfo();
            }
            Console.ReadKey();
        }
    }
}
