using System;

class task_08
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть розмір матриці: ");
        int n = int.Parse(Console.ReadLine());
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

        // Виведення матриці з кольоровими елементами
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Парні числа зеленим кольором
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Непарні числа червоним кольором
                }
                Console.Write(matrix[i][j].ToString("D2") + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
