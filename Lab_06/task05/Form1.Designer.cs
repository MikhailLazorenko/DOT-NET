namespace task05 // Простір імен Task_5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxSports;
        private System.Windows.Forms.CheckBox checkBoxTravel;
        private System.Windows.Forms.CheckBox checkBoxCrafting;
        private System.Windows.Forms.CheckBox checkBoxPainting;
        private System.Windows.Forms.Label labelSports;
        private System.Windows.Forms.Label labelTravel;
        private System.Windows.Forms.Label labelCrafting;
        private System.Windows.Forms.Label labelPainting;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonRefuse;

        protected override void Dispose(bool disposing) // Вивільнення ресурсів
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() // Ініціалізація компонентів форми
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBoxSports = new System.Windows.Forms.CheckBox();
            this.checkBoxTravel = new System.Windows.Forms.CheckBox();
            this.checkBoxCrafting = new System.Windows.Forms.CheckBox();
            this.checkBoxPainting = new System.Windows.Forms.CheckBox();
            this.labelSports = new System.Windows.Forms.Label();
            this.labelTravel = new System.Windows.Forms.Label();
            this.labelCrafting = new System.Windows.Forms.Label();
            this.labelPainting = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonRefuse = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(120, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(130, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Виберіть ваші інтереси:";

            // checkBoxSports
            this.checkBoxSports.AutoSize = true;
            this.checkBoxSports.Location = new System.Drawing.Point(330, 50);
            this.checkBoxSports.Name = "checkBoxSports";
            this.checkBoxSports.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSports.TabIndex = 1;
            this.checkBoxSports.Checked = true;

            // labelSports
            this.labelSports.AutoSize = true;
            this.labelSports.Location = new System.Drawing.Point(30, 50);
            this.labelSports.Name = "labelSports";
            this.labelSports.Size = new System.Drawing.Size(35, 13);
            this.labelSports.TabIndex = 2;
            this.labelSports.Text = "Спорт";

            // checkBoxTravel
            this.checkBoxTravel.AutoSize = true;
            this.checkBoxTravel.Location = new System.Drawing.Point(289, 80);
            this.checkBoxTravel.Name = "checkBoxTravel";
            this.checkBoxTravel.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTravel.TabIndex = 3;

            // labelTravel
            this.labelTravel.AutoSize = true;
            this.labelTravel.Location = new System.Drawing.Point(150, 80);
            this.labelTravel.Name = "labelTravel";
            this.labelTravel.Size = new System.Drawing.Size(55, 13);
            this.labelTravel.TabIndex = 4;
            this.labelTravel.Text = "Мандрівки";

            // checkBoxCrafting
            this.checkBoxCrafting.AutoSize = true;
            this.checkBoxCrafting.Location = new System.Drawing.Point(291, 110);
            this.checkBoxCrafting.Name = "checkBoxCrafting";
            this.checkBoxCrafting.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCrafting.TabIndex = 5;
            this.checkBoxCrafting.Checked = true;

            // labelCrafting
            this.labelCrafting.AutoSize = true;
            this.labelCrafting.Location = new System.Drawing.Point(95, 110);
            this.labelCrafting.Name = "labelCrafting";
            this.labelCrafting.Size = new System.Drawing.Size(75, 13);
            this.labelCrafting.TabIndex = 6;
            this.labelCrafting.Text = "Майстрування";

            // checkBoxPainting
            this.checkBoxPainting.AutoSize = true;
            this.checkBoxPainting.Location = new System.Drawing.Point(332, 140);
            this.checkBoxPainting.Name = "checkBoxPainting";
            this.checkBoxPainting.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPainting.TabIndex = 7;

            // labelPainting
            this.labelPainting.AutoSize = true;
            this.labelPainting.Location = new System.Drawing.Point(150, 140);
            this.labelPainting.Name = "labelPainting";
            this.labelPainting.Size = new System.Drawing.Size(65, 13);
            this.labelPainting.TabIndex = 8;
            this.labelPainting.Text = "Малювання";

            // buttonChoose
            this.buttonChoose.Location = new System.Drawing.Point(125, 140);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 9;
            this.buttonChoose.Text = "Вибрати";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.ButtonChoose_Click);

            // buttonRefuse
            this.buttonRefuse.Location = new System.Drawing.Point(230, 140);
            this.buttonRefuse.Name = "buttonRefuse";
            this.buttonRefuse.Size = new System.Drawing.Size(80, 23);
            this.buttonRefuse.TabIndex = 10;
            this.buttonRefuse.Text = "Відмовитися";
            this.buttonRefuse.UseVisualStyleBackColor = true;
            this.buttonRefuse.Click += new System.EventHandler(this.ButtonRefuse_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.buttonRefuse);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.labelPainting);
            this.Controls.Add(this.checkBoxPainting);
            this.Controls.Add(this.labelCrafting);
            this.Controls.Add(this.checkBoxCrafting);
            this.Controls.Add(this.labelTravel);
            this.Controls.Add(this.checkBoxTravel);
            this.Controls.Add(this.labelSports);
            this.Controls.Add(this.checkBoxSports);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Вибір інтересів";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
