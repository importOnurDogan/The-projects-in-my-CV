namespace MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Abstract
{
    public abstract class Birey:BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcKimlikNo { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }


    }
}
