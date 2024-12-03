namespace Task_8_Test
{
    partial class MsgSendForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.labelTheme = new System.Windows.Forms.Label();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(211, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Відправити повідомлення";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(12, 50);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 15);
            this.labelTo.TabIndex = 1;
            this.labelTo.Text = "До:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(12, 70);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(300, 23);
            this.txtTo.TabIndex = 2;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Location = new System.Drawing.Point(12, 100);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(38, 15);
            this.labelTheme.TabIndex = 3;
            this.labelTheme.Text = "Тема:";
            // 
            // txtTheme
            // 
            this.txtTheme.Location = new System.Drawing.Point(12, 120);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(300, 23);
            this.txtTheme.TabIndex = 4;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(12, 150);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(39, 15);
            this.labelText.TabIndex = 5;
            this.labelText.Text = "Текст:";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 170);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(300, 100);
            this.txtText.TabIndex = 6;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(12, 280);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessage.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 310);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Відправити";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MessageSendForm
            // 
            this.ClientSize = new System.Drawing.Size(330, 360);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelTitle);
            this.Name = "MessageSendForm";
            this.Text = "Відправити повідомлення";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.TextBox txtTheme;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}