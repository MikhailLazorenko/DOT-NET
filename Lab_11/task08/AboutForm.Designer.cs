namespace task08
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelAbout;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelAbout = new System.Windows.Forms.Label();

            // Налаштування форми
            this.Text = "Про програму";
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            // labelAbout
            this.labelAbout.Text = "Текстовий редактор\n\nРозробник: Лазоренко Михайло";
            this.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAbout.Dock = DockStyle.Fill;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);

            // Додавання контролів до форми
            this.Controls.Add(this.labelAbout);

            // Завершення ініціалізації
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
