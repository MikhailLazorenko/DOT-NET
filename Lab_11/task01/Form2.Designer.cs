namespace task01
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonForm5;
        private ToolStripButton toolStripButtonForm6;
        private ToolStripButton toolStripButtonForm7;
        private Label labelForm2;

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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonForm5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForm6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForm7 = new System.Windows.Forms.ToolStripButton();
            this.labelForm2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonForm5,
            this.toolStripButtonForm6,
            this.toolStripButtonForm7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(200, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonForm5
            // 
            this.toolStripButtonForm5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonForm5.Name = "toolStripButtonForm5";
            this.toolStripButtonForm5.Size = new System.Drawing.Size(45, 22);
            this.toolStripButtonForm5.Text = "Form5";
            this.toolStripButtonForm5.Click += new System.EventHandler(this.buttonForm5_Click);
            // 
            // toolStripButtonForm6
            // 
            this.toolStripButtonForm6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonForm6.Name = "toolStripButtonForm6";
            this.toolStripButtonForm6.Size = new System.Drawing.Size(45, 22);
            this.toolStripButtonForm6.Text = "Form6";
            this.toolStripButtonForm6.Click += new System.EventHandler(this.buttonForm6_Click);
            // 
            // toolStripButtonForm7
            // 
            this.toolStripButtonForm7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonForm7.Name = "toolStripButtonForm7";
            this.toolStripButtonForm7.Size = new System.Drawing.Size(45, 22);
            this.toolStripButtonForm7.Text = "Form7";
            this.toolStripButtonForm7.Click += new System.EventHandler(this.buttonForm7_Click);
            // 
            // labelForm2
            // 
            this.labelForm2.AutoSize = true;
            this.labelForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm2.Location = new System.Drawing.Point(50, 40);
            this.labelForm2.Name = "labelForm2";
            this.labelForm2.Size = new System.Drawing.Size(58, 20);
            this.labelForm2.TabIndex = 1;
            this.labelForm2.Text = "Form2";
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.labelForm2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
