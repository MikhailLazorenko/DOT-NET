using System;
using System.Windows.Forms;

namespace task02
{
    public partial class Form2 : Form
    {
        public string CallerName { get; set; }
        public string CallerInfo { get; set; }
        public string ReturnInfo { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelCallerInfo.Text = $"Викликано з {CallerName}: {CallerInfo}";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnInfo = textBoxInfo.Text;
        }

        private void toolStripButtonForm5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.CallerName = "Form2";
            form5.CallerInfo = textBoxInfo.Text;
            form5.ShowDialog();

            string infoFromForm5 = form5.ReturnInfo;
            labelCallerInfo.Text = $"Повернулося з Form5: {infoFromForm5}";
        }

        private void toolStripButtonForm6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.CallerName = "Form2";
            form6.CallerInfo = textBoxInfo.Text;
            form6.ShowDialog();

            string infoFromForm6 = form6.ReturnInfo;
            labelCallerInfo.Text = $"Повернулося з Form6: {infoFromForm6}";
        }

        private void toolStripButtonForm7_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.CallerName = "Form2";
            form7.CallerInfo = textBoxInfo.Text;
            form7.ShowDialog();

            string infoFromForm7 = form7.ReturnInfo;
            labelCallerInfo.Text = $"Повернулося з Form7: {infoFromForm7}";
        }
    }
}
