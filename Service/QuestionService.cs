using AutoMapper;
using Contracts;
using Entities.Exceptions;
using LoggerService;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class QuestionService : IQuestionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public QuestionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public IEnumerable<QuestionDto> GetAllQuestions(bool trackChanges)
        {
            var questions = _repository.Question.GetAllQuestions(trackChanges);

            var questionsDto = _mapper.Map<IEnumerable<QuestionDto>>(questions);
            return questionsDto;
        }
        public QuestionDto GetQuestion(Guid id, bool trackChanges)
        {
            var question = _repository.Question.GetQuestion(id, trackChanges);
            if (question is null)
                throw new QuestionNotFoundException(id);
            var questionDto = _mapper.Map<QuestionDto>(question);
            return questionDto;
        }
    }
}
