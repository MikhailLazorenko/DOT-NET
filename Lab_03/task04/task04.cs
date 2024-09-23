using System;

class task04
{
    // Функція для заміни лапок на дві коми
    static string ReplaceQuotesWithCommas(string input)
    {
        // Замінюємо прямі лапки '"' на дві коми
        string result = input.Replace("\"", ",,");

        return result;
    }

    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть текстовий рядок:");
        string input = Console.ReadLine();

        // Викликаємо функцію для заміни лапок
        string modifiedInput = ReplaceQuotesWithCommas(input);

        // Виводимо результат
        Console.WriteLine($"Рядок після заміни лапок: {modifiedInput}");

        Console.ReadKey();
    }
}
