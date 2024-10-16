using System;
using System.Windows.Forms;

namespace task04
{
    public partial class Form1 : Form
    {
        public Form1() // Конструктор форми, встановлює початкові значення радіокнопок
        {
            InitializeComponent();
            radioButtonKharkiv.Checked = true; // Місто за замовчанням
            radioButtonTrain.Checked = true; // Транспорт за замовчанням
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

        private void buttonCancel_Click(object sender, EventArgs e) // Закриття форми
        {
            this.Close();
        }
    }
}
