using System;
using System.Windows.Forms;

namespace task03_3
{
    public partial class ResultsForm : Form
    {
        public ResultsForm(double area, double perimeter)
        {
            InitializeComponent();
            labelAreaResult.Text = area.ToString("F2");
            labelPerimeterResult.Text = perimeter.ToString("F2");
        }
    }
}
