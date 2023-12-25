using AutoMapper;
using Contracts;
using LoggerService;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IAnswerService> _answerService;
        private readonly Lazy<IQuestionService> _questionService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper) 
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, logger, mapper));
            _answerService = new Lazy<IAnswerService>(() => new AnswerService(repositoryManager, logger, mapper));
            _questionService = new Lazy<IQuestionService>(() => new QuestionService(repositoryManager, logger, mapper));
        }

        public IUserService UserService => _userService.Value;
        public IAnswerService AnswerService => _answerService.Value;
        public IQuestionService QuestionService => _questionService.Value;
    }
}
