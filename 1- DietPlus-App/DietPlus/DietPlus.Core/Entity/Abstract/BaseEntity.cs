using DietPlus.Core.Entity.Contract;
using DietPlus.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Core.Entity.Abstract
{
    public abstract class BaseEntity<T> : IEntity<T>
    {
        public T Id { get; set; }
        public Status Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }= DateTime.Now;

    }
}