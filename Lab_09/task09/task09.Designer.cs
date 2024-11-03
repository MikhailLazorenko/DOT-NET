namespace Lab09
{
    partial class task09
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
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.comboBoxTablets = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(12, 20);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(139, 13);
            this.labelModel.TabIndex = 1;
            this.labelModel.Text = "Виберіть модель планшета:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(270, 50);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(200, 80);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 120);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 4;
            // 
            // comboBoxTablets
            // 
            this.comboBoxTablets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTablets.FormattingEnabled = true;
            this.comboBoxTablets.Items.AddRange(new object[]
            {
                "Apple iPad - 12000 грн",
                "Samsung Galaxy Tab - 9000 грн",
                "Xiaomi Pad - 7000 грн"
            });
            this.comboBoxTablets.Location = new System.Drawing.Point(15, 50);
            this.comboBoxTablets.Name = "comboBoxTablets";
            this.comboBoxTablets.Size = new System.Drawing.Size(170, 21);
            this.comboBoxTablets.TabIndex = 5;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(210, 53);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(50, 13);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "Кількість:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.comboBoxTablets);
            this.Name = "Form1";
            this.Text = "Ціна планшета";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ComboBox comboBoxTablets;
        private System.Windows.Forms.Label labelQuantity; // Додано
    }
}
