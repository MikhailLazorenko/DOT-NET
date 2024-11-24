namespace Lab12
{
    partial class ProfileForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnViewMessages = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(112, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Вітаємо, ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(120, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 25);
            this.lblUsername.TabIndex = 1;
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Location = new System.Drawing.Point(12, 50);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(42, 15);
            this.lblEmailLabel.TabIndex = 2;
            this.lblEmailLabel.Text = "Email: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(60, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 15);
            this.lblEmail.TabIndex = 3;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(12, 80);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(200, 30);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Змінити пароль";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.Location = new System.Drawing.Point(12, 120);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(200, 30);
            this.btnChangeEmail.TabIndex = 5;
            this.btnChangeEmail.Text = "Змінити Email";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            this.btnChangeEmail.Click += new System.EventHandler(this.btnChangeEmail_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(12, 160);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(200, 30);
            this.btnSendMessage.TabIndex = 6;
            this.btnSendMessage.Text = "Відправити повідомлення";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.Location = new System.Drawing.Point(12, 200);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(200, 30);
            this.btnViewMessages.TabIndex = 7;
            this.btnViewMessages.Text = "Переглянути повідомлення";
            this.btnViewMessages.UseVisualStyleBackColor = true;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 240);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 30);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Вийти";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ProfileForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 290);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEmailLabel);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.Name = "ProfileForm";
            this.Text = "Профіль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnViewMessages;
        private System.Windows.Forms.Button btnLogout;
    }
}
