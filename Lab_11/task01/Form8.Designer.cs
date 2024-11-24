namespace task01
{
    partial class Form8
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelForm8;

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
            this.labelForm8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelForm8
            // 
            this.labelForm8.AutoSize = true;
            this.labelForm8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm8.Location = new System.Drawing.Point(50, 40);
            this.labelForm8.Name = "labelForm8";
            this.labelForm8.Size = new System.Drawing.Size(58, 20);
            this.labelForm8.TabIndex = 0;
            this.labelForm8.Text = "Form8";
            // 
            // Form8
            // 
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.labelForm8);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
