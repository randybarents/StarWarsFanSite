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
        [Route("/people/{id}")]
        public IActionResult GetPersonById(string id)
        { 
            return Json(commonFunctions.GetSingleByUrl<Entities.People>("/people/" + id));
        }
    }
}
