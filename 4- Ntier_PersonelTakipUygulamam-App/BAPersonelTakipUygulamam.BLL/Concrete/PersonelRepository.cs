using BAPersonelTakipUygulamam.BLL.Contract;
using BAPersonelTakipUygulamam.DAL.Context;
using BAPersonelTakipUygulamam.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAPersonelTakipUygulamam.BLL.Concrete
{
    public class PersonelRepository : IRepository<Personel>
    {
        PersonelTakibimContext db = new PersonelTakibimContext();

        public void Add(Personel item)
        {
            db.Personeller.Add(item);
            db.SaveChanges();
        }

        public void Delete(Personel item)
        {
            db.Personeller.Remove(item);
            db.SaveChanges();
        }

        public List<Personel> GetAll()
        {
            return db.Personeller.ToList();
        }

        public Personel GetById(int id)
        {
            return db.Personeller.Find(id);
        }

        public void Update(Personel item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified; db.SaveChanges();
        }
    }
}
