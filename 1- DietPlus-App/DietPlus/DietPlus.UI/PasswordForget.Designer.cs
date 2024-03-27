namespace DietPlus.UI
{
    partial class PasswordForget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForget));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnPassword = new Button();
            txtEmail = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pbBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            // btnPassword
            // 
            btnPassword.BackColor = Color.OliveDrab;
            btnPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPassword.ForeColor = SystemColors.ButtonHighlight;
            btnPassword.Location = new Point(100, 125);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(264, 40);
            btnPassword.TabIndex = 2;
            btnPassword.Text = "Şifreyi Gönder";
            btnPassword.UseVisualStyleBackColor = false;
            btnPassword.Click += btnSendEmail_Click;
            btnPassword.MouseEnter += btnSendEmail_MouseEnter;
            btnPassword.MouseLeave += btnSendEmail_MouseLeave;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 27);
            txtEmail.TabIndex = 1;
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
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(btnPassword);
            panel3.Location = new Point(12, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 277);
            panel3.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 75);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 5;
            label1.Text = "E-Mail:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.CreateAccountForPanel;
            panel2.Controls.Add(pbBack);
            panel2.Location = new Point(12, 498);
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
            // PasswordForget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 753);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PasswordForget";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifremi Unuttum";
            FormClosed += SifremiUnuttum_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnPassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pbPassword;
        private Label label1;
        private Panel panel2;
        private PictureBox pbBack;

    }
}