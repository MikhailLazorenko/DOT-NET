using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_8_Test
{
    public partial class MsgSendForm : Form
    {
        private string senderUsername;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\source\repos\Task_8_Test\Task_8_Test\SocNetDB.mdf;Integrated Security=True";

        public MsgSendForm(string senderUsername)
        {
            this.senderUsername = senderUsername;
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";

            string recipient = txtTo.Text.Trim();
            string theme = txtTheme.Text.Trim();
            string text = txtText.Text.Trim();

            if (string.IsNullOrEmpty(recipient) || string.IsNullOrEmpty(text))
            {
                lblErrorMessage.Text = "Будь ласка, заповніть всі обов'язкові поля.";
                return;
            }

            if (!UserExists(recipient))
            {
                lblErrorMessage.Text = "Користувача не знайдено.";
                return;
            }

            SaveMessage(recipient, theme, text);

            MessageBox.Show("Повідомлення надіслано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool UserExists(string username)
        {
            bool exists = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }

            return exists;
        }

        private void SaveMessage(string recipient, string theme, string text)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Messages (Recipient, Sender, Theme, Text) VALUES (@Recipient, @Sender, @Theme, @Text)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Recipient", recipient);
                cmd.Parameters.AddWithValue("@Sender", senderUsername);
                cmd.Parameters.AddWithValue("@Theme", theme);
                cmd.Parameters.AddWithValue("@Text", text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
