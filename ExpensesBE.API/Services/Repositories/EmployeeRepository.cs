using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensesBE.API.Helpers;
using ExpensesBE.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensesBE.API.Services.Repositories
{
    public class EmployeeRepository :GenericRepository<Employee>,  IEmployeeRepository
    {
        public EmployeeRepository(ExpBEContext context):base (context)
        {
            
        }

        public override async Task<IEnumerable<Employee>> GetAllAsync(ResourceParameters pmts)
        {
           IQueryable<Employee> res = _ctx.Employees.Include(d => d.DepartmentOfEmployee);
            if (pmts != null && pmts.Code != null)
            {
                res = res.Where(p => p.Code == pmts.Code);
            }
            if (pmts != null && pmts.Name != null)
            {
                res = res.Where(p => p.Name.Contains(pmts.Name));
            }
                       
             return await res.ToListAsync();
        }

        public override async Task UpdateAsync(Employee emp)
        {
            var empToUpdt = await _ctx.Employees.FindAsync(emp.Id);
            empToUpdt.Code = emp.Code;
            empToUpdt.Name = emp.Name;
            empToUpdt.Treshold = emp.Treshold;
            empToUpdt.MainEmail = emp.MainEmail;
            empToUpdt.DepartmentId = emp.DepartmentId;

        }
        public override async Task<bool> ItemExist(Guid id)
        {
            return await _ctx.Employees.AnyAsync(e => e.Id == id);
        }
    }
}
