using System;
using System.Text;
using System.Windows.Forms;

public partial class task04 : Form
{
    public task04()
    {
        InitializeComponent();
    }

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

    private void BrowseFile(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Виберіть файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                opinionFileTextBox.Text = openFileDialog.FileName;
            }
        }
    }
    private void SubmitData(object sender, EventArgs e)
    {
        string gender = maleRadioButton.Checked ? "Чоловіча" : "Жіноча";
        var interests = new StringBuilder(); // Використання StringBuilder для інтересів

        if (computersCheckBox.Checked) interests.Append("Комп'ютери, ");
        if (sportsCheckBox.Checked) interests.Append("Спорт, ");
        if (artCheckBox.Checked) interests.Append("Мистецтво, ");
        if (scienceCheckBox.Checked) interests.Append("Наука, ");

        // Видалити останню кому і пробіл, якщо інтереси не пусті
        string interestsString = interests.Length > 0
            ? interests.ToString().Substring(0, interests.Length - 2) // Видалити останню кому і пробіл
            : "";

        // Формуємо повідомлення у змінній
        var messageBuilder = new StringBuilder();
        messageBuilder.AppendLine("Дані відправлено!\n");
        messageBuilder.AppendLine($"Ім'я: {nameTextBox.Text}");
        messageBuilder.AppendLine($"Пароль: {passwordTextBox.Text}");
        messageBuilder.AppendLine($"Вік: {ageComboBox.SelectedItem}");
        messageBuilder.AppendLine($"Стать: {gender}");
        messageBuilder.AppendLine($"Інтереси: {interestsString}");
        messageBuilder.AppendLine($"Файл: {opinionFileTextBox.Text}");
        messageBuilder.AppendLine($"Думка: {opinionTextBox.Text}");

        // Відображення повідомлення
        MessageBox.Show(messageBuilder.ToString(), "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new task04());
    }
}
