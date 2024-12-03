using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Task_8_Test
{
    public partial class MsgReceiveForm : Form
    {
        private string username;
        private List<Message> messages = new List<Message>();
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\source\repos\Task_8_Test\Task_8_Test\SocNetDB.mdf;Integrated Security=True";

        public MsgReceiveForm(string username)
        {
            this.username = username;
            InitializeComponent();
            LoadMessages();
        }

        private void LoadMessages()
        {
            messages.Clear();
            lstMessages.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Sender, Theme, Text FROM Messages WHERE Recipient = @Recipient";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Recipient", username);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string sender = reader.GetString(0);
                        string theme = reader.GetString(1);
                        string text = reader.GetString(2);

                        Message msg = new Message(sender, theme, text);
                        messages.Add(msg);
                        lstMessages.Items.Add($"{sender}: {theme}");
                    }
                }
            }
        }

        private void lstMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstMessages.SelectedIndex;
            if (index >= 0 && index < messages.Count)
            {
                MsgDetailsForm messageDetailsForm = new MsgDetailsForm(messages[index]);
                messageDetailsForm.ShowDialog();
            }
        }
    }
}
