using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab10
{
    public partial class task07 : Form
    {
        public task07()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Встановлюємо поточний день тижня при завантаженні форми
            toolStripStatusLabel1.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Оновлюємо текст у toolStripStatusLabel1 поточним днем тижня
            toolStripStatusLabel1.Text = DateTime.Now.DayOfWeek.ToString();

            // Отримуємо текст з textBox1 та інвертуємо його
            string inputText = textBox1.Text;
            string reversedText = ReverseString(inputText);

            // Встановлюємо інверсований текст у toolStripStatusLabel2
            toolStripStatusLabel2.Text = reversedText;
        }

        // Метод для інверсії рядка
        private string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
