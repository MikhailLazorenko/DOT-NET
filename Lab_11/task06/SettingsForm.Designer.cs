partial class SettingsForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button buttonChangeBackground;
    private System.Windows.Forms.Button buttonChangeButtonFont;
    private System.Windows.Forms.Button buttonChangeLabelFont;
    private System.Windows.Forms.Button buttonChangeTextBoxColor;
    private System.Windows.Forms.Button buttonChangeCheckBoxFont;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.buttonChangeBackground = new System.Windows.Forms.Button();
        this.buttonChangeButtonFont = new System.Windows.Forms.Button();
        this.buttonChangeLabelFont = new System.Windows.Forms.Button();
        this.buttonChangeTextBoxColor = new System.Windows.Forms.Button();
        this.buttonChangeCheckBoxFont = new System.Windows.Forms.Button();

        // Властивості форми налаштувань
        this.Text = "Налаштування";
        this.ClientSize = new System.Drawing.Size(400, 300);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.StartPosition = FormStartPosition.CenterParent;

        // Кнопка "Змінити колір фону форми"
        this.buttonChangeBackground.Location = new System.Drawing.Point(50, 30);
        this.buttonChangeBackground.Size = new System.Drawing.Size(300, 30);
        this.buttonChangeBackground.Text = "Змінити колір фону форми";
        this.buttonChangeBackground.Click += new System.EventHandler(this.buttonChangeBackground_Click);
        this.Controls.Add(this.buttonChangeBackground);

        // Кнопка "Змінити шрифт кнопки 'Відправити'"
        this.buttonChangeButtonFont.Location = new System.Drawing.Point(50, 80);
        this.buttonChangeButtonFont.Size = new System.Drawing.Size(300, 30);
        this.buttonChangeButtonFont.Text = "Змінити шрифт кнопки \"Відправити\"";
        this.buttonChangeButtonFont.Click += new System.EventHandler(this.buttonChangeButtonFont_Click);
        this.Controls.Add(this.buttonChangeButtonFont);

        // Кнопка "Змінити шрифт заголовків"
        this.buttonChangeLabelFont.Location = new System.Drawing.Point(50, 130);
        this.buttonChangeLabelFont.Size = new System.Drawing.Size(300, 30);
        this.buttonChangeLabelFont.Text = "Змінити шрифт заголовків";
        this.buttonChangeLabelFont.Click += new System.EventHandler(this.buttonChangeLabelFont_Click);
        this.Controls.Add(this.buttonChangeLabelFont);

        // Кнопка "Змінити колір поля 'Думка'"
        this.buttonChangeTextBoxColor.Location = new System.Drawing.Point(50, 180);
        this.buttonChangeTextBoxColor.Size = new System.Drawing.Size(300, 30);
        this.buttonChangeTextBoxColor.Text = "Змінити колір поля \"Думка\"";
        this.buttonChangeTextBoxColor.Click += new System.EventHandler(this.buttonChangeTextBoxColor_Click);
        this.Controls.Add(this.buttonChangeTextBoxColor);

        // Кнопка "Змінити шрифт чекбоксів 'Інтереси'"
        this.buttonChangeCheckBoxFont.Location = new System.Drawing.Point(50, 230);
        this.buttonChangeCheckBoxFont.Size = new System.Drawing.Size(300, 30);
        this.buttonChangeCheckBoxFont.Text = "Змінити шрифт чекбоксів \"Інтереси\"";
        this.buttonChangeCheckBoxFont.Click += new System.EventHandler(this.buttonChangeCheckBoxFont_Click);
        this.Controls.Add(this.buttonChangeCheckBoxFont);

        // Завершення ініціалізації
        this.ResumeLayout(false);
    }

    // Метод Dispose для звільнення ресурсів
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
}
