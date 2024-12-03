namespace Task_6
{
    partial class EditForm
    {
        /// <summary>
        /// Обов'язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистити всі використовувані ресурси.
        /// </summary>
        /// <param name="disposing">істинне, якщо керовані ресурси слід утилізувати; інакше хибне.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                // Додайте очищення для інших елементів управління, якщо необхідно
            }
            base.Dispose(disposing);
        }

        #region Код, створений конструктором форм Windows

        /// <summary>
        /// Метод, необхідний для підтримки конструктора - не змінюйте
        /// його вміст за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelFields = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(160, 220);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelFields
            // 
            this.panelFields.Location = new System.Drawing.Point(12, 12);
            this.panelFields.Name = "panelFields";
            this.panelFields.Size = new System.Drawing.Size(360, 200);
            this.panelFields.TabIndex = 1;
            // 
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.panelFields);
            this.Controls.Add(this.buttonSave);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelFields;
    }
}
