using MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Abstract;

namespace MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Concrate
{
    public class Egitim:BaseEntity
    {
        public string Ad { get; set; }
        public Guid UrunId { get; set; }
        public Guid SeansId { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public short ToplamSaat { get; set; }

        public virtual List<EgitimOgrencisi> Ogrenciler {  get; set; }
        public virtual List<EgitimEgitmeni> Egitmenler { get; set; }
        public virtual Urun Urun { get; set; }
        public virtual Seans Seans { get; set; }
    }
}
