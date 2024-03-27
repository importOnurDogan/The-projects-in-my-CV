namespace OOP_SInema_Otomasyonu___Cozumu
{
    partial class RezervasyonEkrani
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
            lblRezervasyonEkrani = new Label();
            rbKadin = new RadioButton();
            rbErkek = new RadioButton();
            btnIptalEt = new Button();
            btnKaydet = new Button();
            lblAdSoyad = new Label();
            lblTCno = new Label();
            txtAdSoyad = new TextBox();
            MtxtTCno = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblRezervasyonEkrani
            // 
            lblRezervasyonEkrani.BackColor = SystemColors.ActiveBorder;
            lblRezervasyonEkrani.Dock = DockStyle.Top;
            lblRezervasyonEkrani.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblRezervasyonEkrani.Location = new Point(0, 0);
            lblRezervasyonEkrani.Name = "lblRezervasyonEkrani";
            lblRezervasyonEkrani.Size = new Size(745, 66);
            lblRezervasyonEkrani.TabIndex = 1;
            lblRezervasyonEkrani.Text = "REZERVASYON EKRANI";
            lblRezervasyonEkrani.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(520, 118);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(68, 24);
            rbKadin.TabIndex = 2;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadin";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(520, 172);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(65, 24);
            rbErkek.TabIndex = 3;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // btnIptalEt
            // 
            btnIptalEt.Location = new Point(198, 235);
            btnIptalEt.Name = "btnIptalEt";
            btnIptalEt.Size = new Size(120, 40);
            btnIptalEt.TabIndex = 4;
            btnIptalEt.Text = "IPTAL ET";
            btnIptalEt.UseVisualStyleBackColor = true;
            btnIptalEt.Click += btnIptalEt_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(468, 235);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(117, 40);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Location = new Point(47, 115);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(98, 25);
            lblAdSoyad.TabIndex = 6;
            lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblTCno
            // 
            lblTCno.Location = new Point(47, 169);
            lblTCno.Name = "lblTCno";
            lblTCno.Size = new Size(62, 25);
            lblTCno.TabIndex = 7;
            lblTCno.Text = "TC no";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(198, 115);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(227, 27);
            txtAdSoyad.TabIndex = 8;
            // 
            // MtxtTCno
            // 
            MtxtTCno.Location = new Point(198, 169);
            MtxtTCno.Name = "MtxtTCno";
            MtxtTCno.Size = new Size(227, 27);
            MtxtTCno.TabIndex = 10;
            // 
            // RezervasyonEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 326);
            Controls.Add(MtxtTCno);
            Controls.Add(txtAdSoyad);
            Controls.Add(lblTCno);
            Controls.Add(lblAdSoyad);
            Controls.Add(btnKaydet);
            Controls.Add(btnIptalEt);
            Controls.Add(rbErkek);
            Controls.Add(rbKadin);
            Controls.Add(lblRezervasyonEkrani);
            Name = "RezervasyonEkrani";
            Text = "Form_RezervasyonEkrani";
            Load += RezervasyonEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRezervasyonEkrani;
        private RadioButton rbKadin;
        private RadioButton rbErkek;
        private Button btnIptalEt;
        private Button btnKaydet;
        private Label lblAdSoyad;
        private Label lblTCno;
        private TextBox txtAdSoyad;
        private MaskedTextBox MtxtTCno;
    }
}