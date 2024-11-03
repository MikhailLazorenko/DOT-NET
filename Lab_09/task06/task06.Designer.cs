using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab09
{
    partial class task06
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
            lblTitle = new Label();
            chkCase = new CheckBox();
            chkScreenProtector = new CheckBox();
            chkMemoryUpgrade = new CheckBox();
            chkExtendedWarranty = new CheckBox();
            btnCalculate = new Button();
            lblBasePrice = new Label();
            lblAdditionalPrice = new Label();
            lblDiscount = new Label();
            lblTotalPrice = new Label();
            cmbCurrency = new ComboBox(); // Добавление ComboBox для валюты
            lblCurrency = new Label(); // Метка для отображения выбранной валюты
            pictureBox = new PictureBox();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(135, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Планшет";

            // chkCase
            chkCase.AutoSize = true;
            chkCase.Location = new Point(35, 70);
            chkCase.Name = "chkCase";
            chkCase.Size = new Size(140, 24);
            chkCase.TabIndex = 1;
            chkCase.Text = "Чохол (500 грн)";
            chkCase.UseVisualStyleBackColor = true;

            // chkScreenProtector
            chkScreenProtector.AutoSize = true;
            chkScreenProtector.Location = new Point(35, 100);
            chkScreenProtector.Name = "chkScreenProtector";
            chkScreenProtector.Size = new Size(188, 24);
            chkScreenProtector.TabIndex = 2;
            chkScreenProtector.Text = "Захисне скло (300 грн)";
            chkScreenProtector.UseVisualStyleBackColor = true;

            // chkMemoryUpgrade
            chkMemoryUpgrade.AutoSize = true;
            chkMemoryUpgrade.Location = new Point(35, 130);
            chkMemoryUpgrade.Name = "chkMemoryUpgrade";
            chkMemoryUpgrade.Size = new Size(241, 24);
            chkMemoryUpgrade.TabIndex = 3;
            chkMemoryUpgrade.Text = "Збільшення пам'яті (1500 грн)";
            chkMemoryUpgrade.UseVisualStyleBackColor = true;

            // chkExtendedWarranty
            chkExtendedWarranty.AutoSize = true;
            chkExtendedWarranty.Location = new Point(35, 160);
            chkExtendedWarranty.Name = "chkExtendedWarranty";
            chkExtendedWarranty.Size = new Size(235, 24);
            chkExtendedWarranty.TabIndex = 4;
            chkExtendedWarranty.Text = "Гарантія на 2 роки (1000 грн)";
            chkExtendedWarranty.UseVisualStyleBackColor = true;

            // btnCalculate
            btnCalculate.Location = new Point(35, 200);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "OK";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += BtnCalculate_Click; // Привязка к событию

            // lblBasePrice
            lblBasePrice.AutoSize = true;
            lblBasePrice.Location = new Point(35, 240);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(0, 20);
            lblBasePrice.TabIndex = 6;

            // lblAdditionalPrice
            lblAdditionalPrice.AutoSize = true;
            lblAdditionalPrice.Location = new Point(35, 260);
            lblAdditionalPrice.Name = "lblAdditionalPrice";
            lblAdditionalPrice.Size = new Size(0, 20);
            lblAdditionalPrice.TabIndex = 7;

            // lblDiscount
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(35, 280);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(0, 20);
            lblDiscount.TabIndex = 8;

            // lblTotalPrice
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(35, 300);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 20);
            lblTotalPrice.TabIndex = 9;

            // cmbCurrency
            cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurrency.Items.AddRange(new object[] { "Гривна (UAH)", "Долар (USD)" });
            cmbCurrency.Location = new Point(20, 350);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new Size(121, 24);
            cmbCurrency.TabIndex = 10;
            cmbCurrency.SelectedIndexChanged += CmbCurrency_SelectedIndexChanged; // Привязка к событию

            // lblCurrency
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(20, 380);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(0, 20);
            lblCurrency.TabIndex = 11;

            // pictureBox
            pictureBox.Location = new Point(400, 20);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(200, 200);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Встановлюємо режим
            // Завантаження зображення з ресурсів
            byte[] imageData = Properties.Resources.Tablet; // Ваша назва ресурсу

            using (var ms = new MemoryStream(imageData))
            {
                pictureBox.Image = System.Drawing.Image.FromStream(ms);
            }

            // Form1
            ClientSize = new Size(665, 400);
            Controls.Add(lblCurrency);
            Controls.Add(cmbCurrency); // Добавление ComboBox на форму
            Controls.Add(lblTotalPrice);
            Controls.Add(lblDiscount);
            Controls.Add(lblAdditionalPrice);
            Controls.Add(lblBasePrice);
            Controls.Add(btnCalculate);
            Controls.Add(chkExtendedWarranty);
            Controls.Add(chkMemoryUpgrade);
            Controls.Add(chkScreenProtector);
            Controls.Add(chkCase);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Комплектація";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.CheckBox chkScreenProtector;
        private System.Windows.Forms.CheckBox chkMemoryUpgrade;
        private System.Windows.Forms.CheckBox chkExtendedWarranty;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblAdditionalPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ComboBox cmbCurrency; // Поле для ComboBox
        private System.Windows.Forms.Label lblCurrency; // Поле для метки валюты
        private System.Windows.Forms.PictureBox pictureBox; // Додано PictureBox
    }
}
