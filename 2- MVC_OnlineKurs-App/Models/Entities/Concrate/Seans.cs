using MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Abstract;

namespace MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Concrate
{
    public class Seans:BaseEntity
    {
        public string Ad { get; set; }
        public string EgitimGunleri { get; set; }
        public string Sure { get; set; }
        public string BaslangicSaati { get; set; }
        public string BitisSaati { get; set; }

        //Navi
        public virtual List<Egitim> SeansEgitimleri { get; set; }
    }
}
