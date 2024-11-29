namespace task10
{
    partial class SettingsForm
    {
        /// <summary>
        /// Обов'язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистити всі використовувані ресурси.
        /// </summary>
        /// <param name="disposing">отримання управління ресурсами.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, згенерований Конструктором форм Windows

        /// <summary>
        /// Метод, необхідний для підтримки конструктора — не змінюйте
        /// вміст цього методу з редактором коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumber = new System.Windows.Forms.Label();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.labelColors = new System.Windows.Forms.Label();
            this.listViewColors = new System.Windows.Forms.ListView();
            this.buttonAddColor = new System.Windows.Forms.Button();
            this.buttonRemoveColor = new System.Windows.Forms.Button();
            this.labelDiameter = new System.Windows.Forms.Label();
            this.numericUpDownDiameter = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 15);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(124, 17);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Кількість кульок:";
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(160, 13);
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNumber.TabIndex = 1;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelColors
            // 
            this.labelColors.AutoSize = true;
            this.labelColors.Location = new System.Drawing.Point(12, 50);
            this.labelColors.Name = "labelColors";
            this.labelColors.Size = new System.Drawing.Size(57, 17);
            this.labelColors.TabIndex = 2;
            this.labelColors.Text = "Кольори:";
            // 
            // listViewColors
            // 
            this.listViewColors.HideSelection = false;
            this.listViewColors.Location = new System.Drawing.Point(15, 70);
            this.listViewColors.Name = "listViewColors";
            this.listViewColors.Size = new System.Drawing.Size(265, 150);
            this.listViewColors.TabIndex = 3;
            this.listViewColors.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAddColor
            // 
            this.buttonAddColor.Location = new System.Drawing.Point(15, 230);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(125, 30);
            this.buttonAddColor.TabIndex = 4;
            this.buttonAddColor.Text = "Додати колір";
            this.buttonAddColor.UseVisualStyleBackColor = true;
            this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
            // 
            // buttonRemoveColor
            // 
            this.buttonRemoveColor.Location = new System.Drawing.Point(155, 230);
            this.buttonRemoveColor.Name = "buttonRemoveColor";
            this.buttonRemoveColor.Size = new System.Drawing.Size(125, 30);
            this.buttonRemoveColor.TabIndex = 5;
            this.buttonRemoveColor.Text = "Видалити";
            this.buttonRemoveColor.UseVisualStyleBackColor = true;
            this.buttonRemoveColor.Click += new System.EventHandler(this.buttonRemoveColor_Click);
            // 
            // labelDiameter
            // 
            this.labelDiameter.AutoSize = true;
            this.labelDiameter.Location = new System.Drawing.Point(12, 275);
            this.labelDiameter.Name = "labelDiameter";
            this.labelDiameter.Size = new System.Drawing.Size(94, 17);
            this.labelDiameter.TabIndex = 6;
            this.labelDiameter.Text = "Діаметр (px):";
            // 
            // numericUpDownDiameter
            // 
            this.numericUpDownDiameter.Location = new System.Drawing.Point(160, 273);
            this.numericUpDownDiameter.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDiameter.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownDiameter.Name = "numericUpDownDiameter";
            this.numericUpDownDiameter.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDiameter.TabIndex = 7;
            this.numericUpDownDiameter.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(12, 310);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(103, 17);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "Швидкість (px):";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.DecimalPlaces = 1;
            this.numericUpDownSpeed.Location = new System.Drawing.Point(160, 308);
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSpeed.TabIndex = 9;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(40, 350);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 30);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "Застосувати";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(160, 350);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.numericUpDownDiameter);
            this.Controls.Add(this.labelDiameter);
            this.Controls.Add(this.buttonRemoveColor);
            this.Controls.Add(this.buttonAddColor);
            this.Controls.Add(this.listViewColors);
            this.Controls.Add(this.labelColors);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.labelNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Text = "Налаштування кульок";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Label labelColors;
        private System.Windows.Forms.ListView listViewColors;
        private System.Windows.Forms.Button buttonAddColor;
        private System.Windows.Forms.Button buttonRemoveColor;
        private System.Windows.Forms.Label labelDiameter;
        private System.Windows.Forms.NumericUpDown numericUpDownDiameter;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}
