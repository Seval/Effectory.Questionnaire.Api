using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace effectory.questionnaire.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public ControllerBase(IMediator mediator)
        {
            Mediator = mediator;
        }

        protected readonly IMediator Mediator;
    }
}
