using effectory.questionnaire.application.Models;
using effectory.questionnaire.application.Services;
using effectory.questionnaire.domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace effectory.questionnaire.application.Queries
{
    public class QuestionsWithPaginationQuery : IRequest<List<QuestionModel>>
    {
        [Required]
        public int PageIndex { get; set; }

        [Required]
        public int PageCount { get; set; }
    }

    public class QuestionsWithPaginationQueryHandler : IRequestHandler<QuestionsWithPaginationQuery, List<QuestionModel>>
    {
        private readonly IQuestionnaireService _questionnaireService;

        public QuestionsWithPaginationQueryHandler(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }
        public Task<List<QuestionModel>> Handle(QuestionsWithPaginationQuery request, CancellationToken cancellationToken)
        {
            List<QuestionModel> questionModels = new List<QuestionModel>();
            var list = _questionnaireService.List();
   
           var questions = list.QuestionnaireItems.Where(x => x.ByItemType(ItemType.Question) && x.ByQuestionId()).Select(q => q.QuestionnaireItems.Select(s =>
      new QuestionModel
      {
          Id = (int)s.QuestionId,
          Answers = s.QuestionnaireItems.Select(a => new AnswerModel { Id = a.AnswerId, Texts = a.Texts }).ToList(),
          Texts = s.Texts
      })).ToList();
            foreach (var item in questions)
            {
                questionModels.AddRange(item);
            }

            var result = questionModels.Skip(request.PageIndex * request.PageCount).Take(request.PageCount).ToList();

            return Task.FromResult(result);

        }
    }
}
