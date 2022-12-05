using System;
using System.Collections.Generic;
using System.Text;

namespace effectory.questionnaire.domain
{
    public class Questionnaire
    {
        public int QuestionnaireId { get; set; }
        public List<QuestionnaireItem> QuestionnaireItems { get; set; }
    }
}
