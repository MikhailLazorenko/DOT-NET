using System;
using System.Windows.Forms;

namespace task13
{
    public partial class Form1 : Form
    {
        private ListBox listBox; // Компонент, який буде додаватися та видалятися

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Дозволяє формі обробляти клавіші до обробки контролами
        }

        // Обробка події натискання клавіш
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Додавання ListBox при натисканні Alt + A
            if (e.Alt && e.KeyCode == Keys.A)
            {
                AddListBox();
                e.Handled = true; // Позначити, що клавіша була оброблена
            }
            // Видалення ListBox при натисканні Alt + Shift + D
            else if (e.Alt && e.Shift && e.KeyCode == Keys.D)
            {
                RemoveListBox();
                e.Handled = true; // Позначити, що клавіша була оброблена
            }
        }

        // Функція для додавання ListBox
        private void AddListBox()
        {
            if (listBox == null)
            {
                listBox = new ListBox();
                listBox.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
                listBox.Location = new System.Drawing.Point(20, 20);
                listBox.Size = new System.Drawing.Size(200, 100);
                this.Controls.Add(listBox);
                MessageBox.Show("ListBox додано на форму!", "Інформація");
            }
            else
            {
                MessageBox.Show("ListBox вже додано!", "Попередження");
            }
        }

        // Функція для видалення ListBox
        private void RemoveListBox()
        {
            if (listBox != null)
            {
                this.Controls.Remove(listBox);
                listBox = null;
                MessageBox.Show("ListBox видалено з форми!", "Інформація");
            }
            else
            {
                MessageBox.Show("ListBox не додано на форму!", "Попередження");
            }
        }
    }
}
