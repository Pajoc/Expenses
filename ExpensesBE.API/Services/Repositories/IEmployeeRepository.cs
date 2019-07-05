using ExpensesBE.API.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesBE.API.Services.Repositories
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
        //Task<bool> ItemExist(Guid id);
    }
}
