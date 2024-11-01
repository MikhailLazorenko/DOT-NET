using System;
using System.Windows.Forms;
using System.Drawing; 
namespace Lab08
{
    public partial class task01 : Form
    {
        public task01()
        {
            InitializeComponent();
        }

        // �������� ���������� ������ "³������"
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            // ������������ ������� ������ ��� ��������� ����
            textBoxName.Font = new Font(textBoxName.Font, FontStyle.Bold);
            textBoxPhone.Font = new Font(textBoxPhone.Font, FontStyle.Bold);
            textBoxEmail.Font = new Font(textBoxEmail.Font, FontStyle.Bold);

            MessageBox.Show("��� ������ ���������!");
        }

        // �������� ���������� ������ "�������"
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            // �������� ��������� ����
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            dateTimePickerDOB.Value = DateTime.Now;

            // �������� ������ ��������� ����
            textBoxName.Font = new Font(textBoxName.Font, FontStyle.Regular);
            textBoxPhone.Font = new Font(textBoxPhone.Font, FontStyle.Regular);
            textBoxEmail.Font = new Font(textBoxEmail.Font, FontStyle.Regular);
        }
    }
}
