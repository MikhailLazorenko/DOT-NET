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

            // Підписка на події MouseEnter та MouseLeave для кожної кнопки
            button1.MouseEnter += (s, e) => ChangeFontBold(button1, true);
            button1.MouseLeave += (s, e) => ChangeFontBold(button1, false);

            button2.MouseEnter += (s, e) => ChangeFontBold(button2, true);
            button2.MouseLeave += (s, e) => ChangeFontBold(button2, false);

            button3.MouseEnter += (s, e) => ChangeFontBold(button3, true);
            button3.MouseLeave += (s, e) => ChangeFontBold(button3, false);
        }

        // Метод для зміни шрифту
        private void ChangeFontBold(Button button, bool isBold)
        {
            if (isBold)
            {
                button.Font = new Font(button.Font, FontStyle.Bold);
            }
            else
            {
                button.Font = new Font(button.Font, FontStyle.Regular);
            }
        }
    }
}
