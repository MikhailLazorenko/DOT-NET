namespace Lab08
{
    partial class task11
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
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
            this.timer1 = new System.Windows.Forms.Timer();
            this.SuspendLayout();

            // button1
            this.button1.Location = new System.Drawing.Point(100, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50); // Початковий розмір
            this.button1.Text = "кнопка";
            this.button1.UseVisualStyleBackColor = true;

            // timer1
            this.timer1.Interval = 1000; // 1 секунда
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "task 11";
            this.ResumeLayout(false);
        }
    }
}
