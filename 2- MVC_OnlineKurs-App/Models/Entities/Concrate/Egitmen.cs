using MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Abstract;

namespace MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Concrate
{
    public class Egitmen:Birey
    {
        public DateTime IseBaslamaTarihi { get; set; }
        public DateTime? IsiBirakmaTarihi { get; set; }

        public virtual List<EgitimEgitmeni> Egitimler { get; set; }
    }
}
