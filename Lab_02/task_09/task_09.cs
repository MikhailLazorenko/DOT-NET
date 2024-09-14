using System;

class task_09
{
    static void Main()
    {
        Console.Write("Введіть розмір матриці: ");
        int n = int.Parse(Console.ReadLine());


        // Ініціалізація зубчастого масиву
        int[][] matrix = new int[n][];
        for (int i = 0; i < n; i++)
        {
            matrix[i] = new int[n];
        }

        int number = 1;

        for (int i = 0; i < n; i++)
        {
            int row = n - 1;
            int col = i;
            while (row >= 0 && col >= 0)
            {
                matrix[row][col] = number++;
                row--;
                col--;
            }
        }

        for (int j = 1; j < n; j++)
        {
            int row = n - 1 - j;
            int col = n - 1;
            while (row >= 0 && col >= 0)
            {
                matrix[row][col] = number++;
                row--;
                col--;
            }
        }

        // Виведення матриці
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i][j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }

        Console.Write("Введіть задану величину: ");
        double threshold = double.Parse(Console.ReadLine());

        // Підрахунок кількості рядків, середнє арифметичне яких менше за задану величину
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            double sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += matrix[i][j];
            }
            double average = sum / n;
            if (average < threshold)
            {
                count++;
            }
        }

        Console.WriteLine($"Кількість рядків, середнє арифметичне яких менше за {threshold}: {count}");
    }
}
