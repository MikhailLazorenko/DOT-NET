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
            int quantity;
            if (int.TryParse(textBoxQuantity.Text, out quantity))
            {
                int price = 0;

                if (radioButton1.Checked)
                {
                    price = 12000;
                }
                else if (radioButton2.Checked)
                {
                    price = 9000;
                }
                else if (radioButton3.Checked)
                {
                    price = 7000;
                }

                int totalCost = quantity * price;
                resultLabel.Text = "Загальна вартість: " + totalCost + " грн";
            }
            else
            {
                resultLabel.Text = "Введіть коректне значення кількості.";
            }
        }
    }
}
