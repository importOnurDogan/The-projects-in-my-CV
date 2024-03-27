using DietPlus.Context;
using DietPlus.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {

        private readonly DietlusContextDb db=new DietlusContextDb();

        public void Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }

        public void Delete(T item)
        {
            db.Set<T>().Remove(item);
            db.SaveChanges();
        }

        public T Find(Func<T, bool> expression)
        {
            return db.Set<T>().FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public List<T> GetBy(Func<T, bool> expression)
        {
            return db.Set<T>().Where(expression).ToList();
        }

        public void Update(T item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}