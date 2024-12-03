using System;
using System.Drawing;
using System.Drawing.Interop;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_8_Test;

namespace Task_8_Test
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
            // ����������� byte[] � Image
            try
            {
                byte[] imageBytes = Properties.Resources.pic;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    this.pictureBoxLogo.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�� ������� ����������� ����������: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await Task.Delay(3000); // �������� 3 �������
            LogForm loginForm = new LogForm();
            loginForm.Show();
            this.Hide();
        }
    }
}