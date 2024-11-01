using System;
using System.Windows.Forms;

namespace Lab08
{
    public partial class task12 : Form
    {
        // Змінна для визначення стану розміру кнопки
        private bool isLarge = false;

        public task12()
        {
            InitializeComponent(); 
        }

        // Подія таймера: змінює розмір кнопки при кожному тіку
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isLarge)
            {
                button1.Size = new System.Drawing.Size(100, 50); // Встановлення малого розміру
            }
            else
            {
                button1.Size = new System.Drawing.Size(200, 100); // Встановлення великого розміру
            }
            isLarge = !isLarge; // Перемикання стану розміру кнопки
        }

        // Запуск таймера
        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // Зупинка таймера
        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // Подія для зміни значення інтервалу: оновлює інтервал таймера
        private void IntervalSelector_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)intervalSelector.Value; 
        }
    }
}
