using DietPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Repositories
{
    public class UserMealRepository : BaseRepository<UserMeal>
    {
        UserMeal _userMeal;
        public UserMealRepository(UserDetail userDetail)
        {
            _userMeal = new UserMeal();
        }
        public UserMealRepository()
        {
            
        }
    }
}
