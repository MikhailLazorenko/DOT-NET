using System;
using System.Drawing;
using System.Windows.Forms;

namespace task09
{
    public partial class Form1 : Form
    {
        private class Ball
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Diameter { get; set; }
            public Color Color { get; set; }
            public int VelocityX { get; set; }
            public int VelocityY { get; set; }
        }

        private readonly Ball[] balls;
        private readonly System.Windows.Forms.Timer timer;
        private const int BallDiameter = 40;

        public Form1()
        {
            InitializeComponent();

            // Увімкнути подвійну буферизацію для усунення миготіння
            this.DoubleBuffered = true;

            // Ініціалізація кульок
            balls = new Ball[5];
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
            Random random = new Random();

            for (int i = 0; i < balls.Length; i++)
            {
                bool overlapping;
                do
                {
                    overlapping = false;
                    balls[i] = new Ball
                    {
                        X = random.Next(50, ClientSize.Width - BallDiameter - 50),
                        Y = random.Next(50, ClientSize.Height - BallDiameter - 50),
                        Diameter = BallDiameter,
                        Color = colors[i],
                        VelocityX = random.Next(4, 8) * (random.Next(0, 2) == 0 ? 1 : -1),
                        VelocityY = random.Next(4, 8) * (random.Next(0, 2) == 0 ? 1 : -1)
                    };

                    // Перевірка на перекриття з попередніми кульками
                    for (int j = 0; j < i; j++)
                    {
                        if (IsColliding(balls[i], balls[j]))
                        {
                            overlapping = true;
                            break;
                        }
                    }
                }
                while (overlapping);
            }

            // Ініціалізація таймера
            timer = new System.Windows.Forms.Timer
            {
                Interval = 15 // Менший інтервал для збільшення швидкості
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < balls.Length; i++)
            {
                Ball ball = balls[i];

                // Рух кульки
                ball.X += ball.VelocityX;
                ball.Y += ball.VelocityY;

                // Перевірка зіткнень зі стінками
                if (ball.X <= 0)
                {
                    ball.X = 0;
                    ball.VelocityX = -ball.VelocityX;
                }
                else if (ball.X + ball.Diameter >= ClientSize.Width)
                {
                    ball.X = ClientSize.Width - ball.Diameter;
                    ball.VelocityX = -ball.VelocityX;
                }

                if (ball.Y <= 0)
                {
                    ball.Y = 0;
                    ball.VelocityY = -ball.VelocityY;
                }
                else if (ball.Y + ball.Diameter >= ClientSize.Height)
                {
                    ball.Y = ClientSize.Height - ball.Diameter;
                    ball.VelocityY = -ball.VelocityY;
                }

                // Перевірка зіткнень з іншими кульками
                for (int j = i + 1; j < balls.Length; j++)
                {
                    Ball otherBall = balls[j];
                    if (IsColliding(ball, otherBall))
                    {
                        // Обчислення вектора зіткнення
                        int dx = otherBall.X - ball.X;
                        int dy = otherBall.Y - ball.Y;
                        double distance = Math.Sqrt(dx * dx + dy * dy);
                        if (distance == 0) distance = 1; // Запобігання ділення на нуль

                        // Нормалізація вектора
                        double nx = dx / distance;
                        double ny = dy / distance;

                        // Переміщення кульок, щоб уникнути перекриття
                        double overlap = 0.5 * (distance - ball.Diameter);
                        ball.X += (int)(overlap * nx);
                        ball.Y += (int)(overlap * ny);
                        otherBall.X -= (int)(overlap * nx);
                        otherBall.Y -= (int)(overlap * ny);

                        // Обмін швидкостями для простоти
                        int tempVx = ball.VelocityX;
                        int tempVy = ball.VelocityY;
                        ball.VelocityX = otherBall.VelocityX;
                        ball.VelocityY = otherBall.VelocityY;
                        otherBall.VelocityX = tempVx;
                        otherBall.VelocityY = tempVy;
                    }
                }
            }

            // Перемальовуємо форму
            Invalidate();
        }

        private bool IsColliding(Ball ball1, Ball ball2)
        {
            int dx = ball1.X - ball2.X;
            int dy = ball1.Y - ball2.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);
            return distance < ball1.Diameter;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Ball ball in balls)
            {
                using (Brush brush = new SolidBrush(ball.Color))
                {
                    g.FillEllipse(brush, ball.X, ball.Y, ball.Diameter, ball.Diameter);
                }
            }
        }
    }
}
