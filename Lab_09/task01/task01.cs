using System;
using System.Windows.Forms;

namespace Lab09
{
    public partial class task01 : Form
    {
        // Константа для курсу обміну
        private const double ExchangeRateUAHToMXN = 2.04;

        public task01()
        {
            InitializeComponent();
        }

        // Обробник для події KeyPress для перевірки введення цифр та коми
        private void textBox1_KeyPress()
        {
            // Перевіряємо, чи останній символ у текстовому полі - цифра або кома
            if (textBox1.Text.Length > 0 && !char.IsControl(textBox1.Text[textBox1.Text.Length - 1]) &&
                !char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]) &&
                textBox1.Text[textBox1.Text.Length - 1] != ',')
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1); // Видаляє некоректний символ
            }
            else if (textBox1.Text.Contains(",") &&
                     textBox1.Text.LastIndexOf(",") != textBox1.Text.Length - 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1); // Забороняє більше однієї коми
            }
        }

        // Обробник для події TextChanged для перевірки, чи поле не є порожнім
        private void textBox1_TextChanged()
        {
            buttonOK.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        // Обробник для кнопки OK для конвертації валюти
        private void buttonOK_Click()
        {
            if (double.TryParse(textBox1.Text, out double amountInUAH))
            {
                double amountInMXN = amountInUAH / ExchangeRateUAHToMXN;
                label2.Text = "Сума у песо: " + amountInMXN.ToString("F2");
            }
            else
            {
                MessageBox.Show("Введіть коректну суму у гривнях.");
            }
        }
    }
}
