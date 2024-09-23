using System;

class task02
{
    // Функція для переведення десяткового рядка в шістнадцятковий формат
    static string DecimalToHexadecimal(string decimalString)
    {
        try
        {
            // Перетворюємо рядок на ціле число
            int decimalNumber = int.Parse(decimalString);

            // Перетворюємо число на шістнадцяткове представлення
            string hexString = decimalNumber.ToString("X");

            return hexString;
        }
        catch (FormatException)
        {
            return "Помилка: Введений рядок не є коректним числом.";
        }
        catch (OverflowException)
        {
            return "Помилка: Число занадто велике для обробки.";
        }
    }

    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть десяткове число:");
        string input = Console.ReadLine();

        // Викликаємо функцію для перетворення
        string hexResult = DecimalToHexadecimal(input);

        // Виводимо результат
        Console.WriteLine($"Шістнадцяткове подання: {hexResult}");

        Console.ReadKey();
    }
}
