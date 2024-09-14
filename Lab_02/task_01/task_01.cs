using System;

class task_01
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int[] array = new int[200];
        Random rand = new Random();

        // Заповнення масиву випадковими значеннями від 0 до 100
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(0, 101);
        }

        // Знаходження безперервної ділянки з 10 елементів з максимальною сумою
        int maxSum = int.MinValue;
        int startIndex = 0;

        for (int i = 0; i <= array.Length - 10; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < 10; j++)
            {
                currentSum += array[i + j];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = i;
            }
        }

        // Виведення результатів
        Console.WriteLine("Максимальна сума: " + maxSum);
        Console.WriteLine("Початковий індекс ділянки: " + startIndex);
        Console.WriteLine("Елементи ділянки: ");
        for (int i = startIndex; i < startIndex + 10; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.ReadKey();
    }
}
