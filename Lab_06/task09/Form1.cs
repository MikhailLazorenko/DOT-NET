using System;
using System.Windows.Forms;

namespace task09
{
    // ��������� ���� ��� ������� �����
    public partial class Form1 : Form
    {
        // ����������� �����
        public Form1()
        {
            InitializeComponent(); // ����������� ����������
            // ����'���� ��������� ���� �� ������ ����� �����������
            toolStripButton1.Click += ToolStripButton1_Click;
            toolStripButton2.Click += ToolStripButton2_Click;
            toolStripButton3.Click += ToolStripButton3_Click;
            toolStripButton4.Click += ToolStripButton4_Click;
            toolStripButton5.Click += ToolStripButton5_Click;
            toolStripButton6.Click += ToolStripButton6_Click;
        }

        // �������� ��䳿 ��� ������ 1
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ 1 ���������!"); 
        }

        // �������� ��䳿 ��� ������ 2
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ 2 ���������!"); 
        }

        // �������� ��䳿 ��� ������ 3
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ 3 ���������!"); 
        }

        // �������� ��䳿 ��� ������ 4
        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ 4 ���������!"); 
        }

        // �������� ��䳿 ��� ������ 5
        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ 5 ���������!"); 
        }

        // �������� ��䳿 ��� ������ 6
        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ 6 ���������!"); 
        }
    }
}