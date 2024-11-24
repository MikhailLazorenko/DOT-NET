using Lab12;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab12
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // �������� ��������� ���������� ��� �������
            lblErrorUsername.Text = "";
            lblErrorPassword.Text = "";
            lblErrorConfirmPassword.Text = "";
            lblErrorEmail.Text = "";

            // ��������� �������
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            // ����� ��������
            bool isValid = true; // ��������� ��������� ��� ��������

            // �������� Username
            if (!ValidateUsername(username))
            {
                lblErrorUsername.Text = "���������� ��'� �����������! (���� 15 �������, ���� ����� �� �����)";
                isValid = false;
            }

            // �������� �� ���������� ��� ����
            if (UserExists(username))
            {
                lblErrorUsername.Text = "���������� � ����� ��'�� ��� ����!";
                isValid = false;
            }

            // �������� Password
            if (!ValidatePassword(password))
            {
                lblErrorPassword.Text = "������ �� ���� 12+ �������, � �������, ������� �� �������������.";
                isValid = false;
            }

            // �������� ���� ������
            if (password != confirmPassword)
            {
                lblErrorConfirmPassword.Text = "����� �� ����������!";
                isValid = false;
            }

            // �������� Email
            if (!ValidateEmail(email))
            {
                lblErrorEmail.Text = "����������� ������ Email!";
                isValid = false;
            }

            // ���� ������� ����, ���������� ������ ���������
            if (isValid)
            {
                // �������� �����������
                SaveUser(username, password, email);

                MessageBox.Show("��������� ������!", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ������� �� ����� �����������
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private bool ValidateUsername(string username)
        {
            // ��������: ���� �������� �� �����, ������� �� 15 �������
            return Regex.IsMatch(username, @"^[a-zA-Z0-9]{1,15}$");
        }

        private bool ValidatePassword(string password)
        {
            // ��������: ������� �� ����� 12, ������ �����, �����, ��������� �������
            return Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*]).{12,}$");
        }

        private bool ValidateEmail(string email)
        {
            // ������� ���������� ����� ��� �������� email
            return Regex.IsMatch(email, @"^\S+@\S+\.\S+$");
        }

        private bool UserExists(string username)
        {
            string usersFile = "users.txt";
            if (File.Exists(usersFile))
            {
                var lines = File.ReadAllLines(usersFile);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data.Length >= 1)
                    {
                        string storedUsername = data[0];
                        if (storedUsername == username)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void SaveUser(string username, string password, string email)
        {
            // �������� ����������� � users.txt
            string usersFile = "users.txt";
            string userLine = $"{username};{password};{email}";
            File.AppendAllLines(usersFile, new string[] { userLine });
        }
    }
}
