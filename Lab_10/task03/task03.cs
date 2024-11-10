using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Lab10
{
    public partial class task03 : Form
    {
        private string selectedFolderPath;

        public task03()
        {
            InitializeComponent();
        }

        // Метод завантаження зображень із вказаної папки
        private void LoadImages(string folderPath)
        {
            // Очищає список зображень перед завантаженням нових
            lstImages.Items.Clear();
            // Перевіряє, чи існує обрана папка
            if (Directory.Exists(folderPath))
            {
                // Масив підтримуваних форматів зображень
                string[] supportedExtensions = { "*.jpg", "*.png", "*.bmp", "*.gif", "*.tiff" };

                // Перебирає кожен формат файлів, щоб знайти відповідні зображення
                foreach (string extension in supportedExtensions)
                {
                    // Отримує список файлів для кожного формату в обраній папці
                    string[] files = Directory.GetFiles(folderPath, extension);
                    foreach (string file in files)
                    {
                        // Додає назву файлу зображення в список
                        lstImages.Items.Add(Path.GetFileName(file));
                    }
                }

                // Якщо список зображень не порожній, вибирає перше зображення
                if (lstImages.Items.Count > 0)
                {
                    lstImages.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("У папці немає зображень.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Вказана папка не знайдена.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для обробки вибору нового елемента в списку зображень
        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Перевіряє, чи обраний елемент не є порожнім
            if (lstImages.SelectedItem != null)
            {
                // Визначає повний шлях до файлу зображення
                string selectedFile = lstImages.SelectedItem.ToString();
                string filePath = Path.Combine(selectedFolderPath, selectedFile);

                // Перевіряє, чи існує файл
                if (File.Exists(filePath))
                {
                    try
                    {
                        // Завантажує зображення у pictureBox
                        pictureBox.Image = Image.FromFile(filePath);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неможливо відкрити зображення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Файл не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Обробник події натискання кнопки для вибору папки
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            // Відкриває діалогове вікно для вибору папки
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Виберіть папку з зображеннями";

                // Якщо користувач вибрав папку, зберігає шлях та завантажує зображення
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = folderDialog.SelectedPath;
                    LoadImages(selectedFolderPath);
                }
            }
        }
    }
}
