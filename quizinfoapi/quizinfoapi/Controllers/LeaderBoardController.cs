using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quizinfoapi.DataLogic;

namespace quizinfoapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaderBoardController : ControllerBase
    {
        HighScoreDataProcessor DataProcessor = new HighScoreDataProcessor();

        [HttpGet("GetHighScores")]
        public async Task<IActionResult> GetHighScores()
        {
            dynamic highScores = await (DataProcessor.GetHighScoresAsync());
            return Ok(highScores);
        }
    }
}
