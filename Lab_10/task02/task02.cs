using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab10
{
    public partial class task02 : Form
    {
        private List<string> images;
        private int currentIndex;

        public task02()
        {
            InitializeComponent();
            // Ініціалізація списку зображень та встановлення початкового індексу
            images = new List<string>();
            currentIndex = 0;
        }

        // Метод для вибору папки із зображеннями
        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    images.Clear();
                    // Формати зображень, які підтримує програма
                    string[] supportedExtensions = { "*.jpg", "*.png", "*.bmp", "*.gif", "*.tiff" };
                    foreach (var ext in supportedExtensions)
                    {
                        images.AddRange(Directory.GetFiles(dialog.SelectedPath, ext));
                    }
                    currentIndex = 0;
                    ShowImage();
                }
            }
        }

        // Метод для переходу до наступного зображення
        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % images.Count;
            ShowImage();
        }

        // Метод для переходу до попереднього зображення
        private void button3_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            ShowImage();
        }

        // Метод для запуску автоматичного перегляду слайд-шоу
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // Метод для зупинки автоматичного перегляду слайд-шоу
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // Метод для зміни швидкості слайд-шоу за допомогою повзунка
        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            int speedValue = trackBarSpeed.Value;
            timer1.Interval = speedValue * 100;
            labelSpeedValue.Text = $"Швидкість: {speedValue}";
        }

        // Метод, що виконується при спрацьовуванні таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % images.Count;
            ShowImage();
        }

        // Метод для відображення зображення з поточного індексу
        private void ShowImage()
        {
            if (images.Count > 0)
            {
                // Завантаження зображення в pictureBox для відображення
                pictureBox1.Image = Image.FromFile(images[currentIndex]);
            }
        }
    }
}
