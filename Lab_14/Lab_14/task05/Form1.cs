using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Task_5
{
    public partial class Form1 : Form
    {
        // Параметри підключення до бази даних
        private string connStr = "server=localhost;user=root;database=TelephoneNetworkDB;password=mnc5UbTRn_nZ+M:;"; // Замініть 'your_password' на ваш пароль

        // Змінні для зберігання вибраних таблиці та режиму
        private string selectedTable = "Telephone";
        private string selectedMode = "Form";

        // DataTable для зберігання даних
        private DataTable dataTable = new DataTable();

        // Словник для зберігання контролів фільтрів
        private Dictionary<string, Control> filterControls = new Dictionary<string, Control>();

        // DataGridView
        private DataGridView dataGridView = new DataGridView();

        public Form1()
        {
            // Встановлення культури на українську
            Thread.CurrentThread.CurrentCulture = new CultureInfo("uk-UA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");

            InitializeComponent();

            // Ініціалізація ComboBox
            comboBoxTables.Items.AddRange(new string[] { "Telephone", "ATS", "PaymentForServices" });
            comboBoxTables.SelectedIndex = 0;

            // Підписка на події
            comboBoxTables.SelectedIndexChanged += ComboBoxTables_SelectedIndexChanged;
            radioButtonFormMode.CheckedChanged += RadioButtonMode_CheckedChanged;
            radioButtonTableMode.CheckedChanged += RadioButtonMode_CheckedChanged;

            // Налаштування DataGridView
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Додаємо DataGridView до панелі
            panelContent.Controls.Add(dataGridView);

            // Відображаємо дані
            DisplayData();
        }

        private void ComboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTable = comboBoxTables.SelectedItem.ToString();
            DisplayData();
        }

        private void RadioButtonMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFormMode.Checked)
                selectedMode = "Form";
            else if (radioButtonTableMode.Checked)
                selectedMode = "Table";

            DisplayData();
        }

        // Метод для відображення даних
        private void DisplayData()
        {
            panelContent.Controls.Clear();

            if (selectedMode == "Form")
            {
                DisplayDataInFormMode();
            }
            else if (selectedMode == "Table")
            {
                DisplayDataInTableMode();
            }
        }

        // Метод для відображення даних у режимі таблиці
        private void DisplayDataInTableMode()
        {
            // Очищаємо фільтри та DataGridView
            filterControls.Clear();
            dataGridView.Controls.Clear();
            panelContent.Controls.Clear();

            dataTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM {selectedTable};";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка отримання даних: " + ex.Message);
                    return;
                }
            }

            dataGridView.DataSource = dataTable;

            // Додаємо DataGridView до панелі
            panelContent.Controls.Add(dataGridView);

            // Додаємо рядок фільтрів
            AddFilterRow();
        }

        // Метод для додавання рядка фільтрів
        private void AddFilterRow()
        {
            filterControls.Clear();
            dataGridView.Controls.Clear();

            Panel panelFilters = new Panel();
            panelFilters.Height = dataGridView.ColumnHeadersHeight;
            panelFilters.Dock = DockStyle.Top;

            int x = 0;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                Control filterControl;

                if (!dataTable.Columns.Contains(column.Name))
                    continue;

                // Перевіряємо, чи значення в стовпчику повторюються
                bool hasDuplicates = dataTable.AsEnumerable()
                    .GroupBy(row => row.Field<object>(column.Name))
                    .Any(g => g.Count() > 1);

                if (hasDuplicates)
                {
                    ComboBox comboBox = new ComboBox();
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox.Width = column.Width;
                    comboBox.Left = x;
                    comboBox.Top = 0;

                    // Додаємо значення в ComboBox
                    var values = dataTable.AsEnumerable()
                        .Select(row => row.Field<object>(column.Name))
                        .Distinct()
                        .ToList();

                    values.Insert(0, "Всі");
                    comboBox.DataSource = values;

                    comboBox.SelectedIndexChanged += FilterControl_ValueChanged;

                    filterControl = comboBox;
                }
                else
                {
                    TextBox textBox = new TextBox();
                    textBox.Width = column.Width;
                    textBox.Left = x;
                    textBox.Top = 0;

                    textBox.TextChanged += FilterControl_ValueChanged;

                    filterControl = textBox;
                }

                filterControls[column.Name] = filterControl;
                panelFilters.Controls.Add(filterControl);

                x += column.Width;
            }

            dataGridView.Controls.Add(panelFilters);
        }

        // Обробник зміни фільтрів
        private void FilterControl_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // Метод для застосування фільтрів
        private void ApplyFilters()
        {
            string filterString = "";

            foreach (var kvp in filterControls)
            {
                string columnName = kvp.Key;
                Control control = kvp.Value;

                if (!dataTable.Columns.Contains(columnName))
                    continue;

                if (control is TextBox textBox)
                {
                    if (!string.IsNullOrEmpty(textBox.Text))
                    {
                        if (!string.IsNullOrEmpty(filterString))
                            filterString += " AND ";

                        filterString += $"CONVERT([{columnName}], System.String) LIKE '%{textBox.Text}%'";
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex > 0)
                    {
                        if (!string.IsNullOrEmpty(filterString))
                            filterString += " AND ";

                        string value = comboBox.SelectedItem.ToString().Replace("'", "''");
                        filterString += $"[{columnName}] = '{value}'";
                    }
                }
            }

            try
            {
                dataTable.DefaultView.RowFilter = filterString;

                // Оновлюємо ComboBox після фільтрації
                UpdateComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка застосування фільтрів: " + ex.Message);
            }
        }

        // Метод для оновлення ComboBox після фільтрації
        private void UpdateComboBoxes()
        {
            foreach (var kvp in filterControls)
            {
                string columnName = kvp.Key;
                Control control = kvp.Value;

                if (!dataTable.Columns.Contains(columnName))
                    continue;

                if (control is ComboBox comboBox)
                {
                    var values = dataTable.DefaultView.ToTable(true, columnName).AsEnumerable()
                        .Select(row => row.Field<object>(columnName))
                        .ToList();

                    values.Insert(0, "Всі");
                    comboBox.SelectedIndexChanged -= FilterControl_ValueChanged;
                    comboBox.DataSource = values;
                    comboBox.SelectedIndexChanged += FilterControl_ValueChanged;
                }
            }
        }

        // Метод для відображення даних у режимі формуляру
        private void DisplayDataInFormMode()
        {
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;

            if (selectedTable == "Telephone")
            {
                List<Telephone> telephones = GetTelephones();
                int y = 10;

                foreach (var tel in telephones)
                {
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = $"Телефон: {tel.Number}";
                    groupBox.Location = new System.Drawing.Point(10, y);
                    groupBox.Size = new System.Drawing.Size(panelContent.Width - 40, 100);

                    Label lblNumber = new Label() { Text = "Номер:", Location = new System.Drawing.Point(10, 20) };
                    Label lblNumberValue = new Label() { Text = tel.Number, Location = new System.Drawing.Point(150, 20) };

                    Label lblDate = new Label() { Text = "Дата встановлення:", Location = new System.Drawing.Point(10, 40) };
                    Label lblDateValue = new Label() { Text = tel.InstallationDate.ToShortDateString(), Location = new System.Drawing.Point(150, 40) };

                    Label lblBlocker = new Label() { Text = "Наявність блокатора:", Location = new System.Drawing.Point(10, 60) };
                    Label lblBlockerValue = new Label() { Text = tel.HasBlocker ? "Так" : "Ні", Location = new System.Drawing.Point(150, 60) };

                    groupBox.Controls.Add(lblNumber);
                    groupBox.Controls.Add(lblNumberValue);
                    groupBox.Controls.Add(lblDate);
                    groupBox.Controls.Add(lblDateValue);
                    groupBox.Controls.Add(lblBlocker);
                    groupBox.Controls.Add(lblBlockerValue);

                    panelContent.Controls.Add(groupBox);

                    y += groupBox.Height + 10;
                }
            }
            else if (selectedTable == "ATS")
            {
                List<ATS> atss = GetATSs();
                int y = 10;

                foreach (var ats in atss)
                {
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = $"АТС: {ats.Number}";
                    groupBox.Location = new System.Drawing.Point(10, y);
                    groupBox.Size = new System.Drawing.Size(panelContent.Width - 40, 100);

                    Label lblNumber = new Label() { Text = "Номер:", Location = new System.Drawing.Point(10, 20) };
                    Label lblNumberValue = new Label() { Text = ats.Number, Location = new System.Drawing.Point(150, 20) };

                    Label lblDistrict = new Label() { Text = "Район:", Location = new System.Drawing.Point(10, 40) };
                    Label lblDistrictValue = new Label() { Text = ats.District, Location = new System.Drawing.Point(150, 40) };

                    Label lblTotalNumbers = new Label() { Text = "Загальна кількість номерів:", Location = new System.Drawing.Point(10, 60) };
                    Label lblTotalNumbersValue = new Label() { Text = ats.TotalNumbers.ToString(), Location = new System.Drawing.Point(150, 60) };

                    groupBox.Controls.Add(lblNumber);
                    groupBox.Controls.Add(lblNumberValue);
                    groupBox.Controls.Add(lblDistrict);
                    groupBox.Controls.Add(lblDistrictValue);
                    groupBox.Controls.Add(lblTotalNumbers);
                    groupBox.Controls.Add(lblTotalNumbersValue);

                    panelContent.Controls.Add(groupBox);

                    y += groupBox.Height + 10;
                }
            }
            else if (selectedTable == "PaymentForServices")
            {
                List<PaymentForServices> payments = GetPayments();
                int y = 10;

                foreach (var pay in payments)
                {
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = $"Оплата ID: {pay.ID}";
                    groupBox.Location = new System.Drawing.Point(10, y);
                    groupBox.Size = new System.Drawing.Size(panelContent.Width - 40, 140);

                    Label lblID = new Label() { Text = "ID:", Location = new System.Drawing.Point(10, 20) };
                    Label lblIDValue = new Label() { Text = pay.ID.ToString(), Location = new System.Drawing.Point(150, 20) };

                    Label lblTelephone = new Label() { Text = "Номер телефону:", Location = new System.Drawing.Point(10, 40) };
                    Label lblTelephoneValue = new Label() { Text = pay.TelephoneNumber, Location = new System.Drawing.Point(150, 40) };

                    Label lblATS = new Label() { Text = "Номер АТС:", Location = new System.Drawing.Point(10, 60) };
                    Label lblATSValue = new Label() { Text = pay.ATSNumber, Location = new System.Drawing.Point(150, 60) };

                    Label lblCost = new Label() { Text = "Вартість:", Location = new System.Drawing.Point(10, 80) };
                    Label lblCostValue = new Label() { Text = pay.Cost.ToString("C"), Location = new System.Drawing.Point(150, 80) };

                    Label lblIsPaid = new Label() { Text = "Оплачено:", Location = new System.Drawing.Point(10, 100) };
                    Label lblIsPaidValue = new Label() { Text = pay.IsPaid ? "Так" : "Ні", Location = new System.Drawing.Point(150, 100) };

                    groupBox.Controls.Add(lblID);
                    groupBox.Controls.Add(lblIDValue);
                    groupBox.Controls.Add(lblTelephone);
                    groupBox.Controls.Add(lblTelephoneValue);
                    groupBox.Controls.Add(lblATS);
                    groupBox.Controls.Add(lblATSValue);
                    groupBox.Controls.Add(lblCost);
                    groupBox.Controls.Add(lblCostValue);
                    groupBox.Controls.Add(lblIsPaid);
                    groupBox.Controls.Add(lblIsPaidValue);

                    panelContent.Controls.Add(groupBox);

                    y += groupBox.Height + 10;
                }
            }
        }

        // Метод для отримання списку телефонів
        private List<Telephone> GetTelephones()
        {
            List<Telephone> telephones = new List<Telephone>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Telephone;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        telephones.Add(new Telephone
                        {
                            Number = reader.GetString("Number"),
                            InstallationDate = reader.GetDateTime("InstallationDate"),
                            HasBlocker = reader.GetBoolean("HasBlocker")
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка отримання телефонів: " + ex.Message);
                }
            }

            return telephones;
        }

        // Метод для отримання списку АТС
        private List<ATS> GetATSs()
        {
            List<ATS> atss = new List<ATS>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM ATS;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        atss.Add(new ATS
                        {
                            Number = reader.GetString("Number"),
                            District = reader.GetString("District"),
                            TotalNumbers = reader.GetInt32("TotalNumbers")
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка отримання АТС: " + ex.Message);
                }
            }

            return atss;
        }

        // Метод для отримання списку оплат
        private List<PaymentForServices> GetPayments()
        {
            List<PaymentForServices> payments = new List<PaymentForServices>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM PaymentForServices;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        payments.Add(new PaymentForServices
                        {
                            ID = reader.GetInt32("ID"),
                            TelephoneNumber = reader.GetString("TelephoneNumber"),
                            ATSNumber = reader.GetString("ATSNumber"),
                            Cost = reader.GetDecimal("Cost"),
                            IsPaid = reader.GetBoolean("IsPaid")
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка отримання оплат: " + ex.Message);
                }
            }

            return payments;
        }
    }
}
