using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using task08;

namespace task08
{
    public partial class Form1 : Form
    {
        private string currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            UpdateCursorPosition();
        }

        // ��������� ����������� ������� �������
        private void richTextBoxEditor_SelectionChanged(object sender, EventArgs e)
        {
            UpdateCursorPosition();
        }

        private void UpdateCursorPosition()
        {
            int line = richTextBoxEditor.GetLineFromCharIndex(richTextBoxEditor.SelectionStart) + 1;
            int column = richTextBoxEditor.SelectionStart - richTextBoxEditor.GetFirstCharIndexOfCurrentLine() + 1;
            toolStripStatusLabel.Text = $"�����: {line}, ��������: {column}";
        }

        // ��������� ������ �����
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmSaveChanges())
            {
                richTextBoxEditor.Clear();
                currentFilePath = string.Empty;
                this.Text = "����� ���� - ��������� ��������";
            }
        }

        // ³������� �����
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmSaveChanges())
            {
                OpenFile();
            }
        }

        private void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "������� ����� (*.txt)|*.txt|�� ����� (*.*)|*.*";
                openFileDialog.Title = "������� ����";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        richTextBoxEditor.Text = File.ReadAllText(openFileDialog.FileName);
                        currentFilePath = openFileDialog.FileName;
                        this.Text = Path.GetFileName(currentFilePath) + " - ��������� ��������";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("������� ��� ������� �����: " + ex.Message, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ���������� �����
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileAs();
            }
            else
            {
                try
                {
                    File.WriteAllText(currentFilePath, richTextBoxEditor.Text);
                    MessageBox.Show("���� ������ ���������.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������� ��� ��������� �����: " + ex.Message, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ���������� ����� ��...
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void SaveFileAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "������� ����� (*.txt)|*.txt|�� ����� (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBoxEditor.Text);
                        currentFilePath = saveFileDialog.FileName;
                        this.Text = Path.GetFileName(currentFilePath) + " - ��������� ��������";
                        MessageBox.Show("���� ������ ���������.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("������� ��� ��������� �����: " + ex.Message, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ����� � ��������
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmSaveChanges())
            {
                Application.Exit();
            }
        }

        // ³���������� ���� "��� ��������"
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        // ����� ����� � �����
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindWord();
        }

        private void FindWord()
        {
            string word = Prompt.ShowDialog("������ ����� ��� ������:", "����� �����");
            if (!string.IsNullOrEmpty(word))
            {
                // �������� ������������ ��������
                richTextBoxEditor.SelectAll();
                richTextBoxEditor.SelectionBackColor = Color.White;
                richTextBoxEditor.DeselectAll();

                int startIndex = 0;
                int foundIndex = -1;
                bool found = false;

                while ((foundIndex = richTextBoxEditor.Text.IndexOf(word, startIndex, StringComparison.CurrentCultureIgnoreCase)) != -1)
                {
                    richTextBoxEditor.Select(foundIndex, word.Length);
                    richTextBoxEditor.SelectionBackColor = Color.Yellow;
                    startIndex = foundIndex + word.Length;
                    found = true;
                }

                if (!found)
                {
                    MessageBox.Show($"����� \"{word}\" �� ��������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ����� ��� ������������ ���������� ���
        private bool ConfirmSaveChanges()
        {
            if (richTextBoxEditor.Modified)
            {
                DialogResult result = MessageBox.Show("������ �������� ����?", "����������", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                    return true;
                }
                else if (result == DialogResult.No)
                {
                    return true;
                }
                else // Cancel
                {
                    return false;
                }
            }
            return true;
        }

        // ����� Dispose ��� ��������� �������
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // ����� ����� � ��������
        [STAThread]
        public static void form()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }

    // ��������� ���� ��� �������� �����
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 340 };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
            Button confirmation = new Button() { Text = "��", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
        }
    }
}
