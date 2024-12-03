using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Task_7
{
    public partial class Form1 : Form
    {
        // Параметри підключення до бази даних
        private string connStr = "server=localhost;user=root;database=TelephoneNetworkDB;password=mnc5UbTRn_nZ+M:;"; // Замініть 'your_password' на ваш пароль

        public Form1()
        {
            InitializeComponent();

            // Ініціалізація ComboBox
            comboBoxTables.Items.AddRange(new string[] { "Telephone", "ATS", "PaymentForServices" });
            comboBoxTables.SelectedIndex = 0;

            // Підписка на подію зміни вибору в ComboBox
            comboBoxTables.SelectedIndexChanged += ComboBoxTables_SelectedIndexChanged;

            // Завантаження даних та статистики для початкової таблиці
            LoadDataAndStatistics(comboBoxTables.SelectedItem.ToString());
        }

        private void ComboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = comboBoxTables.SelectedItem.ToString();
            LoadDataAndStatistics(selectedTable);
        }

        private void LoadDataAndStatistics(string tableName)
        {
            LoadData(tableName);
            LoadStatistics(tableName);
        }

        private void LoadData(string tableName)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM {tableName};";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка отримання даних: " + ex.Message);
                }
            }
        }

        private void LoadStatistics(string tableName)
        {
            listViewStatistics.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    if (tableName == "Telephone")
                    {
                        // Загальна кількість телефонів
                        string query1 = "SELECT COUNT(*) FROM Telephone;";
                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        int totalTelephones = Convert.ToInt32(cmd1.ExecuteScalar());

                        // Кількість телефонів з блокатором
                        string query2 = "SELECT COUNT(*) FROM Telephone WHERE HasBlocker = TRUE;";
                        MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                        int telephonesWithBlocker = Convert.ToInt32(cmd2.ExecuteScalar());

                        // Середня кількість днів з моменту встановлення
                        string query3 = "SELECT AVG(DATEDIFF(CURDATE(), InstallationDate)) FROM Telephone;";
                        MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                        double averageDays = Convert.ToDouble(cmd3.ExecuteScalar());

                        // Відображення статистики
                        AddStatistic("Загальна кількість телефонів", totalTelephones.ToString());
                        AddStatistic("Телефони з блокатором", telephonesWithBlocker.ToString());
                        AddStatistic("Середня кількість днів з моменту встановлення", averageDays.ToString("F2"));
                    }
                    else if (tableName == "ATS")
                    {
                        // Загальна кількість АТС
                        string query1 = "SELECT COUNT(*) FROM ATS;";
                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        int totalATS = Convert.ToInt32(cmd1.ExecuteScalar());

                        // Максимальна кількість номерів на АТС
                        string query2 = "SELECT MAX(TotalNumbers) FROM ATS;";
                        MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                        int maxNumbers = Convert.ToInt32(cmd2.ExecuteScalar());

                        // Район з найбільшою кількістю АТС
                        string query3 = "SELECT District FROM ATS GROUP BY District ORDER BY COUNT(*) DESC LIMIT 1;";
                        MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                        string topDistrict = cmd3.ExecuteScalar().ToString();

                        // Відображення статистики
                        AddStatistic("Загальна кількість АТС", totalATS.ToString());
                        AddStatistic("Максимальна кількість номерів на АТС", maxNumbers.ToString());
                        AddStatistic("Район з найбільшою кількістю АТС", topDistrict);
                    }
                    else if (tableName == "PaymentForServices")
                    {
                        // Загальна сума платежів
                        string query1 = "SELECT SUM(Cost) FROM PaymentForServices;";
                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        decimal totalPayments = Convert.ToDecimal(cmd1.ExecuteScalar());

                        // Середня вартість послуг
                        string query2 = "SELECT AVG(Cost) FROM PaymentForServices;";
                        MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                        decimal averageCost = Convert.ToDecimal(cmd2.ExecuteScalar());

                        // Кількість неоплачених послуг
                        string query3 = "SELECT COUNT(*) FROM PaymentForServices WHERE IsPaid = FALSE;";
                        MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                        int unpaidServices = Convert.ToInt32(cmd3.ExecuteScalar());

                        // Відображення статистики
                        AddStatistic("Загальна сума платежів", totalPayments.ToString("F2"));
                        AddStatistic("Середня вартість послуг", averageCost.ToString("F2"));
                        AddStatistic("Кількість неоплачених послуг", unpaidServices.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка отримання статистики: " + ex.Message);
                }
            }
        }

        private void AddStatistic(string name, string value)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(value);
            listViewStatistics.Items.Add(item);
        }
    }
}
