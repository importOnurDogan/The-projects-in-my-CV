namespace DietPlus.UI
{
    partial class CreateNewFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewFood));
            pictureBox1 = new PictureBox();
            btnCreatFood = new Button();
            panel3 = new Panel();
            txtPortion = new NumericUpDown();
            label9 = new Label();
            btnChooseImage = new Button();
            pbPicture = new PictureBox();
            label8 = new Label();
            txtDescription = new RichTextBox();
            label7 = new Label();
            cmbCategory = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtProt = new TextBox();
            label1 = new Label();
            txtFoodName = new TextBox();
            label4 = new Label();
            txtCar = new TextBox();
            label3 = new Label();
            txtFat = new TextBox();
            label2 = new Label();
            txtCalori = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPortion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CreateAccount;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 753);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCreatFood
            // 
            btnCreatFood.BackColor = Color.OliveDrab;
            btnCreatFood.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreatFood.ForeColor = SystemColors.ButtonHighlight;
            btnCreatFood.Location = new Point(101, 577);
            btnCreatFood.Name = "btnCreatFood";
            btnCreatFood.Size = new Size(293, 40);
            btnCreatFood.TabIndex = 10;
            btnCreatFood.Text = "Besin Ekle";
            btnCreatFood.UseVisualStyleBackColor = false;
            btnCreatFood.Click += btnCreatFood_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.CreateAccountForPanel;
            panel3.Controls.Add(txtPortion);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnChooseImage);
            panel3.Controls.Add(pbPicture);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtDescription);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtProt);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtFoodName);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtCar);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtFat);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtCalori);
            panel3.Controls.Add(btnCreatFood);
            panel3.Location = new Point(12, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 698);
            panel3.TabIndex = 11;
            // 
            // txtPortion
            // 
            txtPortion.Location = new Point(109, 165);
            txtPortion.Name = "txtPortion";
            txtPortion.Size = new Size(106, 27);
            txtPortion.TabIndex = 6;
            txtPortion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 167);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 27;
            label9.Text = "Porsiyon";
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(86, 409);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(94, 29);
            btnChooseImage.TabIndex = 9;
            btnChooseImage.Text = "...";
            btnChooseImage.TextAlign = ContentAlignment.TopCenter;
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // pbPicture
            // 
            pbPicture.Location = new Point(202, 405);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(192, 149);
            pbPicture.TabIndex = 25;
            pbPicture.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 418);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 24;
            label8.Text = "Resim";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(105, 209);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(293, 120);
            txtDescription.TabIndex = 7;
            txtDescription.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 352);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 20;
            label7.Text = "Kategory";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(101, 349);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(293, 28);
            cmbCategory.TabIndex = 8;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 208);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 18;
            label5.Text = "Açıklaması";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 120);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 16;
            label6.Text = "Protein";
            // 
            // txtProt
            // 
            txtProt.Location = new Point(286, 117);
            txtProt.Name = "txtProt";
            txtProt.Size = new Size(116, 27);
            txtProt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 27);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 14;
            label1.Text = "Besin Adı";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(109, 24);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(295, 27);
            txtFoodName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 75);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 11;
            label4.Text = "Yağ";
            // 
            // txtCar
            // 
            txtCar.Location = new Point(107, 117);
            txtCar.Name = "txtCar";
            txtCar.Size = new Size(108, 27);
            txtCar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 120);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 9;
            label3.Text = "Karbonhidrat";
            // 
            // txtFat
            // 
            txtFat.Location = new Point(286, 72);
            txtFat.Name = "txtFat";
            txtFat.Size = new Size(116, 27);
            txtFat.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 75);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 7;
            label2.Text = "Kalori";
            // 
            // txtCalori
            // 
            txtCalori.Location = new Point(109, 72);
            txtCalori.Name = "txtCalori";
            txtCalori.Size = new Size(106, 27);
            txtCalori.TabIndex = 2;
            // 
            // CreateNewFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 753);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateNewFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Besin Ekleme";
            Load += CreateNewFood_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPortion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCreatFood;
        private TextBox txtFat;
        private Panel panel3;
        private PictureBox pbPassword;
        private Label label4;
        private TextBox txtCar;
        private Label label3;
        private TextBox txtSifre;
        private Label label2;
        private TextBox txtCalori;
        private Label label1;
        private TextBox txtFoodName;
        private Label label7;
        private ComboBox cmbCategory;
        private Label label5;
        private Label label6;
        private TextBox txtProt;
        private PictureBox pbPicture;
        private Label label8;
        private RichTextBox txtDescription;
        private Button btnChooseImage;
        private Label label9;
        private NumericUpDown txtPortion;
    }
}