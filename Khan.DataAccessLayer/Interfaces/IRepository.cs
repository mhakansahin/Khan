using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Khan.DataAccessLayer.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class //Sadece class tipindeki değerleri kabul edecek.(Entity' ler)
    {
        void Insert(T entity); //Bir entity
        void Insert(IEnumerable<T> entities); //Birden çok entity
        void Update(T entity);
        void Update(T entity, IEnumerable<string> fields); //2. parametre tablonun değişen alanlarını getirecek.
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        TResult Find<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
        IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
    }
}
