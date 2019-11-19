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
    public partial class KitapVerme : Form
    {
        public KitapVerme()
        {
            InitializeComponent();
        }
        ProjeContext db = new ProjeContext();

        Kiralama kiralanan = new Kiralama();
        private void btn_kiralamakaydet_Click(object sender, EventArgs e)
        {
            kiralanan.KitapId = (int)cb_kitap.SelectedValue;

            List<Kitap> kontrol = db.TBLKitap.Where(x => x.ID == kiralanan.KitapId).ToList();
            foreach (Kitap item in kontrol)
            {
                item.Stok = item.Stok - 1;
            }

            Ogrenci o = new Ogrenci();
            o.Tc = txt_kiralamatc.Text;


            List<Ogrenci> k = db.TBLOgrenci.Where(x => x.Tc == o.Tc).ToList();
            foreach (Ogrenci item in k)
            {
                kiralanan.OgrenciId = item.ID;
            }



            kiralanan.AlisTarihi = dtp_alistarihi.Value;
            kiralanan.TeslimTarihi = dtp_teslimtarihi.Value;
            kiralanan.VerilisTarihi = DateTime.Now;

            kiralanan.AktifMi = true;

            db.TBLKiralama.Add(kiralanan);
            db.SaveChanges();

            MessageBox.Show("Kayıt oluşturuldu.");

            KiraTemizle();
        }

        private void KitapVerme_Load(object sender, EventArgs e)
        {
            KitapList();
            groupBox2.Visible = false;
        }

        void KitapList()
        {

            cb_kitap.DataSource = db.TBLKitap.ToList();
            cb_kitap.DisplayMember = "KitapAdi";
            cb_kitap.ValueMember = "ID";
            cb_kitap.SelectedIndex = -1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Ogrenci yeniogrenci = new Ogrenci();
            yeniogrenci.Tc = txt_tc.Text;
            yeniogrenci.Adi = txt_ad.Text;
            yeniogrenci.Soyadi = txt_soyad.Text;
            yeniogrenci.Telefon = txt_telefon.Text;
            yeniogrenci.Email = txt_email.Text;
            yeniogrenci.Adres = txt_adres.Text;

            if (db.TBLOgrenci.Any(x => x.Tc == yeniogrenci.Tc))
            {
                MessageBox.Show("Girdiğiniz Tc kimlik numarası sistemde bulunmaktadır. Tekrar deneyin.");

                OgrenciTemizle();
            }
            else
            {
                db.TBLOgrenci.Add(yeniogrenci);
                db.SaveChanges();

                MessageBox.Show("Kayıt oluşturuldu.");

                OgrenciTemizle();
            }
        }
        void OgrenciTemizle()
        {
            txt_tc.Text = default(string);
            txt_ad.Text = default(string);
            txt_soyad.Text = default(string);
            txt_telefon.Text = default(string);
            txt_email.Text = default(string);
            txt_adres.Text = default(string);

        }
        void KiraTemizle()
        {
            cb_kitap.SelectedIndex = -1;
            txt_kiralamatc.Text = default(string);
            dtp_alistarihi.Value = DateTime.Now;
            dtp_teslimtarihi.Value = DateTime.Now;
        }

        private void cb_kitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cb_kitap.SelectedValue);
                List<Kitap> klist = db.TBLKitap.Where(x => x.ID == id).ToList();

                listView1.Items.Clear();
                foreach (Kitap item in klist)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.KitapAdi.ToString();
                   
                    lvi.SubItems.Add(item.Yazar);
                    lvi.SubItems.Add(item.BasımTarihi.ToString());
                    lvi.SubItems.Add(item.BaskiNo.ToString());
                    lvi.Tag = item.ID;//listviewde tıklanan satırın ID sini almasını sağlıyoruz!!
                    listView1.Items.Add(lvi);
                }

            }
            catch (Exception)
            {

                return;
            }


        }
    }
}
