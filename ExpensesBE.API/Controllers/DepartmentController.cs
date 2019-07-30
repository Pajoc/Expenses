using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesBE.API.Helpers;
using ExpensesBE.API.Models.Entities;
using ExpensesBE.API.Services.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesBE.API.Controllers
{
    [Route("api/department")]
    public class DepartmentController : Controller
    {
        //private IDepartmentRepository _departmentRepo;
        //public DepartmentController(IDepartmentRepository departmentRepo)
        //{
        //    _departmentRepo = departmentRepo;
        //}

        //[HttpGet()]
        //public async Task<JsonResult> GetDepartmentAsync()
        //{
        //    var response = await _departmentRepo.GetAllAsync();
        //    return new JsonResult(response);
        //}

        private IGenericRepository<Department> _departmentRepo;
        public DepartmentController(IGenericRepository<Department> departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }
        
        [HttpGet("{GetDepartments}")]
        public async Task<JsonResult> GetDepartmentsAsync(ResourceParameters pmts)
        {
            var response = await _departmentRepo.GetAllAsync(pmts);
            return new JsonResult(response);
        }


        
    }
}