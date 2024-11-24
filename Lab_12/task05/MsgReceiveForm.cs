using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using UserMessage = Lab12.Message; 

namespace Lab12
{
    public partial class MsgReceiveForm : Form
    {
        private string username;
        private List<UserMessage> messages = new List<UserMessage>(); // Ініціалізація списку

        public MsgReceiveForm(string username)
        {
            this.username = username;
            InitializeComponent();
            LoadMessages();
        }

        private void LoadMessages()
        {
            string messagesFile = "messages.txt";
            if (File.Exists(messagesFile))
            {
                var lines = File.ReadAllLines(messagesFile);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data.Length >= 4)
                    {
                        string recipient = data[0];
                        string sender = data[1];
                        string theme = data[2];
                        string text = data[3];

                        if (recipient == username)
                        {
                            messages.Add(new UserMessage
                            {
                                Sender = sender,
                                Theme = theme,
                                Text = text
                            });
                        }
                    }
                }
            }

            lstMessages.Items.Clear();
            foreach (var message in messages)
            {
                lstMessages.Items.Add($"{message.Sender}: {message.Theme}");
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