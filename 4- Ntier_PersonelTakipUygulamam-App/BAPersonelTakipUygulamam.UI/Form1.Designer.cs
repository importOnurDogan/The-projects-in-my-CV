namespace BAPersonelTakipUygulamam.UI
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
            dataGridView1 = new DataGridView();
            btnPersonelleriGoster = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(766, 283);
            dataGridView1.TabIndex = 0;
            // 
            // btnPersonelleriGoster
            // 
            btnPersonelleriGoster.Location = new Point(73, 316);
            btnPersonelleriGoster.Name = "btnPersonelleriGoster";
            btnPersonelleriGoster.Size = new Size(130, 62);
            btnPersonelleriGoster.TabIndex = 1;
            btnPersonelleriGoster.Text = "Personelleri Goster";
            btnPersonelleriGoster.UseVisualStyleBackColor = true;
            btnPersonelleriGoster.Click += btnPersonelleriGoster_Click;
            // 
            // button1
            // 
            button1.Location = new Point(267, 316);
            button1.Name = "button1";
            button1.Size = new Size(130, 62);
            button1.TabIndex = 2;
            button1.Text = "Personelleri Goster";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(413, 316);
            button2.Name = "button2";
            button2.Size = new Size(130, 62);
            button2.TabIndex = 3;
            button2.Text = "Personelleri Goster";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPersonelleriGoster);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnPersonelleriGoster;
        private Button button1;
        private Button button2;
    }
}