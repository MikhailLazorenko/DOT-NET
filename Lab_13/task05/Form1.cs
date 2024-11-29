using System;
using System.Drawing;
using System.Windows.Forms;

namespace task05
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

            // ������� �����������
            Brush grayBrush = new SolidBrush(Color.White);
            int rectWidth = 300;
            int rectHeight = 200;
            int rectX = (this.ClientSize.Width - rectWidth) / 2;
            int rectY = (this.ClientSize.Height - rectHeight) / 2;
            g.FillRectangle(grayBrush, rectX, rectY, rectWidth, rectHeight);

            // ��������� ��������� ��������
            Pen bluePen = new Pen(Color.Blue, 5);
            int squareSize = 100;
            int wireLength = 80; // ������� ����� ������
            int lineExtension = 40; // ���������� ����������� �� ��������

            // ����� �����-����� ������������
            int centerX = rectX + rectWidth / 2;
            int centerY = rectY + rectHeight / 2;

            // ��������� ������������ (������ ��������)
            Rectangle phoneRect = new Rectangle(centerX - squareSize / 2, centerY - squareSize / 2, squareSize, squareSize);
            g.DrawRectangle(bluePen, phoneRect);

            // ��������� ���� ���������� ��� (����� ������)
            g.DrawLine(bluePen, centerX - squareSize / 2 - wireLength, centerY - squareSize / 4, centerX - squareSize / 2, centerY - squareSize / 4);
            g.DrawLine(bluePen, centerX - squareSize / 2 - wireLength, centerY + squareSize / 4, centerX - squareSize / 2, centerY + squareSize / 4);

            // ��������� ��������� ����������� �� ������
            g.DrawLine(bluePen, centerX + squareSize / 2, centerY - squareSize / 2 - lineExtension, centerX + squareSize / 2, centerY + squareSize / 2 + lineExtension);
        }
    }
}
