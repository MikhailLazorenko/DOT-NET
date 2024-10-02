using System;
using System.Windows.Forms;

namespace task07
{
    public partial class Form1 : Form
    {
        private Button but1;
        private Button but2;
        private Button but3;
        private Button but4;
        private Button but5;
        private TableLayoutPanel tableLayoutPanel;

        public Form1()
        {
            InitializeComponent();

            // Налаштування TableLayoutPanel з трьома рядками і трьома стовпцями
            tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 3,
                Dock = DockStyle.Fill
            };

            // Встановлення розмірів рядків і стовпців
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));

            // Створення кнопок
            but1 = new Button { Text = "but1" };
            but2 = new Button { Text = "but2" };
            but3 = new Button { Text = "but3" };
            but4 = new Button { Text = "but4" };
            but5 = new Button { Text = "but5" };

            // Додавання кнопок до TableLayoutPanel
            tableLayoutPanel.Controls.Add(but1, 1, 0); // Верхній ряд, середній стовпець
            tableLayoutPanel.Controls.Add(but4, 2, 0); // Верхній ряд, правий стовпець
            tableLayoutPanel.Controls.Add(but2, 2, 1); // Середній ряд, правий стовпець
            tableLayoutPanel.Controls.Add(but5, 0, 1); // Середній ряд, лівий стовпець
            tableLayoutPanel.Controls.Add(but3, 0, 2); // Нижній ряд, лівий стовпець

            // Додавання TableLayoutPanel до форми
            this.Controls.Add(tableLayoutPanel);
        }
    }
}
