using LibraryHelperDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelperDAL.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(Func<T, bool> predicate);
        Task Create(T entity);
        Task Delete(int id);
        Task Update(T entity);
    }
}
