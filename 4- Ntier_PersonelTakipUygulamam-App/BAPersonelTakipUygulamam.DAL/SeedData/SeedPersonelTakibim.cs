using BAPersonelTakipUygulamam.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAPersonelTakipUygulamam.DAL.SeedData
{
    public class SeedPersonelTakibim : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasData(
                new Personel() {Id = 1 ,Ad = "Onur", Soyad = "Dogan", DogumTarihi = new DateTime(1995, 09, 04), Yas = 28,
                    IseGirisTarihi = new DateTime(2020,02,02), Biyografi= "", Departmani = "", });
        }
    }
}
