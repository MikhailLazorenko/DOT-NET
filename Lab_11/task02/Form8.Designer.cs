namespace task02
{
    partial class Form8
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelForm8;
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
            this.labelForm8 = new System.Windows.Forms.Label();
            this.labelCallerInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelForm8
            // 
            this.labelForm8.AutoSize = true;
            this.labelForm8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm8.Location = new System.Drawing.Point(50, 20);
            this.labelForm8.Name = "labelForm8";
            this.labelForm8.Size = new System.Drawing.Size(58, 20);
            this.labelForm8.TabIndex = 0;
            this.labelForm8.Text = "Form8";
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
            // Form8
            // 
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.labelCallerInfo);
            this.Controls.Add(this.labelForm8);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
