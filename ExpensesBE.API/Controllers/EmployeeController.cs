using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesBE.API.Models.Entities;
using ExpensesBE.API.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpensesBE.API.Controllers
{
    [Route("api/employee")]
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepo;

        public EmployeeController(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet()]
        public async Task<JsonResult> GetEmployeesAsync()
        {
            var emp =  await _employeeRepo.GetAllAsync();
            return new JsonResult(emp);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeAsync(Guid id)
        {

            if (!await _employeeRepo.ItemExist(id))
            {
                return NotFound();
            }

            var item = await _employeeRepo.FindById(id);

            _employeeRepo.RemoveItem(item);

            if (!_employeeRepo.Save())
            {
                throw new Exception($"Removing a employee {id} failed.");
            }

            
            return NoContent();

        }

    }
}