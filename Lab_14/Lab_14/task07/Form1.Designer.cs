namespace Task_7
{
    partial class Form1
    {
        /// <summary>
        /// Обов'язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистити всі використовувані ресурси.
        /// </summary>
        /// <param name="disposing">істинне, якщо керовані ресурси слід утилізувати; інакше хибне.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                listViewStatistics.Dispose();
                dataGridView.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, створений конструктором форм Windows

        /// <summary>
        /// Метод, необхідний для підтримки конструктора - не змінюйте
        /// його вміст за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.listViewStatistics = new System.Windows.Forms.ListView();
            this.columnHeaderStatistic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelStatistics = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelStatistics.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTables.TabIndex = 0;
            // 
            // listViewStatistics
            // 
            this.listViewStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStatistic,
            this.columnHeaderValue});
            this.listViewStatistics.GridLines = true;
            this.listViewStatistics.HideSelection = false;
            this.listViewStatistics.Location = new System.Drawing.Point(0, 20);
            this.listViewStatistics.Name = "listViewStatistics";
            this.listViewStatistics.Size = new System.Drawing.Size(400, 150);
            this.listViewStatistics.TabIndex = 1;
            this.listViewStatistics.UseCompatibleStateImageBehavior = false;
            this.listViewStatistics.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStatistic
            // 
            this.columnHeaderStatistic.Text = "Статистика";
            this.columnHeaderStatistic.Width = 250;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Значення";
            this.columnHeaderValue.Width = 130;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(600, 150);
            this.dataGridView.TabIndex = 2;
            // 
            // labelStatistics
            // 
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatistics.Location = new System.Drawing.Point(0, 0);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(101, 20);
            this.labelStatistics.TabIndex = 3;
            this.labelStatistics.Text = "Статистика";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(0, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(60, 20);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Дані";
            // 
            // panelStatistics
            // 
            this.panelStatistics.Controls.Add(this.labelStatistics);
            this.panelStatistics.Controls.Add(this.listViewStatistics);
            this.panelStatistics.Location = new System.Drawing.Point(12, 42);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(400, 170);
            this.panelStatistics.TabIndex = 5;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.labelData);
            this.panelData.Controls.Add(this.dataGridView);
            this.panelData.Location = new System.Drawing.Point(12, 220);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(600, 170);
            this.panelData.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(624, 401);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelStatistics);
            this.Controls.Add(this.comboBoxTables);
            this.Name = "Form1";
            this.Text = "Статистика бази даних";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelStatistics.ResumeLayout(false);
            this.panelStatistics.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.ListView listViewStatistics;
        private System.Windows.Forms.ColumnHeader columnHeaderStatistic;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.Panel panelData;
    }
}
