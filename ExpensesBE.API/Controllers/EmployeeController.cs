using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesBE.API.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesBE.API.Controllers
{
    [Route("api/employee")]
    public class EmployeeController : Controller
    {
        private ExpBEContext _ctx;

        public EmployeeController(ExpBEContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet()]
        public JsonResult GetEmployees()
        {
            return new JsonResult( new List<Employee> {
                new Employee { Code = "ABA", Name = "António Barbosa", Treshold = 250000, MainEmail = "antonio.barbosa@beaudrey.pt", IsActive = true, DepartmentId = Guid.NewGuid(), DepartmentOfEmployee = new Department { Id = Guid.NewGuid(), Description = "Custom" } },
                new Employee { Code = "RAN", Name = "Ricardo Antunes", Treshold = 150000, MainEmail = "ricardo.antunes@beaudrey.pt", IsActive = false },
                new Employee { Code = "PCR", Name = "Paula Correia", Treshold = 150000, MainEmail = "paula.correia@beaudrey.pt", IsActive = false },
                new Employee { Code = "LSI", Name = "Luis Silva", Treshold = 150000, MainEmail = "luis.silva@beaudrey.pt", IsActive = false, DepartmentId = Guid.NewGuid(), DepartmentOfEmployee = new Department { Id = Guid.NewGuid(), Description = "Custom" } },
                new Employee { Code = "GMA", Name = "Gil Martins", Treshold = 150000, MainEmail = "gil.martins@beaudrey.pt", IsActive = false },
                new Employee { Code = "VCR", Name = "Vitor Correia", Treshold = 150000, MainEmail = "vitor.correia@beaudrey.pt", IsActive = false },
                new Employee { Code = "JCA", Name = "João Costa", Treshold = 150000, MainEmail = "joão.costa@beaudrey.pt", IsActive = false },
                });
        }


        //[HttpGet(Name = "GetFake")]
        //public IActionResult GetFake()
        //{
        //    return Ok();
        //}
    }
}