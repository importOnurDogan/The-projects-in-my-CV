using DietPlus.Core.Entity.Abstract;
using DietPlus.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Entities
{
    public class Meal:BaseEntity<int>
    {
        public MealName MealName { get; set; }
        //public int TotalCalories { get; set; }
        public List<MealFoodRelationship> MealFoods { get; set; }
        public List<UserMeal> UserMeals { get; set; }
    }
}
