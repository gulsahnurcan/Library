using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ORM.Entity
{
    class Kullanici
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string KullaniciAd { get; set; }
        [Required]
        public string KullaniciSifre { get; set; }

        public bool? AktifMi { get; set; }
    }
}
