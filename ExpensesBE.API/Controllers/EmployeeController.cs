using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesBE.API.Helpers;
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

        [HttpGet("{GetAll}")]
        public async Task<JsonResult> GetEmployeesAsync(ResourceParameters empResourceParameters)
        {
            var emp =  await _employeeRepo.GetAllAsync(empResourceParameters);
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

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(Guid id, [FromBody] Employee emp)
        {
            if (emp == null )
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _employeeRepo.UpdateAsync(emp);

            if (!_employeeRepo.Save())
            {
                throw new Exception($"Removing a employee {id} failed.");
            }

            return NoContent();
        }
    }
}