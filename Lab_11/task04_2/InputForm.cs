using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task04_2
{
    public partial class InputForm : Form
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public double Z { get; private set; }

        public InputForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxX.Text, out int x) &&
                int.TryParse(textBoxY.Text, out int y) &&
                double.TryParse(textBoxZ.Text, out double z))
            {
                X = x;
                Y = y;
                Z = z;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення для x, y та z.", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
