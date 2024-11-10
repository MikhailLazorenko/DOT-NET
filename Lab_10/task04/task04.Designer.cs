namespace Lab10
{
    partial class task04
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListView listViewPayments;

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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.listViewPayments = new System.Windows.Forms.ListView();

            // Form1 settings
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.listViewPayments);
            this.Text = "Фінансовий калькулятор";

            // lblAmount
            this.lblAmount.Location = new System.Drawing.Point(20, 20);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 23);
            this.lblAmount.Text = "Сума:";

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(150, 20);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 23);

            // lblTerm
            this.lblTerm.Location = new System.Drawing.Point(20, 60);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(100, 23);
            this.lblTerm.Text = "Термін (міс):";

            // txtTerm
            this.txtTerm.Location = new System.Drawing.Point(150, 60);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(200, 23);

            // lblInterestRate
            this.lblInterestRate.Location = new System.Drawing.Point(20, 100);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(100, 23);
            this.lblInterestRate.Text = "Відсоткова ставка:";

            // txtInterestRate
            this.txtInterestRate.Location = new System.Drawing.Point(150, 100);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(200, 23);

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(150, 140);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 30);
            this.btnCalculate.Text = "OK";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // listViewPayments
            this.listViewPayments.Location = new System.Drawing.Point(20, 180);
            this.listViewPayments.Name = "listViewPayments";
            this.listViewPayments.Size = new System.Drawing.Size(360, 200);
            this.listViewPayments.View = System.Windows.Forms.View.Details;
            this.listViewPayments.Columns.Add("Місяць", 50);
            this.listViewPayments.Columns.Add("Борг", 100);
            this.listViewPayments.Columns.Add("Відсоток", 100);
            this.listViewPayments.Columns.Add("Платіж", 100);
        }
    }
}
