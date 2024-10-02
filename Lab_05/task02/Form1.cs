using System;
using System.Drawing;
using System.Windows.Forms;

namespace task02 { 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load); // ������ �������� ��䳿 ������������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ������� ����� ������
            Label label1 = new Label();
            label1.Text = "������ ����� ������";
            label1.Size = new Size(300, 30);
            label1.Location = new Point(10, 10);
            label1.Font = new Font("Arial", 14, FontStyle.Italic);
            label1.ForeColor = Color.Purple;
            label1.BackColor = Color.Orange;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(label1); // ������ label1 �� �����

            // ��������� ������� ����� ������
            Label label2 = new Label();
            label2.Text = "������ ����� ������";
            label2.Size = new Size(300, 30);
            label2.Location = new Point(10, 50);
            label2.Font = new Font("Arial", 13, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.BackColor = Color.Red;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(label2); // ������ label2 �� �����

            // ��������� �������� ����� ������
            Label label3 = new Label();
            label3.Text = "����� ����� ������";
            label3.Size = new Size(300, 30);
            label3.Location = new Point(10, 90);
            label3.Font = new Font("Arial", 11, FontStyle.Underline);
            label3.ForeColor = Color.Pink;
            label3.BackColor = Color.Yellow;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(label3); // ������ label3 �� �����
        }
    }
}
