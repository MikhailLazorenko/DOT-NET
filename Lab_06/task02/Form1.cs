using System;
using System.Windows.Forms;

namespace task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Додавання міст до ComboBox та ListBox під час завантаження форми
            string[] cities = { "Пекін", "Шанхай", "Гуанчжоу", "Шеньчжень", "Ченду", "Сіань", "Ханчжоу" };
            comboBoxCities.Items.AddRange(cities);
            listBoxCities.Items.AddRange(cities);
        }
    }
}
