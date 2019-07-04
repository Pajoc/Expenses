using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesBE.API.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var emp = _ctx.Employees.Include(d => d.DepartmentOfEmployee).ToList();

            return new JsonResult(emp);
        }


    }
}