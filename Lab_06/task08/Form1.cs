using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace task08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ������������ ����
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // ��������� ������ 1 ����
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item1");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Item2");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Item3");
            ToolStripMenuItem item4 = new ToolStripMenuItem("Item4");
            ToolStripMenuItem item5 = new ToolStripMenuItem("Item5");
            ToolStripMenuItem item6 = new ToolStripMenuItem("Item6");

            // ��������� ������ 2 ���� ��� Item2
            item2.DropDownItems.Add(new ToolStripMenuItem("Item21"));
            item2.DropDownItems.Add(new ToolStripMenuItem("Item22"));
            item2.DropDownItems.Add(new ToolStripMenuItem("Item23"));

            // ��������� ������ 2 ���� ��� Item3
            item3.DropDownItems.Add(new ToolStripMenuItem("Item31"));
            item3.DropDownItems.Add(new ToolStripMenuItem("Item32"));
            item3.DropDownItems.Add(new ToolStripMenuItem("Item33"));
            item3.DropDownItems.Add(new ToolStripMenuItem("Item34"));

            // ��������� ������ 2 ���� ��� Item4
            item4.DropDownItems.Add(new ToolStripMenuItem("Item41"));
            item4.DropDownItems.Add(new ToolStripMenuItem("Item42"));
            item4.DropDownItems.Add(new ToolStripMenuItem("Item43"));
            item4.DropDownItems.Add(new ToolStripMenuItem("Item44"));
            item4.DropDownItems.Add(new ToolStripMenuItem("Item45"));

            // ��������� ������ 2 ���� ��� Item5
            item5.DropDownItems.Add(new ToolStripMenuItem("Item51"));
            item5.DropDownItems.Add(new ToolStripMenuItem("Item52"));
            item5.DropDownItems.Add(new ToolStripMenuItem("Item53"));
            item5.DropDownItems.Add(new ToolStripMenuItem("Item54"));
            item5.DropDownItems.Add(new ToolStripMenuItem("Item55"));
            item5.DropDownItems.Add(new ToolStripMenuItem("Item56"));  // ������ ������ �������

            // ��������� ������ 1 ���� �� ������������ ����
            contextMenu.Items.Add(item1);
            contextMenu.Items.Add(item2);
            contextMenu.Items.Add(item3);
            contextMenu.Items.Add(item4);
            contextMenu.Items.Add(item5);
            contextMenu.Items.Add(item6);

            // ����'���� ������������ ���� �� Label
            label1.ContextMenuStrip = contextMenu;
            label2.ContextMenuStrip = contextMenu;
            label3.ContextMenuStrip = contextMenu;
        }
    }
}