using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab10
{
    public partial class task06 : Form
    {
        private int seconds = 0;
        private int minutes = 0;
        private bool isRunning = false;
        private bool sizeToggled = false;
        private int originalWidth;
        private int originalHeight;

        public task06()
        {
            InitializeComponent();
            originalWidth = this.Width;
            originalHeight = this.Height;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Якщо таймер не запущений, запускаємо його, беручи значення хвилин та секунд із компонентів NumericUpDown
            if (!isRunning)
            {
                minutes = (int)numericUpDown1.Value;  // Встановлюємо хвилини з поля NumericUpDown1
                seconds = (int)numericUpDown2.Value;  // Встановлюємо секунди з поля NumericUpDown2
                timer.Start();
                isRunning = true;
                startButton.Text = "Зупинити"; // Міняємо текст на кнопці
            }
            else
            {
                timer.Stop();
                isRunning = false;
                startButton.Text = "Старт";  // Повертаємо текст кнопки на "Старт"
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (seconds > 0 || minutes > 0) // Зменшуємо таймер до нуля
            {
                if (seconds == 0)
                {
                    if (minutes > 0)
                    {
                        minutes--;
                        seconds = 59;
                    }
                }
                else
                {
                    seconds--;
                }

                label1.Text = minutes.ToString("D2");
                label3.Text = seconds.ToString("D2");
            }
            else
            {
                // Якщо таймер закінчився, зупиняємо його і змінюємо текст на кнопці
                timer.Stop();
                isRunning = false;
                startButton.Text = "Старт";
            }

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
