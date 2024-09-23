using System;

class task05
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

        // Виводимо результат
        Console.WriteLine($"Кількість слів, що починаються на букву 'С': {count}");

        Console.ReadKey();
    }
}
