namespace task05
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private ComboBox comboBoxCities;
        private Label labelSelectCity;

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
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.labelSelectCity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(80, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(160, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Міста Китаю";
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Items.AddRange(new object[] {
            "Пекін",
            "Шанхай",
            "Гуанчжоу",
            "Шеньчжень",
            "Сіань",
            "Ченду",
            "Ханчжоу"});
            this.comboBoxCities.Location = new System.Drawing.Point(100, 100);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(120, 21);
            this.comboBoxCities.TabIndex = 1;
            this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.comboBoxCities_SelectedIndexChanged);
            // 
            // labelSelectCity
            // 
            this.labelSelectCity.AutoSize = true;
            this.labelSelectCity.Location = new System.Drawing.Point(100, 80);
            this.labelSelectCity.Name = "labelSelectCity";
            this.labelSelectCity.Size = new System.Drawing.Size(82, 13);
            this.labelSelectCity.TabIndex = 2;
            this.labelSelectCity.Text = "Виберіть місто:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.Controls.Add(this.labelSelectCity);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.Text = "Головна форма";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
