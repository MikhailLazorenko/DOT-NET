using System;
using System.Windows.Forms;
using task01;

namespace task01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void contextMenuItemForm8_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }
    }
}
