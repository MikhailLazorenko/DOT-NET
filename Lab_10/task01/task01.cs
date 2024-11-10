using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab10
{
    public partial class task01 : Form
    {
        private List<string> imageFiles;
        private int currentIndex = 0;

        public task01()
        {
            InitializeComponent();
            imageFiles = new List<string>();

            // Прив'язуємо обробники подій за допомогою анонімних методів
            button1.Click += (s, e) => SelectFolder();
            button2.Click += (s, e) => ShowNextImage();
            button3.Click += (s, e) => ShowPreviousImage();
        }

        private void SelectFolder()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = dialog.SelectedPath;

                    // Підтримка різних форматів зображень
                    string[] supportedExtensions = { "*.jpg", "*.jpeg", "*.png", "*.bmp", "*.gif", "*.tiff" };
                    imageFiles = supportedExtensions
                        .SelectMany(ext => Directory.GetFiles(folderPath, ext))
                        .ToList();

                    currentIndex = 0;
                    ShowImage();
                }
            }
        }

        private void ShowNextImage()
        {
            if (imageFiles.Count > 0)
            {
                currentIndex = (currentIndex + 1) % imageFiles.Count;
                ShowImage();
            }
        }

        private void ShowPreviousImage()
        {
            if (imageFiles.Count > 0)
            {
                currentIndex = (currentIndex - 1 + imageFiles.Count) % imageFiles.Count;
                ShowImage();
            }
        }

        private void ShowImage()
        {
            if (imageFiles.Count > 0 && currentIndex >= 0 && currentIndex < imageFiles.Count)
            {
                pictureBox1.ImageLocation = imageFiles[currentIndex];
            }
        }
    }
}
