namespace Lab12
{
    partial class ChangePasswordForm
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
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblErrorOldPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblErrorNewPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblErrorConfirmPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(143, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Зміна паролю";
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.Location = new System.Drawing.Point(12, 50);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(86, 15);
            this.labelOldPassword.TabIndex = 1;
            this.labelOldPassword.Text = "Старий пароль";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(12, 70);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(300, 23);
            this.txtOldPassword.TabIndex = 2;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // lblErrorOldPassword
            // 
            this.lblErrorOldPassword.AutoSize = true;
            this.lblErrorOldPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOldPassword.Location = new System.Drawing.Point(12, 95);
            this.lblErrorOldPassword.Name = "lblErrorOldPassword";
            this.lblErrorOldPassword.Size = new System.Drawing.Size(0, 15);
            this.lblErrorOldPassword.TabIndex = 3;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(12, 120);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(78, 15);
            this.labelNewPassword.TabIndex = 4;
            this.labelNewPassword.Text = "Новий пароль";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(12, 140);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(300, 23);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblErrorNewPassword
            // 
            this.lblErrorNewPassword.AutoSize = true;
            this.lblErrorNewPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNewPassword.Location = new System.Drawing.Point(12, 165);
            this.lblErrorNewPassword.Name = "lblErrorNewPassword";
            this.lblErrorNewPassword.Size = new System.Drawing.Size(0, 15);
            this.lblErrorNewPassword.TabIndex = 6;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(12, 190);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(126, 15);
            this.labelConfirmPassword.TabIndex = 7;
            this.labelConfirmPassword.Text = "Підтвердіть новий пароль";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(12, 210);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 23);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblErrorConfirmPassword
            // 
            this.lblErrorConfirmPassword.AutoSize = true;
            this.lblErrorConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorConfirmPassword.Location = new System.Drawing.Point(12, 235);
            this.lblErrorConfirmPassword.Name = "lblErrorConfirmPassword";
            this.lblErrorConfirmPassword.Size = new System.Drawing.Size(0, 15);
            this.lblErrorConfirmPassword.TabIndex = 9;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(12, 270);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(100, 30);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Змінити";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // ChangePasswordForm
            // 
            this.ClientSize = new System.Drawing.Size(330, 320);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblErrorConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.lblErrorNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.lblErrorOldPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.labelOldPassword);
            this.Controls.Add(this.labelTitle);
            this.Name = "ChangePasswordForm";
            this.Text = "Зміна паролю";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblErrorOldPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblErrorNewPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblErrorConfirmPassword;
        private System.Windows.Forms.Button btnChangePassword;
    }
}
