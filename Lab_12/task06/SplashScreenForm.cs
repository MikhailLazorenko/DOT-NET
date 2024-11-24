using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            this.Load += SplashScreenForm_Load;
        }

        private async void SplashScreenForm_Load(object? sender, EventArgs e)
        {
            // Конвертація byte[] у Image
            try
            {
                byte[] imageBytes = Properties.Resources.pic; // Замініть на правильну назву ресурсу
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    this.pictureBoxLogo.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося завантажити зображення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await Task.Delay(3000); // Затримка 3 секунди
            LogForm loginForm = new LogForm();
            loginForm.Show();
            this.Hide();
        }
    }
}