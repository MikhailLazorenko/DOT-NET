using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_8_Test
{
    partial class LogForm
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
            labelTitle = new Label();
            panelContainer = new Panel();
            lblErrorMessage = new Label();
            labelUsername = new Label();
            txtUsername = new TextBox();
            labelPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            labelNoAccount = new Label();
            btnRegister = new Button();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(64, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Вхід";
            // 
            // panelContainer
            // 
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Controls.Add(lblErrorMessage);
            panelContainer.Controls.Add(labelUsername);
            panelContainer.Controls.Add(txtUsername);
            panelContainer.Controls.Add(labelPassword);
            panelContainer.Controls.Add(txtPassword);
            panelContainer.Controls.Add(btnLogin);
            panelContainer.Controls.Add(labelNoAccount);
            panelContainer.Controls.Add(btnRegister);
            panelContainer.Location = new Point(12, 50);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(490, 240);
            panelContainer.TabIndex = 1;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.ForeColor = Color.Gray;
            lblErrorMessage.Location = new Point(330, 175);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 20);
            lblErrorMessage.TabIndex = 7;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            labelUsername.Location = new Point(10, 20);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(89, 23);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(10, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter username";
            txtUsername.Size = new Size(300, 27);
            txtUsername.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            labelPassword.Location = new Point(10, 80);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(85, 23);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(10, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new Size(300, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Blue;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(10, 150);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Вхід";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelNoAccount
            // 
            labelNoAccount.AutoSize = true;
            labelNoAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            labelNoAccount.Location = new Point(10, 190);
            labelNoAccount.Name = "labelNoAccount";
            labelNoAccount.Size = new Size(194, 20);
            labelNoAccount.TabIndex = 5;
            labelNoAccount.Text = "Немає облікового запису?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Gray;
            btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(240, 185);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 25);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Реєстрація";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // LogForm
            // 
            ClientSize = new Size(520, 300);
            Controls.Add(panelContainer);
            Controls.Add(labelTitle);
            Name = "LogForm";
            Text = "Авторизація";
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelNoAccount;
        private System.Windows.Forms.Button btnRegister;
    }
}