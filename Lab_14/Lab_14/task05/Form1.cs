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
        // ��������� ���������� �� ���� �����
        private string connStr = "server=localhost;user=root;database=TelephoneNetworkDB;password=mnc5UbTRn_nZ+M:;"; // ������ 'your_password' �� ��� ������

        // ���� ��� ��������� �������� ������� �� ������
        private string selectedTable = "Telephone";
        private string selectedMode = "Form";

        // DataTable ��� ��������� �����
        private DataTable dataTable = new DataTable();

        // ������� ��� ��������� �������� �������
        private Dictionary<string, Control> filterControls = new Dictionary<string, Control>();

        // DataGridView
        private DataGridView dataGridView = new DataGridView();

        public Form1()
        {
            // ������������ �������� �� ���������
            Thread.CurrentThread.CurrentCulture = new CultureInfo("uk-UA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");

            InitializeComponent();

            // ����������� ComboBox
            comboBoxTables.Items.AddRange(new string[] { "Telephone", "ATS", "PaymentForServices" });
            comboBoxTables.SelectedIndex = 0;

            // ϳ������ �� ��䳿
            comboBoxTables.SelectedIndexChanged += ComboBoxTables_SelectedIndexChanged;
            radioButtonFormMode.CheckedChanged += RadioButtonMode_CheckedChanged;
            radioButtonTableMode.CheckedChanged += RadioButtonMode_CheckedChanged;

            // ������������ DataGridView
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ������ DataGridView �� �����
            panelContent.Controls.Add(dataGridView);

            // ³��������� ���
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

        // ����� ��� ����������� �����
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

        // ����� ��� ����������� ����� � ����� �������
        private void DisplayDataInTableMode()
        {
            // ������� ������� �� DataGridView
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
                    MessageBox.Show("������� ��������� �����: " + ex.Message);
                    return;
                }
            }

            dataGridView.DataSource = dataTable;

            // ������ DataGridView �� �����
            panelContent.Controls.Add(dataGridView);

            // ������ ����� �������
            AddFilterRow();
        }

        // ����� ��� ��������� ����� �������
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

                // ����������, �� �������� � ��������� ������������
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

                    // ������ �������� � ComboBox
                    var values = dataTable.AsEnumerable()
                        .Select(row => row.Field<object>(column.Name))
                        .Distinct()
                        .ToList();

                    values.Insert(0, "��");
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

        // �������� ���� �������
        private void FilterControl_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // ����� ��� ������������ �������
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

                // ��������� ComboBox ���� ����������
                UpdateComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������������ �������: " + ex.Message);
            }
        }

        // ����� ��� ��������� ComboBox ���� ����������
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

                    values.Insert(0, "��");
                    comboBox.SelectedIndexChanged -= FilterControl_ValueChanged;
                    comboBox.DataSource = values;
                    comboBox.SelectedIndexChanged += FilterControl_ValueChanged;
                }
            }
        }

        // ����� ��� ����������� ����� � ����� ���������
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
                    groupBox.Text = $"�������: {tel.Number}";
                    groupBox.Location = new System.Drawing.Point(10, y);
                    groupBox.Size = new System.Drawing.Size(panelContent.Width - 40, 100);

                    Label lblNumber = new Label() { Text = "�����:", Location = new System.Drawing.Point(10, 20) };
                    Label lblNumberValue = new Label() { Text = tel.Number, Location = new System.Drawing.Point(150, 20) };

                    Label lblDate = new Label() { Text = "���� ������������:", Location = new System.Drawing.Point(10, 40) };
                    Label lblDateValue = new Label() { Text = tel.InstallationDate.ToShortDateString(), Location = new System.Drawing.Point(150, 40) };

                    Label lblBlocker = new Label() { Text = "�������� ���������:", Location = new System.Drawing.Point(10, 60) };
                    Label lblBlockerValue = new Label() { Text = tel.HasBlocker ? "���" : "ͳ", Location = new System.Drawing.Point(150, 60) };

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
                    groupBox.Text = $"���: {ats.Number}";
                    groupBox.Location = new System.Drawing.Point(10, y);
                    groupBox.Size = new System.Drawing.Size(panelContent.Width - 40, 100);

                    Label lblNumber = new Label() { Text = "�����:", Location = new System.Drawing.Point(10, 20) };
                    Label lblNumberValue = new Label() { Text = ats.Number, Location = new System.Drawing.Point(150, 20) };

                    Label lblDistrict = new Label() { Text = "�����:", Location = new System.Drawing.Point(10, 40) };
                    Label lblDistrictValue = new Label() { Text = ats.District, Location = new System.Drawing.Point(150, 40) };

                    Label lblTotalNumbers = new Label() { Text = "�������� ������� ������:", Location = new System.Drawing.Point(10, 60) };
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
                    groupBox.Text = $"������ ID: {pay.ID}";
                    groupBox.Location = new System.Drawing.Point(10, y);
                    groupBox.Size = new System.Drawing.Size(panelContent.Width - 40, 140);

                    Label lblID = new Label() { Text = "ID:", Location = new System.Drawing.Point(10, 20) };
                    Label lblIDValue = new Label() { Text = pay.ID.ToString(), Location = new System.Drawing.Point(150, 20) };

                    Label lblTelephone = new Label() { Text = "����� ��������:", Location = new System.Drawing.Point(10, 40) };
                    Label lblTelephoneValue = new Label() { Text = pay.TelephoneNumber, Location = new System.Drawing.Point(150, 40) };

                    Label lblATS = new Label() { Text = "����� ���:", Location = new System.Drawing.Point(10, 60) };
                    Label lblATSValue = new Label() { Text = pay.ATSNumber, Location = new System.Drawing.Point(150, 60) };

                    Label lblCost = new Label() { Text = "�������:", Location = new System.Drawing.Point(10, 80) };
                    Label lblCostValue = new Label() { Text = pay.Cost.ToString("C"), Location = new System.Drawing.Point(150, 80) };

                    Label lblIsPaid = new Label() { Text = "��������:", Location = new System.Drawing.Point(10, 100) };
                    Label lblIsPaidValue = new Label() { Text = pay.IsPaid ? "���" : "ͳ", Location = new System.Drawing.Point(150, 100) };

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

        // ����� ��� ��������� ������ ��������
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
                    MessageBox.Show("������� ��������� ��������: " + ex.Message);
                }
            }

            return telephones;
        }

        // ����� ��� ��������� ������ ���
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
                    MessageBox.Show("������� ��������� ���: " + ex.Message);
                }
            }

            return atss;
        }

        // ����� ��� ��������� ������ �����
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
                    MessageBox.Show("������� ��������� �����: " + ex.Message);
                }
            }

            return payments;
        }
    }
}
