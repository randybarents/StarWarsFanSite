using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quizinfoapi.DataLogic;
using quizinfoapi.Entities;

namespace quizinfoapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LeaderBoardController : ControllerBase
    {
        HighScoreDataProcessor DataProcessor = new HighScoreDataProcessor();

        [HttpGet("GetHighScores")]
        public async Task<List<LeaderBoard>> GetHighScores()
        {
            List<LeaderBoard> scores = DataProcessor.GetHighScores();
            return scores;
        }
    }
}
