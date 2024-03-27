using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAPersonelTakipUygulamam.DAL.Entity
{
    public class Personel : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas{ get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public string Biyografi { get; set; }
        public string Departmani { get; set; }


    }
}
