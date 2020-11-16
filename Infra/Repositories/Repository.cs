using Infra.Contexts;
using Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly VisualTicketContext _db;

        public Repository(VisualTicketContext db)
        {
            _db = db;
        }

        public void Insert(T obj)
        {
            _db.Set<T>().Add(obj);
            _db.SaveChanges();
        }

        public void Update(T obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Set<T>().Remove(Select(id));
            _db.SaveChanges();
        }

        public IList<T> Select()
        {
            return _db.Set<T>().ToList();
        }

        public T Select(int id)
        {
            return _db.Set<T>().Find(id);
        }

       
    }
}