partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    public System.Windows.Forms.TextBox passwordTextBox;
    public System.Windows.Forms.TextBox nameTextBox;
    public System.Windows.Forms.ComboBox ageComboBox;
    public System.Windows.Forms.RadioButton maleRadioButton;
    public System.Windows.Forms.RadioButton femaleRadioButton;
    public System.Windows.Forms.CheckBox computersCheckBox;
    public System.Windows.Forms.CheckBox sportsCheckBox;
    public System.Windows.Forms.CheckBox artCheckBox;
    public System.Windows.Forms.CheckBox scienceCheckBox;
    public System.Windows.Forms.TextBox opinionFileTextBox;
    public System.Windows.Forms.TextBox opinionTextBox;
    public System.Windows.Forms.Button browseButton;
    public System.Windows.Forms.Button submitButton;
    public System.Windows.Forms.Button clearButton;
    public System.Windows.Forms.Button settingsButton; // Кнопка "Параметри"
    public System.Windows.Forms.GroupBox personalInfoGroupBox;
    public System.Windows.Forms.GroupBox opinionGroupBox;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
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
        this.settingsButton = new System.Windows.Forms.Button(); // Ініціалізація кнопки "Параметри"
        this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
        this.opinionGroupBox = new System.Windows.Forms.GroupBox();

        // Властивості форми
        this.Text = "Реєстраційна форма";
        this.ClientSize = new System.Drawing.Size(700, 650);

        // Пароль
        System.Windows.Forms.Label passwordLabel = new System.Windows.Forms.Label();
        passwordLabel.Text = "Введіть пароль";
        passwordLabel.Location = new System.Drawing.Point(20, 20);
        passwordLabel.AutoSize = true;
        this.passwordTextBox.Location = new System.Drawing.Point(20, 40);
        this.passwordTextBox.PasswordChar = '*';
        this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
        this.Controls.Add(passwordLabel);
        this.Controls.Add(this.passwordTextBox);

        // Кнопка "Параметри"
        this.settingsButton.Location = new System.Drawing.Point(240, 40);
        this.settingsButton.Size = new System.Drawing.Size(100, 23);
        this.settingsButton.Text = "Параметри";
        this.settingsButton.Click += new System.EventHandler(this.OpenSettings);
        this.Controls.Add(this.settingsButton);

        // Група особистої інформації
        this.personalInfoGroupBox.Location = new System.Drawing.Point(20, 80);
        this.personalInfoGroupBox.Size = new System.Drawing.Size(650, 200);
        this.personalInfoGroupBox.Text = "Розкажіть про себе";
        this.Controls.Add(this.personalInfoGroupBox);

        // Ім'я
        System.Windows.Forms.Label nameLabel = new System.Windows.Forms.Label();
        nameLabel.Text = "Ваше ім'я:";
        nameLabel.Location = new System.Drawing.Point(170, 30);
        nameLabel.AutoSize = true;
        this.nameTextBox.Location = new System.Drawing.Point(270, 30);
        this.nameTextBox.Text = "Анонім";
        this.nameTextBox.Size = new System.Drawing.Size(200, 20);

        // Вік
        System.Windows.Forms.Label ageLabel = new System.Windows.Forms.Label();
        ageLabel.Text = "Ваш вік:";
        ageLabel.Location = new System.Drawing.Point(200, 60);
        ageLabel.AutoSize = true;
        this.ageComboBox.Location = new System.Drawing.Point(270, 60);
        this.ageComboBox.Size = new System.Drawing.Size(70, 21);
        this.ageComboBox.Items.AddRange(new object[] { "< 20", "20-29", "30-39", "40-49", "50-59", "60+" });

        // Стать
        System.Windows.Forms.Label genderLabel = new System.Windows.Forms.Label();
        genderLabel.Text = "Ваша стать:";
        genderLabel.Location = new System.Drawing.Point(140, 90);
        genderLabel.AutoSize = true;
        this.maleRadioButton.Location = new System.Drawing.Point(240, 90);
        this.maleRadioButton.Size = new System.Drawing.Size(100, 20);
        this.maleRadioButton.Text = "Чоловіча";
        this.femaleRadioButton.Location = new System.Drawing.Point(340, 90);
        this.femaleRadioButton.Size = new System.Drawing.Size(100, 20);
        this.femaleRadioButton.Text = "Жіноча";

        // Інтереси
        System.Windows.Forms.Label interestsLabel = new System.Windows.Forms.Label();
        interestsLabel.Text = "Ваші інтереси:";
        interestsLabel.Location = new System.Drawing.Point(220, 120);
        interestsLabel.AutoSize = true;
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

        // Додавання контролів до групи особистої інформації
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

        // Група думки
        this.opinionGroupBox.Location = new System.Drawing.Point(20, 300);
        this.opinionGroupBox.Size = new System.Drawing.Size(650, 250);
        this.opinionGroupBox.Text = "Ваша думка";
        this.Controls.Add(this.opinionGroupBox);

        // Мітка для файлу з думкою
        System.Windows.Forms.Label opinionFileLabel = new System.Windows.Forms.Label();
        opinionFileLabel.Text = "Введіть ім'я файла з описом вашої думки:";
        opinionFileLabel.Location = new System.Drawing.Point(130, 30);
        opinionFileLabel.AutoSize = true;
        this.opinionFileTextBox.Location = new System.Drawing.Point(110, 50);
        this.opinionFileTextBox.Size = new System.Drawing.Size(200, 20);
        this.browseButton.Location = new System.Drawing.Point(310, 50);
        this.browseButton.Size = new System.Drawing.Size(75, 23);
        this.browseButton.Text = "Огляд...";
        this.browseButton.Click += new System.EventHandler(this.BrowseFile);

        // Мітка для тексту думки
        System.Windows.Forms.Label opinionTextLabel = new System.Windows.Forms.Label();
        opinionTextLabel.Text = "Або можете висловити свою думку прямо тут:";
        opinionTextLabel.Location = new System.Drawing.Point(120, 80);
        opinionTextLabel.AutoSize = true;
        this.opinionTextBox.Location = new System.Drawing.Point(155, 100);
        this.opinionTextBox.Size = new System.Drawing.Size(200, 60);
        this.opinionTextBox.Multiline = true;

        // Додавання контролів до групи думки
        this.opinionGroupBox.Controls.Add(opinionFileLabel);
        this.opinionGroupBox.Controls.Add(this.opinionFileTextBox);
        this.opinionGroupBox.Controls.Add(this.browseButton);
        this.opinionGroupBox.Controls.Add(opinionTextLabel);
        this.opinionGroupBox.Controls.Add(this.opinionTextBox);

        // Кнопка "Відправити"
        this.submitButton.Location = new System.Drawing.Point(140, 170);
        this.submitButton.Size = new System.Drawing.Size(90, 23);
        this.submitButton.Text = "Відправити";
        this.submitButton.Click += new System.EventHandler(this.SubmitData);
        this.opinionGroupBox.Controls.Add(this.submitButton);

        // Кнопка "Очистити форму"
        this.clearButton.Location = new System.Drawing.Point(230, 170);
        this.clearButton.Size = new System.Drawing.Size(130, 23);
        this.clearButton.Text = "Очистити форму";
        this.clearButton.Click += new System.EventHandler(this.ClearForm);
        this.opinionGroupBox.Controls.Add(this.clearButton);

        // Завершення ініціалізації
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
