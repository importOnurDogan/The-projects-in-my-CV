using OOP_SInema_Otomasyonu___Cozumu.Entity;
using OOP_SInema_Otomasyonu___Cozumu.Enums;

namespace OOP_SInema_Otomasyonu___Cozumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormTasarla(100);
        }


        void FormTasarla(int koltukSayisi)
        {
            int sayac = 0;
            for (int i = 1; i <= 6; i++)
            {
                for (int y = 1; y <= 12; y++)
                {
                    sayac++;
                    Button btn = new Button();
                    btn.Text = sayac.ToString();
                    btn.Width = 60;
                    btn.Height = 60;
                    btn.BackgroundImage = Resource1.imagesmavi;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += Btn_Click;
                    pnlKoltuklar.Controls.Add(btn);
                    if (i % 2 == 0)
                    {
                        btn.Location = new Point(150 + (btn.Width + 5) * y, 10 + (btn.Height + 5) * i);
                    }
                    else
                    {
                        btn.Location = new Point(360 + (btn.Width + 5) * y, 10 + (btn.Height + 5) * i);
                        if (y == 8)
                        {
                            break;
                        }
                    }
                }

            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {

            // sender => bu eventi calistiran nesne
            if (!(sender is Button))
            {
                return;
                // ya da uyari ver
            }
            var tiklanan = sender as Button;
            RezervasyonEkrani rzv = new RezervasyonEkrani(tiklanan);
            rzv.ShowDialog();
        }


        private void btnRapor_Click(object sender, EventArgs e)
        {
            int toplam = 0, kadin = 0,erkek = 0;

            foreach (Button btn in this.pnlKoltuklar.Controls)
            {
                if (btn.Tag != null)
                {
                    var bilet = btn.Tag as Bilet;
                    if (bilet.Cinsiyet == Cinsiyet.Kadin.ToString())
                    {
                        kadin++;
                    }
                    else
                    {
                        erkek++;
                    }
                }
            }
                

            toplam = kadin + erkek;
            MessageBox.Show($"Toplam Seyirci: {toplam}\n Toplam Kadin Seyirci: {kadin}\n Toplam Erkek Izleyici: {erkek}");
        }
    }
}