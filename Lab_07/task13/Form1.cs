using System;
using System.Windows.Forms;

namespace task13
{
    public partial class Form1 : Form
    {
        private ListBox listBox; // ���������, ���� ���� ���������� �� ����������

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // �������� ���� ��������� ������ �� ������� ����������
        }

        // ������� ��䳿 ���������� �����
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // ��������� ListBox ��� ��������� Alt + A
            if (e.Alt && e.KeyCode == Keys.A)
            {
                AddListBox();
                e.Handled = true; // ���������, �� ������ ���� ���������
            }
            // ��������� ListBox ��� ��������� Alt + Shift + D
            else if (e.Alt && e.Shift && e.KeyCode == Keys.D)
            {
                RemoveListBox();
                e.Handled = true; // ���������, �� ������ ���� ���������
            }
        }

        // ������� ��� ��������� ListBox
        private void AddListBox()
        {
            if (listBox == null)
            {
                listBox = new ListBox();
                listBox.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
                listBox.Location = new System.Drawing.Point(20, 20);
                listBox.Size = new System.Drawing.Size(200, 100);
                this.Controls.Add(listBox);
                MessageBox.Show("ListBox ������ �� �����!", "����������");
            }
            else
            {
                MessageBox.Show("ListBox ��� ������!", "������������");
            }
        }

        // ������� ��� ��������� ListBox
        private void RemoveListBox()
        {
            if (listBox != null)
            {
                this.Controls.Remove(listBox);
                listBox = null;
                MessageBox.Show("ListBox �������� � �����!", "����������");
            }
            else
            {
                MessageBox.Show("ListBox �� ������ �� �����!", "������������");
            }
        }
    }
}
