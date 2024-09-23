using System;
using System.IO;

class task08_1
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

        // Записуємо результат у двійковий файл
        using (FileStream fs = new FileStream("output.dat", FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(modifiedInput);
        }

        // Читаємо вміст двійкового файлу і виводимо на екран
        using (FileStream fs = new FileStream("output.dat", FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            string fileContent = reader.ReadString();
            Console.WriteLine($"Рядок після заміни лапок (з файлу): {fileContent}");
        }

        Console.ReadKey();
    }
}
