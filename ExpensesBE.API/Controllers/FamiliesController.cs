using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExpensesBE.API.Controllers
{
    [Route("api/families")]
    public class FamiliesController : Controller
    {
        [HttpGet()]
        public JsonResult GetFamilies()
        {
            return new JsonResult(new List<object>() {
                new {id = 1, Name = "Fuel" },
                new {id = 2, Name = "Restaurant" },
                new {id = 3, Name = "Hotel" }
            });
        }
    }
}
