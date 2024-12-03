using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task_8_Test
{
    public partial class ChangeEmailForm : Form
    {
        private string username;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\source\repos\Task_8_Test\Task_8_Test\SocNetDB.mdf;Integrated Security=True";

        public ChangeEmailForm(string username)
        {
            this.username = username;
            InitializeComponent();
            LoadCurrentEmail();
        }

        private void LoadCurrentEmail()
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
                    txtCurrentEmail.Text = email.ToString();
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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Email = @Email WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", newEmail);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
