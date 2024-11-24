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
        // ������������ ������������ ��� �������
        LoadConfigurationAtStartup();
    }

    // ����� ��� ������������� ������������ ������������
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
                MessageBox.Show("������� ��� ����������� ������������: " + ex.Message, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // �������� ��䳿 ��� ������ "�������� �����"
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

    // �������� ��䳿 ��� ������ "�����..."
    private void BrowseFile(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "������� ����� (*.txt)|*.txt|�� ����� (*.*)|*.*";
            openFileDialog.Title = "������� ����";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                opinionFileTextBox.Text = openFileDialog.FileName;
            }
        }
    }

    // �������� ��䳿 ��� ������ "³��������"
    private void SubmitData(object sender, EventArgs e)
    {
        string gender = maleRadioButton.Checked ? "�������" : "Ƴ����";
        var interests = new StringBuilder();

        if (computersCheckBox.Checked) interests.Append("����'�����, ");
        if (sportsCheckBox.Checked) interests.Append("�����, ");
        if (artCheckBox.Checked) interests.Append("���������, ");
        if (scienceCheckBox.Checked) interests.Append("�����, ");

        string interestsString = interests.Length > 0
            ? interests.ToString().Substring(0, interests.Length - 2)
            : "";

        var messageBuilder = new StringBuilder();
        messageBuilder.AppendLine("��� ����������!\n");
        messageBuilder.AppendLine($"��'�: {nameTextBox.Text}");
        messageBuilder.AppendLine($"������: {passwordTextBox.Text}");
        messageBuilder.AppendLine($"³�: {ageComboBox.SelectedItem}");
        messageBuilder.AppendLine($"�����: {gender}");
        messageBuilder.AppendLine($"��������: {interestsString}");
        messageBuilder.AppendLine($"����: {opinionFileTextBox.Text}");
        messageBuilder.AppendLine($"�����: {opinionTextBox.Text}");

        MessageBox.Show(messageBuilder.ToString(), "ϳ�����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // �������� ��䳿 ��� ������ "���������"
    private void OpenSettings(object sender, EventArgs e)
    {
        SettingsForm settingsForm = new SettingsForm(this);
        settingsForm.ShowDialog();
    }

    // ����� Dispose ��� ��������� �������
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    // ����� ����� � ��������
    [STAThread]
    public static void mainForm()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}
