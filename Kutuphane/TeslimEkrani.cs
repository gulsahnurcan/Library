using Kutuphane.ORM.Context;
using Kutuphane.ORM.Entity;
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
    public partial class TeslimEkrani : Form
    {
        public TeslimEkrani()
        {
            InitializeComponent();
        }
        ProjeContext db = new ProjeContext();

        private void TeslimEkrani_Load(object sender, EventArgs e)
        {
            
        }
        
        private void dtp_verilistarihi_ValueChanged(object sender, EventArgs e)
        {
            teslim.VerilisTarihi = dtp_verilistarihi.Value;

            TimeSpan hesap = teslim.VerilisTarihi - teslim.TeslimTarihi;

            teslim.Fark = hesap.Days;
            teslim.Ceza = teslim.Fark * 0.10;
            

            if (teslim.Ceza<0)
            {
                lbl_ceza.Text =Convert.ToString( 0);
            }
            else
            {
                lbl_ceza.Text = teslim.Ceza.ToString(); 
            }
            
        }

        Ogrenci o = new Ogrenci();
        private void btn_goruntule_Click(object sender, EventArgs e)
        {
            o.Tc = txt_ogrencitc.Text;

            Listele();
        }

        public void Listele()
        {
            dataGridView1.DataSource = db.TBLKiralama.Where(x => x.Ogrenci.Tc == o.Tc && x.AktifMi==true).Select(x => new
            {
                ID = x.ID,
                KitapId = x.KitapId,
                KitapAdi = x.Kitap.KitapAdi,
                OgrenciId = x.OgrenciId,
                OgrenciAdi = x.Ogrenci.Adi,
                AlisTarihi = x.AlisTarihi,
                TeslimTarihi = x.TeslimTarihi

            }).ToList();
        }

        Kiralama teslim = new Kiralama();
        int id;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            teslim = db.TBLKiralama.Find(id);

            txt_kitapid.Text = teslim.KitapId.ToString();
        }

        private void btn_teslimal_Click(object sender, EventArgs e)
        {
            List<Kitap> kontrol = db.TBLKitap.Where(x => x.ID == teslim.KitapId).ToList();

            foreach (Kitap item in kontrol)
            {
                item.Stok = item.Stok + 1;
            }

            teslim.AktifMi = false;

            MessageBox.Show("Teslim Alındı.");
            
            db.SaveChanges();
            Listele();
        }
    }
}
