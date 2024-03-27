using DietPlus.Core.Entity.Abstract;
using DietPlus.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Entities
{
    public class UserDetail:BaseEntity<int>
    {
        public int UserId { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public WeightStatus WeightStatus { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender Gender { get; set; }

        public User User { get; set; }
    }
}
