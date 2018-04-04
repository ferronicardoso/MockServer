using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MockServer.Repositories
{
    public abstract class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        private readonly LiteDatabase db;
        private readonly LiteCollection<T> collection;

        public GenericRepository() 
            : this("MockServer.db")
        {

        }

        public GenericRepository(string connectionString)
        {
            db = new LiteDatabase(connectionString);
            collection = db.GetCollection<T>(typeof(T).Name);
        }

        public virtual int Add(T model)
        {
            return collection.Insert(model);
        }

        public virtual bool Update(T model)
        {
            return collection.Update(model);
        }

        public virtual bool Delete(long Id)
        {
            return collection.Delete(Id);
        }

        public virtual int Delete(Expression<Func<T, bool>> where)
        {
            return collection.Delete(where);
        }

        public virtual T Get(long Id)
        {
            return collection.FindById(Id);
        }

        public virtual T Get(Expression<Func<T, bool>> where)
        {
            return collection.FindOne(where);
        }

        public virtual bool Any(Expression<Func<T, bool>> where)
        {
            return collection.Exists(where);
        }

        public virtual bool Any(long Id)
        {
            return collection.Exists(Query.EQ("_id", Id));
        }

        public virtual IEnumerable<T> List()
        {
            return collection.FindAll();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> where)
        {
            return collection.Find(where);
        }

        public virtual void Dispose()
        {
            if (db != null)
                db.Dispose();
        }
    }
}
