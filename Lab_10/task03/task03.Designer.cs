namespace Lab10
{
    partial class task03
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstImages;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnSelectFolder;

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
            this.lstImages = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // lstImages
            this.lstImages.FormattingEnabled = true;
            this.lstImages.Location = new System.Drawing.Point(12, 12);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(120, 238);
            this.lstImages.TabIndex = 0;
            this.lstImages.SelectedIndexChanged += new System.EventHandler(this.lstImages_SelectedIndexChanged);

            // pictureBox
            this.pictureBox.Location = new System.Drawing.Point(150, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(320, 240);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;

            // btnSelectFolder
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 260);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(120, 30);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Папка...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lstImages);
            this.Name = "Form1";
            this.Text = "Перегляд ілюстрацій";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
