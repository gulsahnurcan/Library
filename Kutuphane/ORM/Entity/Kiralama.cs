using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ORM.Entity
{
    class Kiralama
    {
        [Required]
        public int ID { get; set; }

        public int KitapId { get; set; }
        public virtual Kitap Kitap { get; set; }//Mapping

        public int OgrenciId { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }//Mapping

        public DateTime? AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public DateTime VerilisTarihi { get; set; }

        public int? Fark { get; set; }
        public double? Ceza { get; set; }

        public bool? AktifMi { get; set; }
    }
}
