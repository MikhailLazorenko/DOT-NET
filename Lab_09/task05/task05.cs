using System;
using System.Windows.Forms;

namespace Lab09
{
    public partial class task05 : Form
    {
        public task05()
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

            // Відображення результатів
            lblBasePrice.Text = $"Ціна базової комплектації: {BasePrice} грн";
            lblAdditionalPrice.Text = $"В тому числі дод. обладнання: {additionalPrice} грн";
            lblDiscount.Text = $"Знижка на дод. обладнання (10%): {discount} грн";
            lblTotalPrice.Text = $"Разом: {totalPrice} грн";
        }
    }
}
