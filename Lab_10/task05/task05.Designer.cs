namespace Lab10
{
    partial class task05
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer;

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
            this.stopButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            this.startButton.Location = new System.Drawing.Point(60, 150);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 40);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);

            // stopButton
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.stopButton.Location = new System.Drawing.Point(180, 150);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 40);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);

            // timer
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Name = "Form1";
            this.Text = "Секундомір";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
