using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab09
{
    public partial class task08 : Form
    {
        private decimal priceAppleIpad = 12000m;
        private decimal priceSamsungTab = 9000m;
        private decimal priceXiaomiPad = 7000m;
        private const int WholesaleThreshold = 10;
        private const decimal WholesaleDiscount = 0.85m;
        private const decimal WarrantyIncrease = 1.10m;

        public task08()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            decimal selectedPrice = 0;

            if (radioButton1.Checked)
                selectedPrice = priceAppleIpad;
            else if (radioButton2.Checked)
                selectedPrice = priceSamsungTab;
            else if (radioButton3.Checked)
                selectedPrice = priceXiaomiPad;

            if (int.TryParse(textBoxQuantity.Text, out int quantity) && quantity > 0)
            {
                decimal totalPrice = selectedPrice * quantity;

                // Оптовий режим знижки
                if (checkBoxWholesale.Checked && quantity >= WholesaleThreshold)
                {
                    totalPrice *= WholesaleDiscount;
                }

                // Додаткові витрати за розширену гарантію
                if (checkBoxWarranty.Checked)
                {
                    totalPrice *= WarrantyIncrease;
                }

                resultLabel.Text = $"Загальна вартість: {totalPrice} грн";
            }
            else
            {
                MessageBox.Show("Введіть коректну кількість");
            }
        }

        private void checkBoxWholesale_CheckedChanged(object sender, EventArgs e)
        {
            resultLabel.Text = checkBoxWholesale.Checked ? "Оптовий режим" : "";
        }
    }
}
