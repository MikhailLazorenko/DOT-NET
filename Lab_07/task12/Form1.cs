using System;
using System.Windows.Forms;

namespace task12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ������ �������� ��䳿 SelectedIndexChanged ��� ComboBox
            comboBoxCities.SelectedIndexChanged += ComboBoxCities_SelectedIndexChanged;
        }

        // �������� ��䳿 SelectedIndexChanged
        private void ComboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �������� ������� ����
            string selectedCity = comboBoxCities.SelectedItem.ToString();
            // �������� ������� ���� � MsgBox
            MessageBox.Show($"������� ����: {selectedCity}", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
