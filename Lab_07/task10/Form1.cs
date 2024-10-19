using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ��������� �������� ���� ��� Enter �� Leave
        private void TextBox_EnterLeave(object? sender, EventArgs e)
        {
            // ����������, �� sender � TextBox
            if (sender is System.Windows.Forms.TextBox textBox) // ������� ������ ����
            {
                if (textBox.Focused) // ���� ���� �������
                {
                    // ���� ������ �� ������ ��� �����
                    textBox.Font = new Font(textBox.Font, FontStyle.Bold);
                }
                else // ���� ���� �� �������
                {
                    // ���������� ������ �� ���������� ��� ����� ������
                    textBox.Font = new Font(textBox.Font, FontStyle.Regular);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ����'���� ��������� ���� �� ��������� ����
            textBox1.Enter += TextBox_EnterLeave;
            textBox1.Leave += TextBox_EnterLeave;

            textBox2.Enter += TextBox_EnterLeave;
            textBox2.Leave += TextBox_EnterLeave;

            textBox3.Enter += TextBox_EnterLeave;
            textBox3.Leave += TextBox_EnterLeave;
        }
    }
}
