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
    public class UserMealMap : IEntityTypeConfiguration<UserMeal>
    {
        public void Configure(EntityTypeBuilder<UserMeal> builder)
        {
            // Tablo adını belirtmek için ToTable metodunu kullanabilirsiniz.
            builder.ToTable("UserMeals");

            // UserId ve MealId alanları birincil anahtar ve aynı zamanda dış anahtar olduğu için HasKey ve HasForeignKey metodlarını kullanabiliriz.
            builder.HasKey(x => new { x.UserId, x.MealId });

            // User ilişkisini konfigüre edebiliriz.
            builder.HasOne(x => x.User)
                .WithMany(x => x.UserMeals)
                .HasForeignKey(x => x.UserId);

            // Meal ilişkisini konfigüre edebiliriz.
            builder.HasOne(x => x.Meal)
                .WithMany(x => x.UserMeals)
                .HasForeignKey(x => x.MealId);
        }
    }
}
