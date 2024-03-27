namespace DietPlus.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblSignIn = new Label();
            lblForgotPassword = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pbGoogle = new PictureBox();
            pbTwitter = new PictureBox();
            pbFacebook = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            pbPassword = new PictureBox();
            panel4 = new Panel();
            lblAbout = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGoogle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTwitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFacebook).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
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
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.OliveDrab;
            btnSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = SystemColors.ButtonHighlight;
            btnSignIn.Location = new Point(3, 134);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(340, 40);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "GİRİŞ YAP";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            btnSignIn.MouseEnter += lblSignIn_MouseEnter;
            btnSignIn.MouseLeave += lblSignIn_MouseLeave;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(3, 79);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(295, 40);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Şifre";
            txtPassword.MouseClick += txtPassword_MouseClick;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(3, 15);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 40);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "E-Posta";
            txtEmail.MouseClick += txtUsername_MouseClick;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.BackColor = Color.Transparent;
            lblSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignIn.Location = new Point(3, 15);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(108, 20);
            lblSignIn.TabIndex = 5;
            lblSignIn.Text = "Hesap Oluştur";
            lblSignIn.Click += lblSignIn_Click;
            lblSignIn.MouseEnter += lblSignIn_MouseEnter;
            lblSignIn.MouseLeave += lblSignIn_MouseLeave;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.BackColor = Color.Transparent;
            lblForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblForgotPassword.Location = new Point(209, 15);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(134, 20);
            lblForgotPassword.TabIndex = 6;
            lblForgotPassword.Text = "Şifremi Unuttum?";
            lblForgotPassword.Click += lblForgotPassword_Click;
            lblForgotPassword.MouseEnter += lblSignIn_MouseEnter;
            lblForgotPassword.MouseLeave += lblSignIn_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.LoginArkaplan;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(90, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 134);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.LoginArkaplan;
            panel2.Controls.Add(pbGoogle);
            panel2.Controls.Add(pbTwitter);
            panel2.Controls.Add(pbFacebook);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblSignIn);
            panel2.Controls.Add(lblForgotPassword);
            panel2.Location = new Point(65, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 121);
            panel2.TabIndex = 9;
            // 
            // pbGoogle
            // 
            pbGoogle.Image = Properties.Resources._176526_flurry_google_gmail_icon;
            pbGoogle.Location = new Point(188, 67);
            pbGoogle.Name = "pbGoogle";
            pbGoogle.Size = new Size(35, 35);
            pbGoogle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGoogle.TabIndex = 10;
            pbGoogle.TabStop = false;
            pbGoogle.Click += pbGoogle_Click;
            pbGoogle.MouseEnter += lblSignIn_MouseEnter;
            pbGoogle.MouseLeave += lblSignIn_MouseLeave;
            // 
            // pbTwitter
            // 
            pbTwitter.Image = Properties.Resources._11053970_x_logo_twitter_new_brand_icon;
            pbTwitter.Location = new Point(141, 67);
            pbTwitter.Name = "pbTwitter";
            pbTwitter.Size = new Size(35, 35);
            pbTwitter.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTwitter.TabIndex = 9;
            pbTwitter.TabStop = false;
            pbTwitter.Click += pbTwitter_Click;
            pbTwitter.MouseEnter += lblSignIn_MouseEnter;
            pbTwitter.MouseLeave += lblSignIn_MouseLeave;
            // 
            // pbFacebook
            // 
            pbFacebook.Image = Properties.Resources._317727_facebook_social_media_social_icon;
            pbFacebook.Location = new Point(94, 67);
            pbFacebook.Name = "pbFacebook";
            pbFacebook.Size = new Size(35, 35);
            pbFacebook.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFacebook.TabIndex = 8;
            pbFacebook.TabStop = false;
            pbFacebook.Click += pbFacebook_Click;
            pbFacebook.MouseEnter += lblSignIn_MouseEnter;
            pbFacebook.MouseLeave += lblSignIn_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 44);
            label1.Name = "label1";
            label1.Size = new Size(273, 20);
            label1.TabIndex = 7;
            label1.Text = "-----------------   yada   ----------------- ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(pbPassword);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(btnSignIn);
            panel3.Location = new Point(65, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 177);
            panel3.TabIndex = 11;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources._7148754_visible_password_security_protect_icon;
            pbPassword.Location = new Point(303, 79);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(40, 40);
            pbPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPassword.TabIndex = 11;
            pbPassword.TabStop = false;
            pbPassword.Click += pbPassword_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.LoginArkaplan;
            panel4.Controls.Add(lblAbout);
            panel4.Location = new Point(1, 721);
            panel4.Name = "panel4";
            panel4.Size = new Size(74, 29);
            panel4.TabIndex = 11;
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAbout.Location = new Point(1, 6);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(70, 17);
            lblAbout.TabIndex = 12;
            lblAbout.Text = "Biz Kimiz?";
            lblAbout.Click += lblAbout_Click;
            lblAbout.MouseEnter += lblSignIn_MouseEnter;
            lblAbout.MouseLeave += lblSignIn_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 753);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Sayfası";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGoogle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTwitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFacebook).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSignIn;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblSignIn;
        private Label lblForgotPassword;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pbGoogle;
        private PictureBox pbTwitter;
        private PictureBox pbFacebook;
        private Panel panel3;
        private PictureBox pbPassword;
        private Panel panel4;
        private Label lblAbout;
    }
}