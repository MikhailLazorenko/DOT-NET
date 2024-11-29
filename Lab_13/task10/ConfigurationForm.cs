using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace task10
{
    public partial class SettingsForm : Form
    {
        public Form1.BallSettings UpdatedSettings { get; private set; }

        public SettingsForm(Form1.BallSettings currentSettings)
        {
            InitializeComponent();

            // Клонування поточних налаштувань для редагування
            UpdatedSettings = new Form1.BallSettings
            {
                NumberOfBalls = currentSettings.NumberOfBalls,
                Colors = new List<Color>(currentSettings.Colors),
                Diameter = currentSettings.Diameter,
                Speed = currentSettings.Speed
            };

            // Ініціалізація елементів управління
            numericUpDownNumber.Value = UpdatedSettings.NumberOfBalls;
            numericUpDownDiameter.Value = UpdatedSettings.Diameter;
            numericUpDownSpeed.Value = (decimal)UpdatedSettings.Speed;

            // Ініціалізація списку кольорів
            listViewColors.Clear();
            listViewColors.View = View.Details;
            listViewColors.Columns.Add("Кольори", -2, HorizontalAlignment.Left);
            listViewColors.FullRowSelect = true;

            foreach (Color color in UpdatedSettings.Colors)
            {
                ListViewItem item = new ListViewItem
                {
                    BackColor = color,
                    Text = color.IsNamedColor ? color.Name : $"RGB({color.R},{color.G},{color.B})"
                };
                listViewColors.Items.Add(item);
            }
        }

        private void buttonAddColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    UpdatedSettings.Colors.Add(colorDialog.Color);
                    ListViewItem item = new ListViewItem
                    {
                        BackColor = colorDialog.Color,
                        Text = colorDialog.Color.IsNamedColor ? colorDialog.Color.Name : $"RGB({colorDialog.Color.R},{colorDialog.Color.G},{colorDialog.Color.B})"
                    };
                    listViewColors.Items.Add(item);
                }
            }
        }

        private void buttonRemoveColor_Click(object sender, EventArgs e)
        {
            if (listViewColors.SelectedItems.Count > 0)
            {
                int index = listViewColors.SelectedItems[0].Index;
                listViewColors.Items.RemoveAt(index);
                UpdatedSettings.Colors.RemoveAt(index);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Валідація введених даних
            if (UpdatedSettings.Colors.Count == 0)
            {
                MessageBox.Show("Будь ласка, додайте хоча б один колір.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericUpDownSpeed.Value <= 0)
            {
                MessageBox.Show("Швидкість повинна бути більше нуля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Оновлення налаштувань
            UpdatedSettings.NumberOfBalls = (int)numericUpDownNumber.Value;
            UpdatedSettings.Diameter = (int)numericUpDownDiameter.Value;
            UpdatedSettings.Speed = (double)numericUpDownSpeed.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
