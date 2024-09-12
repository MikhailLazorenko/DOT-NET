using System;

class task_04
{
    static void Main()
    {
    	Console.InputEncoding = System.Text.Encoding.UTF8;
	Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Початкові значення змінних
        double a = 2.0;
        double b = 3.0;

        try
        {
            // Введення значень x і y з клавіатури
            Console.Write("Введіть значення x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть значення y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Перевірка на некоректні значення
            if (y == 0)
            {
                throw new DivideByZeroException("Значення y не може бути нулем.");
            }
            if (x <= 0)
            {
                throw new ArgumentException("Значення x повинно бути більше нуля для обчислення логарифму.");
            }

            // Обчислення t1 і t2
            double t1 = (1 / Math.Pow(b, 2)) * (Math.Pow(Math.Log(x), 2) + (a * x / y));
            double t2 = (x / a) - Math.Tan(a * x / 2) + (2 / Math.Pow(a, 2)) * Math.Log(Math.Sin(a * x / 2));

            // Виведення результатів
            Console.WriteLine($"t1 = {t1}");
            Console.WriteLine($"t2 = {t2}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Невідома помилка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Програма завершила роботу.");
        }
    }
}
