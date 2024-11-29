using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace task10
{
    public partial class Form1 : Form
    {
        // ���� ��� ��������� ����������� ������
        public class BallSettings
        {
            public int NumberOfBalls { get; set; } = 5;
            public List<Color> Colors { get; set; } = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple };
            public int Diameter { get; set; } = 40;
            public double Speed { get; set; } = 5.0; // ���� ��������� ��������
        }

        private class Ball
        {
            public double X { get; set; }
            public double Y { get; set; }
            public int Diameter { get; set; }
            public Color Color { get; set; }
            public double VelocityX { get; set; }
            public double VelocityY { get; set; }
            public double Mass => Diameter; // ������� �����: ���� ����������� �������
        }

        private BallSettings settings;
        private List<Ball> balls;
        private System.Windows.Forms.Timer timer;
        private Random random;

        public Form1()
        {
            InitializeComponent();

            // �������� ������� ����������� ��� �������� ��������
            this.DoubleBuffered = true;

            // ����������� �����������
            settings = new BallSettings();

            // ����������� ���������� ���������� �����
            random = new Random();

            // ����������� ������
            InitializeBalls();

            // ����������� �������
            timer = new System.Windows.Forms.Timer
            {
                Interval = 15 // ������ �������� ��� ��������� ��������
            };
            timer.Tick += Timer_Tick;
            timer.Start();

            // ��������� ������ �����������
            Button settingsButton = new Button
            {
                Text = "������������",
                Location = new Point(591, 10),
                AutoSize = true
            };
            settingsButton.Click += SettingsButton_Click;
            this.Controls.Add(settingsButton);
        }

        private void InitializeBalls()
        {
            balls = new List<Ball>();
            for (int i = 0; i < settings.NumberOfBalls; i++)
            {
                Ball newBall;
                bool overlaps;
                int attempts = 0;
                do
                {
                    overlaps = false;
                    newBall = new Ball
                    {
                        Diameter = settings.Diameter,
                        X = random.Next(50, ClientSize.Width - settings.Diameter - 50),
                        Y = random.Next(50, ClientSize.Height - settings.Diameter - 50),
                        Color = settings.Colors[i % settings.Colors.Count],
                        VelocityX = GetRandomVelocity(),
                        VelocityY = GetRandomVelocity(),
                        // �������� �������� ���, ��� ������� �������� ���������� settings.Speed
                    };

                    // ����������� �������� �� ��������� ��������
                    NormalizeVelocity(newBall);

                    // �������� �� ���������� � ��������� ��������
                    foreach (var existingBall in balls)
                    {
                        double dx = newBall.X - existingBall.X;
                        double dy = newBall.Y - existingBall.Y;
                        double distance = Math.Sqrt(dx * dx + dy * dy);
                        if (distance < (newBall.Diameter / 2 + existingBall.Diameter / 2))
                        {
                            overlaps = true;
                            break;
                        }
                    }

                    attempts++;
                    if (attempts > 1000)
                        break; // ����� � �����, ��� �������� ������������ �����

                } while (overlaps);

                balls.Add(newBall);
            }
        }

        private double GetRandomVelocity()
        {
            double angle = random.NextDouble() * 2 * Math.PI;
            return settings.Speed * Math.Cos(angle);
        }

        private void NormalizeVelocity(Ball ball)
        {
            double magnitude = Math.Sqrt(ball.VelocityX * ball.VelocityX + ball.VelocityY * ball.VelocityY);
            if (magnitude == 0)
            {
                ball.VelocityX = settings.Speed;
                ball.VelocityY = 0;
            }
            else
            {
                ball.VelocityX = (ball.VelocityX / magnitude) * settings.Speed;
                ball.VelocityY = (ball.VelocityY / magnitude) * settings.Speed;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // ������� ������� ������
            foreach (var ball in balls)
            {
                ball.X += ball.VelocityX;
                ball.Y += ball.VelocityY;

                // �������� ������� � �������
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
            }

            // �������� ������� �� ��������
            for (int i = 0; i < balls.Count; i++)
            {
                for (int j = i + 1; j < balls.Count; j++)
                {
                    Ball ball1 = balls[i];
                    Ball ball2 = balls[j];

                    double dx = (ball2.X + ball2.Diameter / 2) - (ball1.X + ball1.Diameter / 2);
                    double dy = (ball2.Y + ball2.Diameter / 2) - (ball1.Y + ball1.Diameter / 2);
                    double distance = Math.Sqrt(dx * dx + dy * dy);
                    double minDist = (ball1.Diameter / 2) + (ball2.Diameter / 2);

                    if (distance < minDist)
                    {
                        // ���������� �������������� �������
                        double nx = dx / distance;
                        double ny = dy / distance;

                        // ���������� ������������� �������
                        double tx = -ny;
                        double ty = nx;

                        // ���������� ���������� ��������
                        double v1n = nx * ball1.VelocityX + ny * ball1.VelocityY;
                        double v1t = tx * ball1.VelocityX + ty * ball1.VelocityY;
                        double v2n = nx * ball2.VelocityX + ny * ball2.VelocityY;
                        double v2t = tx * ball2.VelocityX + ty * ball2.VelocityY;

                        // ��������� ��������: ���� ����������� �����������
                        double v1nAfter = v2n;
                        double v2nAfter = v1n;

                        // ���������� ����� ����������
                        ball1.VelocityX = v1nAfter * nx + v1t * tx;
                        ball1.VelocityY = v1nAfter * ny + v1t * ty;
                        ball2.VelocityX = v2nAfter * nx + v2t * tx;
                        ball2.VelocityY = v2nAfter * ny + v2t * ty;

                        // ����������� ���������� �� ��������� ��������
                        NormalizeVelocity(ball1);
                        NormalizeVelocity(ball2);

                        // ����������� ����������
                        double overlap = minDist - distance + 1; // +1 ��� ���������� ����� ������������
                        double totalMass = ball1.Mass + ball2.Mass;
                        double shift1 = overlap * (ball2.Mass / totalMass);
                        double shift2 = overlap * (ball1.Mass / totalMass);

                        ball1.X -= shift1 * nx;
                        ball1.Y -= shift1 * ny;
                        ball2.X += shift2 * nx;
                        ball2.Y += shift2 * ny;
                    }
                }
            }

            // ������������� �����
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var ball in balls)
            {
                using (Brush brush = new SolidBrush(ball.Color))
                {
                    g.FillEllipse(brush, (float)ball.X, (float)ball.Y, ball.Diameter, ball.Diameter);
                }
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            // �������� ������ ����� ��������� �����������
            timer.Stop();

            using (SettingsForm settingsForm = new SettingsForm(settings))
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    // ������� ������������
                    settings = settingsForm.UpdatedSettings;
                    // ���������, �� ������� ������ ������� ������
                    InitializeBalls();
                }
            }

            // ��������� ������ ���� �������� �����������
            timer.Start();
        }
    }
}
