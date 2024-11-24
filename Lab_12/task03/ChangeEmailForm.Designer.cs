namespace Lab12
{
    partial class ChangeEmailForm
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
            this.labelCurrentEmail = new System.Windows.Forms.Label();
            this.txtCurrentEmail = new System.Windows.Forms.TextBox();
            this.labelNewEmail = new System.Windows.Forms.Label();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.lblErrorNewEmail = new System.Windows.Forms.Label();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(117, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Зміна Email";
            // 
            // labelCurrentEmail
            // 
            this.labelCurrentEmail.AutoSize = true;
            this.labelCurrentEmail.Location = new System.Drawing.Point(12, 50);
            this.labelCurrentEmail.Name = "labelCurrentEmail";
            this.labelCurrentEmail.Size = new System.Drawing.Size(99, 15);
            this.labelCurrentEmail.TabIndex = 1;
            this.labelCurrentEmail.Text = "Поточний Email:";
            // 
            // txtCurrentEmail
            // 
            this.txtCurrentEmail.Location = new System.Drawing.Point(12, 70);
            this.txtCurrentEmail.Name = "txtCurrentEmail";
            this.txtCurrentEmail.ReadOnly = true;
            this.txtCurrentEmail.Size = new System.Drawing.Size(300, 23);
            this.txtCurrentEmail.TabIndex = 2;
            // 
            // labelNewEmail
            // 
            this.labelNewEmail.AutoSize = true;
            this.labelNewEmail.Location = new System.Drawing.Point(12, 100);
            this.labelNewEmail.Name = "labelNewEmail";
            this.labelNewEmail.Size = new System.Drawing.Size(72, 15);
            this.labelNewEmail.TabIndex = 3;
            this.labelNewEmail.Text = "Новий Email:";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(12, 120);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(300, 23);
            this.txtNewEmail.TabIndex = 4;
            // 
            // lblErrorNewEmail
            // 
            this.lblErrorNewEmail.AutoSize = true;
            this.lblErrorNewEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNewEmail.Location = new System.Drawing.Point(12, 145);
            this.lblErrorNewEmail.Name = "lblErrorNewEmail";
            this.lblErrorNewEmail.Size = new System.Drawing.Size(0, 15);
            this.lblErrorNewEmail.TabIndex = 5;
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.Location = new System.Drawing.Point(12, 170);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(100, 30);
            this.btnChangeEmail.TabIndex = 6;
            this.btnChangeEmail.Text = "Змінити";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            this.btnChangeEmail.Click += new System.EventHandler(this.btnChangeEmail_Click);
            // 
            // ChangeEmailForm
            // 
            this.ClientSize = new System.Drawing.Size(330, 220);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.lblErrorNewEmail);
            this.Controls.Add(this.txtNewEmail);
            this.Controls.Add(this.labelNewEmail);
            this.Controls.Add(this.txtCurrentEmail);
            this.Controls.Add(this.labelCurrentEmail);
            this.Controls.Add(this.labelTitle);
            this.Name = "ChangeEmailForm";
            this.Text = "Зміна Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCurrentEmail;
        private System.Windows.Forms.TextBox txtCurrentEmail;
        private System.Windows.Forms.Label labelNewEmail;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label lblErrorNewEmail;
        private System.Windows.Forms.Button btnChangeEmail;
    }
}
