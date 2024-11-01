using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab08
{
    public partial class task07 : Form
    {
        public  task07()
        {
            InitializeComponent();
        }

        // Метод без параметрів
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
            colorMenu.DropDownItems.Add("Red").Click += (s, _) => ChangeLabelColor(Color.Red);
            colorMenu.DropDownItems.Add("Green").Click += (s, _) => ChangeLabelColor(Color.Green);
            colorMenu.DropDownItems.Add("Blue").Click += (s, _) => ChangeLabelColor(Color.Blue);
            colorMenu.DropDownItems.Add("Black").Click += (s, _) => ChangeLabelColor(Color.Black);

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

        private void ChangeLabelColor(Color color)
        {
            // Зміна кольору тексту всіх міток
            label1.ForeColor = color;
            label2.ForeColor = color;
            label3.ForeColor = color;
        }
    }
}
