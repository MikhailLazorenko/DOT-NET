namespace task04_4
{
    partial class ResultsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Label labelResult;
        private Button buttonOK;

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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(70, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(61, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Результат:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(30, 60);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(70, 100);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 30);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.DialogResult = DialogResult.OK;
            // 
            // ResultsForm
            // 
            this.ClientSize = new System.Drawing.Size(230, 150);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTitle);
            this.Name = "ResultsForm";
            this.Text = "Результати";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
