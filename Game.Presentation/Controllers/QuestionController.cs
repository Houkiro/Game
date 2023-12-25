using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Presentation.Controllers
{
    [Route("api/questions")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IServiceManager _service;
        public QuestionController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetQuestions()
        {
            var questions = _service.QuestionService.GetAllQuestions(trackChanges: false);

            return Ok(questions);
        }
        [HttpGet("{id:guid}")]
        public IActionResult GetQuestion(Guid id)
        {
            var question = _service.QuestionService.GetQuestion(id, trackChanges: false);
            return Ok(question);
        }
    }
}
