using System;

class task_08
{
    static void Main()
    {
    	Console.InputEncoding = System.Text.Encoding.UTF8;
	Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Введення похибки та кількості членів ряду
        Console.Write("Введіть похибку: ");
        double epsilon = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть максимальну кількість членів ряду: ");
        int maxTerms = Convert.ToInt32(Console.ReadLine());

        double sum = 0.0;
        double term;
        int n = 0;

        // Обчислення суми членів ряду з заданою похибкою або кількістю членів
        do
        {
            term = Math.Pow(-1, n) * ((n + 1) / (Math.Pow(2, n - 1)));
            sum += term;
            n++;
        } while (Math.Abs(term) > epsilon && n < maxTerms);

        // Видача відповідного повідомлення
        if (Math.Abs(term) <= epsilon)
        {
            Console.WriteLine("Сума членів ряду з точністю до " + epsilon + ": " + sum);
        }
        else
        {
            Console.WriteLine("Досягнуто максимальну кількість членів ряду (" + maxTerms + "): " + sum);
        }

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
