using DietPlus.Context;
using DietPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Repositories
{
    public class FoodRepository : BaseRepository<Food>
    {
        Food _food;
        public FoodRepository(Food food)
        {
            _food = food;
        }
        public FoodRepository( )
        {
            _food = new Food();
        }

        public List<Food> GetAllByTextChange(string str)
        {
            return GetAll().Where(food => food.FoodName.ToLower().Contains(str.ToLower())).ToList();
        }


    }
}
