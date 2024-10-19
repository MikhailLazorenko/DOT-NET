using System;
using System.Windows.Forms;

namespace task14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // �������� ��䳿 ������������ �����
        protected override void OnLoad(EventArgs e)
        {
            // �������� �������� ���� �� ������� ��� ������������ �����
            var result = MessageBox.Show("������ ����������� �����?", "����� �� ������������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ���� ���������� ������ "ͳ", ��������� ����� � ��������� ������������
            if (result == DialogResult.No)
            {
                this.Close();
                return;
            }

            // ���� ���������� ������ "���", ����������� ����� �� ��������� � ����� ����� ����� ������
            base.OnLoad(e);
            SetFormPosition();
        }

        private void SetFormPosition()
        {
            // �������� ������ ������
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // ������������ ������ ����� �� ������ ������
            this.Width = screenWidth / 2;
            this.Height = screenHeight / 2;

            // ������������ ������� ����� � ����� ����� ����� ������
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(screenWidth - this.Width, screenHeight - this.Height);
        }
    }
}
