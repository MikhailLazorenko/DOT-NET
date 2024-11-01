namespace Lab08
{
    partial class task12
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NumericUpDown intervalSelector;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.intervalSelector = new System.Windows.Forms.NumericUpDown();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.SuspendLayout();

            // button1
            this.button1.Location = new System.Drawing.Point(100, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.Text = "кнопка";
            this.button1.UseVisualStyleBackColor = true;

            // startButton
            this.startButton.Location = new System.Drawing.Point(20, 200);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.Text = "Запуск";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += StartButton_Click;

            // stopButton
            this.stopButton.Location = new System.Drawing.Point(120, 200);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.Text = "Зупинка";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += StopButton_Click;

            // intervalSelector
            this.intervalSelector.Location = new System.Drawing.Point(220, 200);
            this.intervalSelector.Minimum = 100;
            this.intervalSelector.Maximum = 5000;
            this.intervalSelector.Value = 1000;
            this.intervalSelector.Increment = 100;
            this.intervalSelector.Name = "intervalSelector";
            this.intervalSelector.Size = new System.Drawing.Size(60, 23);
            this.intervalSelector.ValueChanged += IntervalSelector_ValueChanged;

            // intervalLabel
            this.intervalLabel.Location = new System.Drawing.Point(220, 180);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(60, 20);
            this.intervalLabel.Text = "Інтервал:";

            // timer1
            this.timer1.Interval = 1000;
            this.timer1.Tick += Timer1_Tick;

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.intervalSelector);
            this.Controls.Add(this.intervalLabel);
            this.Name = "Form1";
            this.Text = "task 12";
            this.ResumeLayout(false);
        }
    }
}
