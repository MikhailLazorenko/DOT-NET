using System;
using System.Windows.Forms;

namespace task14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обробник події завантаження форми
        protected override void OnLoad(EventArgs e)
        {
            // Показуємо діалогове вікно із запитом про завантаження форми
            var result = MessageBox.Show("Бажаєте завантажити форму?", "Запит на завантаження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Якщо користувач вибрав "Ні", закриваємо форму і скасовуємо завантаження
            if (result == DialogResult.No)
            {
                this.Close();
                return;
            }

            // Якщо користувач вибрав "Так", налаштовуємо форму на розміщення в нижній правій чверті екрану
            base.OnLoad(e);
            SetFormPosition();
        }

        private void SetFormPosition()
        {
            // Отримуємо розміри екрану
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Встановлюємо розміри форми на чверть екрану
            this.Width = screenWidth / 2;
            this.Height = screenHeight / 2;

            // Встановлюємо позицію форми у нижній правій чверті екрану
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(screenWidth - this.Width, screenHeight - this.Height);
        }
    }
}
