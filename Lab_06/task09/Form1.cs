using System;
using System.Windows.Forms;

namespace task09
{
    // Частковий клас для основної форми
    public partial class Form1 : Form
    {
        // Конструктор форми
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів
            // Прив'язка обробників подій до кнопок панелі інструментів
            toolStripButton1.Click += ToolStripButton1_Click;
            toolStripButton2.Click += ToolStripButton2_Click;
            toolStripButton3.Click += ToolStripButton3_Click;
            toolStripButton4.Click += ToolStripButton4_Click;
            toolStripButton5.Click += ToolStripButton5_Click;
            toolStripButton6.Click += ToolStripButton6_Click;
        }

        // Обробник події для кнопки 1
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка 1 натиснута!"); 
        }

        // Обробник події для кнопки 2
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка 2 натиснута!"); 
        }

        // Обробник події для кнопки 3
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка 3 натиснута!"); 
        }

        // Обробник події для кнопки 4
        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка 4 натиснута!"); 
        }

        // Обробник події для кнопки 5
        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка 5 натиснута!"); 
        }

        // Обробник події для кнопки 6
        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка 6 натиснута!"); 
        }
    }
}