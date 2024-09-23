using System;
using System.Linq;
using System.Text.RegularExpressions;

class task06
{
    // Функція для перевірки, чи закінчується слово на голосну
    static bool EndsWithVowel(string word)
    {
        char[] vowels = { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я', 'А', 'Е', 'Є', 'И', 'І', 'Ї', 'О', 'У', 'Ю', 'Я' };
        return vowels.Contains(word.Last());
    }

    // Функція для перевірки, чи містить слово латинські літери
    static bool ContainsLatinLetters(string word)
    {
        return word.Any(c => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));
    }

    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть текстовий рядок:");
        string input = Console.ReadLine();

        // Розбиваємо текст на слова за пробілами
        string[] words = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        // а) Підраховуємо кількість слів, що закінчуються на голосну літеру
        int vowelEndingCount = words.Count(EndsWithVowel);
        Console.WriteLine($"Кількість слів, що закінчуються на голосну літеру: {vowelEndingCount}");

        // б) Виводимо всі слова, довжина яких менша за 5 символів
        Console.WriteLine("Слова довжиною менше 5 символів:");
        foreach (string word in words.Where(w => w.Length < 5))
        {
            Console.WriteLine(word);
        }

        // в) Видаляємо всі слова, що містять латинські літери
        string[] filteredWords = words.Where(w => !ContainsLatinLetters(w)).ToArray();
        string result = string.Join(" ", filteredWords);

        Console.WriteLine($"Текст без слів, що містять латинські літери: {result}");

        Console.ReadKey();
    }
}
