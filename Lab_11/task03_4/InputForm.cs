using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task03_4
{
    public partial class InputForm : Form
    {
        public double A { get; private set; }
        public double B { get; private set; }

        public InputForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxA.Text, out double a) &&
                double.TryParse(textBoxB.Text, out double b) &&
                a > 0 && b > 0)
            {
                A = a;
                B = b;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні додатні числа для великих та малих півосей.", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
