using ExpensesBE.API.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpensesBE.API.Services.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync(ResourceParameters parms);

        Task<T> FindById(Guid id);

        Task<bool> ItemExist(Guid id);

        void RemoveItem(T item);

        Task UpdateAsync(T item);

        bool Save();
    }
}
