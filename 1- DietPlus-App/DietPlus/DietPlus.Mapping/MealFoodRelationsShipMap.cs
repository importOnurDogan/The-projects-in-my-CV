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
    public class MealFoodRelationsShipMap : IEntityTypeConfiguration<MealFoodRelationship>
    {
        public void Configure(EntityTypeBuilder<MealFoodRelationship> builder)
        {
            // Tablo adını belirtmek için ToTable metodunu kullanabilirsiniz.
            builder.ToTable("MealFoodRelationships");

            // MealId ve FoodId alanları birincil anahtar olduğu için HasKey metodunu kullanabiliriz.
            builder.HasKey(x => new { x.MealId, x.FoodId });


            // Meal ilişkisini konfigüre edebiliriz.
            builder.HasOne(x => x.Meal)
                .WithMany(x => x.MealFoods)
                .HasForeignKey(x => x.MealId);

        }
    }
}
