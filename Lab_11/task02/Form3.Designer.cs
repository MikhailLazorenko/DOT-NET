namespace task02
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelForm3;
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
            this.labelForm3 = new System.Windows.Forms.Label();
            this.labelCallerInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelForm3
            // 
            this.labelForm3.AutoSize = true;
            this.labelForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm3.Location = new System.Drawing.Point(50, 20);
            this.labelForm3.Name = "labelForm3";
            this.labelForm3.Size = new System.Drawing.Size(58, 20);
            this.labelForm3.TabIndex = 0;
            this.labelForm3.Text = "Form3";
            // 
            // labelCallerInfo
            // 
            this.labelCallerInfo.AutoSize = true;
            this.labelCallerInfo.Location = new System.Drawing.Point(50, 50);
            this.labelCallerInfo.Name = "labelCallerInfo";
            this.labelCallerInfo.Size = new System.Drawing.Size(0, 13);
            this.labelCallerInfo.TabIndex = 1;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(50, 80);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(200, 50);
            this.textBoxInfo.TabIndex = 2;
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.labelCallerInfo);
            this.Controls.Add(this.labelForm3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
