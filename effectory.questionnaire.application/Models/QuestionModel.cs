using System;
using System.Collections.Generic;
using System.Text;

namespace effectory.questionnaire.application.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public Dictionary<string,string> Texts { get; set; }
        public List<AnswerModel> Answers { get; set; }
    }
}
