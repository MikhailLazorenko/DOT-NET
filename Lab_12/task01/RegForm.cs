using Lab12;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab12
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Очищення попередніх повідомлень про помилки
            lblErrorUsername.Text = "";
            lblErrorPassword.Text = "";
            lblErrorConfirmPassword.Text = "";
            lblErrorEmail.Text = "";

            // Отримання значень
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Логіка валідації
            bool isValid = true; // Загальний прапорець для перевірки

            // Перевірка Username
            if (!ValidateUsername(username))
            {
                lblErrorUsername.Text = "Некоректне ім'я користувача! (Макс 15 символів, лише літери та цифри)";
                isValid = false;
            }

            // Перевірка чи користувач вже існує
            if (UserExists(username))
            {
                lblErrorUsername.Text = "Користувач з таким ім'ям вже існує!";
                isValid = false;
            }

            // Перевірка Password
            if (!ValidatePassword(password))
            {
                lblErrorPassword.Text = "Пароль має бути 12+ символів, з літерами, цифрами та спецсимволами.";
                isValid = false;
            }

            // Перевірка збігу паролів
            if (password != confirmPassword)
            {
                lblErrorConfirmPassword.Text = "Паролі не співпадають!";
                isValid = false;
            }

            // Перевірка Email
            if (!ValidateEmail(email))
            {
                lblErrorEmail.Text = "Некоректний формат Email!";
                isValid = false;
            }

            // Якщо помилок немає, відобразити успішну реєстрацію
            if (isValid)
            {
                // Зберегти користувача
                SaveUser(username, password, email);

                MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Перехід до форми авторизації
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private bool ValidateUsername(string username)
        {
            // Перевірка: лише латиниця та цифри, довжина до 15 символів
            return Regex.IsMatch(username, @"^[a-zA-Z0-9]{1,15}$");
        }

        private bool ValidatePassword(string password)
        {
            // Перевірка: довжина не менше 12, містить букви, цифри, спеціальні символи
            return Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*]).{12,}$");
        }

        private bool ValidateEmail(string email)
        {
            // Простий регулярний вираз для перевірки email
            return Regex.IsMatch(email, @"^\S+@\S+\.\S+$");
        }

        private bool UserExists(string username)
        {
            string usersFile = "users.txt";
            if (File.Exists(usersFile))
            {
                var lines = File.ReadAllLines(usersFile);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data.Length >= 1)
                    {
                        string storedUsername = data[0];
                        if (storedUsername == username)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void SaveUser(string username, string password, string email)
        {
            // Зберегти користувача в users.txt
            string usersFile = "users.txt";
            string userLine = $"{username};{password};{email}";
            File.AppendAllLines(usersFile, new string[] { userLine });
        }
    }
}
