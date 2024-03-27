using DietPlus.Core.Enum;
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
    public class UserDetailMap : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            // Tablo adını belirtmek için ToTable metodunu kullanabilirsiniz.
            builder.ToTable("UserDetails");

            // UserId alanı birincil anahtar ve aynı zamanda dış anahtar olduğu için HasKey ve HasForeignKey metodlarını kullanabiliriz.
            builder.HasKey(x => x.UserId);
            builder.HasOne(x => x.User)
                .WithOne(x => x.UserDetail)
                .HasForeignKey<UserDetail>(x => x.UserId);

            // Height ve Weight alanları için bir örnek kısıtlama ekleyebiliriz.
            builder.Property(x => x.Height).HasDefaultValue(0);
            builder.Property(x => x.Weight).HasDefaultValue(0);

            // WeightStatus alanını belirlemek için HasConversion metodunu kullanabiliriz.
            builder.Property(x => x.WeightStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (WeightStatus)Enum.Parse(typeof(WeightStatus), v)
                );

            // BirthDate alanı nullable olduğu için HasDefaultValueSql kullanmıyoruz.

        }
    }
}
