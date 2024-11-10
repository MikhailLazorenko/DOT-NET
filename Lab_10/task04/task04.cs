using System;
using System.Windows.Forms;

namespace Lab10
{
    public partial class task04 : Form
    {
        public task04()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            listViewPayments.Items.Clear();

            // Отримання значень введених користувачем
            decimal loanAmount;
            int term;
            decimal interestRate;

            // Перевірка на правильність вводу
            if (!decimal.TryParse(txtAmount.Text, out loanAmount) ||
                !int.TryParse(txtTerm.Text, out term) ||
                !decimal.TryParse(txtInterestRate.Text, out interestRate))
            {
                MessageBox.Show("Будь ласка, введіть правильні значення для суми, терміну та відсоткової ставки.");
                return;
            }

            // Переведення відсоткової ставки у десяткове значення
            interestRate /= 100;
            decimal monthlyRate = interestRate / 12;

            // Розрахунок щомісячного платежу
            decimal monthlyPayment = loanAmount * monthlyRate / (1 - (decimal)Math.Pow((double)(1 + monthlyRate), -term));

            // Розрахунок графіка платежів
            decimal remainingDebt = loanAmount;
            for (int month = 1; month <= term; month++)
            {
                decimal interest = remainingDebt * monthlyRate;
                decimal principal = monthlyPayment - interest;
                remainingDebt -= principal;

                // Додавання елементів до ListView
                var item = new ListViewItem(month.ToString());
                item.SubItems.Add(remainingDebt.ToString("F2"));
                item.SubItems.Add(interest.ToString("F2"));
                item.SubItems.Add(monthlyPayment.ToString("F2"));
                listViewPayments.Items.Add(item);
            }
        }
    }
}
