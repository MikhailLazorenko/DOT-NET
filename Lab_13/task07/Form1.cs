using System;
using System.Drawing;
using System.Windows.Forms;

namespace task07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Параметри області малювання
            int margin = 50; // Відступи
            int width = ClientSize.Width - 2 * margin;
            int height = ClientSize.Height - 2 * margin;

            // Параметри осей
            Pen axisPen = new Pen(Color.Black, 2);

            // Малюємо осі
            g.DrawLine(axisPen, margin, height + margin, margin, margin); // Y-axis
            g.DrawLine(axisPen, margin, height + margin, width + margin, height + margin); // X-axis

            // Малювання сітки
            Pen gridPen = new Pen(Color.LightBlue, 1);
            for (int i = 1; i <= 10; i++)
            {
                // Вертикальні лінії
                int x = margin + i * (width / 10);
                g.DrawLine(gridPen, x, margin, x, height + margin);

                // Горизонтальні лінії
                int y = margin + i * (height / 10);
                g.DrawLine(gridPen, margin, y, width + margin, y);
            }

            // Параметри функції
            double minX = 0;
            double maxX = 20;
            double step = 0.25;

            // Масштабування
            float scaleX = (float)width / (float)(maxX - minX);
            float scaleY = (float)height / 4.0f; // Діапазон Y: від -2 до 2

            // Координати для побудови графіка
            PointF[] points = new PointF[(int)((maxX - minX) / step) + 1];
            int index = 0;

            for (double x = minX; x <= maxX; x += step)
            {
                double y = SawtoothWave(x);

                // Перетворення координат в область малювання
                float graphX = margin + (float)((x - minX) * scaleX);
                float graphY = height + margin - (float)((y + 2) * scaleY); // Y зміщений на 2

                points[index++] = new PointF(graphX, graphY);
            }

            // Малювання графіка
            Pen graphPen = new Pen(Color.Black, 2);
            g.DrawLines(graphPen, points);
        }

        // Обчислення пилкоподібної хвилі
        private double SawtoothWave(double x)
        {
            return 2 * (x / 4.0 - Math.Floor(x / 4.0 + 0.5));
        }
    }
}
