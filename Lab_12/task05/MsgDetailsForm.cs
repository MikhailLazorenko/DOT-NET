using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab12
{
    public partial class MsgDetailsForm : Form
    {
        private Message message;

        public MsgDetailsForm(Message message)
        {
            this.message = message;
            InitializeComponent();
            lblSender.Text = $"Від: {message.Sender}";
            lblTheme.Text = $"Тема: {message.Theme}";
            txtText.Text = message.Text;
        }
    }
}
