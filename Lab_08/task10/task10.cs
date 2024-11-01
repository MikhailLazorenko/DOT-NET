using System;
using System.Windows.Forms;

namespace Lab08
{
    public partial class task10 : Form
    {
        public task10()
        {
            InitializeComponent();
        }

        private void ToolStripButton_Click(object? sender, EventArgs e) 
        {
            if (sender == null) return; // Перевірка на null

            // код для обробки натискання кнопки
            ToolStripButton button = sender as ToolStripButton;
            if (button != null)
            {
                button.Text = "Натиснуто!";
            }
        }
    }
}
