using System;
using System.Windows.Forms;

namespace Lab08
{
    public partial class task05 : Form
    {
        public task05()
        {
            InitializeComponent();
            Form1_Load(); // Виклик методу завантаження форми без EventHandler
        }

        private void Form1_Load()
        {
            // Розділи 1 рівня
            ToolStripMenuItem[] level1Items = new ToolStripMenuItem[6];
            for (int i = 0; i < level1Items.Length; i++)
            {
                level1Items[i] = new ToolStripMenuItem("Item" + (i + 1));
            }

            // Розділи 2 рівня для кожного розділу 1 рівня
            string[][] level2Items = new string[][]
            {
                new string[] {"Item11", "Item12", "Item13"},
                new string[] {"Item21", "Item22", "Item23"},
                new string[] {"Item31", "Item32", "Item33", "Item34"},
                new string[] {"Item41", "Item42", "Item43", "Item44", "Item45"},
                new string[] {"Item51", "Item52", "Item53"},
                new string[] {"Item61", "Item62", "Item63", "Item64"}
            };

            // Додавання підрозділів 2 рівня
            for (int i = 0; i < level1Items.Length; i++)
            {
                foreach (string level2 in level2Items[i])
                {
                    ToolStripMenuItem level2Item = new ToolStripMenuItem(level2);
                    AssignClickHandler(level2Item);
                    level1Items[i].DropDownItems.Add(level2Item);
                }
            }

            // Розділи 3 рівня
            string[][] level3Items = new string[][]
            {
                new string[] {"Item221", "Item222", "Item223"},
                new string[] {"Item231", "Item232", "Item233", "Item234"},
                new string[] {"Item441", "Item442", "Item443", "Item444", "Item445"},
                new string[] {"Item451", "Item452", "Item453", "Item454", "Item455", "Item456"}
            };

            // Додавання підрозділів 3 рівня
            ToolStripMenuItem[] level2ForLevel3 = {
                level1Items[1].DropDownItems[1] as ToolStripMenuItem, // Item22
                level1Items[1].DropDownItems[2] as ToolStripMenuItem, // Item23
                level1Items[3].DropDownItems[3] as ToolStripMenuItem, // Item44
                level1Items[3].DropDownItems[4] as ToolStripMenuItem  // Item45
            };

            for (int i = 0; i < level3Items.Length; i++)
            {
                foreach (string level3 in level3Items[i])
                {
                    ToolStripMenuItem level3Item = new ToolStripMenuItem(level3);
                    AssignClickHandler(level3Item);
                    level2ForLevel3[i].DropDownItems.Add(level3Item);
                }
            }

            // Додавання розділів 1 рівня до меню
            menuStrip1.Items.AddRange(level1Items);
        }

        private void AssignClickHandler(ToolStripMenuItem menuItem)
        {
            string menuItemName = menuItem.Text;
            menuItem.Click += (s, e) => ShowMessageBox(menuItemName);
        }

        private void ShowMessageBox(string itemName)
        {
            MessageBox.Show("Ви вибрали: " + itemName);
        }
    }
}
