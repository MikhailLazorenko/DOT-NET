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
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // ��� ��� �������
            string[] labels = { "���� - 60%", "����� - 20%", "���� - 15%", "��������� �� ���� �������� - 5%" };
            float[] values = { 3f / 5f, 1f / 5f, 3f / 20f, 1f / 20f };

            // ������� ��� ������� ��������
            Brush[] brushes = {
                Brushes.LightBlue, // ����
                Brushes.LightGreen, // �����
                Brushes.Orange, // ����
                Brushes.Purple // ��������� �� ����
            };

            // ����� � ����� �������
            int centerX = ClientSize.Width / 3;
            int centerY = ClientSize.Height / 2;
            int radius = 100;

            // ���������� ���
            float startAngle = 0;

            // ��������� ������� �������
            for (int i = 0; i < values.Length; i++)
            {
                // ��� ��� ��������� ��������
                float sweepAngle = values[i] * 360;

                // ������� �������
                g.FillPie(brushes[i], centerX - radius, centerY - radius, 2 * radius, 2 * radius, startAngle, sweepAngle);

                // ���������� �� ���������� ��������
                startAngle += sweepAngle;
            }

            // �������
            int legendX = centerX + radius + 50;
            int legendY = centerY - radius;

            for (int i = 0; i < labels.Length; i++)
            {
                // ������� ����������� ������� ��������
                g.FillRectangle(brushes[i], legendX, legendY + i * 30, 20, 20);

                // ϳ���� ��� ��������
                g.DrawString(labels[i], new Font("Arial", 10), Brushes.Black, legendX + 30, legendY + i * 30);
            }

            // ���������
            g.DrawString("����� ���� ��������� ��������:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, centerX - radius, centerY - radius - 50);
        }
    }
}
