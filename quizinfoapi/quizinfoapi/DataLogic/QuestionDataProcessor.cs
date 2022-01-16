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
    public class QuestionDataProcessor
    {
        private readonly string connectionString = "Server=studmysql01.fhict.local;Uid=dbi365190;Database=dbi365190;Pwd=MySQLPass123@;";

        public List<Question> GetQuestions()
        {
            string sql = $"SELECT * FROM question";
            using (IDbConnection con = new MySqlConnection(connectionString))
            {
                return con.Query<Question>(sql).ToList();
            }
        }

        public List<Answer> GetAnswersByQuestionId(int Id)
        {
            string sql = $"SELECT * FROM answers INNER JOIN questionanswers AS qa ON qa.QuestionId = '{Id}' WHERE answers.Id = qa.AnswerId";
            using (IDbConnection con = new MySqlConnection(connectionString))
            {
                return con.Query<Answer>(sql).ToList();
            }
        }
    }
}
