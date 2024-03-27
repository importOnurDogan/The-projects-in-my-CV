namespace DietPlus.UI
{
    partial class WhoAreWe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhoAreWe));
            label1 = new Label();
            lblBizKimiz = new Label();
            lblMisyon = new Label();
            label3 = new Label();
            lblEkip = new Label();
            label4 = new Label();
            lblGeriBiildirim = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 31);
            label1.TabIndex = 0;
            label1.Text = "BİZ KİMİZ";
            // 
            // lblBizKimiz
            // 
            lblBizKimiz.AutoSize = true;
            lblBizKimiz.Location = new Point(37, 69);
            lblBizKimiz.Name = "lblBizKimiz";
            lblBizKimiz.Size = new Size(50, 20);
            lblBizKimiz.TabIndex = 1;
            lblBizKimiz.Text = "label2";
            // 
            // lblMisyon
            // 
            lblMisyon.AutoSize = true;
            lblMisyon.Location = new Point(37, 183);
            lblMisyon.Name = "lblMisyon";
            lblMisyon.Size = new Size(50, 20);
            lblMisyon.TabIndex = 3;
            lblMisyon.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 138);
            label3.Name = "label3";
            label3.Size = new Size(169, 31);
            label3.TabIndex = 2;
            label3.Text = "MİSYONUMUZ";
            // 
            // lblEkip
            // 
            lblEkip.AutoSize = true;
            lblEkip.Location = new Point(37, 301);
            lblEkip.Name = "lblEkip";
            lblEkip.Size = new Size(50, 20);
            lblEkip.TabIndex = 5;
            lblEkip.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 258);
            label4.Name = "label4";
            label4.Size = new Size(200, 31);
            label4.TabIndex = 4;
            label4.Text = "UZMAN EKİBİMİZ";
            // 
            // lblGeriBiildirim
            // 
            lblGeriBiildirim.AutoSize = true;
            lblGeriBiildirim.Location = new Point(37, 493);
            lblGeriBiildirim.Name = "lblGeriBiildirim";
            lblGeriBiildirim.Size = new Size(50, 20);
            lblGeriBiildirim.TabIndex = 7;
            lblGeriBiildirim.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 449);
            label5.Name = "label5";
            label5.Size = new Size(167, 31);
            label5.TabIndex = 6;
            label5.Text = "GERİ BİLDİRİM";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackgroundImage = Properties.Resources.arkaplanEnson;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblBizKimiz);
            panel1.Controls.Add(lblGeriBiildirim);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblMisyon);
            panel1.Controls.Add(lblEkip);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 565);
            panel1.TabIndex = 9;
            // 
            // WhoAreWe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WhoAreWe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biz Kimiz?";
            FormClosed += WhoAreWe_FormClosed;
            Load += WhoAreWe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblBizKimiz;
        private Label lblMisyon;
        private Label label3;
        private Label lblEkip;
        private Label label4;
        private Label lblGeriBiildirim;
        private Label label5;
        private Panel panel1;
    }
}