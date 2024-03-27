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
    public class FoodCategoryMap : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            // Tablo adını belirtmek için ToTable metodunu kullanabilirsiniz.
            builder.ToTable("FoodCategories");

            // CategoryName alanını belirlemek için HasMaxLength kullanabiliriz.
            builder.Property(x => x.CategoryName).HasMaxLength(255).IsRequired();

            // Foods ilişkisini konfigüre edebiliriz.
            builder.HasMany(x => x.Foods)
                .WithOne(x => x.FoodCategory)
                .HasForeignKey(x => x.FoodCategoryId);
        }
    }
}
