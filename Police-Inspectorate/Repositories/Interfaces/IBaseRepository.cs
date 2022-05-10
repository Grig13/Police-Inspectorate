using System;
using System.Linq.Expressions;

namespace Police_Inspectorate.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        ICollection<T> GetAll();
        T Create(T entity);
        void Delete(T entity);
        T Update(T entity);
    }
}
