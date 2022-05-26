using LibraryHelperDAL.EF;
using LibraryHelperDAL.Entities;
using LibraryHelperDAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelperDAL.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected StoreContext db;
        DbSet<T> Table => db.Set<T>();
        public BaseRepository(StoreContext context)
        {
            db = context;
        }

        public virtual async Task Create(T entity)
        {
            db.Entry(entity).State = EntityState.Added;
            await db.SaveChangesAsync();
        }

        public virtual async Task Delete(int id)
        {
            var entity = await Get(id);
            db.Entry(entity).State = EntityState.Deleted;
            await db.SaveChangesAsync();
        }

        public virtual async Task<T> Get(int id)
        {
            return await Table.FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await Task.FromResult(Table.ToList());
        }

        public virtual async Task<IEnumerable<T>> GetAll(Func<T, bool> predicate)
        {
            return await Task.FromResult(Table.Where(predicate).ToList());
        }

        public abstract Task Update(T entity);
    }
}
