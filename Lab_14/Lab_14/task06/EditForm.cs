using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Task_6
{
    public partial class EditForm : Form
    {
        private string selectedTable;
        private string connStr;
        private DataRow dataRow;

        // Словник для зберігання динамічно створених елементів управління
        private Dictionary<string, Control> controlsDictionary = new Dictionary<string, Control>();

        public EditForm(string tableName, string connectionString, DataRow row)
        {
            InitializeComponent();

            selectedTable = tableName;
            connStr = connectionString;
            dataRow = row;

            InitializeForm();
        }

        private void InitializeForm()
        {
            // Очищаємо panelFields
            panelFields.Controls.Clear();
            controlsDictionary.Clear();

            if (selectedTable == "Telephone")
            {
                // Додаємо поля для таблиці Telephone
                AddLabelAndControl("Number", "Номер телефону:", new TextBox());
                AddLabelAndControl("InstallationDate", "Дата встановлення:", new DateTimePicker());
                AddLabelAndControl("HasBlocker", "Наявність блокатора:", new CheckBox());
            }
            else if (selectedTable == "ATS")
            {
                // Додаємо поля для таблиці ATS
                AddLabelAndControl("Number", "Номер АТС:", new TextBox());
                AddLabelAndControl("District", "Район:", new TextBox());

                // Створюємо NumericUpDown з відповідними властивостями
                NumericUpDown totalNumbersControl = new NumericUpDown();
                totalNumbersControl.Minimum = 0;
                totalNumbersControl.Maximum = 1000000; // Встановіть відповідне максимальне значення
                totalNumbersControl.DecimalPlaces = 0;
                totalNumbersControl.Increment = 1;

                AddLabelAndControl("TotalNumbers", "Кількість номерів:", totalNumbersControl);
            }
            else if (selectedTable == "PaymentForServices")
            {
                // Додаємо поля для таблиці PaymentForServices
                AddLabelAndControl("ID", "ID:", new TextBox());
                AddLabelAndControl("TelephoneNumber", "Номер телефону:", new TextBox());
                AddLabelAndControl("ATSNumber", "Номер АТС:", new TextBox());

                // Створюємо NumericUpDown для поля Cost
                NumericUpDown costControl = new NumericUpDown();
                costControl.Minimum = 0;
                costControl.Maximum = 1000000; // Встановіть відповідне максимальне значення
                costControl.DecimalPlaces = 2;
                costControl.Increment = 0.01M;

                AddLabelAndControl("Cost", "Вартість:", costControl);
                AddLabelAndControl("IsPaid", "Оплачено:", new CheckBox());
            }

            if (dataRow != null)
            {
                // Режим редагування
                this.Text = "Редагування запису";
                buttonSave.Text = "Зберегти";

                // Заповнюємо поля даними
                FillFields();
            }
            else
            {
                // Режим додавання
                this.Text = "Додавання нового запису";
                buttonSave.Text = "Додати";
            }
        }

        private void AddLabelAndControl(string fieldName, string labelText, Control control)
        {
            int yPosition = panelFields.Controls.Count / 2 * 30 + 10;

            Label label = new Label();
            label.Text = labelText;
            label.Location = new System.Drawing.Point(10, yPosition);
            label.Size = new System.Drawing.Size(140, 22);

            control.Name = fieldName;
            control.Location = new System.Drawing.Point(160, yPosition);
            control.Size = new System.Drawing.Size(200, 22);

            // Якщо контроль є NumericUpDown, встановлюємо властивості
            if (control is NumericUpDown numericUpDown)
            {
                if (fieldName == "TotalNumbers")
                {
                    numericUpDown.Minimum = 0;
                    numericUpDown.Maximum = 1000000; // Встановіть відповідне максимальне значення
                    numericUpDown.DecimalPlaces = 0;
                    numericUpDown.Increment = 1;
                }
                else if (fieldName == "Cost")
                {
                    numericUpDown.Minimum = 0;
                    numericUpDown.Maximum = 1000000; // Встановіть відповідне максимальне значення
                    numericUpDown.DecimalPlaces = 2;
                    numericUpDown.Increment = 0.01M;
                }
                else
                {
                    numericUpDown.Minimum = 0;
                    numericUpDown.Maximum = 1000000; // Загальне максимальне значення
                }
            }

            panelFields.Controls.Add(label);
            panelFields.Controls.Add(control);

            controlsDictionary[fieldName] = control;
        }

        private void FillFields()
        {
            foreach (var kvp in controlsDictionary)
            {
                string fieldName = kvp.Key;
                Control control = kvp.Value;

                if (!dataRow.Table.Columns.Contains(fieldName))
                    continue;

                object value = dataRow[fieldName];

                if (control is TextBox textBox)
                {
                    textBox.Text = value.ToString();
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = Convert.ToBoolean(value);
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = Convert.ToDateTime(value);
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    // Встановлюємо Maximum перед присвоєнням Value
                    if (fieldName == "TotalNumbers" || fieldName == "Cost")
                    {
                        // Властивості вже встановлені в методі AddLabelAndControl
                    }
                    else
                    {
                        numericUpDown.Minimum = 0;
                        numericUpDown.Maximum = 1000000;
                    }

                    numericUpDown.Value = Convert.ToDecimal(value);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataRow != null)
            {
                // Редагування існуючого запису
                UpdateRecord();
            }
            else
            {
                // Додавання нового запису
                InsertRecord();
            }
        }

        private void UpdateRecord()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    if (selectedTable == "Telephone")
                    {
                        query = "UPDATE Telephone SET InstallationDate=@InstallationDate, " +
                            "HasBlocker=@HasBlocker WHERE Number=@Number";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@Number", controlsDictionary["Number"].Text);
                        cmd.Parameters.AddWithValue("@InstallationDate", ((DateTimePicker)controlsDictionary["InstallationDate"]).Value);
                        cmd.Parameters.AddWithValue("@HasBlocker", ((CheckBox)controlsDictionary["HasBlocker"]).Checked);
                    }
                    else if (selectedTable == "ATS")
                    {
                        query = "UPDATE ATS SET District=@District, TotalNumbers=@TotalNumbers " +
                            "WHERE Number=@Number";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@Number", controlsDictionary["Number"].Text);
                        cmd.Parameters.AddWithValue("@District", controlsDictionary["District"].Text);
                        cmd.Parameters.AddWithValue("@TotalNumbers", ((NumericUpDown)controlsDictionary["TotalNumbers"]).Value);
                    }
                    else if (selectedTable == "PaymentForServices")
                    {
                        query = "UPDATE PaymentForServices SET TelephoneNumber=@TelephoneNumber, " +
                            "ATSNumber=@ATSNumber, Cost=@Cost, IsPaid=@IsPaid WHERE ID=@ID";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@ID", controlsDictionary["ID"].Text);
                        cmd.Parameters.AddWithValue("@TelephoneNumber", controlsDictionary["TelephoneNumber"].Text);
                        cmd.Parameters.AddWithValue("@ATSNumber", controlsDictionary["ATSNumber"].Text);
                        cmd.Parameters.AddWithValue("@Cost", ((NumericUpDown)controlsDictionary["Cost"]).Value);
                        cmd.Parameters.AddWithValue("@IsPaid", ((CheckBox)controlsDictionary["IsPaid"]).Checked);
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Запис успішно оновлено.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка оновлення запису: " + ex.Message);
                }
            }
        }

        private void InsertRecord()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    if (selectedTable == "Telephone")
                    {
                        query = "INSERT INTO Telephone (Number, InstallationDate, HasBlocker) " +
                            "VALUES (@Number, @InstallationDate, @HasBlocker)";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@Number", controlsDictionary["Number"].Text);
                        cmd.Parameters.AddWithValue("@InstallationDate", ((DateTimePicker)controlsDictionary["InstallationDate"]).Value);
                        cmd.Parameters.AddWithValue("@HasBlocker", ((CheckBox)controlsDictionary["HasBlocker"]).Checked);
                    }
                    else if (selectedTable == "ATS")
                    {
                        query = "INSERT INTO ATS (Number, District, TotalNumbers) " +
                            "VALUES (@Number, @District, @TotalNumbers)";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@Number", controlsDictionary["Number"].Text);
                        cmd.Parameters.AddWithValue("@District", controlsDictionary["District"].Text);
                        cmd.Parameters.AddWithValue("@TotalNumbers", ((NumericUpDown)controlsDictionary["TotalNumbers"]).Value);
                    }
                    else if (selectedTable == "PaymentForServices")
                    {
                        query = "INSERT INTO PaymentForServices (ID, TelephoneNumber, ATSNumber, Cost, IsPaid) " +
                            "VALUES (@ID, @TelephoneNumber, @ATSNumber, @Cost, @IsPaid)";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@ID", controlsDictionary["ID"].Text);
                        cmd.Parameters.AddWithValue("@TelephoneNumber", controlsDictionary["TelephoneNumber"].Text);
                        cmd.Parameters.AddWithValue("@ATSNumber", controlsDictionary["ATSNumber"].Text);
                        cmd.Parameters.AddWithValue("@Cost", ((NumericUpDown)controlsDictionary["Cost"]).Value);
                        cmd.Parameters.AddWithValue("@IsPaid", ((CheckBox)controlsDictionary["IsPaid"]).Checked);
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Запис успішно додано.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка додавання запису: " + ex.Message);
                }
            }
        }
    }
}
