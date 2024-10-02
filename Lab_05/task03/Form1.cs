using System;
using System.Drawing;
using System.Windows.Forms;

namespace task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load); // Додаємо обробник події завантаження
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Додавання першого рядка тексту
            TextBox textBox1 = new TextBox();
            textBox1.Text = "Перший рядок тексту";
            textBox1.Size = new Size(300, 30);
            textBox1.Location = new Point(10, 10);
            textBox1.Font = new Font("Arial", 14, FontStyle.Italic);
            textBox1.ForeColor = Color.Purple;
            textBox1.BackColor = Color.Orange;
            textBox1.TextAlign = HorizontalAlignment.Left; // Вирівнювання ліворуч
            textBox1.ReadOnly = true; // Зробити текстове поле лише для читання
            this.Controls.Add(textBox1); // Додаємо textBox1 до форми

            // Додавання другого рядка тексту
            TextBox textBox2 = new TextBox();
            textBox2.Text = "Другий рядок тексту";
            textBox2.Size = new Size(300, 30);
            textBox2.Location = new Point(10, 50);
            textBox2.Font = new Font("Arial", 13, FontStyle.Bold);
            textBox2.ForeColor = Color.Green;
            textBox2.BackColor = Color.Red;
            textBox2.TextAlign = HorizontalAlignment.Left; // Вирівнювання ліворуч
            textBox2.ReadOnly = true; // Зробити текстове поле лише для читання
            this.Controls.Add(textBox2); // Додаємо textBox2 до форми

            // Додавання третього рядка тексту
            TextBox textBox3 = new TextBox();
            textBox3.Text = "Третій рядок тексту";
            textBox3.Size = new Size(300, 30);
            textBox3.Location = new Point(10, 90);
            textBox3.Font = new Font("Arial", 11, FontStyle.Underline);
            textBox3.ForeColor = Color.Pink;
            textBox3.BackColor = Color.Yellow;
            textBox3.TextAlign = HorizontalAlignment.Center; // Вирівнювання по центру
            textBox3.ReadOnly = true; // Зробити текстове поле лише для читання
            this.Controls.Add(textBox3); // Додаємо textBox3 до форми
        }
    }
}
