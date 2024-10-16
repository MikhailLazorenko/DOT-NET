using System;
using System.Windows.Forms;

namespace task04
{
    public partial class Form1 : Form
    {
        public Form1() // ����������� �����, ���������� �������� �������� ����������
        {
            InitializeComponent();
            radioButtonKharkiv.Checked = true; // ̳��� �� �����������
            radioButtonTrain.Checked = true; // ��������� �� �����������
        }

        private void buttonSelect_Click(object sender, EventArgs e) // ������� ������ ���� � ����������
        {
            string selectedCity = "";
            string selectedTransport = "";

            // ���������� ��������� ����
            if (radioButtonKharkiv.Checked)
                selectedCity = radioButtonKharkiv.Text;
            else if (radioButtonKyiv.Checked)
                selectedCity = radioButtonKyiv.Text;
            else if (radioButtonOdesa.Checked)
                selectedCity = radioButtonOdesa.Text;
            else if (radioButtonZaporizhzhia.Checked)
                selectedCity = radioButtonZaporizhzhia.Text;

            // ���������� ��������� ����������
            if (radioButtonBus.Checked)
                selectedTransport = radioButtonBus.Text;
            else if (radioButtonTrain.Checked)
                selectedTransport = radioButtonTrain.Text;
            else if (radioButtonPlane.Checked)
                selectedTransport = radioButtonPlane.Text;

            // ��������� ����������
            MessageBox.Show($"�� ������� ����: {selectedCity} �� ���������: {selectedTransport}", "����");
        }

        private void buttonCancel_Click(object sender, EventArgs e) // �������� �����
        {
            this.Close();
        }
    }
}
