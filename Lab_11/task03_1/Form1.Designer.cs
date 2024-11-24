namespace task03_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Label labelA;
        private Label labelB;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Button buttonCalculate;
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
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
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(30, 60);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(100, 13);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "Велика піввісь (a):";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(30, 90);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(96, 13);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "Мала піввісь (b):";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(140, 57);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(140, 87);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(100, 120);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(90, 30);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Обчислити";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(30, 170);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(52, 13);
            this.labelArea.TabIndex = 6;
            this.labelArea.Text = "Площа:";
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(30, 200);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(101, 13);
            this.labelPerimeter.TabIndex = 7;
            this.labelPerimeter.Text = "Довжина еліпса:";
            // 
            // labelAreaResult
            // 
            this.labelAreaResult.AutoSize = true;
            this.labelAreaResult.Location = new System.Drawing.Point(140, 170);
            this.labelAreaResult.Name = "labelAreaResult";
            this.labelAreaResult.Size = new System.Drawing.Size(0, 13);
            this.labelAreaResult.TabIndex = 8;
            // 
            // labelPerimeterResult
            // 
            this.labelPerimeterResult.AutoSize = true;
            this.labelPerimeterResult.Location = new System.Drawing.Point(140, 200);
            this.labelPerimeterResult.Name = "labelPerimeterResult";
            this.labelPerimeterResult.Size = new System.Drawing.Size(0, 13);
            this.labelPerimeterResult.TabIndex = 9;
            // 
            // Version1Form
            // 
            this.ClientSize = new System.Drawing.Size(300, 240);
            this.Controls.Add(this.labelPerimeterResult);
            this.Controls.Add(this.labelAreaResult);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelTitle);
            this.Name = "Version1Form";
            this.Text = "Варіант 1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
