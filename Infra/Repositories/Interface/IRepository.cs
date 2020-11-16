using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace Infra.Repositories.Interface
{
    public interface IRepository<T> where T : class
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        T Select(int id);

        IList<T> Select();

    }
}