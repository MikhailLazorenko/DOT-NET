namespace Task_8_Test
{
    partial class MsgDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblSender = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(12, 9);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(33, 15);
            this.lblSender.TabIndex = 0;
            this.lblSender.Text = "Від: ";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(12, 30);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(42, 15);
            this.lblTheme.TabIndex = 1;
            this.lblTheme.Text = "Тема: ";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 50);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(360, 200);
            this.txtText.TabIndex = 2;
            // 
            // MessageDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblSender);
            this.Name = "MessageDetailsForm";
            this.Text = "Деталі повідомлення";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.TextBox txtText;
    }
}