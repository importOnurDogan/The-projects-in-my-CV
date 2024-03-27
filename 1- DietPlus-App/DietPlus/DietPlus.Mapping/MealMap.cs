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
    public class MealMap : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            // Tablo adını belirtmek için ToTable metodunu kullanabilirsiniz.
            builder.ToTable("Meals");

            // MealName alanını belirtmek için HasConversion metodunu kullanabilirsiniz.
            builder.Property(x => x.MealName)
                .HasConversion(
                    v => v.ToString(),
                    v => (MealName)Enum.Parse(typeof(MealName), v)
                );

            // Date alanı nullable olduğu için HasDefaultValueSql kullanmıyoruz.

            // MealFoods ilişkisini konfigüre edebiliriz.
            builder.HasMany(x => x.MealFoods)
                .WithOne()
                .HasForeignKey(x => x.MealId);

            // UserMeals ilişkisini konfigüre edebiliriz.
            builder.HasMany(x => x.UserMeals)
                .WithOne()
                .HasForeignKey(x => x.MealId);
        }
    }
}
