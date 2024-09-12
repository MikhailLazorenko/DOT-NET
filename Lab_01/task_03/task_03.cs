using System;

class task_03
{
    static void Main()
    {
    	Console.InputEncoding = System.Text.Encoding.UTF8;
	Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Початкові значення змінних
        double a = 2.0;
        double b = 3.0;

        // Введення значень x і y з клавіатури
        Console.Write("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Обчислення t1 і t2
        double t1 = (1 / Math.Pow(b, 2)) * (Math.Pow(Math.Log(x), 2) + (a * x / y));
        double t2 = (x / a) - Math.Tan(a * x / 2) + (2 / Math.Pow(a, 2)) * Math.Log(Math.Sin(a * x / 2));

        // Виведення результатів
        Console.WriteLine($"t1 = {t1}");
        Console.WriteLine($"t2 = {t2}");
    }
}
