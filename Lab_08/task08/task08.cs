using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab08
{
    public partial class task08 : Form
    {
        public task08()
        {
            InitializeComponent();
        }

        private void Form1_Load()
        {
            // Створення контекстного меню
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Створення розділів 1 рівня
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item1");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Item2");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Item3");
            ToolStripMenuItem item4 = new ToolStripMenuItem("Item4");
            ToolStripMenuItem item5 = new ToolStripMenuItem("Item5");
            ToolStripMenuItem item6 = new ToolStripMenuItem("Item6");

            // Додавання підменю зміни кольору
            ToolStripMenuItem colorMenu = new ToolStripMenuItem("Change Color");
            colorMenu.DropDownItems.Add("Red").Click += MenuItem_Click;
            colorMenu.DropDownItems.Add("Green").Click += MenuItem_Click;
            colorMenu.DropDownItems.Add("Blue").Click += MenuItem_Click;
            colorMenu.DropDownItems.Add("Black").Click += MenuItem_Click;

            // Додавання пункту зміни кольору до кожного розділу 1 рівня
            item1.DropDownItems.Add(colorMenu);
            item2.DropDownItems.Add(colorMenu);
            item3.DropDownItems.Add(colorMenu);
            item4.DropDownItems.Add(colorMenu);
            item5.DropDownItems.Add(colorMenu);
            item6.DropDownItems.Add(colorMenu);

            // Додавання розділів 1 рівня до контекстного меню
            contextMenu.Items.Add(item1);
            contextMenu.Items.Add(item2);
            contextMenu.Items.Add(item3);
            contextMenu.Items.Add(item4);
            contextMenu.Items.Add(item5);
            contextMenu.Items.Add(item6);

            // Прив'язка контекстного меню до Label
            label1.ContextMenuStrip = contextMenu;
            label2.ContextMenuStrip = contextMenu;
            label3.ContextMenuStrip = contextMenu;
        }

        // Єдиний обробник подій для підменю
        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                // Визначення кольору на основі тексту пункту меню
                Color color = Color.Black; // Значення за замовчуванням

                switch (menuItem.Text)
                {
                    case "Red":
                        color = Color.Red;
                        break;
                    case "Green":
                        color = Color.Green;
                        break;
                    case "Blue":
                        color = Color.Blue;
                        break;
                    case "Black":
                        color = Color.Black;
                        break;
                }

                ChangeLabelColor(color);
            }
        }

        private void ChangeLabelColor(Color color)
        {
            // Зміна кольору тексту всіх міток
            label1.ForeColor = color;
            label2.ForeColor = color;
            label3.ForeColor = color;
        }
    }
}
