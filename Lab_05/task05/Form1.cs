using System; 
using System.Drawing; 
using System.Windows.Forms; 

namespace task05 // Оголошення простору імен
{
    public partial class Form1 : Form // Оголошення класу Form1
    {
        public Form1() // Конструктор класу Form1
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            InitializePictureBoxes(); // Додавання PictureBox елементів
        }

        private void InitializePictureBoxes() // Метод для ініціалізації PictureBox
        {
            // Перша топологія (горизонтальна лінія)
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile(@"C:\Users\misha\Downloads\1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Location = new Point(10, 95);
            pictureBox1.Size = new Size(100, 50);
            this.Controls.Add(pictureBox1);

            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Image = Image.FromFile(@"C:\Users\misha\Downloads\2.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Location = new Point(120, 60);
            pictureBox2.Size = new Size(100, 85);
            this.Controls.Add(pictureBox2);

            PictureBox pictureBox3 = new PictureBox();
            pictureBox3.Image = Image.FromFile(@"C:\Users\misha\Downloads\3.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Location = new Point(230, 35);
            pictureBox3.Size = new Size(100, 110);
            this.Controls.Add(pictureBox3);

            PictureBox pictureBox4 = new PictureBox();
            pictureBox4.Image = Image.FromFile(@"C:\Users\misha\Downloads\4.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Location = new Point(340, 60);
            pictureBox4.Size = new Size(100, 85);
            this.Controls.Add(pictureBox4);

            PictureBox pictureBox5 = new PictureBox();
            pictureBox5.Image = Image.FromFile(@"C:\Users\misha\Downloads\5.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Location = new Point(450, 95);
            pictureBox5.Size = new Size(100, 50);
            this.Controls.Add(pictureBox5);

            // Друга топологія (різні розміри)
            PictureBox pictureBox6 = new PictureBox();
            pictureBox6.Image = Image.FromFile(@"C:\Users\misha\Downloads\6.jpg");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Location = new Point(10, 220);
            pictureBox6.Size = new Size(100, 50);
            this.Controls.Add(pictureBox6);

            PictureBox pictureBox7 = new PictureBox();
            pictureBox7.Image = Image.FromFile(@"C:\Users\misha\Downloads\7.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Location = new Point(120, 160);
            pictureBox7.Size = new Size(100, 110);
            this.Controls.Add(pictureBox7);

            PictureBox pictureBox8 = new PictureBox();
            pictureBox8.Image = Image.FromFile(@"C:\Users\misha\Downloads\8.jpg");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Location = new Point(230, 210);
            pictureBox8.Size = new Size(220, 60);
            this.Controls.Add(pictureBox8);
        }
    }
}
