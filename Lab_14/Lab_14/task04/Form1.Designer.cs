using System.Windows.Forms;

namespace Task_4
{
    partial class Form1
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
                dataGridView.Dispose();
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
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.groupBoxModes = new System.Windows.Forms.GroupBox();
            this.radioButtonTableMode = new System.Windows.Forms.RadioButton();
            this.radioButtonFormMode = new System.Windows.Forms.RadioButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.groupBoxModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTables.TabIndex = 0;
            // 
            // groupBoxModes
            // 
            this.groupBoxModes.Controls.Add(this.radioButtonTableMode);
            this.groupBoxModes.Controls.Add(this.radioButtonFormMode);
            this.groupBoxModes.Location = new System.Drawing.Point(230, 5);
            this.groupBoxModes.Name = "groupBoxModes";
            this.groupBoxModes.Size = new System.Drawing.Size(250, 40);
            this.groupBoxModes.TabIndex = 1;
            this.groupBoxModes.TabStop = false;
            this.groupBoxModes.Text = "Режим відображення";
            // 
            // radioButtonTableMode
            // 
            this.radioButtonTableMode.AutoSize = true;
            this.radioButtonTableMode.Location = new System.Drawing.Point(130, 15);
            this.radioButtonTableMode.Name = "radioButtonTableMode";
            this.radioButtonTableMode.Size = new System.Drawing.Size(80, 21);
            this.radioButtonTableMode.TabIndex = 1;
            this.radioButtonTableMode.TabStop = true;
            this.radioButtonTableMode.Text = "Таблиця";
            this.radioButtonTableMode.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormMode
            // 
            this.radioButtonFormMode.AutoSize = true;
            this.radioButtonFormMode.Checked = true;
            this.radioButtonFormMode.Location = new System.Drawing.Point(10, 15);
            this.radioButtonFormMode.Name = "radioButtonFormMode";
            this.radioButtonFormMode.Size = new System.Drawing.Size(84, 21);
            this.radioButtonFormMode.TabIndex = 0;
            this.radioButtonFormMode.TabStop = true;
            this.radioButtonFormMode.Text = "Формуляр";
            this.radioButtonFormMode.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.Location = new System.Drawing.Point(12, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(760, 500);
            this.panelContent.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.groupBoxModes);
            this.Controls.Add(this.comboBoxTables);
            this.Name = "Form1";
            this.Text = "Telephone Network Sorting App";
            this.groupBoxModes.ResumeLayout(false);
            this.groupBoxModes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.GroupBox groupBoxModes;
        private System.Windows.Forms.RadioButton radioButtonTableMode;
        private System.Windows.Forms.RadioButton radioButtonFormMode;
        private System.Windows.Forms.Panel panelContent;
    }
}
