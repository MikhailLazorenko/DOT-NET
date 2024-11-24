using System;
using System.Windows.Forms;

namespace task04_4
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
