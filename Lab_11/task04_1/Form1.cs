using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task04_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxX.Text, out int x) &&
                int.TryParse(textBoxY.Text, out int y) &&
                double.TryParse(textBoxZ.Text, out double z))
            {
                int N = x + y;
                if (N < 1)
                {
                    MessageBox.Show("���� x �� y ������� ���� ����� ������ ����� ��� ����� 1.", "������� �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    double product = CalculateProduct(x, y, z);
                    labelResult.Text = $"���������: {product:F4}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "������� ����������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("���� �����, ������ ������� ������ �������� ��� x, y �� z.", "������� �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateProduct(int x, int y, double z)
        {
            int N = x + y;
            double product = 1.0;

            for (int i = 1; i <= N; i++)
            {
                double numerator = 2 * i - z * x;
                double denominator = Math.Pow(x, 3) - i + Math.Pow(i, 2);

                if (denominator == 0)
                    throw new DivideByZeroException($"��������� ������� ���� ��� i = {i}.");

                double fraction = numerator / denominator;

                if (fraction < 0)
                    throw new ArithmeticException($"ϳ���������� ����� ��'����� ��� i = {i}.");

                double term = Math.Sqrt(fraction);
                product *= term;
            }

            return product;
        }
    }
}
