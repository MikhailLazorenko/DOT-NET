using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task_8_Test
{
    public partial class ChangePasswordForm : Form
    {
        private string username;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\source\repos\Task_8_Test\Task_8_Test\SocNetDB.mdf;Integrated Security=True";

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
            bool isValid = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Password FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                var storedPassword = cmd.ExecuteScalar();
                if (storedPassword != null && storedPassword.ToString() == oldPassword)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        private bool ValidatePassword(string password)
        {
            // Така ж перевірка як і раніше
            return Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*]).{12,}$");
        }

        private void UpdatePassword(string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Password = @Password WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
