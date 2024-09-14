using System;

class task_05
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int n = 9;
        int[,] matrix = new int[n, n];
        int number = 1;

        // Заповнення матриці лінійною послідовністю чисел (ЛПЧ) від лівого нижнього кута по діагоналі вліво-вгору
        for (int i = 0; i < n; i++)
        {
            int row = n - 1;
            int col = i;
            while (row >= 0 && col >= 0)
            {
                matrix[row, col] = number++;
                row--;
                col--;
            }
        }

        // Заповнення залишкових діагоналей
        for (int j = 1; j < n; j++)
        {
            int row = n - 1 - j;
            int col = n - 1;
            while (row >= 0 && col >= 0)
            {
                matrix[row, col] = number++;
                row--;
                col--;
            }
        }

        // Виведення матриці
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
