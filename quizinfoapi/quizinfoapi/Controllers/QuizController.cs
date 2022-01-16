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
    public class QuizController : ControllerBase
    {
        QuestionDataProcessor DataProcessor = new QuestionDataProcessor();

        [HttpGet("LoadQuiz")]
        public async Task<List<QuestionAnswers>> LoadQuiz()
        {
            List<Question> questions = DataProcessor.GetQuestions();
            List<QuestionAnswers> questionWithAnswers = new List<QuestionAnswers>();        
            foreach (var item in questions)
            {
                QuestionAnswers temp = new QuestionAnswers();
                temp.questions = item;
                temp.answers = DataProcessor.GetAnswersByQuestionId(item.Id);
                questionWithAnswers.Add(temp);
            }
            return questionWithAnswers;
        }
    }
}
