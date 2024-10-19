using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace task07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Підключення подій для кожної мітки
            label1.MouseDown += Label1_MouseDown;
            label1.MouseUp += Label1_MouseUp;
            label2.MouseDown += Label2_MouseDown;
            label2.MouseUp += Label2_MouseUp;
            label3.MouseDown += Label3_MouseDown;
            label3.MouseUp += Label3_MouseUp;
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e) => ChangeLabelStyle(label1, Color.Red, FontStyle.Bold);
        private void Label1_MouseUp(object sender, MouseEventArgs e) => ChangeLabelStyle(label1, Color.Black, FontStyle.Regular);

        private void Label2_MouseDown(object sender, MouseEventArgs e) => ChangeLabelStyle(label2, Color.Red, FontStyle.Bold);
        private void Label2_MouseUp(object sender, MouseEventArgs e) => ChangeLabelStyle(label2, Color.Black, FontStyle.Regular);

        private void Label3_MouseDown(object sender, MouseEventArgs e) => ChangeLabelStyle(label3, Color.Red, FontStyle.Bold);
        private void Label3_MouseUp(object sender, MouseEventArgs e) => ChangeLabelStyle(label3, Color.Black, FontStyle.Regular);

        // Уточнюємо тип Label
        private void ChangeLabelStyle(System.Windows.Forms.Label label, Color color, FontStyle style)
        {
            label.ForeColor = color; // Зміна кольору тексту
            label.Font = new Font(label.Font, style); // Зміна шрифту
        }
    }
}
