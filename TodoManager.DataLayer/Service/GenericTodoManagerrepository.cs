using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager.DataLayer.Service
{
    public class GenericTodoRepository<TEntity> where TEntity : class
    {
        private TodoManager_dbEntities _db;
        private DbSet<TEntity> _dbSet;
        public GenericTodoRepository(TodoManager_dbEntities db)
        {
            this._db = db;
            this._dbSet = db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
                query = query.Where(where);

            return query.ToList();
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }
        public virtual void Update(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
                _dbSet.Attach(entity); _dbSet.Attach(entity);

            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
                _dbSet.Attach(entity);

            _dbSet.Remove(entity);
        }

        public virtual void Delete(object id)
        {
            var entity = GetById(id);
            Delete(entity);
        }

    }
}
