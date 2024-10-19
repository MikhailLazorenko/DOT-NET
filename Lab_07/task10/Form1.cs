using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Загальний обробник подій для Enter та Leave
        private void TextBox_EnterLeave(object? sender, EventArgs e)
        {
            // Перевіряємо, чи sender є TextBox
            if (sender is System.Windows.Forms.TextBox textBox) // Вказуємо повний шлях
            {
                if (textBox.Focused) // Якщо поле активне
                {
                    // Зміна шрифта на жирний при фокусі
                    textBox.Font = new Font(textBox.Font, FontStyle.Bold);
                }
                else // Якщо поле не активне
                {
                    // Повернення шрифта до звичайного при втраті фокусу
                    textBox.Font = new Font(textBox.Font, FontStyle.Regular);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Прив'язка обробників подій до текстових полів
            textBox1.Enter += TextBox_EnterLeave;
            textBox1.Leave += TextBox_EnterLeave;

            textBox2.Enter += TextBox_EnterLeave;
            textBox2.Leave += TextBox_EnterLeave;

            textBox3.Enter += TextBox_EnterLeave;
            textBox3.Leave += TextBox_EnterLeave;
        }
    }
}
