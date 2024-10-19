using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ϳ������ �� ��䳿 DblClick ��� ������� Label
            label1.DoubleClick += (s, e) => ToggleFont(label1);
            label2.DoubleClick += (s, e) => ToggleFont(label2);
            label3.DoubleClick += (s, e) => ToggleFont(label3);
        }

        private void ToggleFont(System.Windows.Forms.Label label) // ���� �������� �������� ����
        {
            // ����������� �� ��������� � ������ �������
            label.Font = new Font(label.Font, label.Font.Bold ? FontStyle.Regular : FontStyle.Bold);
        }
    }
}
