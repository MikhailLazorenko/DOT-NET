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

        // Оновлення відображення позиції курсора
        private void richTextBoxEditor_SelectionChanged(object sender, EventArgs e)
        {
            UpdateCursorPosition();
        }

        private void UpdateCursorPosition()
        {
            int line = richTextBoxEditor.GetLineFromCharIndex(richTextBoxEditor.SelectionStart) + 1;
            int column = richTextBoxEditor.SelectionStart - richTextBoxEditor.GetFirstCharIndexOfCurrentLine() + 1;
            toolStripStatusLabel.Text = $"Рядок: {line}, Стовпчик: {column}";
        }

        // Створення нового файлу
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmSaveChanges())
            {
                richTextBoxEditor.Clear();
                currentFilePath = string.Empty;
                this.Text = "Новий файл - Текстовий редактор";
            }
        }

        // Відкриття файлу
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
                openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
                openFileDialog.Title = "Виберіть файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        richTextBoxEditor.Text = File.ReadAllText(openFileDialog.FileName);
                        currentFilePath = openFileDialog.FileName;
                        this.Text = Path.GetFileName(currentFilePath) + " - Текстовий редактор";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при відкритті файлу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Збереження файлу
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
                    MessageBox.Show("Файл успішно збережено.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні файлу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Збереження файлу як...
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void SaveFileAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBoxEditor.Text);
                        currentFilePath = saveFileDialog.FileName;
                        this.Text = Path.GetFileName(currentFilePath) + " - Текстовий редактор";
                        MessageBox.Show("Файл успішно збережено.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при збереженні файлу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Вихід з програми
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmSaveChanges())
            {
                Application.Exit();
            }
        }

        // Відображення вікна "Про програму"
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        // Пошук слова в тексті
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindWord();
        }

        private void FindWord()
        {
            string word = Prompt.ShowDialog("Введіть слово для пошуку:", "Пошук слова");
            if (!string.IsNullOrEmpty(word))
            {
                // Скидання попереднього виділення
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
                    MessageBox.Show($"Слово \"{word}\" не знайдено.", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Метод для підтвердження збереження змін
        private bool ConfirmSaveChanges()
        {
            if (richTextBoxEditor.Modified)
            {
                DialogResult result = MessageBox.Show("Бажаєте зберегти зміни?", "Збереження", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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

        // Метод Dispose для звільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Точка входу в програму
        [STAThread]
        public static void form()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }

    // Допоміжний клас для введення слова
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
            Button confirmation = new Button() { Text = "ОК", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
        }
    }
}
