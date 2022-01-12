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
        CommonFunctions apiFunctions = new CommonFunctions();

        [HttpGet("GetPerson")]
        public async Task<IActionResult> GetPerson(int id)
        {
            dynamic personInfo = await (apiFunctions.GetPerson(id));
            return Ok(personInfo);
        }

        [HttpGet("GetPeople")]
        public async Task<IActionResult> GetPeoplePaginated(int pageNumber)
        {
            dynamic peopleListInfo = await (apiFunctions.GetPeoplePaginated(pageNumber));
            return Ok(peopleListInfo);
        }
    }
}
