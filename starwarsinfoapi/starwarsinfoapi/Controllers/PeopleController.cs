using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace starwarsinfoapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : Controller
    {
        CommonFunctions commonFunctions = new CommonFunctions();

        [HttpGet]
        public IActionResult GetPeople(string id)
        {
            id = "10";
            return Json(commonFunctions.GetSingleByUrl<Entities.People>("/people/" + id));
        }
    }
}
