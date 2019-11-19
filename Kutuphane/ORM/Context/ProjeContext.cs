using Kutuphane.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ORM.Context
{
    class ProjeContext:DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString = "Server=404-Y03; Database=Library; uid=sa; pwd=1234;";
        }

        public DbSet<Kitap> TBLKitap { get; set; }
        public DbSet<Ogrenci> TBLOgrenci { get; set; }
        public DbSet<Kiralama> TBLKiralama { get; set; }
        public DbSet<Kullanici> TBLKullanici { get; set; }
    }
}
