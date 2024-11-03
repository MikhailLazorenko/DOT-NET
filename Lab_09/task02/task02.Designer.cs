namespace Lab09
{
    partial class task02
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxFromCurrency;
        private System.Windows.Forms.ComboBox comboBoxToCurrency;
        private System.Windows.Forms.Button buttonConvert;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxFromCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxToCurrency = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сума у грн.";

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);

            // 
            // comboBoxFromCurrency
            // 
            this.comboBoxFromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFromCurrency.FormattingEnabled = true;
            this.comboBoxFromCurrency.Items.AddRange(new object[] { "Гривня", "Мексиканське песо" });
            this.comboBoxFromCurrency.Location = new System.Drawing.Point(20, 60);
            this.comboBoxFromCurrency.Name = "comboBoxFromCurrency";
            this.comboBoxFromCurrency.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFromCurrency.TabIndex = 4;

            // 
            // comboBoxToCurrency
            // 
            this.comboBoxToCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToCurrency.FormattingEnabled = true;
            this.comboBoxToCurrency.Items.AddRange(new object[] { "Гривня", "Мексиканське песо" });
            this.comboBoxToCurrency.Location = new System.Drawing.Point(160, 60);
            this.comboBoxToCurrency.Name = "comboBoxToCurrency";
            this.comboBoxToCurrency.Size = new System.Drawing.Size(121, 21);
            this.comboBoxToCurrency.TabIndex = 5;

            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(120, 90);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(100, 23);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Конвертувати";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;

            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(120, 160);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.Enabled = false;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.comboBoxToCurrency);
            this.Controls.Add(this.comboBoxFromCurrency);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Обмін валют";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
