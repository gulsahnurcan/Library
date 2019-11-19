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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KitapListele();
        }
        ProjeContext db = new ProjeContext();

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            List<Kitap> kitaps = db.TBLKitap.Where(x => x.KitapAdi == txt_adi.Text && x.Yazar == txt_yazar.Text &&  x.BasımTarihi == dtp_basimtarihi.Value && x.BaskiNo == txt_baskino.Text && x.YayinEvi == txt_yayin.Text ).ToList();
            if (kitaps.Count>0)
            {
                foreach (Kitap item in kitaps)
                {
                    int stkkontrol = Convert.ToInt32(item.Stok) + 1;
                    Updated = db.TBLKitap.Find(item.ID);

                    Updated.KitapAdi = txt_adi.Text;
                    Updated.Yazar = txt_yazar.Text;
                    Updated.Tur = (string)cb_tur.SelectedItem;
                    Updated.BasımTarihi = dtp_basimtarihi.Value.Date;
                    Updated.BaskiNo = txt_baskino.Text;
                    Updated.YayinEvi = txt_yayin.Text;
                    Updated.Stok = stkkontrol;
                    Updated.Ucret = Convert.ToDouble(txt_ucret.Text);

                    db.Entry(db.TBLKitap.Find(Updated.ID)).CurrentValues.SetValues(Updated);
                    db.SaveChanges();
                }
            }
            else
            {
                Kitap k = new Kitap();
                k.KitapAdi = txt_adi.Text;
                k.Yazar = txt_yazar.Text;
                k.Tur = (string)cb_tur.SelectedItem;
                k.BasımTarihi = dtp_basimtarihi.Value.Date;
                k.BaskiNo = txt_baskino.Text;
                k.YayinEvi = txt_yayin.Text;
                k.Stok = 1;
                k.Ucret = Convert.ToInt64(txt_ucret.Text);
                db.TBLKitap.Add(k);
                db.SaveChanges();
            }
            
            Temizle();
            KitapListele();

        }
        public void Temizle()
        {
            txt_adi.Text = default(string);
            txt_yazar.Text = default(string);
            cb_tur.SelectedIndex = -1;
            dtp_basimtarihi.Value = DateTime.Now;
            txt_baskino.Text = default(string);
            txt_yayin.Text = default(string);
            txt_ucret.Text = default(string);

        }

        public void KitapListele()
        {
            dataGridView1.DataSource = db.TBLKitap.ToList();
            dataGridView1.Columns[9].Visible = false;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        Kitap secilen;
        int id;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            secilen = db.TBLKitap.Find(id);

            txt_adi.Text = secilen.KitapAdi;
            txt_yazar.Text = secilen.Yazar;
            cb_tur.SelectedItem = secilen.Tur;
            dtp_basimtarihi.Value = secilen.BasımTarihi;
            txt_baskino.Text = secilen.BaskiNo;
            txt_yayin.Text = secilen.YayinEvi;
            txt_ucret.Text = Convert.ToString(secilen.Ucret);

        }

        Kitap Deleted;
        private void btn_sil_Click(object sender, EventArgs e)
        {
            Deleted = db.TBLKitap.Find(id);

            if(Deleted.Stok == 0)
            {
                db.TBLKitap.Remove(Deleted);
            }
            else
            {
                List<Kitap> kontrol = db.TBLKitap.Where(x => x.ID == Deleted.ID).ToList();
                foreach (Kitap item in kontrol)
                {
                    item.Stok = item.Stok - 1;
                }
                
            }
            
            db.SaveChanges();
            MessageBox.Show("Kitap Silindi.");

            Temizle();
            KitapListele();
        }

        Kitap Updated;
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Updated = db.TBLKitap.Find(id);

            Updated.KitapAdi = txt_adi.Text;
            Updated.Yazar = txt_yazar.Text;
            Updated.Tur = (string) cb_tur.SelectedItem;
            Updated.BasımTarihi = dtp_basimtarihi.Value;
            Updated.BaskiNo = txt_baskino.Text;
            Updated.YayinEvi = txt_yayin.Text;
            Updated.Ucret = Convert.ToDouble(txt_ucret.Text);

            db.Entry(db.TBLKitap.Find(Updated.ID)).CurrentValues.SetValues(Updated);
            db.SaveChanges();
            MessageBox.Show("Kitap Güncellendi.");

            Temizle();
            KitapListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KitapListele();
        }
    }
}
