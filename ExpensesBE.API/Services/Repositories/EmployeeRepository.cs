using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensesBE.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensesBE.API.Services.Repositories
{
    public class EmployeeRepository :GenericRepository<Employee>,  IEmployeeRepository
    {
        public EmployeeRepository(ExpBEContext context):base (context)
        {
            
        }

        public override async Task<IEnumerable<Employee>> GetAllAsync(string pmts)
        {
            return await _ctx.Employees.Include(d => d.DepartmentOfEmployee).ToListAsync();
        }

        public override async Task<bool> ItemExist(Guid id)
        {
            return await _ctx.Employees.AnyAsync(e => e.Id == id);
        }
    }
}
