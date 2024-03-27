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
    public class FoodMap : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            // Tablo adını belirtmek için ToTable metodunu kullanabilirsiniz.
            builder.ToTable("Foods");

            // FoodName alanını maksimum uzunluğu 256 karakter olacak şekilde sınırlayabiliriz.
            builder.Property(x => x.FoodName).HasMaxLength(256);

            // PicturePath ve Description alanları nullable olduğu için HasMaxLength kullanmıyoruz.

            // Calories alanı için bir örnek kısıtlama ekleyebiliriz.
            builder.Property(x => x.Calories).HasDefaultValue(0);

            // Carbohydrate, Fat ve Protein alanları nullable double olduğu için kısıtlama eklemiyoruz.

            // FoodCategoryId alanını ve ilişkili FoodCategory özelliğini konfigüre edebiliriz.
            builder.Property(x => x.FoodCategoryId).IsRequired();
            builder.HasOne(x => x.FoodCategory)
                .WithMany()
                .HasForeignKey(x => x.FoodCategoryId);
        }
    }
}
