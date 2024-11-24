using System;
using System.Windows.Forms;

namespace task02
{
    public partial class Form8 : Form
    {
        public string CallerName { get; set; }
        public string CallerInfo { get; set; }
        public string ReturnInfo { get; set; }

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            labelCallerInfo.Text = $"Викликано з {CallerName}: {CallerInfo}";
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnInfo = textBoxInfo.Text;
        }
    }
}
