using Lab12;
using System;
using System.IO;
using System.Windows.Forms;

namespace Lab12
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Очищення попередніх повідомлень про помилки
            lblErrorMessage.Text = "";

            // Отримання значень
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Перевірка чи заповнені поля
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblErrorMessage.Text = "Будь ласка, заповніть всі поля.";
                return;
            }

            // Перевірка авторизації
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Авторизація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Відкрити профільну форму
                ProfileForm profileForm = new ProfileForm(username);
                profileForm.Show();
                this.Hide();
            }
            else
            {
                lblErrorMessage.Text = "Невірний логін або пароль.";
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Перевірка користувача в файлі users.txt
            string usersFile = "users.txt";
            if (File.Exists(usersFile))
            {
                var lines = File.ReadAllLines(usersFile);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data.Length >= 2)
                    {
                        string storedUsername = data[0];
                        string storedPassword = data[1];

                        if (storedUsername == username && storedPassword == password)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Відкрити реєстраційну форму
            RegForm registerForm = new RegForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
