using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab10
{
    public partial class task05 : Form
    {
        private int seconds = 0;
        private int minutes = 0;
        private bool isRunning = false;
        private bool sizeToggled = false;
        private int originalWidth;
        private int originalHeight;

        public task05()
        {
            InitializeComponent();
            originalWidth = this.Width;
            originalHeight = this.Height;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                timer.Start();
                isRunning = true;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                isRunning = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }

            label1.Text = minutes.ToString("D2");
            label3.Text = seconds.ToString("D2");

            // Кожні 5 секунд змінюємо розмір форми
            if ((minutes * 60 + seconds) % 5 == 0)
            {
                ToggleFormSize();
            }
        }

        private void ToggleFormSize()
        {
            if (sizeToggled)
            {
                this.Width = originalWidth;
                this.Height = originalHeight;
            }
            else
            {
                this.Width = originalWidth + 50; // Збільшуємо ширину на 50 пікселів
                this.Height = originalHeight + 50; // Збільшуємо висоту на 50 пікселів
            }
            sizeToggled = !sizeToggled;
        }
    }
}
