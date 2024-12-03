using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_8_Test
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
