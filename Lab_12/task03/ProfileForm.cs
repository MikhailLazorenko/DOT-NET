using Lab12;
using System;
using System.IO;
using System.Windows.Forms;

namespace Lab12
{
    public partial class ProfileForm : Form
    {
        private string username;

        public ProfileForm(string username)
        {
            this.username = username;
            InitializeComponent();
            lblUsername.Text = username;

            // Завантажити дані користувача
            LoadUserData();
        }

        private void LoadUserData()
        {
            string usersFile = "users.txt";
            if (File.Exists(usersFile))
            {
                var lines = File.ReadAllLines(usersFile);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data.Length >= 3)
                    {
                        string storedUsername = data[0];
                        if (storedUsername == username)
                        {
                            lblEmail.Text = data[2];
                            return;
                        }
                    }
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Відкрити форму зміни пароля
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(username);
            changePasswordForm.ShowDialog();
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            // Відкрити форму зміни Email
            ChangeEmailForm changeEmailForm = new ChangeEmailForm(username);
            changeEmailForm.ShowDialog();
            // Оновити Email на профільній формі після зміни
            LoadUserData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Повернутися до форми авторизації
            LogForm loginForm = new LogForm();
            loginForm.Show();
            this.Close();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            // Відкрити форму відправки повідомлення
            MsgSendForm messageSendForm = new MsgSendForm(username);
            messageSendForm.Show();
        }

        private void btnViewMessages_Click(object sender, EventArgs e)
        {
            // Відкрити форму отримання повідомлень
            MsgReceiveForm messageReceiveForm = new MsgReceiveForm(username);
            messageReceiveForm.Show();
        }
    }
}
