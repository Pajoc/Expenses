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

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _ctx.Set<TEntity>().ToListAsync();
        }
    }
}

