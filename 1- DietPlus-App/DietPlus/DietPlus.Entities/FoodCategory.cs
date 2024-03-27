using DietPlus.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Entities
{
    public class FoodCategory:BaseEntity<int>
    {
        public string CategoryName { get; set; }
        public List<Food> Foods { get; set; }
    }
}
