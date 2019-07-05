using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpensesBE.API.Services.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> FindById(Guid id);

        Task<bool> ItemExist(Guid id);

        void RemoveItem(T item);

        bool Save();
    }
}
