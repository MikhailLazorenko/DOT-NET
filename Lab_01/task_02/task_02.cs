using System;

class task_02
{
    static void Main()
    {	
	Console.InputEncoding = System.Text.Encoding.UTF8;
	Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Налаштування кольорів для консолі
        Console.ForegroundColor = ConsoleColor.Yellow; // Колір для таблиці

        // Введення фактичних даних
        string name1, name2, name3;
        string producer1, producer2, producer3;
        ushort components1, components2, components3;
        float price1, price2, price3;

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green; // Колір для тексту
        Console.WriteLine("1. Введіть: назву, виробника, кількість складових частин, ціну > ");
        var input1 = Console.ReadLine().Split(' ');
        name1 = input1[0];
        producer1 = input1[1];
        components1 = ushort.Parse(input1[2]);
        price1 = float.Parse(input1[3]);

        Console.WriteLine("2. Введіть: назву, виробника, кількість складових частин, ціну > ");
        var input2 = Console.ReadLine().Split(' ');
        name2 = input2[0];
        producer2 = input2[1];
        components2 = ushort.Parse(input2[2]);
        price2 = float.Parse(input2[3]);

        Console.WriteLine("3. Введіть: назву, виробника, кількість складових частин, ціну > ");
        var input3 = Console.ReadLine().Split(' ');
        name3 = input3[0];
        producer3 = input3[1];
        components3 = ushort.Parse(input3[2]);
        price3 = float.Parse(input3[3]);

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow; // Повернення кольору таблиці

        // Верх таблиці
        Console.WriteLine("┌────────────┬────────────┬─────────────────┬─────────────┐");
        Console.WriteLine("│                       Офісні пакети                     │");
        Console.WriteLine("├────────────┼────────────┼─────────────────┼─────────────┤");
        Console.WriteLine("│   Назва    │  Виробник  │ К-сть складових │  Ціна ($)   │");
        Console.WriteLine("├────────────┼────────────┼─────────────────┼─────────────┤");

        // Виведення фактичних даних з використанням псевдографіки
        Console.WriteLine($"│ {name1,10} │ {producer1,10} │               {components1,2}│      {price1,7:0.00}│");
        Console.WriteLine($"│ {name2,10} │ {producer2,10} │               {components2,2}│      {price2,7:0.00}│");
        Console.WriteLine($"│ {name3,10} │ {producer3,10} │               {components3,2}│      {price3,7:0.00}│");

        // Нижня частина таблиці
        Console.WriteLine("├────────────┴────────────┴─────────────────┴─────────────┤");
        Console.WriteLine("│ Примітка: можливо безкоштовно отримати продукт          │");
        Console.WriteLine("│ StarOffice через Internet                               │");
        Console.WriteLine("└─────────────────────────────────────────────────────────┘");

        // Повернення кольору за замовчуванням
        Console.ResetColor();
    }
}
