using System;
using System.Windows.Forms;

namespace task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обробник натискання кнопки "Відіслати"
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дані успішно відправлені!");
        }

        // Обробник натискання кнопки "Скинути"
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
        }
    }
}
