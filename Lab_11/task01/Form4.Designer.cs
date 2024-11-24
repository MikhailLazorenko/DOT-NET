namespace task01
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem contextMenuItemForm8;
        private Label labelForm4;

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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.contextMenuItemForm8 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelForm4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemForm8});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // contextMenuItemForm8
            // 
            this.contextMenuItemForm8.Name = "contextMenuItemForm8";
            this.contextMenuItemForm8.Size = new System.Drawing.Size(144, 22);
            this.contextMenuItemForm8.Text = "Відкрити Form8";
            this.contextMenuItemForm8.Click += new System.EventHandler(this.contextMenuItemForm8_Click);
            // 
            // labelForm4
            // 
            this.labelForm4.AutoSize = true;
            this.labelForm4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm4.Location = new System.Drawing.Point(50, 40);
            this.labelForm4.Name = "labelForm4";
            this.labelForm4.Size = new System.Drawing.Size(58, 20);
            this.labelForm4.TabIndex = 1;
            this.labelForm4.Text = "Form4";
            // 
            // Form4
            // 
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.labelForm4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
