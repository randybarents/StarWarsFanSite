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
        public List<Entities.People> allPeople = new List<Entities.People>();

        [HttpGet]
        public IActionResult GetPeople(string id)
        {
            return Json(commonFunctions.GetSingleByUrl<Entities.People>("/people/" + id));
        }
    }
}
