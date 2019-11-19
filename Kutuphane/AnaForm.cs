using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btn_kitapkayit_Click(object sender, EventArgs e)
        {
            Form1 kitapkayit = new Form1();
            kitapkayit.Show();
        }

        private void btn_kitapver_Click(object sender, EventArgs e)
        {
            KitapVerme kitapver = new KitapVerme();
            kitapver.Show();
        }

        private void btn_kitapteslimal_Click(object sender, EventArgs e)
        {
            TeslimEkrani teslimal = new TeslimEkrani();
            teslimal.Show();
        }

        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            OgrenciKitapArama oka = new OgrenciKitapArama();
            oka.Show();
        }

        private void btn_kiralamalistesi_Click(object sender, EventArgs e)
        {
            KiralamaListesi kl = new KiralamaListesi();
            kl.Show();
        }

        private void btn_kullanici_Click(object sender, EventArgs e)
        {
            KullaniciPaneli k = new KullaniciPaneli();
            k.Show();

        }
    }
}
