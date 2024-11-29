using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace task06
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonUpdate;

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
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(688, 13);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(100, 38);
            buttonUpdate.TabIndex = 0;
            buttonUpdate.Text = "Оновити";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(buttonUpdate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Графік";
            Paint += Form1_Paint;
            ResumeLayout(false);
        }
    }
}
