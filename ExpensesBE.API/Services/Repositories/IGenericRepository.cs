using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpensesBE.API.Services.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
