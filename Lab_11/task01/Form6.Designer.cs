namespace task01
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelForm6;

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
            this.labelForm6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelForm6
            // 
            this.labelForm6.AutoSize = true;
            this.labelForm6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm6.Location = new System.Drawing.Point(50, 40);
            this.labelForm6.Name = "labelForm6";
            this.labelForm6.Size = new System.Drawing.Size(58, 20);
            this.labelForm6.TabIndex = 0;
            this.labelForm6.Text = "Form6";
            // 
            // Form6
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.labelForm6);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
