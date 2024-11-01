using System;
using System.Windows.Forms;

namespace Lab08
{
    public partial class task02 : Form
    {
        public task02() // Конструктор форми, встановлює початкові значення радіокнопок
        {
            InitializeComponent();
            radioButtonKharkiv.Checked = true; // Місто за замовчуванням
            radioButtonTrain.Checked = true; // Транспорт за замовчуванням
        }

        private void buttonSelect_Click(object sender, EventArgs e) // Обробка вибору міста і транспорту
        {
            string selectedCity = "";
            string selectedTransport = "";

            // Визначення вибраного міста
            if (radioButtonKharkiv.Checked)
                selectedCity = radioButtonKharkiv.Text;
            else if (radioButtonKyiv.Checked)
                selectedCity = radioButtonKyiv.Text;
            else if (radioButtonOdesa.Checked)
                selectedCity = radioButtonOdesa.Text;
            else if (radioButtonZaporizhzhia.Checked)
                selectedCity = radioButtonZaporizhzhia.Text;

            // Визначення вибраного транспорту
            if (radioButtonBus.Checked)
                selectedTransport = radioButtonBus.Text;
            else if (radioButtonTrain.Checked)
                selectedTransport = radioButtonTrain.Text;
            else if (radioButtonPlane.Checked)
                selectedTransport = radioButtonPlane.Text;

            // Виведення результатів
            MessageBox.Show($"Ви вибрали місто: {selectedCity} та транспорт: {selectedTransport}", "Вибір");
        }

        private void buttonSend_Click(object sender, EventArgs e) // Обробка натискання кнопки "Відіслати"
        {
            // Застосування жирного шрифту до тексту в радіокнопках
            foreach (Control control in groupBoxCity.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    rb.Font = new System.Drawing.Font(rb.Font, System.Drawing.FontStyle.Bold);
                }
            }

            foreach (Control control in groupBoxTransport.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    rb.Font = new System.Drawing.Font(rb.Font, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e) // Обробка натискання кнопки "Скинути"
        {
            // Скидання вибору радіокнопок
            radioButtonKharkiv.Checked = true; // Скидання міста
            radioButtonTrain.Checked = true; // Скидання транспорту

            // Скидання шрифтів
            ResetFontStyles(groupBoxCity);
            ResetFontStyles(groupBoxTransport);
        }

        private void ResetFontStyles(GroupBox groupBox) // Метод скидання стилів шрифтів
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton rb)
                {
                    rb.Font = new System.Drawing.Font(rb.Font, System.Drawing.FontStyle.Regular); // Відновлення до звичайного шрифту
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) // Закриття форми
        {
            this.Close();
        }
    }
}
