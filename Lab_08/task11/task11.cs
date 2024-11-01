using System;
using System.Windows.Forms;

namespace Lab08
{
    public partial class task11 : Form
    {
        private bool isLarge = false; // Стан для перемикання

        public task11()
        {
            InitializeComponent();
            timer1.Start(); // Запуск таймера
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Перемикання між розмірами кнопки
            if (isLarge)
            {
                button1.Size = new System.Drawing.Size(100, 50); // Малий розмір
            }
            else
            {
                button1.Size = new System.Drawing.Size(200, 100); // Великий розмір
            }
            isLarge = !isLarge; // Зміна стану
        }
    }
}
