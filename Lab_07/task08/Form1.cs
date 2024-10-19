using System;
using System.Drawing;
using System.Windows.Forms;

namespace task08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeLabels();
        }

        private void InitializeLabels()
        {
            // ��������� �� ������������ ����
            Label label1 = new Label { Text = "����� 1", Location = new Point(100, 50), AutoSize = true };
            Label label2 = new Label { Text = "����� 2", Location = new Point(100, 100), AutoSize = true };
            Label label3 = new Label { Text = "����� 3", Location = new Point(100, 150), AutoSize = true };

            // ��������� ��������� ����
            label1.MouseDown += Label_MouseDown;
            label1.MouseUp += Label_MouseUp;

            label2.MouseDown += Label_MouseDown;
            label2.MouseUp += Label_MouseUp;

            label3.MouseDown += Label_MouseDown;
            label3.MouseUp += Label_MouseUp;

            // ��������� ���� �� �����
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            // ��������, �� ��������� ��� ������ ����
            if (e.Button == MouseButtons.Left)
            {
                Label label = sender as Label; // �������� ��������� �� ����
                if (label != null)
                {
                    label.Font = new Font(label.Font, FontStyle.Bold); // ������� ����� �� ������
                    label.ForeColor = Color.Red; // ������� ���� ������ �� ��������
                }
            }
        }

        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            // ��������, �� �������� ��� ������ ����
            if (e.Button == MouseButtons.Left)
            {
                Label label = sender as Label; // �������� ��������� �� ����
                if (label != null)
                {
                    label.Font = new Font(label.Font, FontStyle.Regular); // ��������� ����� �� ����������
                    label.ForeColor = Color.Black; // ��������� ���� ������ �� �������
                }
            }
        }
    }
}
