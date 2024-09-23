using System;
using System.IO;

class task08_2
{
    // Функція для підрахунку кількості слів, що починаються на букву 'С' або 'с'
    static int CountWordsStartingWithS(string input)
    {
        int count = 0;

        // Розбиваємо рядок на слова за пробілами
        string[] words = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        // Перевіряємо кожне слово
        foreach (string word in words)
        {
            if (word.Length > 0 && (word[0] == 'С' || word[0] == 'с'))
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

        Console.WriteLine("Введіть текстовий рядок:");
        string input = Console.ReadLine();

        // Викликаємо функцію для підрахунку слів, що починаються на 'С' або 'с'
        int count = CountWordsStartingWithS(input);

        // Записуємо результат у двійковий файл
        using (FileStream fs = new FileStream("output.dat", FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write($"Кількість слів, що починаються на букву 'С': {count}");
        }

        // Читаємо вміст двійкового файлу і виводимо на екран
        using (FileStream fs = new FileStream("output.dat", FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            string fileContent = reader.ReadString();
            Console.WriteLine($"Результат (з файлу): {fileContent}");
        }

        Console.ReadKey();
    }
}
