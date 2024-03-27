namespace MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public Guid ID { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int AutoId { get; set; } // Identity oluyo

    }
}
