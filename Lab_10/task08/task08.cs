using System;
using System.Windows.Forms;

namespace Lab10
{
    public partial class task08 : Form
    {
        public task08()
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
            // Оновлюємо текст в toolStripStatusLabel1 поточним днем тижня
            toolStripStatusLabel1.Text = DateTime.Now.DayOfWeek.ToString();

            // Отримуємо текст із textBox1 і інвертуємо його
            string inputText = textBox1.Text;
            string reversedText = ReverseString(inputText);

            // Встановлюємо інвертований текст у toolStripStatusLabel2
            toolStripStatusLabel2.Text = reversedText;
        }

        // Метод для інверсії строки
        private string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // При мінімізації вікна приховуємо його, залишаючи видимим NotifyIcon
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            // Подвійний клік по NotifyIcon чергує стан форми між приховуванням та показом
            if (this.Visible)
            {
                this.Hide(); // Якщо форма видима, приховуємо її
            }
            else
            {
                this.Show(); // Якщо форма прихована, показуємо її
                this.WindowState = FormWindowState.Normal; // Повертаємо нормальний стан
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // Перевіряємо, чи натиснута права кнопка миші
            if (e.Button == MouseButtons.Right)
            {
                // Приховуємо іконку з системного трея
                notifyIcon1.Visible = false;
                // Примусово завершуємо програму
                Environment.Exit(0);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Перехоплюємо закриття форми, щоб мінімізувати її замість закриття
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
