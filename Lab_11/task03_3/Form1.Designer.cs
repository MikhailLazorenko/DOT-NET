namespace task03_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Label labelA;
        private Label labelB;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Button buttonCalculate;

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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(70, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(78, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Введіть дані:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(30, 60);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(100, 13);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "Велика піввісь (a):";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(30, 90);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(96, 13);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "Мала піввісь (b):";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(140, 57);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(140, 87);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(100, 130);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(90, 30);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Обчислити";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Version3Form
            // 
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelTitle);
            this.Name = "Version3Form";
            this.Text = "Варіант 3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
