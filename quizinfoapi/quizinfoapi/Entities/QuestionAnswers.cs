using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quizinfoapi.Entities
{
    public class QuestionAnswers
    {
        public Question questions { get; set; }
        public List<Answer> answers { get; set; }
    }
}
