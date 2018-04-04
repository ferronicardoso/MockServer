using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MockServer.Repositories
{
    public interface IGenericRepository<T>
    {
        int Add(T model);
        bool Update(T model);
        bool Delete(long Id);
        int Delete(Expression<Func<T, bool>> where);
        T Get(long Id);
        T Get(Expression<Func<T, bool>> where);
        bool Any(Expression<Func<T, bool>> where);
        bool Any(long Id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> where);
    }
}
