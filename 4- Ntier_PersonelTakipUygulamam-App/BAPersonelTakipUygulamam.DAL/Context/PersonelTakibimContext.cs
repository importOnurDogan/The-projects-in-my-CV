using BAPersonelTakipUygulamam.DAL.Entity;
using BAPersonelTakipUygulamam.DAL.SeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAPersonelTakipUygulamam.DAL.Context
{
    public class PersonelTakibimContext : DbContext
    {
        public virtual DbSet<Personel> Personeller { get; set; }
        public virtual DbSet<Departman> Departmanlar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database = PersonelTakibimDB; uid = sa; pwd = 10ur; trustservercertificate = true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departman>().HasData(new Departman() {Id = 2,  DepartmanAdi = "Maliye" });

            modelBuilder.ApplyConfiguration(new SeedPersonelTakibim());           
            base.OnModelCreating(modelBuilder);
        }
    }
}
