using System;
using System.Drawing;
using System.Windows.Forms;

namespace task08
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

            // Дані для діаграми
            string[] labels = { "Вода - 60%", "Білки - 20%", "Жири - 15%", "Вуглеводи та інші речовини - 5%" };
            float[] values = { 3f / 5f, 1f / 5f, 3f / 20f, 1f / 20f };

            // Кольори для кожного сегмента
            Brush[] brushes = {
                Brushes.LightBlue, // Вода
                Brushes.LightGreen, // Білки
                Brushes.Orange, // Жири
                Brushes.Purple // Вуглеводи та інші
            };

            // Центр і радіус діаграми
            int centerX = ClientSize.Width / 3;
            int centerY = ClientSize.Height / 2;
            int radius = 100;

            // Початковий кут
            float startAngle = 0;

            // Малювання кругової діаграми
            for (int i = 0; i < values.Length; i++)
            {
                // Кут для поточного сегмента
                float sweepAngle = values[i] * 360;

                // Малюємо сегмент
                g.FillPie(brushes[i], centerX - radius, centerY - radius, 2 * radius, 2 * radius, startAngle, sweepAngle);

                // Переходимо до наступного сегмента
                startAngle += sweepAngle;
            }

            // Легенда
            int legendX = centerX + radius + 50;
            int legendY = centerY - radius;

            for (int i = 0; i < labels.Length; i++)
            {
                // Малюємо прямокутник кольору сегмента
                g.FillRectangle(brushes[i], legendX, legendY + i * 30, 20, 20);

                // Підпис для сегмента
                g.DrawString(labels[i], new Font("Arial", 10), Brushes.Black, legendX + 30, legendY + i * 30);
            }

            // Заголовок
            g.DrawString("Склад маси людського організму:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, centerX - radius, centerY - radius - 50);
        }
    }
}
