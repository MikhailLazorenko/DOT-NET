namespace task01
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelForm5;

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
            this.labelForm5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelForm5
            // 
            this.labelForm5.AutoSize = true;
            this.labelForm5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm5.Location = new System.Drawing.Point(50, 40);
            this.labelForm5.Name = "labelForm5";
            this.labelForm5.Size = new System.Drawing.Size(58, 20);
            this.labelForm5.TabIndex = 0;
            this.labelForm5.Text = "Form5";
            // 
            // Form5
            // 
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.labelForm5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
