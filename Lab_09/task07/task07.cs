using System;
using System.Windows.Forms;

namespace Lab09
{
    public partial class task07 : Form
    {
        public task07()
        {
            InitializeComponent();
        }

        // Метод, що обробляє натискання кнопки OK
        private void buttonOK_Click()
        {
            if (int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                // Використання тернарного умовного оператора для визначення ціни
                int price = radioButton1.Checked ? 12000 :
                            radioButton2.Checked ? 9000 :
                            radioButton3.Checked ? 7000 : 0;

                if (price > 0)
                {
                    int totalCost = quantity * price;
                    resultLabel.Text = $"Загальна вартість: {totalCost} грн";
                }
                else
                {
                    resultLabel.Text = "Оберіть товар.";
                }
            }
            else
            {
                resultLabel.Text = "Введіть коректне значення кількості.";
            }
        }
    }
}
