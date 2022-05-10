using Police_Inspectorate.Repositories.Interfaces;
using PoliceInspectorate.Context;

namespace Police_Inspectorate.Repositories
{
    public abstract class BaseRepository<T> : Interfaces.IBaseRepository<T> where T : class
    {
        protected readonly PoliceInspectorateContext _dbContext;

        public BaseRepository(PoliceInspectorateContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public T Create(T entity)
        {
            var returnEntity = _dbContext.Set<T>().Add(entity).Entity;
            _dbContext.SaveChanges();
            return returnEntity;
        }

        public T Update(T entity)
        {
            var itemUpdate = _dbContext.Set<T>().Update(entity).Entity;
            _dbContext.SaveChanges();
            return itemUpdate;
        }

        public void Delete(T entity)
        {
            this._dbContext.Set<T>().Remove(entity);
        }

        public ICollection<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }
    }
}
