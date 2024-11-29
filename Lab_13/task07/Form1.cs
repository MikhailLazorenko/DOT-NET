using System;
using System.Drawing;
using System.Windows.Forms;

namespace task07
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

            // ��������� ������ ���������
            int margin = 50; // ³������
            int width = ClientSize.Width - 2 * margin;
            int height = ClientSize.Height - 2 * margin;

            // ��������� ����
            Pen axisPen = new Pen(Color.Black, 2);

            // ������� ��
            g.DrawLine(axisPen, margin, height + margin, margin, margin); // Y-axis
            g.DrawLine(axisPen, margin, height + margin, width + margin, height + margin); // X-axis

            // ��������� ����
            Pen gridPen = new Pen(Color.LightBlue, 1);
            for (int i = 1; i <= 10; i++)
            {
                // ���������� ��
                int x = margin + i * (width / 10);
                g.DrawLine(gridPen, x, margin, x, height + margin);

                // ������������ ��
                int y = margin + i * (height / 10);
                g.DrawLine(gridPen, margin, y, width + margin, y);
            }

            // ��������� �������
            double minX = 0;
            double maxX = 20;
            double step = 0.25;

            // �������������
            float scaleX = (float)width / (float)(maxX - minX);
            float scaleY = (float)height / 4.0f; // ĳ������ Y: �� -2 �� 2

            // ���������� ��� �������� �������
            PointF[] points = new PointF[(int)((maxX - minX) / step) + 1];
            int index = 0;

            for (double x = minX; x <= maxX; x += step)
            {
                double y = SawtoothWave(x);

                // ������������ ��������� � ������� ���������
                float graphX = margin + (float)((x - minX) * scaleX);
                float graphY = height + margin - (float)((y + 2) * scaleY); // Y ������� �� 2

                points[index++] = new PointF(graphX, graphY);
            }

            // ��������� �������
            Pen graphPen = new Pen(Color.Black, 2);
            g.DrawLines(graphPen, points);
        }

        // ���������� ����������� ����
        private double SawtoothWave(double x)
        {
            return 2 * (x / 4.0 - Math.Floor(x / 4.0 + 0.5));
        }
    }
}
