using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Presentation.Controllers
{
    [Route("api/questions/{questionId}/answers")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AnswerController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetAnswersForQuestion(Guid questionId)
        {
            var answers = _service.AnswerService.GetAnswers(questionId, trackChanges: false);
            return Ok(answers);
        }
        [HttpGet("{id:guid}")]
        public IActionResult GetAnswerForQuestion(Guid questionId, Guid id) 
        {
            var answer = _service.AnswerService.GetAnswer(questionId, id, trackChanges: false);
            return Ok(answer);
        }
    }
}
