using ExpensesBE.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesBE.API.Services.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class

    {
        protected readonly ExpBEContext _ctx;

        public GenericRepository(ExpBEContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<TEntity> FindById(Guid id)
        {
            return await _ctx.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(string pmts)
        {
            return await _ctx.Set<TEntity>().ToListAsync();
        }

        public virtual Task<bool> ItemExist(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(TEntity item)
        {
            _ctx.Set<TEntity>().Remove(item);
        }

        public bool Save()
        {
            return _ctx.SaveChanges() >= 0;
        }

    }
}

