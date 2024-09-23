using System;
using System.IO;

class task07_2
{
    // Функція для переведення десяткового рядка в шістнадцятковий формат
    static string DecimalToHexadecimal(string decimalString)
    {
        try
        {
            int decimalNumber = int.Parse(decimalString);
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

        // Читаємо десяткове число з файлу
        string input = File.ReadAllText("input.txt");

        // Перетворюємо на шістнадцяткове
        string hexResult = DecimalToHexadecimal(input);

        // Записуємо результат у файл
        File.WriteAllText("output.txt", $"Шістнадцяткове подання: {hexResult}");

        Console.ReadKey();
    }
}
