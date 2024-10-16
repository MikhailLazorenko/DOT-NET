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
            openFileDialog.Title = "������� ����";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                opinionFileTextBox.Text = openFileDialog.FileName;
            }
        }
    }

    private void SubmitData(object sender, EventArgs e)
    {
        string gender = maleRadioButton.Checked ? "�������" : "Ƴ����";
        string interests = "";
        if (computersCheckBox.Checked) interests += "����'�����, ";
        if (sportsCheckBox.Checked) interests += "�����, ";
        if (artCheckBox.Checked) interests += "���������, ";
        if (scienceCheckBox.Checked) interests += "�����, ";

        if (interests.Length > 0)
        {
            interests = interests.Substring(0, interests.Length - 2); // �������� ������� ���� � �����
        }

        MessageBox.Show($"��� ����������!\n\n��'�: {nameTextBox.Text}\n������: {passwordTextBox.Text}\n³�: {ageComboBox.SelectedItem}\n�����: {gender}\n��������: {interests}\n����: {opinionFileTextBox.Text}\n�����: {opinionTextBox.Text}", "ϳ�����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}
