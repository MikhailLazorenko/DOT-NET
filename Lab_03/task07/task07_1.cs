using System;
using System.IO;

class task07_1
{
    // Функція для визначення позиції слова в рядку
    static int FindWordPosition(string input, int wordNumber)
    {
        if (wordNumber <= 0)
        {
            return -1;
        }

        int currentWord = 0;
        int position = -1;

        for (int i = 0; i < input.Length; i++)
        {
            if ((i == 0 || input[i - 1] == ' ') && input[i] != ' ')
            {
                currentWord++;
                if (currentWord == wordNumber)
                {
                    position = i;
                    break;
                }
            }
        }

        return position;
    }

    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Читаємо вхідний рядок з файлу
        string input = File.ReadAllText("input.txt");

        // Читаємо номер слова з файлу
        int wordNumber = int.Parse(File.ReadAllText("word_number.txt"));

        // Знаходимо позицію слова
        int position = FindWordPosition(input, wordNumber);

        // Записуємо результат у файл
        string result = (position != -1) ? $"Позиція {wordNumber}-го слова: {position}" : "Слово з таким номером не знайдено.";
        File.WriteAllText("output.txt", result);

        Console.ReadKey();
    }
}
