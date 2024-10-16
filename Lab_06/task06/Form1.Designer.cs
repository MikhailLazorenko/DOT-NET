partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.ComboBox ageComboBox;
    private System.Windows.Forms.RadioButton maleRadioButton;
    private System.Windows.Forms.RadioButton femaleRadioButton;
    private System.Windows.Forms.CheckBox computersCheckBox;
    private System.Windows.Forms.CheckBox sportsCheckBox;
    private System.Windows.Forms.CheckBox artCheckBox;
    private System.Windows.Forms.CheckBox scienceCheckBox;
    private System.Windows.Forms.TextBox opinionFileTextBox;
    private System.Windows.Forms.TextBox opinionTextBox;
    private System.Windows.Forms.Button browseButton;
    private System.Windows.Forms.Button submitButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.GroupBox personalInfoGroupBox;
    private System.Windows.Forms.GroupBox opinionGroupBox;

    private void InitializeComponent()
    {
        this.passwordTextBox = new System.Windows.Forms.TextBox();
        this.nameTextBox = new System.Windows.Forms.TextBox();
        this.ageComboBox = new System.Windows.Forms.ComboBox();
        this.maleRadioButton = new System.Windows.Forms.RadioButton();
        this.femaleRadioButton = new System.Windows.Forms.RadioButton();
        this.computersCheckBox = new System.Windows.Forms.CheckBox();
        this.sportsCheckBox = new System.Windows.Forms.CheckBox();
        this.artCheckBox = new System.Windows.Forms.CheckBox();
        this.scienceCheckBox = new System.Windows.Forms.CheckBox();
        this.opinionFileTextBox = new System.Windows.Forms.TextBox();
        this.opinionTextBox = new System.Windows.Forms.TextBox();
        this.browseButton = new System.Windows.Forms.Button();
        this.submitButton = new System.Windows.Forms.Button();
        this.clearButton = new System.Windows.Forms.Button();
        this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
        this.opinionGroupBox = new System.Windows.Forms.GroupBox();

        // Form properties
        this.Text = "Реєстраційна форма";
        this.ClientSize = new System.Drawing.Size(700, 600);

        // Password
        Label passwordLabel = new Label { Text = "Введіть пароль", Location = new System.Drawing.Point(20, 20) };
        this.passwordTextBox.Location = new System.Drawing.Point(20, 40);
        this.passwordTextBox.PasswordChar = '*';
        this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
        this.Controls.Add(passwordLabel);
        this.Controls.Add(this.passwordTextBox);

        // Personal Info GroupBox
        this.personalInfoGroupBox.Location = new System.Drawing.Point(20, 80);
        this.personalInfoGroupBox.Size = new System.Drawing.Size(550, 200);
        this.personalInfoGroupBox.Text = "Розкажіть про себе";
        this.Controls.Add(this.personalInfoGroupBox);

        Label nameLabel = new Label { Text = "Ваше ім'я:", Location = new System.Drawing.Point(170, 30) };
        this.nameTextBox.Location = new System.Drawing.Point(270, 30);
        this.nameTextBox.Text = "Анонім";
        this.nameTextBox.Size = new System.Drawing.Size(200, 20);

        Label ageLabel = new Label { Text = "Ваш вік:", Location = new System.Drawing.Point(200, 60) };
        this.ageComboBox.Location = new System.Drawing.Point(300, 60);
        this.ageComboBox.Size = new System.Drawing.Size(70, 21);
        this.ageComboBox.Items.AddRange(new object[] { "< 20", "20-29", "30-39", "40-49", "50-59", "60+" });

        Label genderLabel = new Label { Text = "Ваша стать:", Location = new System.Drawing.Point(140, 90) };
        this.maleRadioButton.Location = new System.Drawing.Point(240, 90);
        this.maleRadioButton.Size = new System.Drawing.Size(100, 20);
        this.maleRadioButton.Text = "Чоловіча";
        this.femaleRadioButton.Location = new System.Drawing.Point(340, 90);
        this.femaleRadioButton.Size = new System.Drawing.Size(100, 20);
        this.femaleRadioButton.Text = "Жіноча";

        Label interestsLabel = new Label { Text = "Ваші інтереси:", Location = new System.Drawing.Point(220, 120) };
        this.computersCheckBox.Location = new System.Drawing.Point(100, 150);
        this.computersCheckBox.Size = new System.Drawing.Size(100, 20);
        this.computersCheckBox.Text = "Комп'ютери";
        this.sportsCheckBox.Location = new System.Drawing.Point(200, 150);
        this.sportsCheckBox.Size = new System.Drawing.Size(70, 20);
        this.sportsCheckBox.Text = "Спорт";
        this.artCheckBox.Location = new System.Drawing.Point(270, 150);
        this.artCheckBox.Size = new System.Drawing.Size(100, 20);
        this.artCheckBox.Text = "Мистецтво";
        this.scienceCheckBox.Location = new System.Drawing.Point(370, 150);
        this.scienceCheckBox.Size = new System.Drawing.Size(70, 20);
        this.scienceCheckBox.Text = "Наука";

        this.personalInfoGroupBox.Controls.Add(nameLabel);
        this.personalInfoGroupBox.Controls.Add(this.nameTextBox);
        this.personalInfoGroupBox.Controls.Add(ageLabel);
        this.personalInfoGroupBox.Controls.Add(this.ageComboBox);
        this.personalInfoGroupBox.Controls.Add(genderLabel);
        this.personalInfoGroupBox.Controls.Add(this.maleRadioButton);
        this.personalInfoGroupBox.Controls.Add(this.femaleRadioButton);
        this.personalInfoGroupBox.Controls.Add(interestsLabel);
        this.personalInfoGroupBox.Controls.Add(this.computersCheckBox);
        this.personalInfoGroupBox.Controls.Add(this.sportsCheckBox);
        this.personalInfoGroupBox.Controls.Add(this.artCheckBox);
        this.personalInfoGroupBox.Controls.Add(this.scienceCheckBox);

        // Opinion GroupBox
        this.opinionGroupBox.Location = new System.Drawing.Point(20, 300);
        this.opinionGroupBox.Size = new System.Drawing.Size(550, 250);
        this.opinionGroupBox.Text = "Ваша думка";
        this.Controls.Add(this.opinionGroupBox);

        // Label for opinion file
        Label opinionFileLabel = new Label { Text = "Введіть ім'я файла з описом вашої думки:", Location = new System.Drawing.Point(130, 30), AutoSize = true };
        this.opinionFileTextBox.Location = new System.Drawing.Point(110, 50);
        this.opinionFileTextBox.Size = new System.Drawing.Size(200, 20);
        this.browseButton.Location = new System.Drawing.Point(310, 50);
        this.browseButton.Size = new System.Drawing.Size(75, 23);
        this.browseButton.Text = "Огляд...";

        // Label for opinion text
        Label opinionTextLabel = new Label { Text = "Або можете висловити свою думку прямо тут:", Location = new System.Drawing.Point(120, 80), AutoSize = true };
        this.opinionTextBox.Location = new System.Drawing.Point(155, 100);
        this.opinionTextBox.Size = new System.Drawing.Size(200, 60);
        this.opinionTextBox.Multiline = true;

        this.opinionGroupBox.Controls.Add(opinionFileLabel);
        this.opinionGroupBox.Controls.Add(this.opinionFileTextBox);
        this.opinionGroupBox.Controls.Add(this.browseButton);
        this.opinionGroupBox.Controls.Add(opinionTextLabel);
        this.opinionGroupBox.Controls.Add(this.opinionTextBox);

        // Move buttons into the opinion group box
        this.submitButton.Location = new System.Drawing.Point(140, 170);
        this.submitButton.Size = new System.Drawing.Size(90, 23);
        this.submitButton.Text = "Відправити";
        this.opinionGroupBox.Controls.Add(this.submitButton);

        this.clearButton.Location = new System.Drawing.Point(230, 170);
        this.clearButton.Size = new System.Drawing.Size(130, 23);
        this.clearButton.Text = "Очистити форму";
        this.opinionGroupBox.Controls.Add(this.clearButton);

        // Event handlers
        this.clearButton.Click += new System.EventHandler(this.ClearForm);
        this.browseButton.Click += new System.EventHandler(this.BrowseFile);
        this.submitButton.Click += new System.EventHandler(this.SubmitData);

        // Form cleanup
        this.ResumeLayout(false);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
}
