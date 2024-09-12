using System;

class task_05
{
    static void Main()
    {
    	Console.InputEncoding = System.Text.Encoding.UTF8;
	Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть координати точки (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        if (IsPointInShadedArea(x, y))
        {
            Console.WriteLine("Точка потрапляє в заштриховану область.");
        }
        else
        {
            Console.WriteLine("Точка не потрапляє в заштриховану область.");
        }
    }

    static bool IsPointInShadedArea(double x, double y)
    {
        // Перевірка, чи точка знаходиться в верхній півколі з радіусом 1
        return (x * x + y * y <= 1) && (y >= 0);
    }
}
