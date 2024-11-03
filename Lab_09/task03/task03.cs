using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Lab09
{
    public partial class task03 : Form
    {
        public task03()
        {
            InitializeComponent();

            // Налаштування для текстового поля та кнопки
            textBox1.TextChanged += (s, e) => TextBox1_TextChanged(); // Виклик обробника TextChanged без sender
            button1.Enabled = false; // Початково кнопка недоступна
        }

        private void TextBox1_TextChanged()
        {
            // Видаляємо всі символи, які не є цифрами
            string input = textBox1.Text;
            string filteredInput = string.Empty;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    filteredInput += c;
                }
            }

            if (input != filteredInput)
            {
                textBox1.Text = filteredInput;
                textBox1.SelectionStart = filteredInput.Length; // Переміщуємо курсор в кінець тексту
            }

            // Кнопка "OK" стає доступною, коли поле не порожнє
            button1.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        private void Button1_Click()
        {
            // Отримуємо значення в кілометрах
            if (double.TryParse(textBox1.Text, out double kilometers))
            {
                // Формула для конвертації кілометрів у лінки
                double links = kilometers * 4970.9695378987;
                label1.Text = $"{kilometers} км = {links} лінків";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть правильне значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
