using DietPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Repositories
{
    public class FoodCategoryRepository : BaseRepository<FoodCategory>
    {
        FoodCategory _foodCategory;
        public FoodCategoryRepository(FoodCategory foodCategory)
        {
            _foodCategory = foodCategory;
        }
        public FoodCategoryRepository()
        {
            
        }
    }
}
