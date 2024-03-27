using MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Abstract;

namespace MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Concrate
{
    public class Teknoloji:BaseEntity
    {
        public string Ad {  get; set; }
        public string Aciklama { get; set; }

        //Navi
        public virtual List<Urun> Urunler { get; set; }
    }
}
