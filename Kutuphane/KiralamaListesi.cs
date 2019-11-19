using Kutuphane.ORM.Context;
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
    public partial class KiralamaListesi : Form
    {
        public KiralamaListesi()
        {
            InitializeComponent();
        }
        ProjeContext db = new ProjeContext();

        private void KiralamaListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLKiralama.Where(x => x.AktifMi == true).Select(x =>  new
            {
                ID = x.ID,
                KitapID = x.KitapId,
                Kitap = x.Kitap.KitapAdi,
                OgrenciID = x.OgrenciId,
                Ogrenci = x.Ogrenci.Adi,
                AlisTarihi = x.AlisTarihi,
                TeslimTarihi = x.TeslimTarihi

            }).ToList(); 

            
        }
    }
}
