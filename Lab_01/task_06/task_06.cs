using System;

class task_06
{
    static void Main()
    {
    	Console.InputEncoding = System.Text.Encoding.UTF8;
	Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть координати точки (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        // Використовуємо тернарний оператор для визначення результату
        string result = (x * x + y * y <= 1) && (y >= 0) ? "Точка потрапляє в заштриховану область." : "Точка не потрапляє в заштриховану область.";

        Console.WriteLine(result);
    }
}
