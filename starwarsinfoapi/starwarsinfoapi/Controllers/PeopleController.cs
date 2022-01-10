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
        public IActionResult GetPersonById(string id)
        { 
            return Json(commonFunctions.GetSingleByUrl<Entities.People>("/people/" +id));
        }

        [HttpGet]
        [Route("/Peoples")]
        public Entities.PeopleArray GetAllPeople(string pageId = "1")
        {
            Entities.PeopleArray result = commonFunctions.GetSingleByUrl<Entities.PeopleArray>("people/?page=" + pageId);
            return result;
        }
    }
}
