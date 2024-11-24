using System;
using System.Windows.Forms;
using task05;

namespace task05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBoxCities.SelectedItem.ToString();
            CityForm cityForm = new CityForm(selectedCity);
            cityForm.ShowDialog();
        }
    }
}
