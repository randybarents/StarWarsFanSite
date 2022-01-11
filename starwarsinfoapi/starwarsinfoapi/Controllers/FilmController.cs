using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace starwarsinfoapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : Controller
    {
        CommonFunctions commonFunctions = new CommonFunctions();

        /*[HttpGet]
        public IActionResult GetFilm (string id)
        {
            id = "3";
            return Json(commonFunctions.GetSingleByUrl<Entities.Film>("/films/" + id));
        }*/
    }
}
