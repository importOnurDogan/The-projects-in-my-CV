using DietPlus.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Entities
{
    public class User:BaseEntity<int>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public List<UserMeal> UserMeals { get; set; }
        public UserDetail UserDetail { get; set; }
    }
}
