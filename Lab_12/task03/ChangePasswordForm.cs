using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab12
{
    public partial class ChangePasswordForm : Form
    {
        private string username;

        public ChangePasswordForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            lblErrorOldPassword.Text = "";
            lblErrorNewPassword.Text = "";
            lblErrorConfirmPassword.Text = "";

            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (!ValidateOldPassword(oldPassword))
            {
                lblErrorOldPassword.Text = "Невірний старий пароль!";
                return;
            }

            if (!ValidatePassword(newPassword))
            {
                lblErrorNewPassword.Text = "Пароль має бути 12+ символів, з літерами, цифрами та спецсимволами.";
                return;
            }

            if (newPassword != confirmPassword)
            {
                lblErrorConfirmPassword.Text = "Паролі не співпадають!";
                return;
            }

            // Оновити пароль
            UpdatePassword(newPassword);

            MessageBox.Show("Пароль успішно змінено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool ValidateOldPassword(string oldPassword)
        {
            string usersFile = "users.txt";
            if (File.Exists(usersFile))
            {
                var lines = File.ReadAllLines(usersFile);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data.Length >= 2)
                    {
                        if (data[0] == username && data[1] == oldPassword)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool ValidatePassword(string password)
        {
            // Така ж перевірка як і раніше
            return Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*]).{12,}$");
        }

        private void UpdatePassword(string newPassword)
        {
            string usersFile = "users.txt";
            if (File.Exists(usersFile))
            {
                var lines = File.ReadAllLines(usersFile);
                for (int i = 0; i < lines.Length; i++)
                {
                    var data = lines[i].Split(';');
                    if (data[0] == username)
                    {
                        data[1] = newPassword;
                        lines[i] = string.Join(";", data);
                        break;
                    }
                }
                File.WriteAllLines(usersFile, lines);
            }
        }
    }
}
