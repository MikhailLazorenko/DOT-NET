using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace task04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Підписка на події DblClick для кожного Label
            label1.DoubleClick += Label_DoubleClick;
            label2.DoubleClick += Label_DoubleClick;
            label3.DoubleClick += Label_DoubleClick;
        }

        // Один обробник події для всіх Label
        private void Label_DoubleClick(object sender, EventArgs e)
        {
            // Перевірка, чи об'єкт sender є Label
            if (sender is System.Windows.Forms.Label label)
            {
                // Перемикання між звичайним і жирним шрифтом
                label.Font = new Font(label.Font, label.Font.Bold ? FontStyle.Regular : FontStyle.Bold);
            }
        }
    }
}
