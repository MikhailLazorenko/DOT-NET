using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Task_8_Test
{
    public partial class ProfileForm : Form
    {
        private string username;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\source\repos\Task_8_Test\Task_8_Test\SocNetDB.mdf;Integrated Security=True";

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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Email FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                var email = cmd.ExecuteScalar();
                if (email != null)
                {
                    lblEmail.Text = email.ToString();
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
