using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Task_7
{
    public partial class Form1 : Form
    {
        // ��������� ���������� �� ���� �����
        private string connStr = "server=localhost;user=root;database=TelephoneNetworkDB;password=mnc5UbTRn_nZ+M:;"; // ������ 'your_password' �� ��� ������

        public Form1()
        {
            InitializeComponent();

            // ����������� ComboBox
            comboBoxTables.Items.AddRange(new string[] { "Telephone", "ATS", "PaymentForServices" });
            comboBoxTables.SelectedIndex = 0;

            // ϳ������ �� ���� ���� ������ � ComboBox
            comboBoxTables.SelectedIndexChanged += ComboBoxTables_SelectedIndexChanged;

            // ������������ ����� �� ���������� ��� ��������� �������
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
                    MessageBox.Show("������� ��������� �����: " + ex.Message);
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
                        // �������� ������� ��������
                        string query1 = "SELECT COUNT(*) FROM Telephone;";
                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        int totalTelephones = Convert.ToInt32(cmd1.ExecuteScalar());

                        // ʳ������ �������� � ����������
                        string query2 = "SELECT COUNT(*) FROM Telephone WHERE HasBlocker = TRUE;";
                        MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                        int telephonesWithBlocker = Convert.ToInt32(cmd2.ExecuteScalar());

                        // ������� ������� ��� � ������� ������������
                        string query3 = "SELECT AVG(DATEDIFF(CURDATE(), InstallationDate)) FROM Telephone;";
                        MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                        double averageDays = Convert.ToDouble(cmd3.ExecuteScalar());

                        // ³���������� ����������
                        AddStatistic("�������� ������� ��������", totalTelephones.ToString());
                        AddStatistic("�������� � ����������", telephonesWithBlocker.ToString());
                        AddStatistic("������� ������� ��� � ������� ������������", averageDays.ToString("F2"));
                    }
                    else if (tableName == "ATS")
                    {
                        // �������� ������� ���
                        string query1 = "SELECT COUNT(*) FROM ATS;";
                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        int totalATS = Convert.ToInt32(cmd1.ExecuteScalar());

                        // ����������� ������� ������ �� ���
                        string query2 = "SELECT MAX(TotalNumbers) FROM ATS;";
                        MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                        int maxNumbers = Convert.ToInt32(cmd2.ExecuteScalar());

                        // ����� � ��������� ������� ���
                        string query3 = "SELECT District FROM ATS GROUP BY District ORDER BY COUNT(*) DESC LIMIT 1;";
                        MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                        string topDistrict = cmd3.ExecuteScalar().ToString();

                        // ³���������� ����������
                        AddStatistic("�������� ������� ���", totalATS.ToString());
                        AddStatistic("����������� ������� ������ �� ���", maxNumbers.ToString());
                        AddStatistic("����� � ��������� ������� ���", topDistrict);
                    }
                    else if (tableName == "PaymentForServices")
                    {
                        // �������� ���� �������
                        string query1 = "SELECT SUM(Cost) FROM PaymentForServices;";
                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        decimal totalPayments = Convert.ToDecimal(cmd1.ExecuteScalar());

                        // ������� ������� ������
                        string query2 = "SELECT AVG(Cost) FROM PaymentForServices;";
                        MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                        decimal averageCost = Convert.ToDecimal(cmd2.ExecuteScalar());

                        // ʳ������ ����������� ������
                        string query3 = "SELECT COUNT(*) FROM PaymentForServices WHERE IsPaid = FALSE;";
                        MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                        int unpaidServices = Convert.ToInt32(cmd3.ExecuteScalar());

                        // ³���������� ����������
                        AddStatistic("�������� ���� �������", totalPayments.ToString("F2"));
                        AddStatistic("������� ������� ������", averageCost.ToString("F2"));
                        AddStatistic("ʳ������ ����������� ������", unpaidServices.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������� ��������� ����������: " + ex.Message);
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
