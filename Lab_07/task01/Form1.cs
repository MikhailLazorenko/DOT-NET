using System;
using System.Windows.Forms;

namespace task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click()
        {
            DisplayMessage("�� ��������� ������ 1");
        }

        private void button2_Click()
        {
            DisplayMessage("�� ��������� ������ 2");
        }

        private void button3_Click()
        {
            DisplayMessage("�� ��������� ������ 3");
        }

        private void DisplayMessage(string message)
        {
            labelResult.Text = message;
        }
    }
}
