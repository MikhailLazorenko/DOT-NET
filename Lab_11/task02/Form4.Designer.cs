using System;
using System.Windows.Forms;

namespace task02
{
    public partial class Form4 : Form
    {
        public string CallerName { get; set; }
        public string CallerInfo { get; set; }
        public string ReturnInfo { get; set; }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            labelCallerInfo.Text = $"Викликано з {CallerName}: {CallerInfo}";
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnInfo = textBoxInfo.Text;
        }

        private void contextMenuItemForm8_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.CallerName = "Form4";
            form8.CallerInfo = textBoxInfo.Text;
            form8.ShowDialog();

            string infoFromForm8 = form8.ReturnInfo;
            labelCallerInfo.Text = $"Повернулося з Form8: {infoFromForm8}";
        }
    }
}
