using System;
using System.Windows.Forms;

namespace task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                DisplayMessage($"Ви натиснули {clickedButton.Text}");
            }
        }

        private void DisplayMessage(string message)
        {
            labelResult.Text = message;
        }
    }
}
