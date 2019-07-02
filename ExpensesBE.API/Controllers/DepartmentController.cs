using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesBE.API.Controllers
{
    [Route("api/department")]
    public class DepartmentController : Controller
    {
        [HttpGet()]
        public JsonResult GetDepartment()
        {
            return new JsonResult(new List<object>() {
                new {id = Guid.NewGuid(), Description = "Accounting" },
                new {id = Guid.NewGuid(), Description = "Design" },
                new {id = Guid.NewGuid(), Description = "IT" },
                new {id = Guid.NewGuid(), Description = "Production" },
            });
        }
    }
}