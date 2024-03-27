using MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Abstract;

namespace MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Concrate
{
    public class Ogrenci:Birey
    {
        public Ogrenci()
        {
            this.Egitimler = new List<EgitimOgrencisi>();
        }
        
        public virtual List<EgitimOgrencisi> Egitimler {  get; set; }
    }
}
