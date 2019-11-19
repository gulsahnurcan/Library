using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ORM.Entity
{
    class Ogrenci
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Tc { get; set; }
        [Required]
        public string Adi { get; set; }
        [Required]
        public string Soyadi { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Adres { get; set; }

        public bool? AktifMi { get; set; }

        public List<Kitap> Kitaplar { get; set; }

    }
}
