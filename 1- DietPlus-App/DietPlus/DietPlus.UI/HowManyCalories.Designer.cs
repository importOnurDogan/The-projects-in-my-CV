namespace DietPlus.UI
{
    partial class HowManyCalories
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowManyCalories));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pbBack = new PictureBox();
            pbPicture = new PictureBox();
            dataGridView1 = new DataGridView();
            txtFind = new TextBox();
            lblFoodName = new Label();
            lblKalori = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.HawManyCalories;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 753);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.CreateAccountForPanel;
            panel2.Controls.Add(pbBack);
            panel2.Location = new Point(421, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 50);
            panel2.TabIndex = 9;
            // 
            // pbBack
            // 
            pbBack.BackColor = Color.Transparent;
            pbBack.Dock = DockStyle.Fill;
            pbBack.Image = Properties.Resources.arrow_back;
            pbBack.Location = new Point(0, 0);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(50, 50);
            pbBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            pbBack.MouseEnter += btnSendEmail_MouseEnter;
            pbBack.MouseLeave += btnSendEmail_MouseLeave;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.Transparent;
            pbPicture.Image = Properties.Resources.elma;
            pbPicture.Location = new Point(12, 46);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(140, 148);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 11;
            pbPicture.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(12, 200);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(459, 344);
            dataGridView1.TabIndex = 12;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(12, 12);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(392, 27);
            txtFind.TabIndex = 1;
            txtFind.Text = "Besin Adını Giriniz.";
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.BackColor = Color.White;
            lblFoodName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFoodName.Location = new Point(195, 81);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(0, 31);
            lblFoodName.TabIndex = 17;
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.BackColor = Color.White;
            lblKalori.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblKalori.Location = new Point(195, 112);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(0, 31);
            lblKalori.TabIndex = 19;
            // 
            // HowManyCalories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 753);
            Controls.Add(lblKalori);
            Controls.Add(lblFoodName);
            Controls.Add(txtFind);
            Controls.Add(dataGridView1);
            Controls.Add(pbPicture);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HowManyCalories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kaç Kalori";
            Load += HowManyCalories_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private PictureBox pbPassword;
        private Panel panel2;
        private PictureBox pbBack;
        private PictureBox pbPicture;
        private DataGridView dataGridView1;
        private TextBox txtFind;
        private Label lblFoodName;
        private Label lblKalori;
    }
}