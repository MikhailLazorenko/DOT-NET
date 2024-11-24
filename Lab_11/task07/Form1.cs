using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using task07;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // Завантаження конфігурації при запуску
        LoadConfigurationAtStartup();
    }

    // Метод для автоматичного завантаження конфігурації
    private void LoadConfigurationAtStartup()
    {
        string configFile = "default.cfg";
        if (File.Exists(configFile))
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                using (FileStream fs = new FileStream(configFile, FileMode.Open))
                {
                    Configuration config = (Configuration)serializer.Deserialize(fs);
                    config.ApplyConfiguration(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні конфігурації: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Обробник події для кнопки "Очистити форму"
    private void ClearForm(object sender, EventArgs e)
    {
        passwordTextBox.Clear();
        nameTextBox.Clear();
        ageComboBox.SelectedIndex = -1;
        maleRadioButton.Checked = false;
        femaleRadioButton.Checked = false;
        computersCheckBox.Checked = false;
        sportsCheckBox.Checked = false;
        artCheckBox.Checked = false;
        scienceCheckBox.Checked = false;
        opinionFileTextBox.Clear();
        opinionTextBox.Clear();
    }

    // Обробник події для кнопки "Огляд..."
    private void BrowseFile(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
            openFileDialog.Title = "Виберіть файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                opinionFileTextBox.Text = openFileDialog.FileName;
            }
        }
    }

    // Обробник події для кнопки "Відправити"
    private void SubmitData(object sender, EventArgs e)
    {
        string gender = maleRadioButton.Checked ? "Чоловіча" : "Жіноча";
        var interests = new StringBuilder();

        if (computersCheckBox.Checked) interests.Append("Комп'ютери, ");
        if (sportsCheckBox.Checked) interests.Append("Спорт, ");
        if (artCheckBox.Checked) interests.Append("Мистецтво, ");
        if (scienceCheckBox.Checked) interests.Append("Наука, ");

        string interestsString = interests.Length > 0
            ? interests.ToString().Substring(0, interests.Length - 2)
            : "";

        var messageBuilder = new StringBuilder();
        messageBuilder.AppendLine("Дані відправлено!\n");
        messageBuilder.AppendLine($"Ім'я: {nameTextBox.Text}");
        messageBuilder.AppendLine($"Пароль: {passwordTextBox.Text}");
        messageBuilder.AppendLine($"Вік: {ageComboBox.SelectedItem}");
        messageBuilder.AppendLine($"Стать: {gender}");
        messageBuilder.AppendLine($"Інтереси: {interestsString}");
        messageBuilder.AppendLine($"Файл: {opinionFileTextBox.Text}");
        messageBuilder.AppendLine($"Думка: {opinionTextBox.Text}");

        MessageBox.Show(messageBuilder.ToString(), "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // Обробник події для кнопки "Параметри"
    private void OpenSettings(object sender, EventArgs e)
    {
        SettingsForm settingsForm = new SettingsForm(this);
        settingsForm.ShowDialog();
    }

    // Метод Dispose для звільнення ресурсів
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    // Точка входу в програму
    [STAThread]
    public static void mainForm()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}
