using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Task_3
{
    public partial class Form1 : Form
    {
        // ��������� ���������� �� ���� �����
        static string server = "localhost";
        static string database = "TelephoneNetworkDB";
        static string user = "root";
        static string password = "mnc5UbTRn_nZ+M:"; // ������ �� ��� ������
        static string connStr = $"server={server};user={user};database={database};password={password};";

        // ����� ��� ��������� ��������� ��������� ������ �� �������
        string selectedTable = "Telephone";
        string selectedMode = "Form";

        public Form1()
        {
            // ������������ �������� �� ���������
            Thread.CurrentThread.CurrentCulture = new CultureInfo("uk-UA");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
            InitializeComponent();

            // ������������ ComboBox
            comboBoxTables.Items.AddRange(new string[] { "Telephone", "ATS", "PaymentForServices" });
            comboBoxTables.SelectedIndex = 0; // �������� ����� ������� �� �������������

            // ϳ��������� �� ��䳿
            comboBoxTables.SelectedIndexChanged += ComboBoxTables_SelectedIndexChanged;
            radioButtonFormMode.CheckedChanged += RadioButtonMode_CheckedChanged;
            radioButtonTableMode.CheckedChanged += RadioButtonMode_CheckedChanged;

            // ³��������� ��� �� �������������
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

        // ����� ��� ����������� ����� �������� �� �������� ������
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

        // ����� ��� ����������� ����� � ����� ���������
        private void DisplayDataInFormMode()
        {
            if (selectedTable == "Telephone")
            {
                List<Telephone> telephones = GetTelephones();
                int y = 10;

                foreach (var tel in telephones)
                {
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = $"�������: {tel.Number}";
                    groupBox.Location = new Point(10, y);
                    groupBox.Size = new Size(panelContent.Width - 40, 100);

                    Label lblNumber = new Label() { Text = "�����:", Location = new Point(10, 20) };
                    Label lblNumberValue = new Label() { Text = tel.Number, Location = new Point(150, 20) };

                    Label lblDate = new Label() { Text = "���� ������������:", Location = new Point(10, 40) };
                    Label lblDateValue = new Label() { Text = tel.InstallationDate.ToShortDateString(), Location = new Point(150, 40) };

                    Label lblBlocker = new Label() { Text = "�������� ���������:", Location = new Point(10, 60) };
                    Label lblBlockerValue = new Label() { Text = tel.HasBlocker ? "���" : "ͳ", Location = new Point(150, 60) };

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
                    groupBox.Location = new Point(10, y);
                    groupBox.Size = new Size(panelContent.Width - 40, 100);

                    Label lblNumber = new Label() { Text = "�����:", Location = new Point(10, 20) };
                    Label lblNumberValue = new Label() { Text = ats.Number, Location = new Point(150, 20) };

                    Label lblDistrict = new Label() { Text = "�����:", Location = new Point(10, 40) };
                    Label lblDistrictValue = new Label() { Text = ats.District, Location = new Point(150, 40) };

                    Label lblTotalNumbers = new Label() { Text = "�������� ������� ������:", Location = new Point(10, 60) };
                    Label lblTotalNumbersValue = new Label() { Text = ats.TotalNumbers.ToString(), Location = new Point(150, 60) };

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
                    groupBox.Location = new Point(10, y);
                    groupBox.Size = new Size(panelContent.Width - 40, 140);

                    Label lblID = new Label() { Text = "ID:", Location = new Point(10, 20) };
                    Label lblIDValue = new Label() { Text = pay.ID.ToString(), Location = new Point(150, 20) };

                    Label lblTelephone = new Label() { Text = "����� ��������:", Location = new Point(10, 40) };
                    Label lblTelephoneValue = new Label() { Text = pay.TelephoneNumber, Location = new Point(150, 40) };

                    Label lblATS = new Label() { Text = "����� ���:", Location = new Point(10, 60) };
                    Label lblATSValue = new Label() { Text = pay.ATSNumber, Location = new Point(150, 60) };

                    Label lblCost = new Label() { Text = "�������:", Location = new Point(10, 80) };
                    Label lblCostValue = new Label() { Text = pay.Cost.ToString("C"), Location = new Point(150, 80) };

                    Label lblIsPaid = new Label() { Text = "��������:", Location = new Point(10, 100) };
                    Label lblIsPaidValue = new Label() { Text = pay.IsPaid ? "���" : "ͳ", Location = new Point(150, 100) };

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

        // ����� ��� ����������� ����� � ����� �������
        private void DisplayDataInTableMode()
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (selectedTable == "Telephone")
            {
                List<Telephone> telephones = GetTelephones();
                dataGridView.DataSource = telephones;
            }
            else if (selectedTable == "ATS")
            {
                List<ATS> atss = GetATSs();
                dataGridView.DataSource = atss;
            }
            else if (selectedTable == "PaymentForServices")
            {
                List<PaymentForServices> payments = GetPayments();
                dataGridView.DataSource = payments;
            }

            panelContent.Controls.Add(dataGridView);
        }

        // ����� ��� ��������� ������ ��������
        private List<Telephone> GetTelephones()
        {
            List<Telephone> telephones = new List<Telephone>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
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

            return telephones;
        }

        // ����� ��� ��������� ������ ���
        private List<ATS> GetATSs()
        {
            List<ATS> atss = new List<ATS>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
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

            return atss;
        }

        // ����� ��� ��������� ������ �����
        private List<PaymentForServices> GetPayments()
        {
            List<PaymentForServices> payments = new List<PaymentForServices>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
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

            return payments;
        }
    }
}
