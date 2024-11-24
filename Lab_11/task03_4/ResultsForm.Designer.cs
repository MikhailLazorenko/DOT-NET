namespace task03_4
{
    partial class ResultsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Label labelArea;
        private Label labelPerimeter;
        private Label labelAreaResult;
        private Label labelPerimeterResult;
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
            this.labelArea = new System.Windows.Forms.Label();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.labelAreaResult = new System.Windows.Forms.Label();
            this.labelPerimeterResult = new System.Windows.Forms.Label();
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
            this.labelTitle.Text = "Результати:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(30, 60);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(52, 13);
            this.labelArea.TabIndex = 1;
            this.labelArea.Text = "Площа:";
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(30, 90);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(101, 13);
            this.labelPerimeter.TabIndex = 2;
            this.labelPerimeter.Text = "Довжина еліпса:";
            // 
            // labelAreaResult
            // 
            this.labelAreaResult.AutoSize = true;
            this.labelAreaResult.Location = new System.Drawing.Point(140, 60);
            this.labelAreaResult.Name = "labelAreaResult";
            this.labelAreaResult.Size = new System.Drawing.Size(0, 13);
            this.labelAreaResult.TabIndex = 3;
            // 
            // labelPerimeterResult
            // 
            this.labelPerimeterResult.AutoSize = true;
            this.labelPerimeterResult.Location = new System.Drawing.Point(140, 90);
            this.labelPerimeterResult.Name = "labelPerimeterResult";
            this.labelPerimeterResult.Size = new System.Drawing.Size(0, 13);
            this.labelPerimeterResult.TabIndex = 4;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(70, 130);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 30);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.DialogResult = DialogResult.OK;
            // 
            // ResultsForm
            // 
            this.ClientSize = new System.Drawing.Size(220, 180);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelPerimeterResult);
            this.Controls.Add(this.labelAreaResult);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelTitle);
            this.Name = "ResultsForm";
            this.Text = "Результати";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
