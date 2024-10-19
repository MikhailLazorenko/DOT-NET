using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Прив'язка обробника подій KeyDown до текстового поля
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        // Обробник події KeyDown
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Перевірка, чи натиснута клавіша є верхнім регістром з N до Z
            if (e.KeyCode >= Keys.N && e.KeyCode <= Keys.Z)
            {
                // Дозволяємо введення символа
                e.SuppressKeyPress = false; // Не скасовуємо натискання
            }
            else
            {
                // Якщо символ не відповідає умові, скасовуємо натискання
                e.SuppressKeyPress = true; // Скасовуємо натискання
            }
        }
    }
}
