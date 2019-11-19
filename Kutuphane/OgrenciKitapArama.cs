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
    public partial class OgrenciKitapArama : Form
    {
        public OgrenciKitapArama()
        {
            InitializeComponent();
            Listele();
        }
        ProjeContext db = new ProjeContext();

        List<DateTime> list = new List<DateTime>();

        Kitap kitapal = new Kitap();
        int id;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            kitapal = db.TBLKitap.Find(id);

            txt_kitapid.Text = kitapal.ID.ToString();
            txt_kitapadi.Text = kitapal.KitapAdi;


        }
        public void Listele()
        {
            dataGridView1.DataSource = db.TBLKitap.OrderBy(x=> x.KitapAdi).ToList();
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void btn_kontrolet_Click(object sender, EventArgs e)
        {
            if(kitapal.Stok == 0)
            {
                List<Kiralama> kiratarihial = db.TBLKiralama.Where(x => x.KitapId == id && x.AktifMi == true).ToList();

                List<DateTime> tarihler = new List<DateTime>();
                

                foreach (Kiralama item in kiratarihial)
                {
                    
                   tarihler.Add(item.TeslimTarihi);
                    
                }

                tarihler.Sort();
                MessageBox.Show("Aradığınız kitap " + tarihler[0].ToShortDateString() + " tarihinde kütüphaneye teslim edilecek.");
                

            
            }
            else
            {
                MessageBox.Show("Kitaptan Kütüphanede " + kitapal.Stok + " Adet Mevcut. ");
            }
        }

    }
}

  