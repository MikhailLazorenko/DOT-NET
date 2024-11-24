using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace task05
{
    public partial class CityForm : Form
    {
        private string cityName;

        public CityForm(string cityName)
        {
            InitializeComponent();
            this.cityName = cityName;
            LoadCityInfo();
        }

        private void LoadCityInfo()
        {
            labelCityName.Text = cityName;

            // Встановлення опису та зображення міста
            switch (cityName)
            {
                case "Пекін":
                    pictureBoxCity.Image = ByteArrayToImage(Properties.Resources.Beijing);
                    textBoxDescription.Text = "Пекін — столиця Китаю, відомий своїми історичними пам'ятками, такими як Заборонене місто та Велика Китайська стіна.";
                    break;
                case "Шанхай":
                    pictureBoxCity.Image = ByteArrayToImage(Properties.Resources.Shanghai);
                    textBoxDescription.Text = "Шанхай — найбільше місто Китаю, глобальний фінансовий центр з сучасним горизонтом та жвавими торговими районами.";
                    break;
                case "Гуанчжоу":
                    pictureBoxCity.Image = ByteArrayToImage(Properties.Resources.Guangzhou);
                    textBoxDescription.Text = "Гуанчжоу — велике портове місто на півдні Китаю з багатою історією торгівлі та культурними пам'ятками.";
                    break;
                case "Шеньчжень":
                    pictureBoxCity.Image = ByteArrayToImage(Properties.Resources.Shenzhen);
                    textBoxDescription.Text = "Шеньчжень — сучасне місто неподалік від Гонконгу, відоме своїми технологічними компаніями та швидким розвитком.";
                    break;
                case "Сіань":
                    pictureBoxCity.Image = ByteArrayToImage(Properties.Resources.Xian);
                    textBoxDescription.Text = "Сіань — стародавнє місто, відоме своїми історичними пам'ятками, включаючи теракотову армію імператора Цінь Шихуана.";
                    break;
                case "Ченду":
                    pictureBoxCity.Image = ByteArrayToImage(Properties.Resources.Chengdu);
                    textBoxDescription.Text = "Ченду — місто на південному заході Китаю, відоме як батьківщина гігантських панд та своєю смачною кухнею.";
                    break;
                case "Ханчжоу":
                    pictureBoxCity.Image = ByteArrayToImage(Properties.Resources.Hangzhou);
                    textBoxDescription.Text = "Ханчжоу — місто, відоме своїм мальовничим Західним озером та історичними храмами і садами.";
                    break;
                default:
                    pictureBoxCity.Image = null;
                    textBoxDescription.Text = "Інформація про це місто недоступна.";
                    break;
            }
        }

        /// <summary>
        /// Конвертує масив байтів у об'єкт Image.
        /// </summary>
        /// <param name="bytes">Масив байтів, що представляє зображення.</param>
        /// <returns>Об'єкт Image або null, якщо конвертація не вдалася.</returns>
        private Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                try
                {
                    return Image.FromStream(ms);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
