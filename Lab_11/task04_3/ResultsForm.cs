using System;
using System.Windows.Forms;

namespace task04_3
{
    public partial class ResultsForm : Form
    {
        public ResultsForm(double result)
        {
            InitializeComponent();
            labelResult.Text = $"Результат: {result:F4}";
        }
    }
}
