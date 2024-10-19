using System;
using System.Drawing;
using System.Windows.Forms;

namespace task06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.Font = new Font(button.Font, FontStyle.Bold);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.Font = new Font(button.Font, FontStyle.Regular);
            }
        }
    }
}
