using effectory.questionnaire.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace effectory.questionnaire.application.Services
{
    public interface IQuestionnaireService
    {
        Questionnaire List();
    }
}
