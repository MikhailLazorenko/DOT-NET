using System;
using System.Windows.Forms;

namespace task04_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                int x = inputForm.X;
                int y = inputForm.Y;
                double z = inputForm.Z;

                try
                {
                    double product = CalculateProduct(x, y, z);
                    ResultsForm resultsForm = new ResultsForm(product);
                    resultsForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка обчислення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private double CalculateProduct(int x, int y, double z)
        {
            int N = x + y;
            if (N < 1)
                throw new ArgumentException("Сума x та y повинна бути цілим числом більше або рівним 1.");

            double product = 1.0;

            for (int i = 1; i <= N; i++)
            {
                double numerator = 2 * i - z * x;
                double denominator = Math.Pow(x, 3) - i + Math.Pow(i, 2);

                if (denominator == 0)
                    throw new DivideByZeroException($"Знаменник дорівнює нулю при i = {i}.");

                double fraction = numerator / denominator;

                if (fraction < 0)
                    throw new ArithmeticException($"Підкореневий вираз від'ємний при i = {i}.");

                double term = Math.Sqrt(fraction);
                product *= term;
            }

            return product;
        }
    }
}
