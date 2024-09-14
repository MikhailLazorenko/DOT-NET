using System;
using System.Collections.Generic;

class task_04
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть розмір колекції: ");
        int size = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();
        Random rand = new Random();

        // Заповнення колекції випадковими значеннями від 0 до 100
        for (int i = 0; i < size; i++)
        {
            list.Add(rand.Next(0, 101));
        }

        // Знаходження безперервної ділянки з 10 елементів з максимальною сумою
        int maxSum = int.MinValue;
        int startIndex = 0;

        for (int i = 0; i <= list.Count - 10; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < 10; j++)
            {
                currentSum += list[i + j];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = i;
            }
        }

        // Виведення результатів з використанням кольорів
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Максимальна сума: " + maxSum);
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Початковий індекс ділянки: " + startIndex);
        Console.ResetColor();

        Console.WriteLine("Елементи ділянки: ");
        for (int i = startIndex; i < startIndex + 10; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(list[i] + " ");
            Console.ResetColor();
        }
        Console.ReadKey();
    }
}
