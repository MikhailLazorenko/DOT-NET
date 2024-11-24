namespace task02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonForm2;
        private Button buttonForm3;
        private Button buttonForm4;
        private Label labelForm1;
        private Label labelCallerInfo;
        private TextBox textBoxInfo;

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
            this.buttonForm2 = new System.Windows.Forms.Button();
            this.buttonForm3 = new System.Windows.Forms.Button();
            this.buttonForm4 = new System.Windows.Forms.Button();
            this.labelForm1 = new System.Windows.Forms.Label();
            this.labelCallerInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonForm2
            // 
            this.buttonForm2.Location = new System.Drawing.Point(50, 150);
            this.buttonForm2.Name = "buttonForm2";
            this.buttonForm2.Size = new System.Drawing.Size(100, 30);
            this.buttonForm2.TabIndex = 0;
            this.buttonForm2.Text = "Відкрити Form2";
            this.buttonForm2.UseVisualStyleBackColor = true;
            this.buttonForm2.Click += new System.EventHandler(this.buttonForm2_Click);
            // 
            // buttonForm3
            // 
            this.buttonForm3.Location = new System.Drawing.Point(50, 190);
            this.buttonForm3.Name = "buttonForm3";
            this.buttonForm3.Size = new System.Drawing.Size(100, 30);
            this.buttonForm3.TabIndex = 1;
            this.buttonForm3.Text = "Відкрити Form3";
            this.buttonForm3.UseVisualStyleBackColor = true;
            this.buttonForm3.Click += new System.EventHandler(this.buttonForm3_Click);
            // 
            // buttonForm4
            // 
            this.buttonForm4.Location = new System.Drawing.Point(50, 230);
            this.buttonForm4.Name = "buttonForm4";
            this.buttonForm4.Size = new System.Drawing.Size(100, 30);
            this.buttonForm4.TabIndex = 2;
            this.buttonForm4.Text = "Відкрити Form4";
            this.buttonForm4.UseVisualStyleBackColor = true;
            this.buttonForm4.Click += new System.EventHandler(this.buttonForm4_Click);
            // 
            // labelForm1
            // 
            this.labelForm1.AutoSize = true;
            this.labelForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm1.Location = new System.Drawing.Point(50, 20);
            this.labelForm1.Name = "labelForm1";
            this.labelForm1.Size = new System.Drawing.Size(58, 20);
            this.labelForm1.TabIndex = 3;
            this.labelForm1.Text = "Form1";
            // 
            // labelCallerInfo
            // 
            this.labelCallerInfo.AutoSize = true;
            this.labelCallerInfo.Location = new System.Drawing.Point(50, 50);
            this.labelCallerInfo.Name = "labelCallerInfo";
            this.labelCallerInfo.Size = new System.Drawing.Size(116, 13);
            this.labelCallerInfo.TabIndex = 4;
            this.labelCallerInfo.Text = "Немає попередньої форми";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(50, 80);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(200, 50);
            this.textBoxInfo.TabIndex = 5;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.labelCallerInfo);
            this.Controls.Add(this.labelForm1);
            this.Controls.Add(this.buttonForm2);
            this.Controls.Add(this.buttonForm3);
            this.Controls.Add(this.buttonForm4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
