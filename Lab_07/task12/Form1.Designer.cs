namespace task12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxCities;
        private ListBox listBoxCities;

        // Приватний масив міст
        private string[] cities = new string[]
        {
            "Пекін",
            "Шанхай",
            "Гуанчжоу",
            "Шеньчжень",
            "Ченду",
            "Сіань",
            "Ханчжоу"
        };

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
            this.comboBoxCities = new ComboBox();
            this.listBoxCities = new ListBox();
            this.SuspendLayout();

            // ComboBox Cities
            this.comboBoxCities.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Items.AddRange(cities); // Додаємо масив міст
            this.comboBoxCities.Location = new System.Drawing.Point(20, 20);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCities.TabIndex = 0;

            // ListBox Cities
            this.listBoxCities.FormattingEnabled = true;
            this.listBoxCities.Items.AddRange(cities); // Додаємо масив міст
            this.listBoxCities.Location = new System.Drawing.Point(20, 60);
            this.listBoxCities.Name = "listBoxCities";
            this.listBoxCities.Size = new System.Drawing.Size(200, 95);
            this.listBoxCities.TabIndex = 1;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.listBoxCities);
            this.Name = "Form1";
            this.Text = "Список міст Китаю";
            this.ResumeLayout(false);
        }
    }
}
