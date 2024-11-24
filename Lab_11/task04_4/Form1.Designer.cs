namespace task04_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Button buttonStart;

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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(70, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(130, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Обчислення виразу";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(90, 70);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 30);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Почати";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Variant4Form
            // 
            this.ClientSize = new System.Drawing.Size(260, 130);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTitle);
            this.Name = "Variant4Form";
            this.Text = "Варіант 4";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
