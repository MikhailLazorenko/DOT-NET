using System;
using System.Drawing;
using System.Windows.Forms;

namespace task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void pictureBoxUkraine_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // �������� PictureBox �� �������� ������ ��� ���������
                pictureBoxBulgaria.Visible = true;
            }
        }

        private void pictureBoxUkraine_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // ������� PictureBox �� �������� ������ ��� ���������
                pictureBoxBulgaria.Visible = false;
            }
        }
    }
}
