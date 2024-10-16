namespace task09
{
    // Частковий клас, що представляє основну форму програми
    partial class Form1
    {
        // Контейнер для компонентів форми
        private System.ComponentModel.IContainer components = null;

        // Панель інструментів
        private System.Windows.Forms.ToolStrip toolStrip1;

        // Кнопки на панелі інструментів
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;

        // Вивільнення ресурсів, що використовуються формою
        protected override void Dispose(bool disposing)
        {
            // Вивільнення компонентів, якщо це необхідно
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            // Виклик базового методу для завершення звільнення ресурсів
            base.Dispose(disposing);
        }

        // Метод для ініціалізації компонентів форми
        private void InitializeComponent()
        {
            // Створення нових екземплярів панелі інструментів і кнопок
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();

            // Запуск сесії налаштування панелі інструментів
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();

            // Додавання кнопок до панелі інструментів
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});

            // Налаштування позиції, назви та розмірів панелі інструментів
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";

            // Налаштування кнопок на панелі інструментів
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = System.Drawing.Image.FromFile(@"resource\1.jpg"); // Зображення для кнопки 1
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Tool1";

            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = System.Drawing.Image.FromFile(@"resource\2.jpg"); // Зображення для кнопки 2
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Tool2";

            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = System.Drawing.Image.FromFile(@"resource\3.jpg"); // Зображення для кнопки 3
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Tool3";

            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = System.Drawing.Image.FromFile(@"resource\4.jpg"); // Зображення для кнопки 4
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Tool4";

            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = System.Drawing.Image.FromFile(@"resource\5.jpg"); // Зображення для кнопки 5
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Tool5";

            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = System.Drawing.Image.FromFile(@"resource\6.jpg"); // Зображення для кнопки 6
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Tool6";

            // Налаштування властивостей основної форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450); // Розмір форми
            this.Controls.Add(this.toolStrip1); // Додавання панелі інструментів до форми
            this.Name = "Form1"; 
            this.Text = "task09"; 

            // Завершення налаштування панелі інструментів і форми
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}