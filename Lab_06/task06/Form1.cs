using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
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
        string interests = "";

        if (computersCheckBox.Checked) interests += "Комп'ютери, ";
        if (sportsCheckBox.Checked) interests += "Спорт, ";
        if (artCheckBox.Checked) interests += "Мистецтво, ";
        if (scienceCheckBox.Checked) interests += "Наука, ";

        // Видалити останню кому і пробіл, якщо інтереси не пусті
        if (interests.Length > 0)
        {
            interests = interests.Substring(0, interests.Length - 2); // Видалити останню кому і пробіл
        }

        // Формуємо повідомлення у змінній
        string message = $"Дані відправлено!\n\n" +
                         $"Ім'я: {nameTextBox.Text}\n" +
                         $"Пароль: {passwordTextBox.Text}\n" +
                         $"Вік: {ageComboBox.SelectedItem}\n" +
                         $"Стать: {gender}\n" +
                         $"Інтереси: {interests}\n" +
                         $"Файл: {opinionFileTextBox.Text}\n" +
                         $"Думка: {opinionTextBox.Text}";

        // Відображення повідомлення
        MessageBox.Show(message, "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}
