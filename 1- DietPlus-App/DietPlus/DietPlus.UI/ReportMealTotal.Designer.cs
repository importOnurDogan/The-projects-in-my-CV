namespace DietPlus.UI
{
    partial class ReportMealTotal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMealTotal));
            dataGridView1 = new DataGridView();
            pbReturn = new PictureBox();
            label1 = new Label();
            lblSumCal = new Label();
            btnMonth = new Button();
            btnWeek = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReturn).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 67);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1006, 385);
            dataGridView1.TabIndex = 0;
            // 
            // pbReturn
            // 
            pbReturn.Image = Properties.Resources.arrow_back;
            pbReturn.Location = new Point(26, 511);
            pbReturn.Name = "pbReturn";
            pbReturn.Size = new Size(40, 40);
            pbReturn.SizeMode = PictureBoxSizeMode.StretchImage;
            pbReturn.TabIndex = 2;
            pbReturn.TabStop = false;
            pbReturn.Click += pbReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 465);
            label1.Name = "label1";
            label1.Size = new Size(169, 31);
            label1.TabIndex = 3;
            label1.Text = "Toplam Kalori:";
            // 
            // lblSumCal
            // 
            lblSumCal.AutoSize = true;
            lblSumCal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSumCal.Location = new Point(191, 465);
            lblSumCal.Name = "lblSumCal";
            lblSumCal.Size = new Size(0, 31);
            lblSumCal.TabIndex = 4;
            // 
            // btnMonth
            // 
            btnMonth.BackColor = Color.OliveDrab;
            btnMonth.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMonth.ForeColor = Color.White;
            btnMonth.Location = new Point(26, 12);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(169, 39);
            btnMonth.TabIndex = 5;
            btnMonth.Text = "AYLIK";
            btnMonth.UseVisualStyleBackColor = false;
            btnMonth.Click += btnMonth_Click;
            // 
            // btnWeek
            // 
            btnWeek.BackColor = Color.OliveDrab;
            btnWeek.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnWeek.ForeColor = Color.White;
            btnWeek.Location = new Point(238, 12);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(169, 39);
            btnWeek.TabIndex = 6;
            btnWeek.Text = "HAFTALIK";
            btnWeek.UseVisualStyleBackColor = false;
            btnWeek.Click += btnWeek_Click;
            // 
            // ReportMealTotal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 552);
            Controls.Add(btnWeek);
            Controls.Add(btnMonth);
            Controls.Add(lblSumCal);
            Controls.Add(label1);
            Controls.Add(pbReturn);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReportMealTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gün Sonu Raporu";
            Load += ReportMealTotal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pbReturn;
        private Label label1;
        private Label lblSumCal;
        private Button btnMonth;
        private Button btnWeek;
    }
}