namespace task02 
{
    partial class Form1
    {
        /// <summary>
        /// Обов'язкова змінна для дизайнера.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очищення ресурсів, які використовуються.
        /// </summary>
        /// <param name="disposing">true, якщо управлінські ресурси слід видалити; інакше - false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, згенерований дизайнером Windows Form

        /// <summary>
        /// Обов'язковий метод для підтримки дизайнера - не змінюйте
        /// вміст цього методу за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 200); // Встановлюємо розміри вікна
            this.Name = "Form1";
            this.Text = "Приклад застосунку";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
