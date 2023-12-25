using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        public QuestionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        { 
        }

        public IEnumerable<Question> GetAllQuestions(bool trackChanges)  => FindAll(trackChanges).OrderBy(q => q.Text).ToList();


        public Question GetQuestion(Guid questionId, bool trackChanges) => FindByCondition(q => q.Id.Equals(questionId), trackChanges).SingleOrDefault();
    }
}
