using System;
using System.Windows.Forms;

namespace task07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ������ 1 ����
            ToolStripMenuItem[] level1Items = new ToolStripMenuItem[6];
            for (int i = 0; i < level1Items.Length; i++)
            {
                level1Items[i] = new ToolStripMenuItem("Item" + (i + 1));
            }

            // ������ 2 ���� ��� ������� ������ 1 ����
            string[][] level2Items = new string[][]
            {
                new string[] {"Item11", "Item12", "Item13"},                 // 3 ������
                new string[] {"Item21", "Item22", "Item23"},                 // 3 ������
                new string[] {"Item31", "Item32", "Item33", "Item34"},       // 4 ������
                new string[] {"Item41", "Item42", "Item43", "Item44", "Item45"}, // 5 ������
                new string[] {"Item51", "Item52", "Item53"},                 // 3 ������
                new string[] {"Item61", "Item62", "Item63", "Item64"}        // 4 ������
            };

            // ��������� �������� 2 ����
            for (int i = 0; i < level1Items.Length; i++)
            {
                foreach (string level2 in level2Items[i])
                {
                    ToolStripMenuItem level2Item = new ToolStripMenuItem(level2);
                    level1Items[i].DropDownItems.Add(level2Item);
                }
            }

            // ������ 3 ���� ��� ��������� ������ 2 ����
            string[][] level3Items = new string[][]
            {
                new string[] {"Item221", "Item222", "Item223"},                 // 3 ������ ��� Item22
                new string[] {"Item231", "Item232", "Item233", "Item234"},      // 4 ������ ��� Item23
                new string[] {"Item441", "Item442", "Item443", "Item444", "Item445"}, // 5 ������ ��� Item44
                new string[] {"Item451", "Item452", "Item453", "Item454", "Item455", "Item456"} // 6 ������ ��� Item45
            };

            // ��������� �������� 3 ����
            ToolStripMenuItem[] level2ForLevel3 = {
                level1Items[1].DropDownItems[1] as ToolStripMenuItem,  // Item22
                level1Items[1].DropDownItems[2] as ToolStripMenuItem,  // Item23
                level1Items[3].DropDownItems[3] as ToolStripMenuItem,  // Item44
                level1Items[3].DropDownItems[4] as ToolStripMenuItem   // Item45
            };

            for (int i = 0; i < level3Items.Length; i++)
            {
                foreach (string level3 in level3Items[i])
                {
                    ToolStripMenuItem level3Item = new ToolStripMenuItem(level3);
                    level2ForLevel3[i].DropDownItems.Add(level3Item);
                }
            }

            // ��������� ������ 1 ���� �� ����
            menuStrip1.Items.AddRange(level1Items);
        }
    }
}