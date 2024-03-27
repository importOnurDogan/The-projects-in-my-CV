namespace OOP_SInema_Otomasyonu___Cozumu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            lblSinemaOtomasyonu = new Label();
            pnlKoltuklar = new Panel();
            btnRapor = new Button();
            SuspendLayout();
            // 
            // lblSinemaOtomasyonu
            // 
            lblSinemaOtomasyonu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSinemaOtomasyonu.Location = new Point(34, 9);
            lblSinemaOtomasyonu.Name = "lblSinemaOtomasyonu";
            lblSinemaOtomasyonu.Size = new Size(811, 79);
            lblSinemaOtomasyonu.TabIndex = 1;
            lblSinemaOtomasyonu.Text = "Sinema Otomasyonu";
            lblSinemaOtomasyonu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlKoltuklar
            // 
            pnlKoltuklar.Location = new Point(34, 111);
            pnlKoltuklar.Name = "pnlKoltuklar";
            pnlKoltuklar.Size = new Size(1026, 616);
            pnlKoltuklar.TabIndex = 2;
            // 
            // btnRapor
            // 
            btnRapor.Location = new Point(1088, 111);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(105, 83);
            btnRapor.TabIndex = 3;
            btnRapor.Text = "Rapor";
            btnRapor.UseVisualStyleBackColor = true;
            btnRapor.Click += btnRapor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 739);
            Controls.Add(btnRapor);
            Controls.Add(pnlKoltuklar);
            Controls.Add(lblSinemaOtomasyonu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblSinemaOtomasyonu;
        private Panel pnlKoltuklar;
        private Button btnRapor;
    }
}