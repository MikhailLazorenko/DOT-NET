using System;
using System.Windows.Forms;

namespace Lab09
{
    public partial class task02 : Form
    {
        // Константа для курсу обміну
        private const double ExchangeRateUAHToMXN = 2.04;

        public task02()
        {
            InitializeComponent();
        }

        // Обробник для події KeyPress для перевірки введення цифр та коми
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Запобігає введенню некоректного символу
            }
            else if (textBox1.Text.Contains(",") && e.KeyChar == ',')
            {
                e.Handled = true; // Забороняє більше однієї коми
            }
        }

        // Обробник для події TextChanged для перевірки, чи поле не є порожнім
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        // Обробник для кнопки OK для конвертації валюти
        private void buttonOK_Click(object sender, EventArgs e)
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

        // Обробник для кнопки конвертації
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double amount) &&
                comboBoxFromCurrency.SelectedItem != null &&
                comboBoxToCurrency.SelectedItem != null)
            {
                string fromCurrency = comboBoxFromCurrency.SelectedItem.ToString();
                string toCurrency = comboBoxToCurrency.SelectedItem.ToString();

                double convertedAmount = 0;

                if (fromCurrency == "Гривня" && toCurrency == "Мексиканське песо")
                {
                    convertedAmount = amount / ExchangeRateUAHToMXN; // Конвертуємо з гривні в мексиканське песо
                }
                else if (fromCurrency == "Мексиканське песо" && toCurrency == "Гривня")
                {
                    convertedAmount = amount * ExchangeRateUAHToMXN; // Конвертуємо з мексиканського песо в гривню
                }

                label2.Text = $"Сума: {convertedAmount:F2} {toCurrency}";
            }
            else
            {
                MessageBox.Show("Введіть коректну суму і виберіть валюти для конвертації.");
            }
        }
    }
}
