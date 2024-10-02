using System;
using System.Drawing;
using System.Windows.Forms;

namespace task06 
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
            PictureBox pictureBox1 = CreatePictureBox(@"C:\Users\misha\Downloads\1.jpg", new Point(10, 95), new Size(100, 50));
            this.Controls.Add(pictureBox1);

            PictureBox pictureBox2 = CreatePictureBox(@"C:\Users\misha\Downloads\2.jpg", new Point(120, 60), new Size(100, 85));
            this.Controls.Add(pictureBox2);

            PictureBox pictureBox3 = CreatePictureBox(@"C:\Users\misha\Downloads\3.jpg", new Point(230, 35), new Size(100, 110));
            this.Controls.Add(pictureBox3);

            PictureBox pictureBox4 = CreatePictureBox(@"C:\Users\misha\Downloads\4.jpg", new Point(340, 60), new Size(100, 85));
            this.Controls.Add(pictureBox4);

            PictureBox pictureBox5 = CreatePictureBox(@"C:\Users\misha\Downloads\5.jpg", new Point(450, 95), new Size(100, 50));
            this.Controls.Add(pictureBox5);

            // Друга топологія (різні розміри)
            PictureBox pictureBox6 = CreatePictureBox(@"C:\Users\misha\Downloads\6.jpg", new Point(10, 220), new Size(100, 50));
            this.Controls.Add(pictureBox6);

            PictureBox pictureBox7 = CreatePictureBox(@"C:\Users\misha\Downloads\7.jpg", new Point(120, 160), new Size(100, 110));
            this.Controls.Add(pictureBox7);

            PictureBox pictureBox8 = CreatePictureBox(@"C:\Users\misha\Downloads\8.jpg", new Point(230, 210), new Size(220, 60));
            this.Controls.Add(pictureBox8);
        }

        // Метод для створення PictureBox з заданими параметрами
        private PictureBox CreatePictureBox(string imagePath, Point location, Size size)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(imagePath);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = location;
            pictureBox.Size = size;
            return pictureBox;
        }
    }
}
