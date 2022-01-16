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

        public List<LeaderBoard> GetHighScores()
        {
            string sql = $"SELECT Username , Score FROM leaderboard ORDER BY Score DESC";
            using (IDbConnection con = new MySqlConnection(connectionString))
            {
                 return con.Query<LeaderBoard>(sql).ToList();
            }
        }
    }
}
