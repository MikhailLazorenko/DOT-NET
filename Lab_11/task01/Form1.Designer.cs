namespace task01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonForm2;
        private Button buttonForm3;
        private Button buttonForm4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuForms;
        private ToolStripMenuItem menuItemForm2;
        private ToolStripMenuItem menuItemForm3;
        private ToolStripMenuItem menuItemForm4;
        private Label labelForm1;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuForms = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemForm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemForm4 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelForm1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonForm2
            // 
            this.buttonForm2.Location = new System.Drawing.Point(50, 80);
            this.buttonForm2.Name = "buttonForm2";
            this.buttonForm2.Size = new System.Drawing.Size(100, 30);
            this.buttonForm2.TabIndex = 0;
            this.buttonForm2.Text = "Відкрити Form2";
            this.buttonForm2.UseVisualStyleBackColor = true;
            this.buttonForm2.Click += new System.EventHandler(this.buttonForm2_Click);
            // 
            // buttonForm3
            // 
            this.buttonForm3.Location = new System.Drawing.Point(50, 120);
            this.buttonForm3.Name = "buttonForm3";
            this.buttonForm3.Size = new System.Drawing.Size(100, 30);
            this.buttonForm3.TabIndex = 1;
            this.buttonForm3.Text = "Відкрити Form3";
            this.buttonForm3.UseVisualStyleBackColor = true;
            this.buttonForm3.Click += new System.EventHandler(this.buttonForm3_Click);
            // 
            // buttonForm4
            // 
            this.buttonForm4.Location = new System.Drawing.Point(50, 160);
            this.buttonForm4.Name = "buttonForm4";
            this.buttonForm4.Size = new System.Drawing.Size(100, 30);
            this.buttonForm4.TabIndex = 2;
            this.buttonForm4.Text = "Відкрити Form4";
            this.buttonForm4.UseVisualStyleBackColor = true;
            this.buttonForm4.Click += new System.EventHandler(this.buttonForm4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuForms});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuForms
            // 
            this.menuForms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemForm2,
            this.menuItemForm3,
            this.menuItemForm4});
            this.menuForms.Name = "menuForms";
            this.menuForms.Size = new System.Drawing.Size(52, 20);
            this.menuForms.Text = "Форми";
            // 
            // menuItemForm2
            // 
            this.menuItemForm2.Name = "menuItemForm2";
            this.menuItemForm2.Size = new System.Drawing.Size(138, 22);
            this.menuItemForm2.Text = "Відкрити Form2";
            this.menuItemForm2.Click += new System.EventHandler(this.buttonForm2_Click);
            // 
            // menuItemForm3
            // 
            this.menuItemForm3.Name = "menuItemForm3";
            this.menuItemForm3.Size = new System.Drawing.Size(138, 22);
            this.menuItemForm3.Text = "Відкрити Form3";
            this.menuItemForm3.Click += new System.EventHandler(this.buttonForm3_Click);
            // 
            // menuItemForm4
            // 
            this.menuItemForm4.Name = "menuItemForm4";
            this.menuItemForm4.Size = new System.Drawing.Size(138, 22);
            this.menuItemForm4.Text = "Відкрити Form4";
            this.menuItemForm4.Click += new System.EventHandler(this.buttonForm4_Click);
            // 
            // labelForm1
            // 
            this.labelForm1.AutoSize = true;
            this.labelForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm1.Location = new System.Drawing.Point(50, 40);
            this.labelForm1.Name = "labelForm1";
            this.labelForm1.Size = new System.Drawing.Size(58, 20);
            this.labelForm1.TabIndex = 4;
            this.labelForm1.Text = "Form1";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(200, 220);
            this.Controls.Add(this.labelForm1);
            this.Controls.Add(this.buttonForm2);
            this.Controls.Add(this.buttonForm3);
            this.Controls.Add(this.buttonForm4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
