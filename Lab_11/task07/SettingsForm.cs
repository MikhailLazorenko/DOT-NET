using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

    // Обробник події для кнопки "Зберегти конфігурацію"
    private void buttonSaveConfiguration_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Filter = "Файли конфігурації (*.cfg)|*.cfg|Всі файли (*.*)|*.*";
            saveFileDialog.Title = "Зберегти конфігурацію";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Configuration config = new Configuration(mainForm);
                    XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        serializer.Serialize(fs, config);
                    }
                    MessageBox.Show("Конфігурацію успішно збережено.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні конфігурації: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    // Обробник події для кнопки "Завантажити конфігурацію"
    private void buttonLoadConfiguration_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Файли конфігурації (*.cfg)|*.cfg|Всі файли (*.*)|*.*";
            openFileDialog.Title = "Завантажити конфігурацію";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        Configuration config = (Configuration)serializer.Deserialize(fs);
                        config.ApplyConfiguration(mainForm);
                    }
                    MessageBox.Show("Конфігурацію успішно завантажено.", "Завантаження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні конфігурації: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
