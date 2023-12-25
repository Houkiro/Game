using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AnswerRepository : RepositoryBase<Answer>, IAnswerRepository
    {
        public AnswerRepository(RepositoryContext repositoryContext) : base(repositoryContext) 
        {
        }

        public IEnumerable<Answer> GetAnswers(Guid questionId, bool trackChanges) => 
            FindByCondition(a => a.QuestionId.Equals(questionId), trackChanges).OrderBy(q => q.Text).ToList();

        public Answer GetAnswer(Guid questionId, Guid id, bool trackChanges) =>
            FindByCondition(a => a.QuestionId.Equals(questionId) && a.Id.Equals(id), trackChanges).SingleOrDefault();
    }
}
