using System;

class task_07
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
	Console.OutputEncoding = System.Text.Encoding.UTF8;

        double epsilon = 0.000001;
        double sum = 0.0;
        double term;
        int n = 0;

        // Обчислення суми членів ряду з точністю до 0.000001
        do
        {
            term = Math.Pow(-1, n) * ((n + 1) / (Math.Pow(2, n-1)));
            sum += term;
            n++;
        } while (Math.Abs(term) > epsilon);

        Console.WriteLine("Сума членів ряду з точністю до 0.000001: " + sum);

        // Обчислення суми перших 10 членів ряду
        sum = 0.0;
        for (n = 0; n < 10; n++)
        {
            term = Math.Pow(-1, n) * ((n + 1) / (Math.Pow(2, n - 1)));
            sum += term;
        }

        Console.WriteLine("Сума перших 10 членів ряду: " + sum);
    }
}
