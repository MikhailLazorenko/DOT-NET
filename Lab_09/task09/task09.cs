using System;
using System.Windows.Forms;

namespace Lab09
{
    public partial class task09 : Form
    {
        // Ціни моделей планшетів
        private decimal priceAppleIpad = 12000m;
        private decimal priceSamsungTab = 9000m;
        private decimal priceXiaomiPad = 7000m;

        public task09()
        {
            InitializeComponent();
        }

        // Метод обробки події кнопки OK
        private void buttonOK_Click(object sender, EventArgs e)
        {
            decimal selectedPrice = 0;

            // Вибір ціни залежно від обраної моделі
            switch (comboBoxTablets.SelectedIndex)
            {
                case 0:
                    selectedPrice = priceAppleIpad;
                    break;
                case 1:
                    selectedPrice = priceSamsungTab;
                    break;
                case 2:
                    selectedPrice = priceXiaomiPad;
                    break;
                default:
                    resultLabel.Text = "Будь ласка, виберіть модель планшета.";
                    return;
            }

            // Читаємо кількість з текстового поля
            if (int.TryParse(textBoxQuantity.Text, out int quantity) && quantity > 0)
            {
                // Обчислюємо загальну вартість
                decimal totalPrice = selectedPrice * quantity;
                resultLabel.Text = $"Загальна вартість: {totalPrice} грн";
            }
            else
            {
                resultLabel.Text = "Будь ласка, введіть коректну кількість.";
            }
        }
    }
}
