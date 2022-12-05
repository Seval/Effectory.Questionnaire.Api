using effectory.questionnaire.application.Models;
using effectory.questionnaire.domain;
using effectory.questionnaire.infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace effectory.questionnaire.application.Services
{
    public class QuestionnaireService : IQuestionnaireService
    {
        private readonly IJsonReader<Questionnaire> _jsonReader;

        public QuestionnaireService(IJsonReader<Questionnaire> jsonReader)
        {
            _jsonReader = jsonReader;
        }

        public Questionnaire List()
        {
           return _jsonReader.Read(Options.Position);
        }
    }
}
