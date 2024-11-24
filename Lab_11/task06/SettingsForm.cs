using System;
using System.Drawing;
using System.Windows.Forms;

public partial class SettingsForm : Form
{
    private Form1 mainForm;

    public SettingsForm(Form1 form)
    {
        InitializeComponent();
        mainForm = form;
    }

    // Обробник події для кнопки "Змінити колір фону форми"
    private void buttonChangeBackground_Click(object sender, EventArgs e)
    {
        using (ColorDialog colorDialog = new ColorDialog())
        {
            colorDialog.Color = mainForm.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.BackColor = colorDialog.Color;
            }
        }
    }

    // Обробник події для кнопки "Змінити шрифт кнопки 'Відправити'"
    private void buttonChangeButtonFont_Click(object sender, EventArgs e)
    {
        using (FontDialog fontDialog = new FontDialog())
        {
            fontDialog.Font = mainForm.submitButton.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.submitButton.Font = fontDialog.Font;
            }
        }
    }

    // Обробник події для кнопки "Змінити шрифт заголовків"
    private void buttonChangeLabelFont_Click(object sender, EventArgs e)
    {
        using (FontDialog fontDialog = new FontDialog())
        {
            fontDialog.Font = mainForm.personalInfoGroupBox.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.personalInfoGroupBox.Font = fontDialog.Font;
                mainForm.opinionGroupBox.Font = fontDialog.Font;
            }
        }
    }

    // Обробник події для кнопки "Змінити колір поля 'Думка'"
    private void buttonChangeTextBoxColor_Click(object sender, EventArgs e)
    {
        using (ColorDialog colorDialog = new ColorDialog())
        {
            colorDialog.Color = mainForm.opinionTextBox.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.opinionTextBox.BackColor = colorDialog.Color;
            }
        }
    }

    // Обробник події для кнопки "Змінити шрифт чекбоксів 'Інтереси'"
    private void buttonChangeCheckBoxFont_Click(object sender, EventArgs e)
    {
        using (FontDialog fontDialog = new FontDialog())
        {
            fontDialog.Font = mainForm.computersCheckBox.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in mainForm.personalInfoGroupBox.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        checkBox.Font = fontDialog.Font;
                    }
                }
            }
        }
    }
}
