using System;
using System.Windows.Forms;

namespace task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ��� �� ComboBox �� ListBox �� ��� ������������ �����
            string[] cities = { "����", "������", "��������", "���������", "�����", "ѳ���", "�������" };
            comboBoxCities.Items.AddRange(cities);
            listBoxCities.Items.AddRange(cities);
        }
    }
}
