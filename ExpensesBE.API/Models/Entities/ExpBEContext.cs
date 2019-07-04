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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new { Id = new Guid("09af5a52-9421-44e8-a2bb-a6b9ccbc8239"), Description = "Accounting" },
                new { Id = new Guid("412c3012-d891-4f5e-9613-ff7aa63e6bb3"), Description = "Design" },
                new { Id = new Guid("9edf91ee-ab77-4521-a402-5f188bc0c577"), Description = "IT" },
                new { Id = new Guid("578359b7-1967-41d6-8b87-64ab7605587e"), Description = "Production" }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = new Guid("c7ba6add-09c4-45f8-8dd0-eaca221e5d93"), Code = "ABA", Name = "António Barbosa", Treshold = 250000, MainEmail = "antonio.barbosa@beaudrey.pt", IsActive = true, },
                new Employee { Id = new Guid("a3749477-f823-4124-aa4a-fc9ad5e79cd6"), Code = "RAN", Name = "Ricardo Antunes", Treshold = 150000, MainEmail = "ricardo.antunes@beaudrey.pt", IsActive = false, DepartmentId = new Guid("578359b7-1967-41d6-8b87-64ab7605587e") },
                new Employee { Id = new Guid("70a1f9b9-0a37-4c1a-99b1-c7709fc64167"), Code = "PCR", Name = "Paula Correia", Treshold = 150000, MainEmail = "paula.correia@beaudrey.pt", IsActive = false, DepartmentId = new Guid("09af5a52-9421-44e8-a2bb-a6b9ccbc8239")},
                new Employee { Id = new Guid("60188a2b-2784-4fc4-8df8-8919ff838b0b"), Code = "LSI", Name = "Luis Silva", Treshold = 150000, MainEmail = "luis.silva@beaudrey.pt", IsActive = false },
                new Employee { Id = new Guid("76053df4-6687-4353-8937-b45556748abe"), Code = "GMA", Name = "Gil Martins", Treshold = 150000, MainEmail = "gil.martins@beaudrey.pt", IsActive = false },
                new Employee { Id = new Guid("447eb762-95e9-4c31-95e1-b20053fbe215"), Code = "VCR", Name = "Vitor Correia", Treshold = 150000, MainEmail = "vitor.correia@beaudrey.pt", IsActive = false, DepartmentId = new Guid("412c3012-d891-4f5e-9613-ff7aa63e6bb3") },
                new Employee { Id = new Guid("bc4c35c3-3857-4250-9449-155fcf5109ec"), Code = "JCA", Name = "João Costa", Treshold = 150000, MainEmail = "joão.costa@beaudrey.pt", IsActive = false }



                );
        }
    }
}
