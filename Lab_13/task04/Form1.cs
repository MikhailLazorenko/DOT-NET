using System;
using System.Drawing;
using System.Windows.Forms;

namespace task04
{
    public partial class Form1 : Form
    {
        private int state = 0; // �������� ����
        private System.Windows.Forms.Timer timer; // ������ ��� ����������� �����

        public Form1()
        {
            InitializeComponent();

            // ����������� �������
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // �������� 2 �������
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            state = (state + 1) % 3; // ���� ����� (0, 1, 2)
            UpdateFlagLocations();
        }

        private void UpdateFlagLocations()
        {
            switch (state)
            {
                case 0:
                    // ���� 0: ������ ������ � �����
                    pictureBoxBulgaria.Visible = false;
                    break;
                case 1:
                    // ���� 1: ������ ������ �������� �� ������
                    pictureBoxBulgaria.Location = new Point(pictureBoxUkraine.Right + 10, pictureBoxUkraine.Top);
                    pictureBoxBulgaria.Visible = true;
                    break;
                case 2:
                    // ���� 2: ������ ������ ������ ��� �������
                    pictureBoxBulgaria.Location = new Point(pictureBoxUkraine.Left, pictureBoxUkraine.Top - pictureBoxBulgaria.Height - 10);
                    pictureBoxBulgaria.Visible = true;
                    break;
            }
        }

        private void pictureBoxUkraine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // ������� ������ ������
            int width = pictureBoxUkraine.ClientSize.Width;
            int height = pictureBoxUkraine.ClientSize.Height;

            g.FillRectangle(Brushes.Blue, 0, 0, width, height / 2);
            g.FillRectangle(Brushes.Yellow, 0, height / 2, width, height / 2);
        }

        private void pictureBoxBulgaria_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // ������� ������ ������
            int width = pictureBoxBulgaria.ClientSize.Width;
            int height = pictureBoxBulgaria.ClientSize.Height;

            g.FillRectangle(Brushes.White, 0, 0, width, height / 3);
            g.FillRectangle(Brushes.Green, 0, height / 3, width, height / 3);
            g.FillRectangle(Brushes.Red, 0, 2 * height / 3, width, height / 3);
        }
    }
}
