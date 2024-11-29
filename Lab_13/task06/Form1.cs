using System;
using System.Drawing;
using System.Windows.Forms;

namespace task06
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private float[] currencyValues;

        public Form1()
        {
            InitializeComponent();
            GenerateRandomData();
        }

        private void GenerateRandomData()
        {
            int pointsCount = 10; // ʳ������ �����
            currencyValues = new float[pointsCount];

            for (int i = 0; i < pointsCount; i++)
            {
                // �������� �������� �������� ����� (���������, � ������� �� 30 �� 32)
                currencyValues[i] = (float)(30 + random.NextDouble() * 2);
            }

            // ������������� ������
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.CadetBlue, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot };

            int margin = 50; // ³������ � ����
            int width = ClientSize.Width - 2 * margin;
            int height = ClientSize.Height - 2 * margin;

            // ��������� ����
            g.DrawLine(Pens.Black, margin, margin, margin, height + margin); // Y-axis
            g.DrawLine(Pens.Black, margin, height + margin, width + margin, height + margin); // X-axis

            if (currencyValues == null || currencyValues.Length < 2)
                return;

            // �������������
            float maxY = 32; // ����� �������� ��������
            float minY = 30; // ���� �������� ��������
            float scaleX = (float)width / (currencyValues.Length - 1);
            float scaleY = (float)height / (maxY - minY);

            // ��������� �������
            PointF[] points = new PointF[currencyValues.Length];
            for (int i = 0; i < currencyValues.Length; i++)
            {
                float x = margin + i * scaleX;
                float y = height + margin - (currencyValues[i] - minY) * scaleY;
                points[i] = new PointF(x, y);

                // ϳ������� ��������
                string label = currencyValues[i].ToString("0.00");
                g.DrawString(label, new Font("Arial", 8), Brushes.Black, x - 10, y - 20);
            }

            // ������� ��� �������
            g.DrawLines(pen, points);

            // ������� ����� �������
            foreach (var point in points)
            {
                g.FillRectangle(Brushes.Black, point.X - 2, point.Y - 2, 4, 4);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GenerateRandomData(); // �������� ��� ���
        }
    }
}
