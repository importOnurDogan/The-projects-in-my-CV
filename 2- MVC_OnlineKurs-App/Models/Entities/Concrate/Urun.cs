using MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Abstract;

namespace MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Concrate
{
    public class Urun:BaseEntity
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public short Saat { get; set; }
        public byte ZorlukSeviyesi { get; set; }
        public Guid TeknolojiId { get; set; }

        //Navi
        public virtual List<Egitim> Egitimler { get; set; }
        public virtual Teknoloji teknoloji { get; set; }
    }
}
