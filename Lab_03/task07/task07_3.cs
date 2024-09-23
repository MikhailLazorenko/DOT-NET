using System;
using System.IO;

class task07_3
{
    // Функція для підрахунку кількості літер 'м'
    static int CountLetterM(string input)
    {
        int count = 0;

        // Перебираємо кожен символ у рядку
        foreach (char c in input)
        {
            // Перевіряємо, чи є символ буквою 'м' (враховуємо як малу, так і велику літеру)
            if (c == 'м' || c == 'М')
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Читаємо вхідний текст з файлу
        string input = File.ReadAllText("input.txt");

        // Викликаємо функцію для підрахунку
        int count = CountLetterM(input);

        // Записуємо результат у файл
        File.WriteAllText("output.txt", $"Кількість букв 'м' у рядку: {count}");

        Console.ReadKey();
    }
}
