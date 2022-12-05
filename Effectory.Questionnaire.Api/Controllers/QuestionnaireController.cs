using effectory.questionnaire.application.Exceptions;
using effectory.questionnaire.application.Models;
using effectory.questionnaire.application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        [HttpGet("{PageIndex}/{PageCount}")]
        [ProducesResponseType(typeof(List<QuestionModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> ListQuestions([FromRoute] QuestionsWithPaginationQuery query, CancellationToken token)
        {
            try
            {
                var result = await Mediator.Send(query, token);

                return Ok(result);
            }
            catch (HttpResponseException ex)
            {
                return StatusCode(ex.StatusCode, ex.Message);
            }
            catch (Exception e)
            {
                _logger.LogCritical(e, e.Message);
                return BadRequest();
            }
        }
    }
}
