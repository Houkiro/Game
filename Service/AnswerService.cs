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
    internal sealed class AnswerService : IAnswerService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AnswerService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<AnswerDto> GetAnswers(Guid questionId, bool trackChanges)
        {
            var question = _repository.Question.GetQuestion(questionId, trackChanges);
            if (question is null)
                throw new QuestionNotFoundException(questionId);
            var answerFromDb = _repository.Answer.GetAnswers(questionId, trackChanges);
            var answersDto = _mapper.Map<IEnumerable<AnswerDto>>(answerFromDb);
            return answersDto;
        }
        public AnswerDto GetAnswer(Guid questionId, Guid id, bool trackChanges) 
        {
            var question = _repository.Question.GetQuestion(questionId, trackChanges);
            if(question is null)
                throw new QuestionNotFoundException(questionId);
            var answerDb = _repository.Answer.GetAnswer(questionId, id, trackChanges);
            if(answerDb is null)
                throw new AnswerNotFoundException(id);
            var answer = _mapper.Map<AnswerDto>(answerDb);
            return answer;
        }
    }
}
