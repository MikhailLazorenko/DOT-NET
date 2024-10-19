using System;
using System.Drawing;
using System.Windows.Forms;

namespace task09
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;

        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }

        private void InitializeTextBoxes()
        {
            // ��������� �� ������������ ��������� ����
            textBox1 = new TextBox { Location = new Point(100, 50), Width = 200 };
            textBox2 = new TextBox { Location = new Point(100, 100), Width = 200 };
            textBox3 = new TextBox { Location = new Point(100, 150), Width = 200 };

            // ��������� ��������� ����
            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;

            textBox2.Enter += TextBox2_Enter;
            textBox2.Leave += TextBox2_Leave;

            textBox3.Enter += TextBox3_Enter;
            textBox3.Leave += TextBox3_Leave;

            // ��������� ��������� ���� �� �����
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold); // ������� ����� �� ������
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular); // ��������� ����� �� ����������
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Font = new Font(textBox2.Font, FontStyle.Bold); // ������� ����� �� ������
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            textBox2.Font = new Font(textBox2.Font, FontStyle.Regular); // ��������� ����� �� ����������
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Font = new Font(textBox3.Font, FontStyle.Bold); // ������� ����� �� ������
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            textBox3.Font = new Font(textBox3.Font, FontStyle.Regular); // ��������� ����� �� ����������
        }
    }
}
