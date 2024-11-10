namespace Lab10
{
    partial class task06
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numericUpDown1; // Minutes input
        private System.Windows.Forms.NumericUpDown numericUpDown2; // Seconds input
        private System.Windows.Forms.Label labelMinutes; // Label for "Хвилини"
        private System.Windows.Forms.Label labelSeconds; // Label for "Секунди"

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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown(); // Minutes input
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown(); // Seconds input
            this.labelMinutes = new System.Windows.Forms.Label(); // Label for "Хвилини"
            this.labelSeconds = new System.Windows.Forms.Label(); // Label for "Секунди"
            this.SuspendLayout();

            // label1 - хвилини
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label1.Location = new System.Drawing.Point(80, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "00";

            // label2 - двокрапка
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label2.Location = new System.Drawing.Point(160, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";

            // label3 - секунди
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label3.Location = new System.Drawing.Point(190, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "00";

            // startButton
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.startButton.Location = new System.Drawing.Point(120, 150);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 40);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);

            // timer
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);

            // labelMinutes - підпис "Хвилини"
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(20, 110);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(48, 13);
            this.labelMinutes.TabIndex = 7;
            this.labelMinutes.Text = "Хвилини:";

            // numericUpDown1 - хвилини
            this.numericUpDown1.Location = new System.Drawing.Point(80, 110);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 5;

            // labelSeconds - підпис "Секунди"
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(150, 110);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(50, 13);
            this.labelSeconds.TabIndex = 8;
            this.labelSeconds.Text = "Секунди:";

            // numericUpDown2 - секунди
            this.numericUpDown2.Location = new System.Drawing.Point(210, 110);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown2.TabIndex = 6;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.numericUpDown2);
            this.Name = "Form1";
            this.Text = "Секундомір";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
