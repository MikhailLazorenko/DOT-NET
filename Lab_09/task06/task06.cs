using System;
using System.Windows.Forms;

namespace Lab09
{
    public partial class task06 : Form
    {
        public task06()
        {
            InitializeComponent();
        }

        // Базова ціна планшета
        private const decimal BasePrice = 20000m;

        // Ціни на додаткові послуги та аксесуари
        private const decimal CasePrice = 500m;
        private const decimal ScreenProtectorPrice = 300m;
        private const decimal MemoryUpgradePrice = 1500m;
        private const decimal ExtendedWarrantyPrice = 1000m;

        // Відсоток знижки на додаткові послуги
        private const decimal DiscountRate = 0.10m;

        private void CalculatePrices()
        {
            // Розрахунок вартості додаткових послуг
            decimal additionalPrice = 0;

            if (chkCase.Checked) additionalPrice += CasePrice;
            if (chkScreenProtector.Checked) additionalPrice += ScreenProtectorPrice;
            if (chkMemoryUpgrade.Checked) additionalPrice += MemoryUpgradePrice;
            if (chkExtendedWarranty.Checked) additionalPrice += ExtendedWarrantyPrice;

            // Розрахунок знижки
            decimal discount = additionalPrice * DiscountRate;

            // Загальна сума
            decimal totalPrice = BasePrice + additionalPrice - discount;

            // Отримання вибраної валюти
            string selectedCurrency = cmbCurrency.SelectedItem?.ToString() ?? "Гривна (UAH)";

            // Конвертація валюти
            if (selectedCurrency == "Долар (USD)")
            {
                totalPrice /= 41.28m; // Курс долара
                lblCurrency.Text = "Валюта: Долар (USD)";
            }
            else
            {
                lblCurrency.Text = "Валюта: Гривна (UAH)";
            }

            // Відображення результатів
            lblBasePrice.Text = $"Ціна базової комплектації: {BasePrice} грн";
            lblAdditionalPrice.Text = $"В тому числі дод. обладнання: {additionalPrice} грн";
            lblDiscount.Text = $"Знижка на дод. обладнання (10%): {discount} грн";
            lblTotalPrice.Text = $"Разом: {totalPrice:F2} {selectedCurrency}"; // Форматування до двох знаків після коми
        }

        // Обработчик для кнопки расчета
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalculatePrices();
        }

        // Обработчик для изменения выбора валюты
        private void CmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePrices();
        }
    }
}
