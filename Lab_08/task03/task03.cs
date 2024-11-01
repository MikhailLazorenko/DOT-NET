using System;
using System.Windows.Forms;

namespace Lab08
{
    public partial class task03 : Form
    {
        public task03() // Конструктор форми.
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
            // Скидання вибору чекбоксів до значень за замовчуванням.
            checkBoxSports.Checked = true;
            checkBoxTravel.Checked = false;
            checkBoxCrafting.Checked = true;
            checkBoxPainting.Checked = false;

            // Скидання стилю шрифту до звичайного.
            labelSports.Font = new System.Drawing.Font(labelSports.Font, System.Drawing.FontStyle.Regular);
            labelTravel.Font = new System.Drawing.Font(labelTravel.Font, System.Drawing.FontStyle.Regular);
            labelCrafting.Font = new System.Drawing.Font(labelCrafting.Font, System.Drawing.FontStyle.Regular);
            labelPainting.Font = new System.Drawing.Font(labelPainting.Font, System.Drawing.FontStyle.Regular);

            MessageBox.Show("Вибір скинуто."); // Повідомлення про скидання.
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            // Застосування жирного шрифту до вибраних текстових рядків.
            if (checkBoxSports.Checked)
                labelSports.Font = new System.Drawing.Font(labelSports.Font, System.Drawing.FontStyle.Bold);
            else
                labelSports.Font = new System.Drawing.Font(labelSports.Font, System.Drawing.FontStyle.Regular);

            if (checkBoxTravel.Checked)
                labelTravel.Font = new System.Drawing.Font(labelTravel.Font, System.Drawing.FontStyle.Bold);
            else
                labelTravel.Font = new System.Drawing.Font(labelTravel.Font, System.Drawing.FontStyle.Regular);

            if (checkBoxCrafting.Checked)
                labelCrafting.Font = new System.Drawing.Font(labelCrafting.Font, System.Drawing.FontStyle.Bold);
            else
                labelCrafting.Font = new System.Drawing.Font(labelCrafting.Font, System.Drawing.FontStyle.Regular);

            if (checkBoxPainting.Checked)
                labelPainting.Font = new System.Drawing.Font(labelPainting.Font, System.Drawing.FontStyle.Bold);
            else
                labelPainting.Font = new System.Drawing.Font(labelPainting.Font, System.Drawing.FontStyle.Regular);
        }
    }
}
