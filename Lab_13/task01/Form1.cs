using System;
using System.Drawing;
using System.Windows.Forms;

namespace task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Отримуємо графічний контекст
            Graphics g = e.Graphics;

            // Визначаємо розміри PictureBox
            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;

            // Розміри прапора
            int flagWidth = width / 4;
            int flagHeight = height / 6;

            // Координати для лівого нижнього кута
            int x = 10; 
            int y = height - flagHeight - 10; 

            // Малюємо синю частину прапора
            g.FillRectangle(Brushes.Blue, x, y, flagWidth, flagHeight / 2);

            // Малюємо жовту частину прапора
            g.FillRectangle(Brushes.Yellow, x, y + flagHeight / 2, flagWidth, flagHeight / 2);
        }
    }
}
