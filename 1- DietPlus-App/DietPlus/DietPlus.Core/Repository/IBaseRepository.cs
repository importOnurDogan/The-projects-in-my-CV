using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Core.Repository
{
    public interface IBaseRepository<T> where T : class, new()
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetAll();
        List<T> GetBy(Func<T, bool> expression);
        T Find(Func<T, bool> expression);


    }
}
