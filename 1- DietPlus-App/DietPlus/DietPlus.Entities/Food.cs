using DietPlus.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Entities
{
    public class Food : BaseEntity<int>
    {
        public string FoodName { get; set; }
        public int Calories { get; set; } = 0;
        public double? Carbohydrate { get; set; } = 0;
        public double? Fat { get; set; } = 0;
        public double? Protein { get; set; } = 0;
        public string? Description { get; set; }
        public int PortionQuantity { get; set; } = 0;
        public byte[] Picture { get; set; }
        public int FoodCategoryId { get; set; }
        public FoodCategory FoodCategory { get; set; }
    }
}
