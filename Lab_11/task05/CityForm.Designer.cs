namespace task05
{
    partial class CityForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelCityName;
        private PictureBox pictureBoxCity;
        private TextBox textBoxDescription;

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
            this.labelCityName = new System.Windows.Forms.Label();
            this.pictureBoxCity = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelCityName.Location = new System.Drawing.Point(20, 20);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(66, 24);
            this.labelCityName.TabIndex = 0;
            this.labelCityName.Text = "Місто";
            // 
            // pictureBoxCity
            // 
            this.pictureBoxCity.Location = new System.Drawing.Point(20, 60);
            this.pictureBoxCity.Name = "pictureBoxCity";
            this.pictureBoxCity.Size = new System.Drawing.Size(300, 200);
            this.pictureBoxCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCity.TabIndex = 1;
            this.pictureBoxCity.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(20, 280);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(300, 100);
            this.textBoxDescription.TabIndex = 2;
            // 
            // CityForm
            // 
            this.ClientSize = new System.Drawing.Size(340, 400);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.pictureBoxCity);
            this.Controls.Add(this.labelCityName);
            this.Name = "CityForm";
            this.Text = "Інформація про місто";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
