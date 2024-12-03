using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Task_8_Test;

namespace Task_8_Test
{
    public partial class LogForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\source\repos\Task_8_Test\Task_8_Test\SocNetDB.mdf;Integrated Security=True";

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
            bool isAuthenticated = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                isAuthenticated = count > 0;
            }

            return isAuthenticated;
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
