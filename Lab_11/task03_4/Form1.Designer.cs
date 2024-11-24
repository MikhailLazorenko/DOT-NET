namespace task03_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Button buttonInput;

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
            this.buttonInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(70, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(114, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Обчислення еліпса";
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(90, 70);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(90, 30);
            this.buttonInput.TabIndex = 1;
            this.buttonInput.Text = "Почати";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // Version4Form
            // 
            this.ClientSize = new System.Drawing.Size(260, 130);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.labelTitle);
            this.Name = "Version4Form";
            this.Text = "Варіант 4";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
