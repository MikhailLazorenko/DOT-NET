using System;
using System.Windows.Forms;

namespace task02
{
    public partial class Form3 : Form
    {
        public string CallerName { get; set; }
        public string CallerInfo { get; set; }
        public string ReturnInfo { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labelCallerInfo.Text = $"Викликано з {CallerName}: {CallerInfo}";
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnInfo = textBoxInfo.Text;
        }
    }
}
