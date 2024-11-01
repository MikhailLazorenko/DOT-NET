using System;
using System.Windows.Forms;

namespace Lab08
{
    // Частковий клас для основної форми
    public partial class task09 : Form
    {
        // Конструктор форми
        public task09()
        {
            InitializeComponent(); // Ініціалізація компонентів

            // Прив'язка обробників подій до кнопок панелі інструментів
            toolStripButton1.Click += (s, e) => ShowToolTip("Tool1");
            toolStripButton2.Click += (s, e) => ShowToolTip("Tool2");
            toolStripButton3.Click += (s, e) => ShowToolTip("Tool3");
            toolStripButton4.Click += (s, e) => ShowToolTip("Tool4");
            toolStripButton5.Click += (s, e) => ShowToolTip("Tool5");
            toolStripButton6.Click += (s, e) => ShowToolTip("Tool6");
        }

        // Метод для показу підказки
        private void ShowToolTip(string toolTip)
        {
            MessageBox.Show($"{toolTip} натиснута!");
        }
    }
}
