using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensesBE.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensesBE.API.Services.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private ExpBEContext _ctx;

        public DepartmentRepository(ExpBEContext context)
        {
            _ctx = context;
        }

        public async Task<IEnumerable<Department>> GetAllAsync()
        {
            return await _ctx.Department.ToListAsync();
        }
    }
}
