using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab09
{
    public partial class task04 : Form
    {
        public task04()
        {
            InitializeComponent();

            button1.Enabled = false; // Кнопка недоступна, поки поле пусте
            comboBox1.SelectedIndex = 0; // Встановлюємо напрямок конвертації за замовчуванням
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Перевірка на те, щоб у полі були лише цифри
            ValidateInput(textBox1);
            button1.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = ""; // Очищуємо результат при зміні напрямку
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double input))
            {
                if (comboBox1.SelectedIndex == 0) // Кілометри -> Лінки
                {
                    double result = input * 4970.9695378987;
                    label1.Text = $"{input} км = {result} лінків";
                }
                else if (comboBox1.SelectedIndex == 1) // Лінки -> Кілометри
                {
                    double result = input / 4970.9695378987;
                    label1.Text = $"{input} лінків = {result} км";
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть правильне числове значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateInput(System.Windows.Forms.TextBox textBox)
        {
            string input = textBox.Text;
            string filteredInput = string.Empty;
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    filteredInput += c;
                }
            }

            if (input != filteredInput)
            {
                textBox.Text = filteredInput;
                textBox.SelectionStart = filteredInput.Length;
            }
        }
    }
}
