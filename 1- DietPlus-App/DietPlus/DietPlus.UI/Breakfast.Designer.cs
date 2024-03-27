namespace DietPlus.UI
{
    partial class Breakfast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Breakfast));
            panel1 = new Panel();
            btnChoose = new Button();
            txtFoodFind = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnChoose);
            panel1.Controls.Add(txtFoodFind);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 34);
            panel1.TabIndex = 0;
            // 
            // btnChoose
            // 
            btnChoose.BackColor = Color.LimeGreen;
            btnChoose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChoose.ForeColor = SystemColors.ButtonHighlight;
            btnChoose.Location = new Point(407, -1);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(134, 32);
            btnChoose.TabIndex = 3;
            btnChoose.Text = "SEÇ";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // txtFoodFind
            // 
            txtFoodFind.Location = new Point(54, 4);
            txtFoodFind.Name = "txtFoodFind";
            txtFoodFind.Size = new Size(347, 27);
            txtFoodFind.TabIndex = 1;
            txtFoodFind.Text = "Besini Seçiniz...";
            txtFoodFind.TextChanged += txtFoodFind_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.find;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 34);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 67);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(557, 496);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Breakfast
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.breakfast2;
            ClientSize = new Size(564, 562);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Breakfast";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kahvaltı";
            Load += Breakfast_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtFoodFind;
        private DataGridView dataGridView1;
        private Button btnChoose;
    }
}