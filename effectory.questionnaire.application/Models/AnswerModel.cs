using System;
using System.Collections.Generic;
using System.Text;

namespace effectory.questionnaire.application.Models
{
    public class AnswerModel
    {
        public int? Id { get; set; }
        public Dictionary<string,string> Texts { get; set; }
    }
}
