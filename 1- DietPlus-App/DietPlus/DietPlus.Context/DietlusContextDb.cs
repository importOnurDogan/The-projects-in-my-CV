using DietPlus.Entities;
using DietPlus.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Context
{
    public class DietlusContextDb:DbContext
    {
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<MealFoodRelationship> MealFoodRelationships { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserMeal> UserMeals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DietPlusDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FoodMap());
            modelBuilder.ApplyConfiguration(new FoodCategoryMap());
            modelBuilder.ApplyConfiguration(new MealMap());
            modelBuilder.ApplyConfiguration(new MealFoodRelationsShipMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserDetailMap());
            modelBuilder.ApplyConfiguration(new UserMealMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
