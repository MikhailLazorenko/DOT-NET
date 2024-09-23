using System;

class task01
{
    // Функція для визначення позиції слова в рядку
    static int FindWordPosition(string input, int wordNumber)
    {

        if (wordNumber <= 0)
        {
            Console.WriteLine("Некоректний номер слова.");
            return -1;
        }

        int currentWord = 0; // Лічильник слів
        int position = -1;   // Позиція потрібного слова

        for (int i = 0; i < input.Length; i++)
        {
            // Якщо знайдено початок слова
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

        if (position == -1)
        {
            Console.WriteLine("Слово з таким номером не знайдено.");
        }

        return position;
    }

    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        Console.WriteLine("Введіть номер слова:");
        int wordNumber = int.Parse(Console.ReadLine());

        int position = FindWordPosition(input, wordNumber);

        if (position != -1)
        {
            Console.WriteLine($"Позиція {wordNumber}-го слова: {position}");
        }
        Console.ReadKey();
    }
}
