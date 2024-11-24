namespace task04_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Button buttonInput;
        private Label labelResult;

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
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(60, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(130, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Обчислення виразу";
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(80, 60);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(90, 30);
            this.buttonInput.TabIndex = 1;
            this.buttonInput.Text = "Ввести дані";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(30, 110);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(61, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Результат:";
            // 
            // Variant2Form
            // 
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.labelTitle);
            this.Name = "Variant2Form";
            this.Text = "Варіант 2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
