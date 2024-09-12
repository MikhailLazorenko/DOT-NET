using System;

class task_09
{
    static void Main()
    {
    	Console.InputEncoding = System.Text.Encoding.UTF8;
	Console.OutputEncoding = System.Text.Encoding.UTF8;

        double minX = 0;
        double maxX = 19.75;
        double step = 0.25;
        int width = 80; // Ширина графіка
        int height = 20; // Висота графіка

        char[,] graph = new char[height, width];

        // Ініціалізація графіка пробілами
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                graph[i, j] = ' ';
            }
        }

        // Обчислення значень функції та заповнення графіка
        for (double x = minX; x <= maxX; x += step)
        {
            double y = SawtoothWave(x);
            Console.WriteLine($"x = {x:F2}, y = {y:F2}");

            int graphX = (int)((x - minX) / (maxX - minX) * (width - 1));
            int graphY = (int)((y + 1) / 2 * (height - 1));
            graph[height - 1 - graphY, graphX] = '*';
        }

        // Виведення графіка на екран
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(graph[i, j]);
            }
            Console.WriteLine();
        }
    }

    static double SawtoothWave(double x)
    {
        return 2 * (x / 4.0 - Math.Floor(x / 4.0 + 0.5));
    }
}
