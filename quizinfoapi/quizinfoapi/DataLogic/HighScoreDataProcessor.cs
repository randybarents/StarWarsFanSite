using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quizinfoapi.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace quizinfoapi.DataLogic
{
    public class HighScoreDataProcessor
    {
        private readonly string connectionString = "Server=studmysql01.fhict.local;Uid=dbi365190;Database=dbi365190;Pwd=MySQLPass123@;";

        /*public Task GetHighScoresAsync()
        {
            List<LeaderBoard> scores = new List<LeaderBoard>();
            var sql = $"SELECT Username , Score FROM leaderboard";
        }*/
    }
}
