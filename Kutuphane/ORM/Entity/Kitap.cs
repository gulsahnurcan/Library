using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ORM.Entity
{
    class Kitap
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string KitapAdi { get; set; }
        [Required]
        public string Yazar { get; set; }
        [Required]
        public string Tur { get; set; }
        [Required]
        public DateTime BasımTarihi { get; set; }
        [Required]
        public string BaskiNo { get; set; }
        [Required]
        public string YayinEvi { get; set; }

        public int? Stok { get; set; }
        public double? Ucret { get; set; }

        public bool? AktifMi { get; set; }

        public List<Ogrenci> Ogrenciler { get; set; }

    }
}
