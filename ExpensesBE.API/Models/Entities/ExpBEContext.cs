using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesBE.API.Models.Entities
{
    public class ExpBEContext: DbContext
    {

        public ExpBEContext(DbContextOptions<ExpBEContext> options): base(options)
        {
            Database.Migrate();//Melhor que estar a fazer manualmente Update-Database
        }

        public DbSet<Department> Department { get; set; }
        public DbSet <Employee> Employees { get; set; }
    }
}
