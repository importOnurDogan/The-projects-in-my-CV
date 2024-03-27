namespace DietPlus.UI
{
    partial class MemberShipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberShipForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnUpdate = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            btnDelete = new Button();
            label7 = new Label();
            cmbWeightStatus = new ComboBox();
            label5 = new Label();
            txtHeight = new TextBox();
            label6 = new Label();
            txtWeight = new TextBox();
            panel4 = new Panel();
            pbSifre = new PictureBox();
            label3 = new Label();
            txtPassword = new TextBox();
            panel2 = new Panel();
            pbBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSifre).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
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
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(21, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(244, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(111, 193);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 40);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "GUNCELLE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.CreateAccountForPanel;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(91, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 134);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.CreateAccountForPanel;
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cmbWeightStatus);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtHeight);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtWeight);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(btnUpdate);
            panel3.Location = new Point(12, 216);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 258);
            panel3.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(279, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 132);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 20;
            label7.Text = "Kilo Durumu:";
            // 
            // cmbWeightStatus
            // 
            cmbWeightStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeightStatus.FormattingEnabled = true;
            cmbWeightStatus.Location = new Point(111, 129);
            cmbWeightStatus.Name = "cmbWeightStatus";
            cmbWeightStatus.Size = new Size(293, 28);
            cmbWeightStatus.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 86);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 18;
            label5.Text = "Boy:";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(289, 79);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(115, 27);
            txtHeight.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 86);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 16;
            label6.Text = "Kilo:";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(109, 83);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(108, 27);
            txtWeight.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.CreateAccountForPanel;
            panel4.Controls.Add(pbSifre);
            panel4.Location = new Point(420, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(27, 27);
            panel4.TabIndex = 12;
            // 
            // pbSifre
            // 
            pbSifre.BackColor = Color.Transparent;
            pbSifre.Dock = DockStyle.Fill;
            pbSifre.Image = Properties.Resources.question_mark;
            pbSifre.Location = new Point(0, 0);
            pbSifre.Name = "pbSifre";
            pbSifre.Size = new Size(27, 27);
            pbSifre.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSifre.TabIndex = 1;
            pbSifre.TabStop = false;
            pbSifre.Click += pbSifre_Click;
            pbSifre.MouseEnter += pbBack_MouseEnter;
            pbSifre.MouseLeave += pbBack_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 41);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 9;
            label3.Text = "Şifre:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(109, 38);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(295, 27);
            txtPassword.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.CreateAccountForPanel;
            panel2.Controls.Add(pbBack);
            panel2.Location = new Point(12, 691);
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
            pbBack.MouseEnter += pbBack_MouseEnter;
            pbBack.MouseLeave += pbBack_MouseLeave;
            // 
            // MemberShipForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 753);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemberShipForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üyelik İşlemleri";
            FormClosed += HesapOlustur_FormClosed;
            Load += MemberShipForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSifre).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnUpdate;
        private TextBox txtPassword;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pbPassword;
        private Label label3;
        private TextBox txtSifre;
        private Panel panel2;
        private PictureBox pbBack;
        private Panel panel4;
        private PictureBox pbSifre;
        private Label label7;
        private ComboBox cmbWeightStatus;
        private Label label5;
        private TextBox txtHeight;
        private Label label6;
        private TextBox txtWeight;
        private Button btnDelete;
    }
}