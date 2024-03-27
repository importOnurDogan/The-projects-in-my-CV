using OOP_SInema_Otomasyonu___Cozumu.Entity;
using OOP_SInema_Otomasyonu___Cozumu.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SInema_Otomasyonu___Cozumu
{
    public partial class RezervasyonEkrani : Form
    {
        public RezervasyonEkrani()
        {
            InitializeComponent();
        }

        public RezervasyonEkrani(Button btn)
        {
            InitializeComponent();
            this.btn = btn;
        }
        Button btn;



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (this.btn != null)
            {
                this.btn.BackgroundImage = Resource1.imageskirmizi;
            }
            Bilet bilet;
            if (btn.Tag != null)
            {
                bilet = btn.Tag as Bilet;
            }
            else
            {
                bilet = new Bilet();
            }

            bilet.AdSoyad = txtAdSoyad.Text;
            bilet.TcKimlikNo = MtxtTCno.Text;
            bilet.Cinsiyet = rbKadin.Checked ? Cinsiyet.Kadin.ToString() : Cinsiyet.Erkek.ToString();
            bilet.BiletNumarasi = Convert.ToInt32(this.btn.Text);
            this.btn.Tag = bilet;

            Temizle();
            this.Close();
        }




        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            if (this.btn != null && this.btn.Tag != null)
            {
                DialogResult cvp = MessageBox.Show("Bileti iptal etmek istiyor musunuz? ", "Bilet iptal uyarisi :", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cvp == DialogResult.Yes)
                {
                    this.btn.Tag = null;
                    this.btn.BackgroundImage = Resource1.imagesmavi;
                    GC.Collect(); // Garbage Collector'u calistirir.
                }
                this.btn.BackgroundImage = Resource1.imagesmavi;
            }
        }




        private void RezervasyonEkrani_Load(object sender, EventArgs e)
        {
            rbKadin.Checked = true;
            btnIptalEt.Enabled = false;
            if (this.btn != null && this.btn.Tag != null)
            {
                Bilet alinanBilet = this.btn.Tag as Bilet;
                txtAdSoyad.Text = alinanBilet.AdSoyad;
                MtxtTCno.Text = alinanBilet?.TcKimlikNo;
                if (alinanBilet.Cinsiyet == Cinsiyet.Kadin.ToString())
                {
                    rbKadin.Checked = true;
                }
                else
                {
                    rbErkek.Checked = true;
                }
                btnIptalEt.Enabled = true;
            }
        }



        void Temizle()
        {
            rbKadin.Checked = true;
            txtAdSoyad.Clear();
            MtxtTCno.Clear();

        }
    }
}
