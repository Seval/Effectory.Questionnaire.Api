using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace effectory.questionnaire.api.Controllers
{
    public class QuestionnaireController : ControllerBase
    {
        private readonly ILogger<QuestionnaireController> _logger;

        public QuestionnaireController(IMediator mediator, ILogger<QuestionnaireController> logger) : base(mediator)
        {
            _logger = logger;
        }

    }
}
