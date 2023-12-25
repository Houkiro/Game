using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IAnswerRepository> _answerRepository;
        private readonly Lazy<IQuestionRepository> _questionRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));
            _answerRepository = new Lazy<IAnswerRepository>(() => new AnswerRepository(repositoryContext));
            _questionRepository = new Lazy<IQuestionRepository>(() => new QuestionRepository(repositoryContext));
        }
        public IUserRepository User => _userRepository.Value;
        public IAnswerRepository Answer => _answerRepository.Value;
        public IQuestionRepository Question => _questionRepository.Value;
        public void Save() => _repositoryContext.SaveChanges();
    }
}
