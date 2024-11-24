using System;
using System.Windows.Forms;
using task02;

namespace task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelCallerInfo.Text = "Немає попередньої форми";
        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            // Передача інформації до Form2
            form2.CallerName = "Form1";
            form2.CallerInfo = textBoxInfo.Text;
            form2.ShowDialog();

            // Отримання інформації від Form2
            string infoFromForm2 = form2.ReturnInfo;
            labelCallerInfo.Text = $"Повернулося з Form2: {infoFromForm2}";
        }

        private void buttonForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.CallerName = "Form1";
            form3.CallerInfo = textBoxInfo.Text;
            form3.ShowDialog();

            string infoFromForm3 = form3.ReturnInfo;
            labelCallerInfo.Text = $"Повернулося з Form3: {infoFromForm3}";
        }

        private void buttonForm4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.CallerName = "Form1";
            form4.CallerInfo = textBoxInfo.Text;
            form4.ShowDialog();

            string infoFromForm4 = form4.ReturnInfo;
            labelCallerInfo.Text = $"Повернулося з Form4: {infoFromForm4}";
        }
    }
}
