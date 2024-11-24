namespace task01
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelForm3;

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
            this.labelForm3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelForm3
            // 
            this.labelForm3.AutoSize = true;
            this.labelForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm3.Location = new System.Drawing.Point(50, 40);
            this.labelForm3.Name = "labelForm3";
            this.labelForm3.Size = new System.Drawing.Size(58, 20);
            this.labelForm3.TabIndex = 0;
            this.labelForm3.Text = "Form3";
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.labelForm3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
