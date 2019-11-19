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
    public partial class KullaniciPaneli : Form
    {
        public KullaniciPaneli()
        {
            InitializeComponent();
        }
        ProjeContext db = new ProjeContext();

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();

            k.Ad = txt_ad.Text;
            k.Soyad = txt_soyad.Text;
            k.KullaniciAd = txt_kullaniciad.Text;
            k.KullaniciSifre = txt_sifre.Text;


            if (db.TBLKullanici.Any(x => x.KullaniciAd == k.KullaniciAd))
            {
                MessageBox.Show("Girdiğiniz Kullanıcı Adı Kullanılmaktadır. Tekrar deneyin.");

                Temizle();
            }
            else
            {
                db.TBLKullanici.Add(k);
                db.SaveChanges();

                MessageBox.Show("Kayıt Oluşturuldu.");

                KullaniciListe();
                Temizle();
            }
        }
        public void Temizle()
        {
            txt_ad.Text = default(string);
            txt_soyad.Text = default(string);
            txt_kullaniciad.Text = default(string);
            txt_sifre.Text = default(string);
        }
        public void KullaniciListe()
        {
            listView1.Items.Clear();
            foreach (Kullanici item in db.TBLKullanici.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Ad.ToString());
                lvi.SubItems.Add(item.Soyad.ToString());
                lvi.SubItems.Add(item.KullaniciAd.ToString());
                lvi.SubItems.Add(item.KullaniciSifre.ToString());

                lvi.Tag = item.ID;//listviewde tıklanan satırın ID sini almasını sağlıyoruz!!
                listView1.Items.Add(lvi);
            }

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            updated = db.TBLKullanici.Find(id);
            updated.Ad = txt_ad.Text;
            updated.Soyad = txt_soyad.Text;
            updated.KullaniciAd = txt_kullaniciad.Text;
            updated.KullaniciSifre = txt_sifre.Text;

            db.Entry(db.TBLKullanici.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();
            MessageBox.Show("Kullanici Güncellendi.");

            Temizle();
            KullaniciListe();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Kullanici deleted = db.TBLKullanici.Find(id);
            db.TBLKullanici.Remove(deleted);
            db.SaveChanges();//her savechanges dediğimizde bütün veri tabanını kaydediyor
            MessageBox.Show("Kullanici Silindi.");

            Temizle();
            KullaniciListe();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        Kullanici updated;
        int id;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].Tag);
            updated = db.TBLKullanici.Find(id);
            txt_ad.Text = updated.Ad;
            txt_soyad.Text = updated.Soyad;
            txt_kullaniciad.Text = updated.KullaniciAd;
            txt_sifre.Text = updated.KullaniciSifre;
        }

        
       
    }
}
