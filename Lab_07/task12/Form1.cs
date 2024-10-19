using System;
using System.Windows.Forms;

namespace task12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Додаємо обробник події SelectedIndexChanged для ComboBox
            comboBoxCities.SelectedIndexChanged += ComboBoxCities_SelectedIndexChanged;
        }

        // Обробник події SelectedIndexChanged
        private void ComboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отримуємо вибране місто
            string selectedCity = comboBoxCities.SelectedItem.ToString();
            // Виводимо вибране місто в MsgBox
            MessageBox.Show($"Вибране місто: {selectedCity}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
