using DietPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Repositories
{
    public class MealFoodRelationRepository : BaseRepository<MealFoodRelationship>
    {
        MealFoodRelationship _foodRelationship;
        public MealFoodRelationRepository(MealFoodRelationship mealFoodRelationship)
        {
            _foodRelationship = mealFoodRelationship;
        }
        public MealFoodRelationRepository()
        {
            
        }
    }
}
