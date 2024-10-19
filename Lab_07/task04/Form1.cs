using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace task04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ϳ������ �� ��䳿 DblClick ��� ������� Label
            label1.DoubleClick += Label_DoubleClick;
            label2.DoubleClick += Label_DoubleClick;
            label3.DoubleClick += Label_DoubleClick;
        }

        // ���� �������� ��䳿 ��� ��� Label
        private void Label_DoubleClick(object sender, EventArgs e)
        {
            // ��������, �� ��'��� sender � Label
            if (sender is System.Windows.Forms.Label label)
            {
                // ����������� �� ��������� � ������ �������
                label.Font = new Font(label.Font, label.Font.Bold ? FontStyle.Regular : FontStyle.Bold);
            }
        }
    }
}
