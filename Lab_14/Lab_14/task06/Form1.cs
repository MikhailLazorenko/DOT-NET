using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Task_6;

namespace Task_6
{
    public partial class Form1 : Form
    {
        // ��������� ���������� �� ���� �����
        private string connStr = "server=localhost;user=root;database=TelephoneNetworkDB;password=mnc5UbTRn_nZ+M:;"; // ������ 'your_password' �� ��� ������

        // ����� ��� ��������� ������� �������
        private string selectedTable = "Telephone";

        // DataTable ��� ��������� �����
        private DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();

            // ����������� ComboBox
            comboBoxTables.Items.AddRange(new string[] { "Telephone", "ATS", "PaymentForServices" });
            comboBoxTables.SelectedIndex = 0;

            // ϳ������ �� ��䳿
            comboBoxTables.SelectedIndexChanged += ComboBoxTables_SelectedIndexChanged;

            // ������������ DataGridView
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            // ������ DataGridView �� �����
            panelContent.Controls.Add(dataGridView);

            // ϳ��������� �� ��䳿 DataGridView
            dataGridView.CellDoubleClick += DataGridView_CellDoubleClick;

            // ³��������� ���
            LoadData();
        }

        private void ComboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTable = comboBoxTables.SelectedItem.ToString();
            LoadData();
        }

        // ����� ��� ������������ �����
        private void LoadData()
        {
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
        }

        // ������ "�����������"
        private void buttonView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // ������ "������"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(selectedTable, connStr, null);
            editForm.FormClosed += EditForm_FormClosed;
            editForm.ShowDialog();
        }

        // ������ "����������"
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
                EditForm editForm = new EditForm(selectedTable, connStr, row);
                editForm.FormClosed += EditForm_FormClosed;
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("���� �����, ������� ����� ��� �����������.");
            }
        }

        // ������ "��������"
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;

                DialogResult result = MessageBox.Show("�� ����� ������ �������� ��� �����?", "ϳ����������� ���������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        try
                        {
                            conn.Open();
                            string query = "";

                            if (selectedTable == "Telephone")
                            {
                                query = "DELETE FROM Telephone WHERE Number=@Number";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@Number", row["Number"]);
                                cmd.ExecuteNonQuery();
                            }
                            else if (selectedTable == "ATS")
                            {
                                query = "DELETE FROM ATS WHERE Number=@Number";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@Number", row["Number"]);
                                cmd.ExecuteNonQuery();
                            }
                            else if (selectedTable == "PaymentForServices")
                            {
                                query = "DELETE FROM PaymentForServices WHERE ID=@ID";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@ID", row["ID"]);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("����� ������ ��������.");
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("������� ��������� ������: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("���� �����, ������� ����� ��� ���������.");
            }
        }

        // �������� ��䳿 ��������� ���� �� �����
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow row = ((DataRowView)dataGridView.Rows[e.RowIndex].DataBoundItem).Row;
                EditForm editForm = new EditForm(selectedTable, connStr, row);
                editForm.FormClosed += EditForm_FormClosed;
                editForm.ShowDialog();
            }
        }

        // ��������� ��� ���� �������� ����� �����������
        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }
    }
}
