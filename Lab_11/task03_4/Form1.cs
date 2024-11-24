using System;
using System.Windows.Forms;

namespace task03_4
{
    public partial class Form1 : Form
    {
        private double a;
        private double b;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                a = inputForm.A;
                b = inputForm.B;

                double area = Math.PI * a * b;
                double perimeter = CalculatePerimeter(a, b);

                ResultsForm resultsForm = new ResultsForm(area, perimeter);
                resultsForm.ShowDialog();
            }
        }

        private double CalculatePerimeter(double a, double b)
        {
            double h = Math.Pow((a - b) / (a + b), 2);
            double perimeter = Math.PI * (a + b) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
            return perimeter;
        }
    }
}
