using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task03_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxA.Text, out double a) &&
                double.TryParse(textBoxB.Text, out double b) &&
                a > 0 && b > 0)
            {
                double area = Math.PI * a * b;
                double perimeter = CalculatePerimeter(a, b);

                labelAreaResult.Text = area.ToString("F2");
                labelPerimeterResult.Text = perimeter.ToString("F2");
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні додатні числа для великих та малих півосей.", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculatePerimeter(double a, double b)
        {
            // Використання другого наближення Рамануджана
            double h = Math.Pow((a - b) / (a + b), 2);
            double perimeter = Math.PI * (a + b) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
            return perimeter;
        }
    }
}
