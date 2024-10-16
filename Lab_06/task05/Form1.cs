using System;
using System.Windows.Forms;

namespace task05
{
    public partial class Form1 : Form
    {
        public Form1() // Конструктор форми.
        {
            InitializeComponent();

            // Встановлення координат для CheckBox та Label.
            checkBoxSports.Location = new System.Drawing.Point(330, 50);
            labelSports.Location = new System.Drawing.Point(75, 50);

            checkBoxTravel.Location = new System.Drawing.Point(330, 80);
            labelTravel.Location = new System.Drawing.Point(75, 80);

            checkBoxCrafting.Location = new System.Drawing.Point(250, 110);
            labelCrafting.Location = new System.Drawing.Point(160, 110);

            checkBoxPainting.Location = new System.Drawing.Point(250, 140);
            labelPainting.Location = new System.Drawing.Point(170, 140);
        }

        private void ButtonChoose_Click(object sender, EventArgs e)
        {
            // Формування повідомлення з вибраними інтересами.
            string selectedInterests = "Ви вибрали: ";

            if (checkBoxSports.Checked)
                selectedInterests += "Спорт ";
            if (checkBoxTravel.Checked)
                selectedInterests += "Мандрівки ";
            if (checkBoxCrafting.Checked)
                selectedInterests += "Майстрування ";
            if (checkBoxPainting.Checked)
                selectedInterests += "Малювання ";

            MessageBox.Show(selectedInterests); // Виведення результатів.
        }

        private void ButtonRefuse_Click(object sender, EventArgs e)
        {
            // Скидання вибору.
            checkBoxSports.Checked = false;
            checkBoxTravel.Checked = false;
            checkBoxCrafting.Checked = false;
            checkBoxPainting.Checked = false;

            MessageBox.Show("Ви відмовилися від вибору.");
        }
    }
}
