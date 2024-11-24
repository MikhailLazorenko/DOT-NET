using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab12
{
    public partial class ChangeEmailForm : Form
    {
        private string username;

        public ChangeEmailForm(string username)
        {
            this.username = username;
            InitializeComponent();
            LoadCurrentEmail();
        }

        private void LoadCurrentEmail()
        {
            string usersFile = "users.txt";
            if (File.Exists(usersFile))
            {
                var lines = File.ReadAllLines(usersFile);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data[0] == username && data.Length >= 3)
                    {
                        txtCurrentEmail.Text = data[2];
                        break;
                    }
                }
            }
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            lblErrorNewEmail.Text = "";

            string newEmail = txtNewEmail.Text.Trim();

            if (!ValidateEmail(newEmail))
            {
                lblErrorNewEmail.Text = "Некоректний формат Email!";
                return;
            }

            UpdateEmail(newEmail);

            MessageBox.Show("Email успішно змінено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^\S+@\S+\.\S+$");
        }

        private void UpdateEmail(string newEmail)
        {
            string usersFile = "users.txt";
            if (File.Exists(usersFile))
            {
                var lines = File.ReadAllLines(usersFile);
                for (int i = 0; i < lines.Length; i++)
                {
                    var data = lines[i].Split(';');
                    if (data[0] == username && data.Length >= 3)
                    {
                        data[2] = newEmail;
                        lines[i] = string.Join(";", data);
                        break;
                    }
                }
                File.WriteAllLines(usersFile, lines);
            }
        }
    }
}
