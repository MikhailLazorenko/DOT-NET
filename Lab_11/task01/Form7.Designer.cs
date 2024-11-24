namespace task01
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelForm7;

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
            this.labelForm7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelForm7
            // 
            this.labelForm7.AutoSize = true;
            this.labelForm7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm7.Location = new System.Drawing.Point(50, 40);
            this.labelForm7.Name = "labelForm7";
            this.labelForm7.Size = new System.Drawing.Size(58, 20);
            this.labelForm7.TabIndex = 0;
            this.labelForm7.Text = "Form7";
            // 
            // Form7
            // 
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.labelForm7);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
