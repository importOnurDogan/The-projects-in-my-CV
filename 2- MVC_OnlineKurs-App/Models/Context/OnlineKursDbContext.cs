using Microsoft.EntityFrameworkCore;
using MVC_OnlineKursApp_ProjesiCozumu.Models.Entities.Concrate;

namespace MVC_OnlineKursApp_ProjesiCozumu.Models.Context
{
    public class OnlineKursDbContext:DbContext
    {
        public OnlineKursDbContext(DbContextOptions<OnlineKursDbContext> options) : base(options)
        {
        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Egitmen> Egitmenler { get; set; }
        public DbSet<Egitim> Egitimler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Seans> Seanslar { get; set; }
        public DbSet<Teknoloji> Teknolojiler { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {

            }
            
            return base.SaveChanges(); 
        }


    }
}
