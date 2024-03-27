using DietPlus.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Entities
{
    public class UserMeal:BaseEntity<int>
    {
        public int UserId { get; set; }
        public int MealId { get; set; }
        public User User { get; set; }
        public Meal Meal { get; set; }
    }
}
