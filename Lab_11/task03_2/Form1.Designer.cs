namespace task03_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Button buttonInput;
        private Label labelArea;
        private Label labelPerimeter;
        private Label labelAreaResult;
        private Label labelPerimeterResult;

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
            this.buttonInput = new System.Windows.Forms.Button();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.labelAreaResult = new System.Windows.Forms.Label();
            this.labelPerimeterResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(70, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(170, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Обчислення еліпса";
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(100, 60);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(90, 30);
            this.buttonInput.TabIndex = 1;
            this.buttonInput.Text = "Ввести дані";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(30, 110);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(52, 13);
            this.labelArea.TabIndex = 2;
            this.labelArea.Text = "Площа:";
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(30, 140);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(101, 13);
            this.labelPerimeter.TabIndex = 3;
            this.labelPerimeter.Text = "Довжина еліпса:";
            // 
            // labelAreaResult
            // 
            this.labelAreaResult.AutoSize = true;
            this.labelAreaResult.Location = new System.Drawing.Point(140, 110);
            this.labelAreaResult.Name = "labelAreaResult";
            this.labelAreaResult.Size = new System.Drawing.Size(0, 13);
            this.labelAreaResult.TabIndex = 4;
            // 
            // labelPerimeterResult
            // 
            this.labelPerimeterResult.AutoSize = true;
            this.labelPerimeterResult.Location = new System.Drawing.Point(140, 140);
            this.labelPerimeterResult.Name = "labelPerimeterResult";
            this.labelPerimeterResult.Size = new System.Drawing.Size(0, 13);
            this.labelPerimeterResult.TabIndex = 5;
            // 
            // Version2Form
            // 
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.labelPerimeterResult);
            this.Controls.Add(this.labelAreaResult);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.labelTitle);
            this.Name = "Version2Form";
            this.Text = "Варіант 2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
