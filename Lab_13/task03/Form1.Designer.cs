using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace task03
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxUkraine;
        private System.Windows.Forms.PictureBox pictureBoxBulgaria;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBoxUkraine = new PictureBox();
            pictureBoxBulgaria = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUkraine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBulgaria).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxUkraine
            // 
            pictureBoxUkraine.Location = new Point(12, 424);
            pictureBoxUkraine.Margin = new Padding(3, 4, 3, 4);
            pictureBoxUkraine.Name = "pictureBoxUkraine";
            pictureBoxUkraine.Size = new Size(200, 125);
            pictureBoxUkraine.TabIndex = 0;
            pictureBoxUkraine.TabStop = false;
            pictureBoxUkraine.Paint += pictureBoxUkraine_Paint;
            pictureBoxUkraine.MouseDown += pictureBoxUkraine_MouseDown;
            pictureBoxUkraine.MouseUp += pictureBoxUkraine_MouseUp;
            // 
            // pictureBoxBulgaria
            // 
            pictureBoxBulgaria.Location = new Point(12, 271);
            pictureBoxBulgaria.Margin = new Padding(3, 4, 3, 4);
            pictureBoxBulgaria.Name = "pictureBoxBulgaria";
            pictureBoxBulgaria.Size = new Size(200, 125);
            pictureBoxBulgaria.TabIndex = 1;
            pictureBoxBulgaria.TabStop = false;
            pictureBoxBulgaria.Visible = false;
            pictureBoxBulgaria.Paint += pictureBoxBulgaria_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(pictureBoxBulgaria);
            Controls.Add(pictureBoxUkraine);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Прапори України та Болгарії";
            ((System.ComponentModel.ISupportInitialize)pictureBoxUkraine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBulgaria).EndInit();
            ResumeLayout(false);
        }
    }
}
