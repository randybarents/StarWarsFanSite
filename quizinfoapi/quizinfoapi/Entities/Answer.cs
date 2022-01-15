using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quizinfoapi.Entities
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerString { get; set; }
        public bool Correct { get; set; }
    }
}
