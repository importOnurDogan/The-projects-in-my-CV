using DietPlus.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Tablo adını belirtmek için ToTable metodunu kullanabilirsiniz.
            builder.ToTable("Users");

            // Email alanını belirlemek için HasMaxLength kullanabiliriz.
            builder.Property(x => x.Email).HasMaxLength(255);

            // Password alanını belirlemek için HasMaxLength kullanabiliriz.
            builder.Property(x => x.Password).HasMaxLength(255);

            // UserName alanını belirlemek için HasMaxLength kullanabiliriz.
            builder.Property(x => x.UserName).HasMaxLength(255).IsRequired();

            // UserMeals ilişkisini konfigüre edebiliriz.
            builder.HasMany(x => x.UserMeals)
                .WithOne()
                .HasForeignKey(x => x.UserId);

            // UserDetail ilişkisini konfigüre edebiliriz.
            builder.HasOne(x => x.UserDetail)
                .WithOne()
                .HasForeignKey<UserDetail>(x => x.UserId);
        }
    }
}
