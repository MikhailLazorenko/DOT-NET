using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ����'���� ��������� ���� KeyDown �� ���������� ����
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        // �������� ��䳿 KeyDown
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // ��������, �� ��������� ������ � ������ �������� � N �� Z
            if (e.KeyCode >= Keys.N && e.KeyCode <= Keys.Z)
            {
                // ���������� �������� �������
                e.SuppressKeyPress = false; // �� ��������� ����������
            }
            else
            {
                // ���� ������ �� ������� ����, ��������� ����������
                e.SuppressKeyPress = true; // ��������� ����������
            }
        }
    }
}
