using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab12
{
    public partial class MsgSendForm : Form
    {
        private string senderUsername;

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
            string usersFile = "users.txt";
            if (File.Exists(usersFile))
            {
                var lines = File.ReadAllLines(usersFile);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data.Length >= 1 && data[0] == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void SaveMessage(string recipient, string theme, string text)
        {
            string messagesFile = "messages.txt";
            string messageLine = $"{recipient};{senderUsername};{theme};{text}";
            File.AppendAllLines(messagesFile, new string[] { messageLine });
        }
    }
}
