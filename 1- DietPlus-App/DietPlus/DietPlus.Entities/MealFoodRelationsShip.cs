using DietPlus.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Entities
{
    public class MealFoodRelationship:BaseEntity<int>
    {
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public Meal Meal { get; set; }
        public Food Food { get; set; }
    }
}
