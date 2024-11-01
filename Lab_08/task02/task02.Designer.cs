namespace Lab08
{
    partial class task02
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxCity;
        private System.Windows.Forms.GroupBox groupBoxTransport;
        private System.Windows.Forms.RadioButton radioButtonKharkiv;
        private System.Windows.Forms.RadioButton radioButtonKyiv;
        private System.Windows.Forms.RadioButton radioButtonOdesa;
        private System.Windows.Forms.RadioButton radioButtonZaporizhzhia;
        private System.Windows.Forms.RadioButton radioButtonBus;
        private System.Windows.Forms.RadioButton radioButtonTrain;
        private System.Windows.Forms.RadioButton radioButtonPlane;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSend; // Кнопка "Відіслати"
        private System.Windows.Forms.Button buttonReset; // Кнопка "Скинути"

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
            this.groupBoxCity = new System.Windows.Forms.GroupBox();
            this.radioButtonKharkiv = new System.Windows.Forms.RadioButton();
            this.radioButtonKyiv = new System.Windows.Forms.RadioButton();
            this.radioButtonOdesa = new System.Windows.Forms.RadioButton();
            this.radioButtonZaporizhzhia = new System.Windows.Forms.RadioButton();
            this.groupBoxTransport = new System.Windows.Forms.GroupBox();
            this.radioButtonBus = new System.Windows.Forms.RadioButton();
            this.radioButtonTrain = new System.Windows.Forms.RadioButton();
            this.radioButtonPlane = new System.Windows.Forms.RadioButton();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button(); // Ініціалізація кнопки "Відіслати"
            this.buttonReset = new System.Windows.Forms.Button(); // Ініціалізація кнопки "Скинути"

            // Налаштування компонентів вибору міста
            this.groupBoxCity.SuspendLayout();
            this.groupBoxTransport.SuspendLayout();
            this.SuspendLayout();

            // Налаштування GroupBox для міста
            this.groupBoxCity.Controls.Add(this.radioButtonKharkiv);
            this.groupBoxCity.Controls.Add(this.radioButtonKyiv);
            this.groupBoxCity.Controls.Add(this.radioButtonOdesa);
            this.groupBoxCity.Controls.Add(this.radioButtonZaporizhzhia);
            this.groupBoxCity.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCity.Name = "groupBoxCity";
            this.groupBoxCity.Size = new System.Drawing.Size(200, 150);
            this.groupBoxCity.TabIndex = 0;
            this.groupBoxCity.TabStop = false;
            this.groupBoxCity.Text = "Вибрати місто:";

            // Налаштування RadioButtons для міст
            this.radioButtonKharkiv.AutoSize = true;
            this.radioButtonKharkiv.Location = new System.Drawing.Point(6, 19);
            this.radioButtonKharkiv.Name = "radioButtonKharkiv";
            this.radioButtonKharkiv.Size = new System.Drawing.Size(58, 17);
            this.radioButtonKharkiv.TabIndex = 0;
            this.radioButtonKharkiv.TabStop = true;
            this.radioButtonKharkiv.Text = "Харків";
            this.radioButtonKharkiv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonKharkiv.UseVisualStyleBackColor = true;

            this.radioButtonKyiv.AutoSize = true;
            this.radioButtonKyiv.Location = new System.Drawing.Point(6, 42);
            this.radioButtonKyiv.Name = "radioButtonKyiv";
            this.radioButtonKyiv.Size = new System.Drawing.Size(46, 17);
            this.radioButtonKyiv.TabIndex = 1;
            this.radioButtonKyiv.TabStop = true;
            this.radioButtonKyiv.Text = "Київ";
            this.radioButtonKyiv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonKyiv.UseVisualStyleBackColor = true;

            this.radioButtonOdesa.AutoSize = true;
            this.radioButtonOdesa.Location = new System.Drawing.Point(6, 65);
            this.radioButtonOdesa.Name = "radioButtonOdesa";
            this.radioButtonOdesa.Size = new System.Drawing.Size(57, 17);
            this.radioButtonOdesa.TabIndex = 2;
            this.radioButtonOdesa.TabStop = true;
            this.radioButtonOdesa.Text = "Одеса";
            this.radioButtonOdesa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonOdesa.UseVisualStyleBackColor = true;

            this.radioButtonZaporizhzhia.AutoSize = true;
            this.radioButtonZaporizhzhia.Location = new System.Drawing.Point(6, 88);
            this.radioButtonZaporizhzhia.Name = "radioButtonZaporizhzhia";
            this.radioButtonZaporizhzhia.Size = new System.Drawing.Size(75, 17);
            this.radioButtonZaporizhzhia.TabIndex = 3;
            this.radioButtonZaporizhzhia.TabStop = true;
            this.radioButtonZaporizhzhia.Text = "Запоріжжя";
            this.radioButtonZaporizhzhia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonZaporizhzhia.UseVisualStyleBackColor = true;

            // Налаштування GroupBox для транспорту
            this.groupBoxTransport.Controls.Add(this.radioButtonBus);
            this.groupBoxTransport.Controls.Add(this.radioButtonTrain);
            this.groupBoxTransport.Controls.Add(this.radioButtonPlane);
            this.groupBoxTransport.Location = new System.Drawing.Point(218, 12);
            this.groupBoxTransport.Name = "groupBoxTransport";
            this.groupBoxTransport.Size = new System.Drawing.Size(200, 150);
            this.groupBoxTransport.TabIndex = 1;
            this.groupBoxTransport.TabStop = false;
            this.groupBoxTransport.Text = "Вибрати транспорт:";

            // Налаштування RadioButtons для транспорту
            this.radioButtonBus.AutoSize = true;
            this.radioButtonBus.Location = new System.Drawing.Point(6, 19);
            this.radioButtonBus.Name = "radioButtonBus";
            this.radioButtonBus.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBus.TabIndex = 0;
            this.radioButtonBus.TabStop = true;
            this.radioButtonBus.Text = "Автобус";
            this.radioButtonBus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonBus.UseVisualStyleBackColor = true;

            this.radioButtonTrain.AutoSize = true;
            this.radioButtonTrain.Location = new System.Drawing.Point(6, 42);
            this.radioButtonTrain.Name = "radioButtonTrain";
            this.radioButtonTrain.Size = new System.Drawing.Size(54, 17);
            this.radioButtonTrain.TabIndex = 1;
            this.radioButtonTrain.TabStop = true;
            this.radioButtonTrain.Text = "Потяг";
            this.radioButtonTrain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonTrain.UseVisualStyleBackColor = true;

            this.radioButtonPlane.AutoSize = true;
            this.radioButtonPlane.Location = new System.Drawing.Point(6, 65);
            this.radioButtonPlane.Name = "radioButtonPlane";
            this.radioButtonPlane.Size = new System.Drawing.Size(66, 17);
            this.radioButtonPlane.TabIndex = 2;
            this.radioButtonPlane.TabStop = true;
            this.radioButtonPlane.Text = "Літак";
            this.radioButtonPlane.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonPlane.UseVisualStyleBackColor = true;

            // Налаштування кнопок
            this.buttonSelect.Location = new System.Drawing.Point(12, 168);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Вибрати";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);

            this.buttonSend.Location = new System.Drawing.Point(93, 168);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Відіслати";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);

            this.buttonReset.Location = new System.Drawing.Point(174, 168);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Скинути";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);

            this.buttonCancel.Location = new System.Drawing.Point(255, 168);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Вихід";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 201);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.groupBoxTransport);
            this.Controls.Add(this.groupBoxCity);
            this.Name = "Form1";
            this.Text = "Конвертер";
            this.groupBoxCity.ResumeLayout(false);
            this.groupBoxCity.PerformLayout();
            this.groupBoxTransport.ResumeLayout(false);
            this.groupBoxTransport.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
